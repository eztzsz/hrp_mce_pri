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
    /// Srv_MCE_GetMCEAssetsMtnList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsMtnList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                StringBuilder strCondition = new StringBuilder();
                CauseObject_MCE_B_ASSETS_MT_APPLY p = new CauseObject_MCE_B_ASSETS_MT_APPLY();

                p.ASSETS_ID = request["id"];

                if (!string.IsNullOrEmpty(request["condition"]))//
                {
                    strCondition.Append(" and (MCE_B_ASSETS_MT_APPLY.CODE like '%" + request["condition"].ToString().Trim() + "%' )");
                }

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_B_ASSETS_MT_APPLY[] list = BizLogicObject_MCE_B_ASSETS_MT_APPLY.Proxy.Query(p);


                if (list != null && list.Length > 0)
                {
                    foreach (DisplayObject_MCE_B_ASSETS_MT_APPLY item in list)
                    {
                        string strMtn_User = "";
                        CauseObject_MCE_B_ASSETS_MT_APPLY_EN pMCE_B_ASSETS_MT_APPLY_EN = new CauseObject_MCE_B_ASSETS_MT_APPLY_EN();
                        pMCE_B_ASSETS_MT_APPLY_EN.BASE_ID = item.ID;
                      
                        DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] listMCE_B_ASSETS_MT_APPLY_EN = BizLogicObject_MCE_B_ASSETS_MT_APPLY_EN.Proxy.Query(pMCE_B_ASSETS_MT_APPLY_EN);

                        if (listMCE_B_ASSETS_MT_APPLY_EN != null && listMCE_B_ASSETS_MT_APPLY_EN.Length > 0)
                        {
                            strMtn_User = listMCE_B_ASSETS_MT_APPLY_EN[0].USER_ID_NAME;
                        }
                        item.COMMENTS = strMtn_User;
                    }
                }
                else
                { 
                    list = new DisplayObject_MCE_B_ASSETS_MT_APPLY[1];
                    DisplayObject_MCE_B_ASSETS_MT_APPLY item = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
                    list[0] = item;
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