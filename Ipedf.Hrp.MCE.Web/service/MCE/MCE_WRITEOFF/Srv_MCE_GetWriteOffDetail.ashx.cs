using System.Web;
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
    /// Srv_MCE_GetWriteOffDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetWriteOffDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_MCE_B_ASSETS_WRITE_OFF p = new CauseObject_MCE_B_ASSETS_WRITE_OFF();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_WRITE_OFF[] listHead = BizLogicObject_MCE_B_ASSETS_WRITE_OFF.Proxy.Query(p);


                JSON_PAGER_Write_Off jsonPager = new JSON_PAGER_Write_Off();
                if (listHead == null)
                    throw new Exception("获取列表信息失败.");

                jsonPager.head = listHead[0];


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "ASSETS_CODE";


                CauseObject_MCE_B_ASSETS pd = new CauseObject_MCE_B_ASSETS();
                pd.SetCustomCondition(" and MCE_B_ASSETS.ID in(select asset_id from MCE_B_ASSETS_WRITE_OFF_D where base_id='" + request["id"].ToString() + "')");
                DisplayObject_MCE_B_ASSETS[] listDetail = BizLogicObject_MCE_B_ASSETS.Proxy.Query(pd, null, orderBy);



                OrderByParameter orderByAttach = new OrderByParameter();
                orderByAttach.Asc = false;
                orderByAttach.OrderBy = "CREATE_DATE";


                CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH pAttach = new CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
                pAttach.BASE_ID = request["id"].ToString();


                DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] listAttach = BizLogicObject_MCE_B_ASSETS_WRITE_OFF_ATTACH.Proxy.Query(pAttach, null, orderByAttach);


                jsonPager.total = listDetail.Length;
                jsonPager.rows = listDetail;
                jsonPager.attach = listAttach;

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