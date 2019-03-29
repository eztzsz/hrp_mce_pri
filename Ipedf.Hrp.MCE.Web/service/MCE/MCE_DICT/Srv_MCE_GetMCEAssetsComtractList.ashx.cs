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


namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEAssetsComtractList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsComtractList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                OrderByParameter orderBy = new OrderByParameter();
                orderBy.Asc = true;
                orderBy.OrderBy = "CODE";

                StringBuilder strCondition = new StringBuilder();
                CauseObject_MCE_B_ASSETS_CONTRACT p = new CauseObject_MCE_B_ASSETS_CONTRACT();

                p.ASSETS_ID = request["id"];

                if (!string.IsNullOrEmpty(request["condition"]))//
                {
                    strCondition.Append(" and (MCE_B_ASSETS_CONTRACT.CODE like '%" + request["condition"].ToString().Trim() + "%' or MDM_D_DEPT_SECOND_PARTY.NAME like '%" + request["condition"].ToString().Trim() + "%'  or COM_DEPART_FIRST_PARTY.NAME like '%" + request["condition"].ToString().Trim() + "%'  or COM_TYPE_TYPE_ID.NAME like '%" + request["condition"].ToString().Trim() + "%'  )");
                }



                if (!string.IsNullOrEmpty(strCondition.ToString()))
                {
                    p.SetCustomCondition(strCondition.ToString());
                }

                DisplayObject_MCE_B_ASSETS_CONTRACT[] list = BizLogicObject_MCE_B_ASSETS_CONTRACT.Proxy.Query(p, null, orderBy);


                if (list != null && list.Length > 0)
                {
                    foreach (DisplayObject_MCE_B_ASSETS_CONTRACT item in list)
                    {
                        string strFiles = "";
                        CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                        pCOM_FILE.REF_TAB_ID = item.ID;
                        pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";

                        DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                        if (listCOM_FILE != null && listCOM_FILE.Length > 0)
                        {
                            foreach (DisplayObject_COM_FILE file in listCOM_FILE)
                            {
                                if (!string.IsNullOrEmpty(file.SERVER_NAME))
                                {
                                    strFiles = strFiles + file.SERVER_NAME + "/" + file.CLIENT_NAME + ",";
                                }
                            }
                            strFiles = strFiles.TrimEnd(',');
                        }
                        item.BACKUP1 = strFiles;
                    }
                }


                jsonMsg.Message = list;
                jsonMsg.Succeed = 1;

            }
            catch (Exception ex)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = ex.Message;
            }
            finally
            {
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd" };

                string strMsg = JsonConvert.SerializeObject(jsonMsg, Formatting.Indented, timeConverter);
                strMsg = strMsg.Replace("0001-01-01", "");
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