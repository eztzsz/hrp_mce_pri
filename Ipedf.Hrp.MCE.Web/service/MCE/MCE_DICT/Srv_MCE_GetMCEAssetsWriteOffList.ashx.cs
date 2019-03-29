using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Ipedf.Hrp.Web.Code;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Text;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEAssetsWriteOffList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsWriteOffList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //允许跨域
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            JSON_MSG jsonMsg = new JSON_MSG();
            try
            {
                context.Response.ContentType = "text/plain";
                HttpRequest request = context.Request;


                if (string.IsNullOrEmpty(request["id"]))
                {
                    throw new Exception("参数错误.");
                }


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "CODE";


                StringBuilder strCondition = new StringBuilder();

                strCondition.Append(" and MCE_B_ASSETS_WRITE_OFF.ID in (select base_id from MCE_B_ASSETS_WRITE_OFF_D where asset_id='" + request["id"] + "')");
                CauseObject_MCE_B_ASSETS_WRITE_OFF p = new CauseObject_MCE_B_ASSETS_WRITE_OFF();
                p.STATE = 5;

              //  p.ASSETS_ID = request["id"];

                if (!string.IsNullOrEmpty(request["condition"]))//
                {
                    strCondition.Append(" and (MCE_B_ASSETS_WRITE_OFF.CODE like '%" + request["condition"].ToString().Trim() + "%' )");
                }

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_B_ASSETS_WRITE_OFF[] list = BizLogicObject_MCE_B_ASSETS_WRITE_OFF.Proxy.Query(p, null, orderBy);

                decimal decOriginal_value = 0;
                decimal decNet_value = 0;
                decimal decRudimental_value = 0;

                EntityObject_MCE_B_ASSETS entitAsset = new EntityObject_MCE_B_ASSETS();
                entitAsset.ID = request["id"];
                entitAsset = BizLogicObject_MCE_B_ASSETS.Proxy.Get(entitAsset);
                if (entitAsset!=null)
                {
                    decOriginal_value = entitAsset.ORIGINAL_VALUE;
                    decNet_value = entitAsset.NET_VALUE;
                    decRudimental_value = entitAsset.RUDIMENTAL_VALUE;
                }

                if (list != null && list.Length > 0)
                {
                    foreach (DisplayObject_MCE_B_ASSETS_WRITE_OFF item in list)
                    {
                        item.ORIGINAL_VALUE = decOriginal_value;
                        item.NET_VALUE = decNet_value;
                        item.RUDIMENTAL_VALUE = decRudimental_value;

                        string strFiles = "";
                        CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH pMCE_B_ASSETS_WRITE_OFF_ATTACH = new CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
                        pMCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = item.ID;
                    
                        DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] listMCE_B_ASSETS_WRITE_OFF_ATTACH = BizLogicObject_MCE_B_ASSETS_WRITE_OFF_ATTACH.Proxy.Query(pMCE_B_ASSETS_WRITE_OFF_ATTACH);

                        if (listMCE_B_ASSETS_WRITE_OFF_ATTACH != null && listMCE_B_ASSETS_WRITE_OFF_ATTACH.Length > 0)
                        {
                            foreach (DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH file in listMCE_B_ASSETS_WRITE_OFF_ATTACH)
                            {
                                if (!string.IsNullOrEmpty(file.SAVENAME))
                                {
                                    strFiles = strFiles + file.SAVENAME + "/" + file.FILE_NAME + ",";
                                }
                            }
                            strFiles = strFiles.TrimEnd(',');
                        }

                        item.BACKUP1 = strFiles;
                    }
                }


                jsonMsg.Message = list;
                jsonMsg.Succeed = 1;

            }
            catch (Exception ex)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = ex.Message;
            }
            finally
            {
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm" };

                string strMsg = JsonConvert.SerializeObject(jsonMsg, Formatting.Indented, timeConverter);
                strMsg = strMsg.Replace("0001-01-01 00:00", "");
                context.Response.Write(strMsg);

                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}