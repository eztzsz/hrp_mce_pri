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
    /// Srv_MCE_GetMCEAssetsDeprTypeList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsDeprTypeList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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


                StringBuilder strCondition = new StringBuilder();
                CauseObject_MCE_D_DEPR_TYPE p = new CauseObject_MCE_D_DEPR_TYPE();

                if (!string.IsNullOrEmpty(request["condition"]))//
                {
                    strCondition.Append(" and (MCE_D_DEPR_TYPE.CODE like '%" + request["condition"].ToString().Trim() + "%'  or MCE_D_DEPR_TYPE.NAME like '%" + request["condition"].ToString().Trim() + "%' )");
                }


                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_D_DEPR_TYPE[] list = BizLogicObject_MCE_D_DEPR_TYPE.Proxy.Query(p);



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