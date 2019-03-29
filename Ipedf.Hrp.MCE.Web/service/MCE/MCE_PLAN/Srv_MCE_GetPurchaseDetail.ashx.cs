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
    /// Srv_MCE_GetPurchaseDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetPurchaseDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_MCE_B_ASSETS_PURCHASE p = new CauseObject_MCE_B_ASSETS_PURCHASE();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_PURCHASE[] listHead = BizLogicObject_MCE_B_ASSETS_PURCHASE.Proxy.Query(p);


                if (listHead == null)
                    throw new Exception("获取列表信息失败.");

                if (!string.IsNullOrEmpty(listHead[0].ASSET_ID))
                {

                    PRV_MCE_Web_Service.PRV_Web_Service service = new PRV_MCE_Web_Service.PRV_Web_Service();
                    if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                    {
                        string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                        service.Url = strServiceURL;
                    }

                    string json = service.GetMceAssetDetail(listHead[0].ASSET_ID);

                    if (!string.IsNullOrEmpty(json))
                    {
                        DisplayObject_PRV_B_ASSET entity = (JsonConvert.DeserializeObject<DisplayObject_PRV_B_ASSET>(json));
                        if(entity!=null && !string.IsNullOrEmpty( entity.PICTURE))
                        {
                            listHead[0].PICTURE = entity.PICTURE;
                        }
                    }
                }

                jsonMsg.Succeed = 1;
                jsonMsg.Message = listHead[0];
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