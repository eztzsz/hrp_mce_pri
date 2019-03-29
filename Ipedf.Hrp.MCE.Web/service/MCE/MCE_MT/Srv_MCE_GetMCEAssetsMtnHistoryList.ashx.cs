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
    /// Srv_MCE_GetMCEAssetsMtnHistoryList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsMtnHistoryList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "FINANCE_CYCLE";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;


                if (string.IsNullOrEmpty(request["id"]))
                {
                    throw new Exception("参数错误.");
                }

                CauseObject_V_MCE_ASSETS_DEPR_MTN p = new CauseObject_V_MCE_ASSETS_DEPR_MTN();
                p.ASSERTS_ID = request["id"];


                List<DisplayObject_V_MCE_ASSETS_DEPR_MTN> list = new List<DisplayObject_V_MCE_ASSETS_DEPR_MTN>();
                DisplayObject_V_MCE_ASSETS_DEPR_MTN[] list0 = BizLogicObject_V_MCE_ASSETS_DEPR_MTN.Proxy.Query(p, pager, orderBy);

                if (list0 != null && list0.Length > 0)
                {
                    list = list0.ToList();
                }

                object objMoney = list.Sum(l => l.MAINTAIN_MONEY);


                DisplayObject_V_MCE_ASSETS_DEPR_MTN pageItem = new DisplayObject_V_MCE_ASSETS_DEPR_MTN();
                pageItem.FINANCE_CYCLE = "小计";
                if (!string.IsNullOrEmpty(objMoney.ToString()))
                {
                    pageItem.MAINTAIN_MONEY = decimal.Parse(objMoney.ToString());
                }

                list.Add(pageItem);


                DisplayObject_V_MCE_ASSETS_DEPR_MTN[] list1 = BizLogicObject_V_MCE_ASSETS_DEPR_MTN.Proxy.Query(p);

                object objTotMoney = list1.Sum(l => l.MAINTAIN_MONEY);

                DisplayObject_V_MCE_ASSETS_DEPR_MTN totalItem = new DisplayObject_V_MCE_ASSETS_DEPR_MTN();

                totalItem.FINANCE_CYCLE = "总计";
                if (!string.IsNullOrEmpty(objTotMoney.ToString()))
                {
                    totalItem.MAINTAIN_MONEY = decimal.Parse(objTotMoney.ToString());
                }

                list.Add(totalItem);

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