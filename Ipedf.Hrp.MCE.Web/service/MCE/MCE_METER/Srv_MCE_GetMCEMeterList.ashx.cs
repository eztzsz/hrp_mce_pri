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
    /// Srv_MCE_GetMCEMeterList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEMeterList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "CODE";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;

                CauseObject_MCE_B_ASSETS_METER p = new CauseObject_MCE_B_ASSETS_METER();

                if (!string.IsNullOrEmpty(request["status"]))
                {
                    p.STATE = int.Parse(request["status"].ToString());
                }


                if (!string.IsNullOrEmpty(request["dept"]))
                {
                    p.USING_DEPT_ID = request["dept"].ToString();
                }


                if (!string.IsNullOrEmpty(request["asset"]))
                {
                    p.ASSETS_ID = request["asset"].ToString();
                }


                if (!string.IsNullOrEmpty(request["meter_type"]))
                {
                    p.METER_TYPE = request["meter_type"].ToString();
                }

                if (!string.IsNullOrEmpty(request["code"]))
                {
                    p.CODE = "%" + request["code"].ToString() + "%";
                }

                if (!string.IsNullOrEmpty(request["beginspan"]))
                {
                    p.NEXT_IDENTIFICATION = new DateSpan();
                    p.NEXT_IDENTIFICATION.Begin = DateTime.Parse(request["beginspan"].ToString());
                }
                if (!string.IsNullOrEmpty(request["endspan"]))
                {
                    if (p.NEXT_IDENTIFICATION == null)
                        p.NEXT_IDENTIFICATION = new DateSpan();
                    p.NEXT_IDENTIFICATION.End = DateTime.Parse(request["endspan"].ToString());
                }


                DisplayObject_MCE_B_ASSETS_METER[] list = BizLogicObject_MCE_B_ASSETS_METER.Proxy.Query(p, pager, orderBy);



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