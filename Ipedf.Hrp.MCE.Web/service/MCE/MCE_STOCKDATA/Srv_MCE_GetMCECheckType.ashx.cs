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
    /// Srv_MCE_GetMCECheckType 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCECheckType : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                if (request["id"] == null)
                {
                    throw new Exception("参数错误.");
                }


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "CODE";


                CauseObject_MCE_D_MCE_TYPE p = new CauseObject_MCE_D_MCE_TYPE();

                string strCondition = " and MCE_D_MCE_TYPE.ID in(select type_id from MCE_B_ASSETS_CHECK_TYPE where base_id='" + request["id"] + "')";

                p.SetCustomCondition(strCondition);


                DisplayObject_MCE_D_MCE_TYPE[] list = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Query(p, null, orderBy);



                /*
                    JSON_PAGER jsonPager = new JSON_PAGER();
             

                    CauseObject_MCE_B_ASSETS_CHECK_TYPE pd = new CauseObject_MCE_B_ASSETS_CHECK_TYPE();
                    pd.BASE_ID = request["id"].ToString();

                    DisplayObject_MCE_B_ASSETS_CHECK_TYPE[] listDetail = BizLogicObject_MCE_B_ASSETS_CHECK_TYPE.Proxy.Query(pd, null, orderBy);
                */


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