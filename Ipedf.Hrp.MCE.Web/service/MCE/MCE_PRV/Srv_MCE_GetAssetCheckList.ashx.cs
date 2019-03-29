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
    /// Srv_MCE_GetAssetCheckList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetAssetCheckList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_PRV_B_ASSET p = new CauseObject_PRV_B_ASSET();


                StringBuilder strCondition = new StringBuilder();
                strCondition.Append(" and PRV_B_ASSET.STATE > -1 ");

                if (!string.IsNullOrEmpty(request["state"]))
                {
                        p.STATE = int.Parse(request["state"].ToString());                    
                }


                if (!string.IsNullOrEmpty(request["prv"]))
                {
                    p.PRV_ID = request["prv"].ToString();
                }

                if (!string.IsNullOrEmpty(request["refprv"]))
                {
                    EntityObject_MDM_D_DEPT entityDept = new EntityObject_MDM_D_DEPT();
                    entityDept.ID = request["refprv"];
                    entityDept = BizLogicObject_MDM_D_DEPT.Proxy.Get(entityDept);

                    if (entityDept != null)
                    {
                        p.PRV_ID = entityDept.REF_ID;
                    }
                }

                if (!string.IsNullOrEmpty(request["typeid"]))
                {
                    p.TYPE_ID = request["typeid"].ToString();
                }


                if (!string.IsNullOrEmpty(request["name"]))
                {
                    p.NAME = "%" + request["name"].ToString().Trim() + "%";
                }



                if (!string.IsNullOrEmpty(request["prd"]))//生产厂家
                {
                    strCondition.Append(" and PRV_D_DEPT_PRD_ID.NAME like '%" + request["prd"].ToString().Trim() + "%'");

                }

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }


                string strOrder = JsonConvert.SerializeObject(orderBy);
                string strPage = JsonConvert.SerializeObject(pager);
                string strCause = JsonConvert.SerializeObject(p);

                PRV_MCE_Web_Service.PRV_Web_Service service = new PRV_MCE_Web_Service.PRV_Web_Service();
                if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                {
                    string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                    service.Url = strServiceURL;
                }

                string strJson = service.GetPrvAssetInfo(strCause, strPage, strOrder);

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