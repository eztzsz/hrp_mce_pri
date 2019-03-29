using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.IO;
using System.Text;
using System.Web.Services;
using System.Web.SessionState;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEStockList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEStockList : IHttpHandler, IRequiresSessionState
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
                orderBy.OrderBy = "CODE, NAME";
                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;
                StringBuilder strCondition = new StringBuilder();
                strCondition.Append(" and MDM_D_STOCK.STOCK_TYPE_ID = '00320003' ");


                List<JsonMtrPurStock> list = new System.Collections.Generic.List<JsonMtrPurStock>();
                CauseObject_MDM_D_STOCK cause = new CauseObject_MDM_D_STOCK();
                if (!string.IsNullOrEmpty(request["area"]))
                    cause.DEPT_ID = request["area"].ToString().Trim();
                if (!string.IsNullOrEmpty(request["is_area"]) && request["is_area"].ToString().Trim() == "1")
                    cause.DEPT_ID = BizLogicObject_MTR_D_MTR.Proxy.getAreaByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID.Trim());
                if (!string.IsNullOrEmpty(request["condition"]))
                    strCondition.Append(string.Format(" and (upper(MDM_D_STOCK.CODE) like upper('%{0}%') or upper(MDM_D_STOCK.NAME) like upper('%{0}%')) ", request["condition"].ToString().Trim()));
                cause.SetCustomCondition(strCondition.ToString());
                DisplayObject_MDM_D_STOCK[] stocks = BizLogicObject_MDM_D_STOCK.Proxy.Query(cause, pager, orderBy);
                foreach (DisplayObject_MDM_D_STOCK item in stocks)
                {
                    JsonMtrPurStock tmp = new JsonMtrPurStock();
                    tmp.id = item.ID.Trim();
                    tmp.code = item.CODE;
                    tmp.name = item.NAME;
                    tmp.dept = item.DEPT_ID.Trim();
                    tmp.deptName = item.DEPT_ID_NAME;
                    list.Add(tmp);
                }
                JSON_PAGER jsonPager = new JSON_PAGER();
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
                context.Response.Write(JsonConvert.SerializeObject(jsonMsg));
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