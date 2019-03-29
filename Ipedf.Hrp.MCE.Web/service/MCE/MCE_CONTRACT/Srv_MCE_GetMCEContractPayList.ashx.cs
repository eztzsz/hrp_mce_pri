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
    /// Srv_MCE_GetMCEContractPayList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEContractPayList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "CODE,PERIODS";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;

                CauseObject_V_MCE_QUERY_CONTRACT_PAY p = new CauseObject_V_MCE_QUERY_CONTRACT_PAY();
                p.H_STATE = 3;
                p.CONTRACT_STATE = 1;

                if (!string.IsNullOrEmpty(request["status"]))
                {
                    p.STATE = int.Parse(request["status"].ToString());
                }

                if (!string.IsNullOrEmpty(request["contract_status"]))
                {
                    p.CONTRACT_STATE = int.Parse(request["contract_status"].ToString());
                }

                if (!string.IsNullOrEmpty(request["dept"]))
                {
                    p.SECOND_PARTY = request["dept"].ToString();
                }


                if (!string.IsNullOrEmpty(request["code"]))
                {
                    p.CODE = "%" + request["code"].ToString() + "%";
                }

                if (!string.IsNullOrEmpty(request["name"]))
                {
                    p.NAME = "%" + request["name"].ToString() + "%";
                }

          

                if (!string.IsNullOrEmpty(request["beginspan"]))
                {
                    p.PLAN_PAY_DATE = new DateSpan();
                    p.PLAN_PAY_DATE.End = DateTime.Parse(request["beginspan"].ToString()).AddDays(1);
                }
     


                DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] list = BizLogicObject_V_MCE_QUERY_CONTRACT_PAY.Proxy.Query(p, pager, orderBy);



                JSON_PAGER jsonPager = new JSON_PAGER();

                jsonPager.total = pager.TotalRecords;
                jsonPager.rows = list;

                jsonMsg.Message = jsonPager;
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