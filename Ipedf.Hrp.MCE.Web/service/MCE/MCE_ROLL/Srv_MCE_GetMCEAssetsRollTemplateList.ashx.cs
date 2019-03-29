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
    /// Srv_MCE_GetMCEAssetsRollTemplateList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsRollTemplateList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "NAME";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;


                CauseObject_MCE_B_ASSETS_FILETEMPLATE p = new CauseObject_MCE_B_ASSETS_FILETEMPLATE();

                StringBuilder strCondition = new StringBuilder();
                if (!string.IsNullOrEmpty(request["condition"]))//条件
                {
                    strCondition.Append(" and (MCE_B_ASSETS_FILETEMPLATE.name like '%" + request["condition"].ToString().Trim() + "%' or MCE_B_ASSETS_FILETEMPLATE.comments like '%" + request["condition"].ToString().Trim() + "%')");
                }

                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_B_ASSETS_FILETEMPLATE[] list = BizLogicObject_MCE_B_ASSETS_FILETEMPLATE.Proxy.Query(p, pager, orderBy);


                JSON_PAGER jsonPager = new JSON_PAGER();
   ;
                jsonPager.total = pager.TotalRecords;
                jsonPager.rows = list;
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