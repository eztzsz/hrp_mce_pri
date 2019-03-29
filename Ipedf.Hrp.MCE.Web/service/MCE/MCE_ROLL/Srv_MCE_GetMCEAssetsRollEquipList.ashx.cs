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
    /// Srv_MCE_GetMCEAssetsRollEquipList 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsRollEquipList : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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


                if (string.IsNullOrEmpty(request["rollid"]))
                {
                    throw new Exception("参数错误.");
                }

                if (string.IsNullOrEmpty(request["assetsid"]))
                {
                    throw new Exception("参数错误.");
                }

                StringBuilder strCondition = new StringBuilder();
                CauseObject_V_MCE_ASSETS_ROLLEQUIP p = new CauseObject_V_MCE_ASSETS_ROLLEQUIP();

                p.ROLL_ID = request["rollid"];


                p.SetCustomCondition(" and V_MCE_ASSETS_ROLLEQUIP.Assets_Id<>'" + request["assetsid"] + "'");
                

                DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] list = BizLogicObject_V_MCE_ASSETS_ROLLEQUIP.Proxy.Query(p);

                if (list!=null && list.Length>0)
                {
                    for (int i=0;i<list.Length;i++)
                    {
                        if(!string.IsNullOrEmpty(list[i].PICTURE))
                        {
                            list[i].PICTURE = "../../upload/mce/" + list[i].PICTURE;
                        }
                        else
                        {
                            list[i].PICTURE = "../../images/icon/imgDefault.png";
                        }
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