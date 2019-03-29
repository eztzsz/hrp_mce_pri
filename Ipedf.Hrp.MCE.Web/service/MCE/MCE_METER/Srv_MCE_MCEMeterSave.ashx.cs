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
    /// Srv_MCE_MCEMeterSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEMeterSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                JsonMCE_METER entity = JsonConvert.DeserializeObject<JsonMCE_METER>(rsb.ToString());


                if (string.IsNullOrEmpty(entity.CODE))
                {
                    throw new Exception("参数错误,单号不能为空.");
                }


                if (string.IsNullOrEmpty(entity.ASSETS_ID))
                {
                    throw new Exception("参数错误,设备名称不能为空.");
                }

                if (string.IsNullOrEmpty(entity.HEAD_USER_ID))
                {
                    throw new Exception("参数错误,计量负责人不能为空.");
                }

                if (string.IsNullOrEmpty(entity.IDENTIFICATION_CYCLE))
                {
                    throw new Exception("参数错误,计量周期不能为空.");
                }

                if (string.IsNullOrEmpty(entity.NEXT_IDENTIFICATION))
                {
                    throw new Exception("参数错误,下次待检日期不能为空.");
                }


                if (string.IsNullOrEmpty(entity.METER_TYPE))
                {
                    throw new Exception("参数错误,计量分类不能为空.");
                }

                BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_METER.Proxy.Save_Ext2(entity);


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