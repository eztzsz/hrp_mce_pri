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
    /// Srv_MCE_GetMCEMTNExecDetail 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEMTNExecDetail : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            JSON_MSG jsonMsg = new JSON_MSG();
            try
            {
                context.Response.ContentType = "text/plain";
                HttpRequest request = context.Request;

                CauseObject_MCE_B_ASSETS_MT_EXEC p = new CauseObject_MCE_B_ASSETS_MT_EXEC();
                p.ID = request["id"].ToString();

                DisplayObject_MCE_B_ASSETS_MT_EXEC[] listHead = BizLogicObject_MCE_B_ASSETS_MT_EXEC.Proxy.Query(p);


                JSON_PAGER_MT_EXEC jsonPager = new JSON_PAGER_MT_EXEC();
                if (listHead == null)
                    throw new Exception("获取列表信息失败.");


                if(listHead[0].STATE<=1 && listHead[0].ACTUAL_EXEC_DATE<DateTime.Now.AddYears(-100))
                {
                    listHead[0].ACTUAL_EXEC_DATE=DateTime.Now;
                }

                jsonPager.head = listHead[0];


                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "ASSETS_NAME";


                CauseObject_MCE_B_ASSETS_MT_EXEC_D pd = new CauseObject_MCE_B_ASSETS_MT_EXEC_D();
                pd.BASE_ID = request["id"].ToString();


                DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] listDetail = BizLogicObject_MCE_B_ASSETS_MT_EXEC_D.Proxy.Query(pd, null, orderBy);




                OrderByParameter orderByAttach = new OrderByParameter();
                orderByAttach.Asc = false;
                orderByAttach.OrderBy = "CREATE_TIME";

                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                pCOM_FILE.REF_TAB_ID = request["id"];
                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_MT_EXEC";

                List<JsonMCEMT_APPLY_MTN_ATTACH> list = new List<JsonMCEMT_APPLY_MTN_ATTACH>();

                DisplayObject_COM_FILE[] listAttach = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE, null, orderByAttach);
                if (listAttach != null && listAttach.Length > 0)
                {
                    foreach (DisplayObject_COM_FILE item in listAttach)
                    {
                        JsonMCEMT_APPLY_MTN_ATTACH attach = new JsonMCEMT_APPLY_MTN_ATTACH();
                        attach.ID = item.ID;
                        attach.CLIENT_NAME = item.CLIENT_NAME;
                        attach.SERVER_NAME = item.SERVER_NAME;
                        attach.CREATE_USER_ID = item.CREATE_USER_ID;

                        if (!string.IsNullOrEmpty(attach.CREATE_USER_ID))
                        {
                            EntityObject_COM_USER entity = new EntityObject_COM_USER();

                            entity.ID = attach.CREATE_USER_ID;

                            entity = BizLogicObject_COM_USER.Proxy.Get(entity);

                            if (entity != null)
                            {
                                attach.CREATE_USER_ID_NAME = entity.NAME;
                            }
                        }
                        attach.CREATE_TIME = item.CREATE_TIME;
                        list.Add(attach);

                    }
                }
                jsonPager.attach = list;


                jsonPager.total = listDetail.Length;
                jsonPager.rows = listDetail;

                jsonMsg.Succeed = 1;
                jsonMsg.Message = jsonPager;
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