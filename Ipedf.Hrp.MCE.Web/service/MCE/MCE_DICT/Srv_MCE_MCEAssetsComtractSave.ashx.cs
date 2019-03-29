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
    /// Srv_MCE_MCEAssetsComtractSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEAssetsComtractSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                JsonMceAssetsContract item = JsonConvert.DeserializeObject<JsonMceAssetsContract>(rsb.ToString());

                /*
                if (string.IsNullOrEmpty(item.code))
                {
                    throw new Exception("合同编号不能为空.");
                }
                */
                if (string.IsNullOrEmpty(item.name))
                {
                    throw new Exception("合同名称不能为空.");
                }

                /*
                CauseObject_MCE_B_ASSETS_CONTRACT p = new CauseObject_MCE_B_ASSETS_CONTRACT();
                p.CODE = item.code;
            

                if (!string.IsNullOrEmpty(item.id))
                {
                    string strCondition = " and MCE_B_ASSETS_CONTRACT.ID<>'" + item.id + "'";
                   p.SetCustomCondition(strCondition);
                }

            
                DisplayObject_MCE_B_ASSETS_CONTRACT[] list = BizLogicObject_MCE_B_ASSETS_CONTRACT.Proxy.Query(p);
                if (list != null && list.Length > 0)
                {
                    throw new Exception("合同编号:[" + item.code + "]已经在用.");
                }
                */


                BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_CONTRACT.Proxy.Save_Ext(item);
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