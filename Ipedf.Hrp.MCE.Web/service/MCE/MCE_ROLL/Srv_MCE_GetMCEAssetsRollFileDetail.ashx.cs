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


namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEAssetsRollFileDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsRollFileDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                CauseObject_MCE_B_ASSETS_ROLLFILE p = new CauseObject_MCE_B_ASSETS_ROLLFILE();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_ROLLFILE[] listHead = BizLogicObject_MCE_B_ASSETS_ROLLFILE.Proxy.Query(p);


                if (listHead == null || listHead.Length == 0)
                    throw new Exception("获取列表信息失败.");

                string strFiles = "";
                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                pCOM_FILE.REF_TAB_ID = listHead[0].ID;
                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_ROLLFILE";

                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                if (listCOM_FILE != null && listCOM_FILE.Length > 0)
                {
                    strFiles = listCOM_FILE[0].SERVER_NAME;
                }
                listHead[0].BACKUP1 = strFiles;

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