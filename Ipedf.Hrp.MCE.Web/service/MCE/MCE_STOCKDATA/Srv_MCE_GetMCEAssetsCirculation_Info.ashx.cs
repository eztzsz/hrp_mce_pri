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
    /// Srv_MCE_GetMCEAssetsCirculation_Info 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEAssetsCirculation_Info : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                string strID = request["id"];

                   EntityObject_MCE_B_ASSETS entAssets = BizLogicObject_MCE_B_ASSETS.Proxy.Get(new EntityObject_MCE_B_ASSETS() { ID =strID });
                   if (entAssets == null)
                   {
                       throw new Exception("数据错误.");
                   }

                JsonMceCirculation_Info jsonMceCirculation_Info = new JsonMceCirculation_Info();
                jsonMceCirculation_Info.AOG_Info = new JsonMceCirculation_AOG();
                jsonMceCirculation_Info.Instock_Info = new JsonMceCirculation_Instock();
                jsonMceCirculation_Info.Outstock_Info = new JsonMceCirculation_Outstock();
                jsonMceCirculation_Info.Back_Info = new JsonMceCirculation_Back();
                jsonMceCirculation_Info.Return_Info = new JsonMceCirculation_Return();
                jsonMceCirculation_Info.Transfer_Info = new JsonMceCirculation_Transfer();


                CauseObject_MCE_B_AOG p_AOG = new CauseObject_MCE_B_AOG();
                p_AOG.SetCustomCondition(" and MCE_B_AOG.ID in(select base_id from MCE_B_AOG_D where id=(select ref_tab_id from MCE_B_ASSETS_INSTOCK_D where ref_tab_name='MCE_B_AOG_D' and id='" + entAssets.REF_TAB_ID + "'))");

                DisplayObject_MCE_B_AOG[] listAOG = BizLogicObject_MCE_B_AOG.Proxy.Query(p_AOG);
                if (listAOG != null && listAOG.Length>0)
                {
                  
                    jsonMceCirculation_Info.AOG_Info.id = listAOG[0].ID;
                    jsonMceCirculation_Info.AOG_Info.code = listAOG[0].CODE;
                    jsonMceCirculation_Info.AOG_Info.purcharse_person = listAOG[0].PURCHARSE_PERSON;
                    jsonMceCirculation_Info.AOG_Info.create_date = listAOG[0].CREATE_DATE;
                  //  jsonMceCirculation_Info.AOG_Info.purcharse_date = listAOG[0].pu;
                    jsonMceCirculation_Info.AOG_Info.use_dept_id = listAOG[0].USE_DEPT_ID;
                    jsonMceCirculation_Info.AOG_Info.use_dept_name = listAOG[0].USE_DEPT_ID_NAME;
                    jsonMceCirculation_Info.AOG_Info.use_user_id = listAOG[0].USE_USER_ID;
                    jsonMceCirculation_Info.AOG_Info.use_user_name = listAOG[0].INSTALL_USER_ID_NAME;
                    jsonMceCirculation_Info.AOG_Info.provider_id = listAOG[0].PROVIDER_ID_NAME;
                    jsonMceCirculation_Info.AOG_Info.provider_name = listAOG[0].PROVIDER_ID_NAME;
                    jsonMceCirculation_Info.AOG_Info.invoice_code = listAOG[0].INVOICE_CODE;
                    jsonMceCirculation_Info.AOG_Info.purcharse_ht_num = listAOG[0].PURCHARSE_HT_NUM;
                }


                CauseObject_MCE_B_ASSETS_INSTOCK p_INSTOCK = new CauseObject_MCE_B_ASSETS_INSTOCK();
                p_INSTOCK.SetCustomCondition(" and MCE_B_ASSETS_INSTOCK.ID in(select base_id from MCE_B_ASSETS_INSTOCK_D where id='" + entAssets.REF_TAB_ID + "')");

                DisplayObject_MCE_B_ASSETS_INSTOCK[] listINSTOCK = BizLogicObject_MCE_B_ASSETS_INSTOCK.Proxy.Query(p_INSTOCK);
                if (listINSTOCK != null && listINSTOCK.Length > 0)
                {
                
                    jsonMceCirculation_Info.Instock_Info.id = listINSTOCK[0].ID;
                    jsonMceCirculation_Info.Instock_Info.code = listINSTOCK[0].CODE;

                    jsonMceCirculation_Info.Instock_Info.user_id = listINSTOCK[0].USER_ID;
                    jsonMceCirculation_Info.Instock_Info.user_name = listINSTOCK[0].USER_ID_NAME;
                    jsonMceCirculation_Info.Instock_Info.create_date = listINSTOCK[0].CREATE_DATE;
                    jsonMceCirculation_Info.Instock_Info.invoice_code = listINSTOCK[0].INVOICE_CODE;
                    jsonMceCirculation_Info.Instock_Info.warehouse_id = listINSTOCK[0].WAREHOUSE_ID;
                    jsonMceCirculation_Info.Instock_Info.warehouse_name = listINSTOCK[0].WAREHOUSE_ID_NAME;
                    jsonMceCirculation_Info.Instock_Info.provider_id = listINSTOCK[0].PROVIDER_ID;
                    jsonMceCirculation_Info.Instock_Info.provider_name = listINSTOCK[0].PROVIDER_ID_NAME;
                }


                CauseObject_MCE_B_ASSETS_OUTSTOCK p_OUTSTOCK = new CauseObject_MCE_B_ASSETS_OUTSTOCK();
                p_OUTSTOCK.SetCustomCondition(" and MCE_B_ASSETS_OUTSTOCK.ID in(select base_id from MCE_B_ASSETS_OUTSTOCK_D where ref_tab_name='MCE_B_ASSETS_INSTOCK_D' and ref_tab_id='" + entAssets.REF_TAB_ID + "')");

                DisplayObject_MCE_B_ASSETS_OUTSTOCK[] listOUTSTOCK = BizLogicObject_MCE_B_ASSETS_OUTSTOCK.Proxy.Query(p_OUTSTOCK);
                if (listOUTSTOCK != null && listOUTSTOCK.Length > 0)
                {

                    jsonMceCirculation_Info.Outstock_Info.id = listOUTSTOCK[0].ID;
                    jsonMceCirculation_Info.Outstock_Info.code = listOUTSTOCK[0].CODE;

                    jsonMceCirculation_Info.Outstock_Info.using_user_id = listOUTSTOCK[0].USING_USER_ID;
                    jsonMceCirculation_Info.Outstock_Info.using_user_name = listOUTSTOCK[0].USING_USER_ID_NAME;
                    jsonMceCirculation_Info.Outstock_Info.create_user_id = listOUTSTOCK[0].CREATE_USER_ID;
                    jsonMceCirculation_Info.Outstock_Info.create_user_name = listOUTSTOCK[0].CREATE_USER_ID_NAME;
                    jsonMceCirculation_Info.Outstock_Info.create_date = listOUTSTOCK[0].CREATE_DATE;
                    jsonMceCirculation_Info.Outstock_Info.stock_id = listOUTSTOCK[0].STOCK_ID;
                    jsonMceCirculation_Info.Outstock_Info.stock_name = listOUTSTOCK[0].STOCK_ID_NAME;
                    jsonMceCirculation_Info.Outstock_Info.using_dept_id = listOUTSTOCK[0].USING_DEPT_ID;
                    jsonMceCirculation_Info.Outstock_Info.using_dept_name = listOUTSTOCK[0].USING_DEPT_ID_NAME;
                }



                CauseObject_MCE_B_ASSETS_BACK p_BACK = new CauseObject_MCE_B_ASSETS_BACK();
                p_BACK.SetCustomCondition(" and MCE_B_ASSETS_BACK.ID in(select base_id from MCE_B_ASSETS_BACK_D where assets_id='" + strID + "')");

                DisplayObject_MCE_B_ASSETS_BACK[] listBACK = BizLogicObject_MCE_B_ASSETS_BACK.Proxy.Query(p_BACK);
                if (listBACK != null && listBACK.Length > 0)
                {

                    jsonMceCirculation_Info.Back_Info.id = listBACK[0].ID;
                    jsonMceCirculation_Info.Back_Info.code = listBACK[0].CODE;

                    jsonMceCirculation_Info.Back_Info.return_dept_id = listBACK[0].RETURN_DEPT_ID;
                    jsonMceCirculation_Info.Back_Info.return_dept_name = listBACK[0].RETURN_DEPT_ID_NAME;
                    jsonMceCirculation_Info.Back_Info.create_date = listBACK[0].CREATE_DATE;
                    jsonMceCirculation_Info.Back_Info.return_user_id = listBACK[0].RETURN_USER_ID;
                    jsonMceCirculation_Info.Back_Info.return_user_name = listBACK[0].RETURN_USER_ID_NAME;     
                }



                CauseObject_MCE_B_SALES_RETURN p_RETURN = new CauseObject_MCE_B_SALES_RETURN();
                p_RETURN.SetCustomCondition(" and MCE_B_SALES_RETURN.ID in(select base_id from MCE_B_SALES_RETURN_D where assets_id='" + strID + "')");

                DisplayObject_MCE_B_SALES_RETURN[] listRETURN = BizLogicObject_MCE_B_SALES_RETURN.Proxy.Query(p_RETURN);
                if (listRETURN != null && listRETURN.Length > 0)
                {
                   
                    jsonMceCirculation_Info.Return_Info.id = listRETURN[0].ID;
                    jsonMceCirculation_Info.Return_Info.code = listRETURN[0].CODE;

                    jsonMceCirculation_Info.Return_Info.user_id = listRETURN[0].USER_ID;
                    jsonMceCirculation_Info.Return_Info.user_name = listRETURN[0].USER_ID_NAME;
                    jsonMceCirculation_Info.Return_Info.create_date = listRETURN[0].CREATE_DATE;
                    jsonMceCirculation_Info.Return_Info.provider_id = listRETURN[0].PROVIDER_ID;
                    jsonMceCirculation_Info.Return_Info.provider_name = listRETURN[0].PROVIDER_ID_NAME;
                    jsonMceCirculation_Info.Return_Info.stock_id = listRETURN[0].STOCK_ID;
                    jsonMceCirculation_Info.Return_Info.stock_name = listRETURN[0].STOCK_ID_NAME;
                }



                CauseObject_MCE_B_ASSETS_TRANSFER p_TRANSFER = new CauseObject_MCE_B_ASSETS_TRANSFER();
                p_TRANSFER.SetCustomCondition(" and MCE_B_ASSETS_TRANSFER.ID in(select base_id from MCE_B_ASSETS_TRANSFER_D where assets_id='" + strID + "')");


                OrderByParameter orderByTransfer = new OrderByParameter();
                orderByTransfer.Asc = false;
                orderByTransfer.OrderBy = "CREATE_DATE";

                DisplayObject_MCE_B_ASSETS_TRANSFER[] listTRANSFER = BizLogicObject_MCE_B_ASSETS_TRANSFER.Proxy.Query(p_TRANSFER, null, orderByTransfer);
                if (listTRANSFER != null && listTRANSFER.Length > 0)
                {
                    
                    jsonMceCirculation_Info.Transfer_Info.id = listTRANSFER[0].ID;
                    jsonMceCirculation_Info.Transfer_Info.code = listTRANSFER[0].CODE;

                    jsonMceCirculation_Info.Transfer_Info.create_user_id = listTRANSFER[0].CREATE_USER_ID;
                    jsonMceCirculation_Info.Transfer_Info.create_user_name = listTRANSFER[0].CREATE_USER_ID_NAME;
                    jsonMceCirculation_Info.Transfer_Info.create_date = listTRANSFER[0].CREATE_DATE;
                    jsonMceCirculation_Info.Transfer_Info.transfer_user_id = listTRANSFER[0].TRANSFER_USER_ID;
                    jsonMceCirculation_Info.Transfer_Info.transfer_user_name = listTRANSFER[0].TRANSFER_USER_ID_NAME;
                    jsonMceCirculation_Info.Transfer_Info.transfer_dept_id = listTRANSFER[0].TRANSFER_DEPT_ID;
                    jsonMceCirculation_Info.Transfer_Info.transfer_dept_name = listTRANSFER[0].TRANSFER_DEPT_ID_NAME;
                    jsonMceCirculation_Info.Transfer_Info.user_id = listTRANSFER[0].USER_ID;
                    jsonMceCirculation_Info.Transfer_Info.user_name = listTRANSFER[0].USER_ID_NAME;
                    jsonMceCirculation_Info.Transfer_Info.dept_id = listTRANSFER[0].DEPT_ID;
                    jsonMceCirculation_Info.Transfer_Info.dept_name = listTRANSFER[0].DEPT_ID_NAME;
  
                }


                jsonMsg.Succeed = 1;
                jsonMsg.Message = jsonMceCirculation_Info;
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