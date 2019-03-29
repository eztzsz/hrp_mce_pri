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
    /// Srv_MCE_GetMCEAssetsList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                orderBy.OrderBy = "ASSETS_CODE";

                PagingParamter pager = new PagingParamter();
                pager.PageSize = string.IsNullOrEmpty(request["limit"]) ? 10 : int.Parse(request["limit"].ToString());
                pager.PageIndex = string.IsNullOrEmpty(request["offset"]) ? 0 : (int.Parse(request["offset"].ToString()) <= 0) ? 0 : int.Parse(request["offset"].ToString()) - 1;

                StringBuilder strCondition = new StringBuilder();

                CauseObject_MCE_B_ASSETS p = new CauseObject_MCE_B_ASSETS();

                if (!string.IsNullOrEmpty(request["status"]))
                {
                    p.STATE = int.Parse(request["status"].ToString());
                }

                if (!string.IsNullOrEmpty(request["type_id"]))
                {
                    p.MACHINE_TYPE_ID = request["type_id"].ToString();
                }

                  if (!string.IsNullOrEmpty(request["brand"]))//品牌
                {
                    p.BRAND_NAME = "%" + request["brand"].ToString() + "%";
                }

                if (!string.IsNullOrEmpty(request["use_state"]))//使用状态
                {
                    p.USE_STATE = request["use_state"].ToString();
                }

                if (!string.IsNullOrEmpty(request["ownership_type_id"]))//权属信息
                {
                    p.OWNERSHIP_TYPE_ID = request["ownership_type_id"].ToString();
                }

                if (!string.IsNullOrEmpty(request["assets_state"]))//资产状态
                {
                    p.ASSETS_STATE = request["assets_state"].ToString();
                }

                if (!string.IsNullOrEmpty(request["card_type_id"]))//卡片类型
                {
                    p.CARD_TYPE_ID = request["card_type_id"].ToString();
                }

                if (!string.IsNullOrEmpty(request["is_metering"]))//是否计量
                {
                    p.IS_METERING =int.Parse( request["is_metering"].ToString());
                }

                if (!string.IsNullOrEmpty(request["is_force_sense"]))//是否强检设备
                {
                    p.IS_FORCE_SENSE = int.Parse(request["is_force_sense"].ToString());
                }

                if (!string.IsNullOrEmpty(request["prv"]))//供应商
                {
                    p.PROVIDER_ID = request["prv"];
                }

                if (!string.IsNullOrEmpty(request["prd"]))//生产厂家
                {
                    strCondition.Append(" and MDM_D_DEPT_PRD_ID.NAME like '%" + request["prd"].ToString().Trim() + "%'");
                }

                //if (!string.IsNullOrEmpty(request["prv"]))//供应商
                //{
                //    strCondition.Append(" and MDM_D_DEPT_PROVIDER_ID.NAME like '%" + request["prv"].ToString().Trim() + "%'");
                //}


                if (!string.IsNullOrEmpty(request["usedept"]))//领用科室
                {
                    strCondition.Append(" and COM_DEPART_USING_DEPT_ID.NAME like '%" + request["usedept"].ToString().Trim() + "%'");
                }

                if (!string.IsNullOrEmpty(request["cust_condition"]))//定制条件
                {
                    strCondition.Append(request["cust_condition"]);
                }

                if (!string.IsNullOrEmpty(request["condition"]))//条件
                {
                    strCondition.Append(" and (MCE_B_ASSETS.assets_code like '%" + request["condition"].ToString().Trim() + "%' or MCE_B_ASSETS.assets_name like '%" + request["condition"].ToString().Trim() + "%' or MCE_B_ASSETS.spec like '%" + request["condition"].ToString().Trim() + "%' or COM_DEPART_USING_DEPT_ID.NAME like '%" + request["condition"].ToString().Trim() + "%')");
                }
                else
                {
                    if (!string.IsNullOrEmpty(request["code"]))
                    {
                        p.ASSETS_CODE = "%" + request["code"].ToString() + "%";
                    }

                    if (!string.IsNullOrEmpty(request["name"]))
                    {
                        p.ASSETS_NAME = "%" + request["name"].ToString() + "%";
                    }

                    if (!string.IsNullOrEmpty(request["spec"]))//规格型号
                    {
                        p.SPEC = "%" + request["spec"].ToString() + "%";
                    }
                }

                if(!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                List<DisplayObject_MCE_B_ASSETS> list = new List<DisplayObject_MCE_B_ASSETS>();
                DisplayObject_MCE_B_ASSETS[] list0 = BizLogicObject_MCE_B_ASSETS.Proxy.Query(p, pager, orderBy);

                if(list0!=null && list0.Length>0)
                {
                    list = list0.ToList();
                }

                string strNeedTotal = "1";
                if (!string.IsNullOrEmpty(request["needTotal"]))//需要合计
                {
                    strNeedTotal = request["needTotal"];
                }

                if (strNeedTotal == "1")
                {
                    object objORIGINAL_VALUE = list.Sum(l => l.ORIGINAL_VALUE);
                    object objNET_VALUE = list.Sum(l => l.NET_VALUE);

                    DisplayObject_MCE_B_ASSETS pageItem = new DisplayObject_MCE_B_ASSETS();
                    pageItem.ASSETS_CODE = "小计";
                    if (!string.IsNullOrEmpty(objORIGINAL_VALUE.ToString()))
                    {
                        pageItem.ORIGINAL_VALUE = decimal.Parse(objORIGINAL_VALUE.ToString());
                    }

                    if (!string.IsNullOrEmpty(objNET_VALUE.ToString()))
                    {
                        pageItem.NET_VALUE = decimal.Parse(objNET_VALUE.ToString());
                    }
                    list.Add(pageItem);


                    DisplayObject_MCE_B_ASSETS totalItem = BizLogicObject_MCE_B_ASSETS.Proxy.GetTotalRecord(p);
                    list.Add(totalItem);
                }

                JSON_PAGER jsonPager = new JSON_PAGER();
        
                jsonPager.total = pager.TotalRecords;
                jsonPager.rows = list;


                string strDropDown = "0";
                if (!string.IsNullOrEmpty(request["dropdown"]))//
                {
                    strDropDown = request["dropdown"];
                }

                if (strDropDown=="1" && list != null && list.Count > 0)
                {
                    foreach(DisplayObject_MCE_B_ASSETS item in list)
                    {
                        item.NAME = item.ASSETS_NAME;
                    }
                }

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