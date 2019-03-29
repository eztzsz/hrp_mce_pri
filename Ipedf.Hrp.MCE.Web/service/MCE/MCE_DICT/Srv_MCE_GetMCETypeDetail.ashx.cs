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
    /// Srv_MCE_GetMCETypeDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCETypeDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_MCE_D_MCE_TYPE p = new CauseObject_MCE_D_MCE_TYPE();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_D_MCE_TYPE[] listHead = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Query(p);


                JSON_PAGER jsonPager = new JSON_PAGER();
                if (listHead == null || listHead.Length==0)
                    throw new Exception("获取列表信息失败.");

                jsonPager.head = listHead[0];


                CauseObject_MCE_D_TYPE_DEPT pd = new CauseObject_MCE_D_TYPE_DEPT();
                pd.MCE_TYPE_ID = request["id"].ToString();

                DisplayObject_MCE_D_TYPE_DEPT[] listDetail = BizLogicObject_MCE_D_TYPE_DEPT.Proxy.Query(pd);


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