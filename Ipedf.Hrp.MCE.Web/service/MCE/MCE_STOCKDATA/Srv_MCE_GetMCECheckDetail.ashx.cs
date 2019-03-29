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

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCECheckDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCECheckDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                if(request["id"]==null)
                {
                    throw new Exception("参数错误.");
                }

                CauseObject_MCE_B_ASSETS_CHECK p = new CauseObject_MCE_B_ASSETS_CHECK();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_CHECK[] listHead = BizLogicObject_MCE_B_ASSETS_CHECK.Proxy.Query(p);


                JSON_PAGER jsonPager = new JSON_PAGER();
                if (listHead == null)
                    throw new Exception("获取列表信息失败.");

                jsonPager.head = listHead[0];


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "ASSETS_ID";


                CauseObject_MCE_B_ASSETS_CHECK_D pd = new CauseObject_MCE_B_ASSETS_CHECK_D();
                pd.BASE_ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_CHECK_D[] listDetail = BizLogicObject_MCE_B_ASSETS_CHECK_D.Proxy.Query(pd, null, orderBy);


                jsonPager.total = listDetail.Length;
                jsonPager.rows = listDetail;
                jsonMsg.Succeed = 1;
                jsonMsg.Message = jsonPager;
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