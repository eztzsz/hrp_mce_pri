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
    /// Srv_MCE_MCETypeSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCETypeSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                //  string strID = request["id"].ToString();


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

                JsonMceType jsonMceType = JsonConvert.DeserializeObject<JsonMceType>(rsb.ToString());

                if (string.IsNullOrEmpty(jsonMceType.parent_id) ||string.IsNullOrEmpty(jsonMceType.code) || string.IsNullOrEmpty(jsonMceType.name)|| jsonMceType.state<=0)
                {
                    throw new Exception("父类、类型编码、类型名称、状态不能为空.");
                }


                CauseObject_MCE_D_MCE_TYPE p = new CauseObject_MCE_D_MCE_TYPE();
                p.CODE = jsonMceType.code;
             

                string strCondition = "";
                if (!string.IsNullOrEmpty(jsonMceType.id))
                {
                    strCondition = strCondition + " and MCE_D_MCE_TYPE.ID<>'" + jsonMceType.id + "'";
                    p.SetCustomCondition(strCondition);
                }


                DisplayObject_MCE_D_MCE_TYPE[] list = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Query(p);
                if (list != null && list.Length > 0)
                {
                    throw new Exception("分类编码:[" + jsonMceType.code + "]已经存在.");
                }

                BizLogicMsg msg = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Save_Ext(jsonMceType);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);

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