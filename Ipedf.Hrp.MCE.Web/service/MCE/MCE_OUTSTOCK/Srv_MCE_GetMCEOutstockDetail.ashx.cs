﻿using System.Web;
using Ipedf.Core;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Web.Services;
using System.Reflection;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Web.SessionState;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEOutstockDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEOutstockDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_MCE_B_ASSETS_OUTSTOCK p = new CauseObject_MCE_B_ASSETS_OUTSTOCK();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_OUTSTOCK[] listHead = BizLogicObject_MCE_B_ASSETS_OUTSTOCK.Proxy.Query(p);


                JSON_PAGER jsonPager = new JSON_PAGER();
                if (listHead == null)
                    throw new Exception("获取列表信息失败.");

                jsonPager.head = listHead[0];


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "ASSETS_NAME";


                CauseObject_MCE_B_ASSETS_OUTSTOCK_D pd = new CauseObject_MCE_B_ASSETS_OUTSTOCK_D();
                pd.BASE_ID = request["id"].ToString();


                DisplayObject_MCE_B_ASSETS_OUTSTOCK_D[] listDetail = BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.Query(pd, null, orderBy);


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
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd" };

                string strMsg = JsonConvert.SerializeObject(jsonMsg, Formatting.Indented, timeConverter);
                strMsg = strMsg.Replace("0001-01-01", "");

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