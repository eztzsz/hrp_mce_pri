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
using Ipedf.Hrp.Entity;


namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_MCETransferSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCETransferSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                if (string.IsNullOrEmpty(rsb.ToString()))
                {
                    throw new Exception("参数错误.");
                }

                JsonMCE_TRANSFER entity = JsonConvert.DeserializeObject<JsonMCE_TRANSFER>(rsb.ToString());


                if (string.IsNullOrEmpty(entity.CODE))
                {
                    throw new Exception("参数错误,单号不能为空.");
                }

                if (string.IsNullOrEmpty(entity.TRANSFER_DEPT_ID))
                {
                    throw new Exception("参数错误,转移科室不能为空.");
                }

                if (string.IsNullOrEmpty(entity.DEPT_ID))
                {
                    throw new Exception("参数错误,当前使用科室不能为空.");
                }

                if (string.IsNullOrEmpty(entity.CREATE_DATE))
                {
                    throw new Exception("参数错误,转移日期不能为空.");
                }

                if (entity.children != null && entity.children.Count > 0)
                {
                    foreach (JsonMCE_TRANSFER_D item in entity.children)
                    {
                        if (string.IsNullOrEmpty(item.ASSETS_ID))
                        {
                            throw new Exception("参数错误,设备名称不能为空.");
                        }

                        if (string.IsNullOrEmpty(item.ASSETS_NAME))
                        {
                            throw new Exception("参数错误,设备名称不能为空.");
                        }
                        if (string.IsNullOrEmpty(item.ASSETS_CODE))
                        {
                            throw new Exception("参数错误,设备编码不能为空.");
                        }
                       
                    }
                }
                else
                {
                    throw new Exception("没有明细数据");
                }


                BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_TRANSFER.Proxy.Save_Ext(entity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);

                jsonMsg.Succeed = 1;
                jsonMsg.Message = msg.Message;


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