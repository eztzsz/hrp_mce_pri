﻿using System;
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
    /// Srv_MCE_GetMCEOutStockBackList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEOutStockBackList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                string strIDS = "";
                if (!string.IsNullOrEmpty(request["ids"]))
                {
                    strIDS = request["ids"].ToString();
                }

                if(string.IsNullOrEmpty(strIDS))
                {
                    throw new Exception("参数错误.");
                }

                string[] arrID = strIDS.Split(',');
                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "assets_code";
                CauseObject_V_MCE_ASSET_OUTSTOCK_BACK p = new CauseObject_V_MCE_ASSET_OUTSTOCK_BACK();
                foreach (string strID in arrID)
                {
                    p.SetINValue("BASE_ID", strID);                  
                }
           
                DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] list = BizLogicObject_V_MCE_ASSET_OUTSTOCK_BACK.Proxy.Query(p);

                jsonMsg.Message = list;
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