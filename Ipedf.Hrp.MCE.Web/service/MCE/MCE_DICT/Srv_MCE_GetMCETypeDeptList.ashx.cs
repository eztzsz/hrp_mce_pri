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
    /// Srv_MCE_GetMCETypeDeptList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCETypeDeptList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "CODE, POST_CODE";
                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;
                StringBuilder strCondition = new StringBuilder();
                string area = string.Empty;
                CauseObject_COM_DEPART pItem = new CauseObject_COM_DEPART();
                if (!string.IsNullOrEmpty(request["code"]))
                    strCondition.Append(string.Format(" and COM_DEPART.CODE like upper('%{0}%') ", request["code"].ToString().Trim()));
                if (!string.IsNullOrEmpty(request["area"]))
                {
                    area = request["area"].ToString().Trim();
                    strCondition.Append(string.Concat(" and COM_DEPART.ID in (select distinct id from com_depart where parent_id is not null start with id = '", area, "' connect by parent_id= prior id) "));
                }

                if (!string.IsNullOrEmpty(request["mcetype_id"]))
                {
                    string mcetype_id = request["mcetype_id"].ToString().Trim();
                    strCondition.Append(string.Concat(" and COM_DEPART.ID in (select distinct dept_id from MCE_D_TYPE_DEPT where mce_type_id='", mcetype_id, "')"));
                }

                if (!string.IsNullOrEmpty(request["is_area"]) && request["is_area"].ToString().Trim() == "1")
                {
                    area = BizLogicObject_MTR_D_MTR.Proxy.getAreaByDept(SystemLogic.Proxy.CurrentUser.DEPART_ID.Trim());
                    strCondition.Append(string.Concat(" and COM_DEPART.ID in (select distinct id from com_depart where parent_id is not null start with id = '", area, "' connect by parent_id= prior id) "));
                }
                if (!string.IsNullOrEmpty(request["condition"]))
                    strCondition.Append(string.Format(" and (upper(COM_DEPART.CODE) like upper('%{0}%') or upper(COM_DEPART.NAME) like upper('%{0}%')) ", request["condition"].ToString().Trim()));
                if (!string.IsNullOrEmpty(strCondition.ToString()))
                    pItem.SetCustomCondition(strCondition.ToString());

                List<JsonMtrDept> list = BizLogicObject_MTR_D_MTR.Proxy.getDeptList(pItem, pager, orderBy, area);
                JSON_PAGER jsonPager = new JSON_PAGER();
                if (list == null)
                    throw new Exception("获取科室列表失败.");
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