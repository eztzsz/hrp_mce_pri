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
    /// Srv_MCE_MCEDeprTypeSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEDeprTypeSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                EntityObject_MCE_D_DEPR_TYPE item = JsonConvert.DeserializeObject<EntityObject_MCE_D_DEPR_TYPE>(rsb.ToString());

                if (string.IsNullOrEmpty(item.CODE) || string.IsNullOrEmpty(item.NAME))
                {
                    throw new Exception("编码、名称不能为空.");
                }


                CauseObject_MCE_D_DEPR_TYPE p = new CauseObject_MCE_D_DEPR_TYPE();
                p.CODE = item.CODE;
            
                string strCondition = "";
                if (!string.IsNullOrEmpty(item.ID))
                {
                    strCondition = strCondition + " and MCE_D_DEPR_TYPE.ID<>'" + item.ID + "'";
                    p.SetCustomCondition(strCondition);
                }


                DisplayObject_MCE_D_DEPR_TYPE[] list = BizLogicObject_MCE_D_DEPR_TYPE.Proxy.Query(p);
                if (list != null && list.Length > 0)
                {
                    throw new Exception("编码:[" + item.CODE + "]已经存在.");
                }

                BizLogicMsg msg = BizLogicObject_MCE_D_DEPR_TYPE.Proxy.Save_Ext(item);
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