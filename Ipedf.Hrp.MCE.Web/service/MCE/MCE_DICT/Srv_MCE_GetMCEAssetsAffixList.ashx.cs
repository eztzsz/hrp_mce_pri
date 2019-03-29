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
    /// Srv_MCE_GetMCEAssetsAffixList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsAffixList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "CODE";

                //PagingParamter pager = new PagingParamter();
                //pager.PageSize = int.MaxValue;
                //pager.PageIndex = 0;

                StringBuilder strCondition = new StringBuilder();


                if (string.IsNullOrEmpty(request["id"]))
                {
                    throw new Exception("参数错误.");
                }


                CauseObject_MCE_B_ASSETS_AFFIX p = new CauseObject_MCE_B_ASSETS_AFFIX();

                p.ASSETS_ID = request["id"];

                if (!string.IsNullOrEmpty(request["condition"]))//
                {

                    strCondition.Append(" and (MCE_B_ASSETS_AFFIX.CODE like '%" + request["condition"].ToString().Trim() + "%' or MCE_B_ASSETS_AFFIX.NAME like '%" + request["condition"].ToString().Trim() + "%' or MCE_B_ASSETS_AFFIX.SPEC like '%" + request["condition"].ToString().Trim() + "%' )");
                }

             

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_B_ASSETS_AFFIX[] list = BizLogicObject_MCE_B_ASSETS_AFFIX.Proxy.Query(p, null, orderBy);

            
                if(list!=null && list.Length>0)
                {
                    foreach(DisplayObject_MCE_B_ASSETS_AFFIX item in list)
                    {
                        string strFiles = "";
                        CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                        pCOM_FILE.REF_TAB_ID = item.ID;
                        pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_AFFIX";

                        DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                        if (listCOM_FILE != null && listCOM_FILE.Length > 0)
                        {
                            foreach (DisplayObject_COM_FILE file in listCOM_FILE)
                            {
                                if (!string.IsNullOrEmpty(file.SERVER_NAME))
                                {
                                    strFiles = strFiles + file.SERVER_NAME + "/" + file.CLIENT_NAME + ",";
                                }
                            }
                            strFiles = strFiles.TrimEnd(',');
                        }
                        item.BACKUP1 = strFiles;

                        item.BACKUP2 = BarCodeHelper.GenerateBarCode(item.CODE);
                    }
                }

                //JSON_PAGER jsonPager = new JSON_PAGER();

                //jsonPager.total = pager.TotalRecords;
                //jsonPager.rows = list;

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