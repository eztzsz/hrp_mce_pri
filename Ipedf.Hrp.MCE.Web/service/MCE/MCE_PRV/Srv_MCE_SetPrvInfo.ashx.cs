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
    /// Srv_MCE_SetPrvInfo 的摘要说明
    /// </summary>
    public class Srv_MCE_SetPrvInfo : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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
                List<string> idList = JsonConvert.DeserializeObject<List<string>>(rsb.ToString());


                foreach (string strID in idList)
                {

                    CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                    p.REF_ID = strID;
                    p.AUDIT_STATE = "COM_1002_01";
                    DisplayObject_MDM_D_DEPT[] listExist = BizLogicObject_MDM_D_DEPT.Proxy.Query(p);
                    if (listExist != null && listExist.Length > 0)
                    {
                        throw new Exception("供应商" + listExist[0].NAME + "已经审核.");
                    }
                }



                BizLogicMsg msg = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Save_Dept_Ext(idList);
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