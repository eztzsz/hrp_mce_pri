using System.Web;
using Ipedf.Core;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Web.Services;
using System.Reflection;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Web.SessionState;
using System;
using Newtonsoft.Json.Converters;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetAssetCheckDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetAssetCheckDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                if( request["id"]==null)
                {
                    throw new Exception("参数错误.");
                }

                string strID = request["id"].ToString();


                PRV_MCE_Web_Service.PRV_Web_Service service = new PRV_MCE_Web_Service.PRV_Web_Service();
                if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                {
                    string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                    service.Url = strServiceURL;
                }

                string json = service.GetMceAssetDetail(strID);

                jsonMsg.Succeed = 1;
                jsonMsg.Message = (JsonConvert.DeserializeObject<DisplayObject_PRV_B_ASSET>(json));
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