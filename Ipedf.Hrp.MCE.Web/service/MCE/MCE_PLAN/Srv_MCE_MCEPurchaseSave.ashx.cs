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
    /// Srv_MCE_MCEPurchaseSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEPurchaseSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                JsonMCE_PURCHASE json = JsonConvert.DeserializeObject<JsonMCE_PURCHASE>(rsb.ToString());


                if (string.IsNullOrEmpty(json.CODE))
                {
                    throw new Exception("参数错误,单号不能为空.");
                }

                if (json.APPLY_AMOUNT <= 0)
                {
                    throw new Exception("参数错误,请输入正确的申购数量.");
                }

                if (json.APPLY_MONEY <= 0)
                {
                    throw new Exception("参数错误,请输入正确预算金额.");
                }

                EntityObject_MCE_B_ASSETS_PURCHASE entity = new EntityObject_MCE_B_ASSETS_PURCHASE();
                entity.ID = json.ID;

                if (!string.IsNullOrEmpty(entity.ID))
                {

                    entity = BizLogicObject_MCE_B_ASSETS_PURCHASE.Proxy.Get(entity);

                    if (entity == null)
                    {
                        throw new Exception("获取数据出错.");
                    }
                }

             

                entity.CODE = json.CODE;
           
                entity.APPLY_AMOUNT = json.APPLY_AMOUNT;
                entity.APPLY_MONEY = json.APPLY_MONEY;
                entity.APPLY_PRICE = json.APPLY_PRICE;
                entity.TYPE_ID = json.TYPE_ID;
                entity.ASSET_ID = json.ASSET_ID;
                entity.ASSET_NAME = json.ASSET_NAME;
                entity.SPEC = json.SPEC;
                entity.CURRENCY_ID = json.CURRENCY_ID;
                entity.UNIT_ID = json.UNIT_ID;
                entity.UNIT_NAME = json.UNIT_ID_NAME;
              
       

                if (string.IsNullOrEmpty(json.ID))
                {
                    if (!string.IsNullOrEmpty(json.PRD_ID))
                    {
                        string strPrdID = "";
                        CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                        p.REF_ID = json.PRD_ID;

                        DisplayObject_MDM_D_DEPT[] listPrd = BizLogicObject_MDM_D_DEPT.Proxy.Query(p);
                        if (listPrd != null && listPrd.Length > 0)
                        {
                            strPrdID = listPrd[0].ID;
                        }

                        entity.PRD_ID = strPrdID;
                    }

                    entity.REF_PRD_ID = json.PRD_ID;

                    if (!string.IsNullOrEmpty(json.PRV_ID))
                    {
                        string strPrvID = "";

                        CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                        p.REF_ID = json.PRV_ID;

                        DisplayObject_MDM_D_DEPT[] listPrv = BizLogicObject_MDM_D_DEPT.Proxy.Query(p);
                        if (listPrv != null && listPrv.Length > 0)
                        {
                            strPrvID = listPrv[0].ID;
                        }

                        entity.PRV_ID = strPrvID;
                    }

                    entity.REF_PRV_ID = json.PRV_ID;
                }

                entity.PRD_NAME = json.PRD_ID_NAME;
                entity.PRV_NAME = json.PRV_ID_NAME;

                entity.PURCHASE_TYPE_ID = json.PURCHASE_TYPE_ID;
                entity.COMMENTS = json.COMMENTS;

                entity.STATE = 1;
                entity.ID = json.ID;
                entity.ID = json.ID;

                BizLogicMsg msg = new BizLogicMsg();

                if (string.IsNullOrEmpty(entity.ID))
                {
                    entity.APPLY_DEPT_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                    entity.APPLY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                    entity.CREATE_DEPT_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                    entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                    entity.CREATE_DATE = entity.CREATE_TIME = DateTime.Now;

                    msg = BizLogicObject_MCE_B_ASSETS_PURCHASE.Proxy.Save(entity);
                }
                else
                {        
                    entity.MODIFY_DEPT_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                    entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                    entity.MODIFY_TIME = DateTime.Now;

                    msg = BizLogicObject_MCE_B_ASSETS_PURCHASE.Proxy.Update(entity);
                }

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