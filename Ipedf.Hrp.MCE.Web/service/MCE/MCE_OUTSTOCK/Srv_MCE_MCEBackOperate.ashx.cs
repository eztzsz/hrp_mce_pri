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
using Ipedf.Web.ServiceContract;
using System.IO;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_MCEBackOperate 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEBackOperate : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                string strType = "";
                if (!string.IsNullOrEmpty(request["oType"]))
                {
                    strType = request["oType"];
                }
                else
                {
                    throw new Exception("参数错误.");
                }

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

                if (string.IsNullOrEmpty(rsb.ToString()))
                {
                    throw new Exception("参数错误.");
                }

                List<string> idList = JsonConvert.DeserializeObject<List<string>>(rsb.ToString());

                if (idList == null || idList.Count == 0)
                {
                    throw new Exception("参数错误.");
                }

                if (strType == "submit")
                {
                    BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_BACK.Proxy.Submit_Ext(idList);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                }
                else if (strType == "audit")
                {
                    BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_BACK.Proxy.Audit_Ext(idList);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
                }
                else if (strType == "delete")
                {
                    BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_BACK.Proxy.Delete_Ext(idList);
                    if (!msg.Succeed)
                        throw new Exception(msg.Message);
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