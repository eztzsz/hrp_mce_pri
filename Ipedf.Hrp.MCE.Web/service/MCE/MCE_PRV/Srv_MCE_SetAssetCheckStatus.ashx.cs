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

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_SetAssetCheckStatus 的摘要说明
    /// </summary>
    public class Srv_MCE_SetAssetCheckStatus : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                StringBuilder rsb = new StringBuilder();
                int bytelengg = (int)request.InputStream.Length;
                using (var reader = new StreamReader(request.InputStream, Encoding.UTF8))
                {
                    var read = new Char[bytelengg];
                    var count = reader.Read(read, 0, bytelengg);
                    while (count > 0)
                    {
                        var str = new string(read, 0, count);
                        rsb.Append(str);
                        count = reader.Read(read, 0, bytelengg);
                    }
                    reader.Close();
                    reader.Dispose();
                    request.InputStream.Close();
                    request.InputStream.Dispose();
                }
                JsonMCE_Asser_Check jsonMCE_Asser_Check = JsonConvert.DeserializeObject<JsonMCE_Asser_Check>(rsb.ToString());

                if (jsonMCE_Asser_Check.idList == null || jsonMCE_Asser_Check.idList.Count == 0)
                {
                    throw new Exception("参数错误.");
                }



                PRV_MCE_Web_Service.PRV_Web_Service service = new PRV_MCE_Web_Service.PRV_Web_Service();
                if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                {
                    string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                    service.Url = strServiceURL;
                }

                string strJson = JsonConvert.SerializeObject(jsonMCE_Asser_Check.idList);
                string strRet = service.CheckMceAssetIsAudit(strJson);
                if (strRet == "-1")
                {
                    throw new Exception("审核失败，已经审核的设备不能再审核.");
                }


                if (jsonMCE_Asser_Check.State == "1" && !string.IsNullOrEmpty(strRet))
                {
                    BizLogicMsg msg = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Save_Prd_Ext(strRet);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                }

                string strUserID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                string strUserName = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;
                
                int intRet = service.SetMceAssetAuditStatus(strJson, jsonMCE_Asser_Check.State, strUserID, strUserName, jsonMCE_Asser_Check.Reason);
                if (intRet == 0)
                {
                    throw new Exception("审核失败.");
                }


                jsonMsg.Succeed = 1;

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