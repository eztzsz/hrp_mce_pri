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
    /// Srv_MCE_GetPrvCheckList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetPrvCheckList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.Asc = false;
                orderBy.OrderBy = "CREATE_TIME";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;

                CauseObject_PRV_D_DEPT p = new CauseObject_PRV_D_DEPT();
                p.DEPT_TYPE_ID = "00340005";

                if (!string.IsNullOrEmpty(request["status"]))
                {
                    p.AUDIT_STATE = request["status"].ToString();
                }

                if (!string.IsNullOrEmpty(request["prvid"]))
                {
                    p.ID = request["prvid"].ToString();
                }

                StringBuilder strCondition = new StringBuilder();
                if (!string.IsNullOrEmpty(request["condition"]))
                    strCondition.Append(string.Format(" and (upper(PRV_D_DEPT.CODE) like upper('%{0}%') or upper(PRV_D_DEPT.NAME) like upper('%{0}%')) ", request["condition"].ToString().Trim()));

                if (!string.IsNullOrEmpty(request["beginspan"]))
                {
                    p.CREATE_TIME = new DateSpan();
                    p.CREATE_TIME.Begin = DateTime.Parse(request["beginspan"].ToString());
                }
                if (!string.IsNullOrEmpty(request["endspan"]))
                {
                    if (p.CREATE_TIME == null)
                        p.CREATE_TIME = new DateSpan();
                    p.CREATE_TIME.End = DateTime.Parse(request["endspan"].ToString());
                }

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                    p.SetCustomCondition(strCondition.ToString());

                string strOrder = JsonConvert.SerializeObject(orderBy);
                string strPage = JsonConvert.SerializeObject(pager);
                string strCause = JsonConvert.SerializeObject(p);

                PRV_MCE_Web_Service.PRV_Web_Service service = new PRV_MCE_Web_Service.PRV_Web_Service();
                if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                {
                    string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                    service.Url = strServiceURL;
                }

                string strJson = service.GetPrvInfo(strCause, strPage, strOrder);

                JSON_PAGER list = JsonConvert.DeserializeObject<JSON_PAGER>(strJson);
                jsonMsg.Succeed = 1;
                jsonMsg.Message = list;
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