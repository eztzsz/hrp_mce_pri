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
    /// Srv_MCE_GetMCEAssetsUserInfo 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsUserInfo : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                JsonMceAssetsUserInfo jsonMceAssetsUserInfo = new JsonMceAssetsUserInfo();

                jsonMceAssetsUserInfo.user_id = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                jsonMceAssetsUserInfo.user_name = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;

                jsonMceAssetsUserInfo.dept_id = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                jsonMceAssetsUserInfo.dept_name = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME;
                jsonMceAssetsUserInfo.sys_date = DateTime.Now.ToString("yyyy-MM-dd");
                jsonMceAssetsUserInfo.finance_cycle = DateTime.Now.ToString("yyyyMM");
                if(request["code_type"]!=null)
                {
                    string strCode = BizLogicObject_MCE_B_ASSETS.Proxy.Generate_Bill_Code(request["code_type"]);
                    jsonMceAssetsUserInfo.code = strCode;
                }
                jsonMsg.Message = jsonMceAssetsUserInfo;
                jsonMsg.Succeed = 1;

            }
            catch (Exception ex)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = ex.Message;
            }
            finally
            {
                string strMsg = JsonConvert.SerializeObject(jsonMsg);
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