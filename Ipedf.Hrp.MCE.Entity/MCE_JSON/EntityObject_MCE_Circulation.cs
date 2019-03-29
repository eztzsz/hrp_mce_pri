using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{
    public class JsonMceCirculation_Info//流转信息
    {
        public JsonMceCirculation_AOG AOG_Info { get; set; }
        public JsonMceCirculation_Instock Instock_Info { get; set; }
        public JsonMceCirculation_Outstock Outstock_Info { get; set; }
        public JsonMceCirculation_Back Back_Info { get; set; }
        public JsonMceCirculation_Return Return_Info { get; set; }
        public JsonMceCirculation_Transfer Transfer_Info { get; set; }
    }

    public class JsonMceCirculation_AOG//验收
    {
        public string id { get; set; }
        public string code { get; set; }
        public string purcharse_person { get; set; }
        public DateTime create_date { get; set; }
        public DateTime purcharse_date { get; set; }
        public string use_dept_id { get; set; }
        public string use_dept_name { get; set; }
        public string use_user_id { get; set; }
        public string use_user_name { get; set; }
        public string provider_id { get; set; }
        public string provider_name { get; set; }
        public string invoice_code { get; set; }
        public string purcharse_ht_num { get; set; }
    }



    public class JsonMceCirculation_Instock//入库
    {
        public string id { get; set; }
        public string code { get; set; }
        public string user_id { get; set; }//入库人
        public string user_name { get; set; }//入库人        
        public DateTime create_date { get; set; }//入库日期
        public string invoice_code { get; set; }//发票号
        public string warehouse_id { get; set; }//入库仓库
        public string warehouse_name { get; set; }//入库仓库
        public string provider_id { get; set; }//供应商
        public string provider_name { get; set; }//供应商
    }



    public class JsonMceCirculation_Outstock//出库
    {
        public string id { get; set; }
        public string code { get; set; }
        public string using_user_id { get; set; }//领用人
        public string using_user_name { get; set; }//领用人        
        public string create_user_id { get; set; }//出库人
        public string create_user_name { get; set; }//出库人        
        public DateTime create_date { get; set; }//出库日期
        public string stock_id { get; set; }//出库仓库
        public string stock_name { get; set; }//出库仓库
        public string using_dept_id { get; set; }//领用科室
        public string using_dept_name { get; set; }//领用科室
    }


    public class JsonMceCirculation_Back//退库
    {
        public string id { get; set; }
        public string code { get; set; }
        public string return_dept_id { get; set; }//退库科室
        public string return_dept_name { get; set; }//退库科室
        public DateTime create_date { get; set; }//退库日期
        public string return_user_id { get; set; }//退库人
        public string return_user_name{ get; set; }//退库人
    }


    public class JsonMceCirculation_Return//退货
    {
        public string id { get; set; }
        public string code { get; set; }
        public string user_id { get; set; }//退货人
        public string user_name { get; set; }//退货人
        public DateTime create_date { get; set; }//退货日期
        public string provider_id { get; set; }//供货商
        public string provider_name { get; set; }//供货商
        public string stock_id { get; set; }//退货仓库
        public string stock_name { get; set; }//退货仓库
    }


    public class JsonMceCirculation_Transfer//调拨
    {
        public string id { get; set; }
        public string code { get; set; }
        public string create_user_id { get; set; }//调拨人
        public string create_user_name { get; set; }//调拨人
        public DateTime create_date { get; set; }//调拨日期
        public string transfer_user_id { get; set; }//调出人
        public string transfer_user_name { get; set; }//调出人
        public string transfer_dept_id { get; set; }//调出科室
        public string transfer_dept_name { get; set; }//调出科室
        public string user_id { get; set; }//领用人
        public string user_name { get; set; }//领用人
        public string dept_id { get; set; }//领用科室
        public string dept_name { get; set; }//领用科室

    }



    public class JsonMCE_AOG
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string USE_DEPT_ID { get; set; }
        public string PROVIDER_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string USE_USER_ID { get; set; }
        public string PURCHARSE_PERSON { get; set; }
        public string PURCHARSE_HT_NUM { get; set; }
        public string COMMENTS { get; set; }
        public string INVOICE_CODE { get; set; }
        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }
          
        public List<JsonMCE_AOG_D> children { get; set; }
    }


    public class JsonMCE_AOG_D
    {
        public string ID { get; set; }
        public string ASSET_ID { get; set; }
        public string ASSET_TYPE_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string SPEC { get; set; }
        public string PRD_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public string MONEY { get; set; }
        public string UNIT_ID { get; set; }
        public string COUNTRY { get; set; }
        public string REG_CODE { get; set; }

        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }
    }





    public class JsonMCE_INSTOCK
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string WAREHOUSE_ID { get; set; }
        
        public string PROVIDER_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string USER_ID { get; set; }

        public string COMMENTS { get; set; }
        public string INVOICE_CODE { get; set; }
        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_INSTOCK_D> children { get; set; }
    }


    public class JsonMCE_INSTOCK_D
    {
        public string ID { get; set; }
        public string USING_DEPT_ID { get; set; }
        public string ASSET_ID { get; set; }
        
        public string ASSET_TYPE_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string SPEC { get; set; }
        public string PRD_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public string MONEY { get; set; }
        public string UNIT_ID { get; set; }
        public string COUNTRY { get; set; }
        public string DEPR_YEAR_AMOUNT { get; set; }
        public string DEPR_TYPE_ID { get; set; }

        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }
    }



    public class JsonMCE_OUTSTOCK
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string WAREHOUSE_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string USING_DEPT_ID { get; set; }
        public string USING_USER_ID { get; set; }

        public string COMMENTS { get; set; }

        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_OUTSTOCK_D> children { get; set; }
    }


    public class JsonMCE_OUTSTOCK_D
    {
        public string ID { get; set; }
        public string ASSET_TYPE_ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string PRD_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public string MONEY { get; set; }
        public string UNIT_ID { get; set; }
        public string COUNTRY { get; set; }
        public string USE_DATE { get; set; }
        public string ECONOMIC_USE_TYPE_ID { get; set; }
        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }

    }





    public class JsonMCE_TRANSFER
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string TRANSFER_DEPT_ID { get; set; }
        public string TRANSFER_USER_ID { get; set; }
        public string DEPT_ID { get; set; }
        public string USER_ID { get; set; }

        public string CREATE_DATE { get; set; }

        public string COMMENTS { get; set; }

        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_TRANSFER_D> children { get; set; }
    }


    public class JsonMCE_TRANSFER_D
    {
        public string ID { get; set; }    
        public string ASSETS_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string COMMENTS { get; set; }
    }



    public class JsonMCE_BACK
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string RETURN_DEPT_ID { get; set; }
        public string RETURN_USER_ID { get; set; }
        public string DEPT_ID { get; set; }
        public string USER_ID { get; set; }
        public string STOCK_ID { get; set; }

        
        public string CREATE_DATE { get; set; }

        public string COMMENTS { get; set; }

        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_BACK_D> children { get; set; }
    }


    public class JsonMCE_BACK_D
    {
        public string ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }
        public string COMMENTS { get; set; }
    }




    public class JsonMCE_SALESRETURN
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string PROVIDER_ID { get; set; }
        public string USER_ID { get; set; }
        public string STOCK_ID { get; set; }

        public decimal TOTAL_MONEY { get; set; }

        public string CREATE_DATE { get; set; }

        public string COMMENTS { get; set; }

        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_SALESRETURN_D> children { get; set; }
    }


    public class JsonMCE_SALESRETURN_D
    {
        public string ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string ASSETS_CODE { get; set; }

        public decimal AMOUNT { get; set; }
        public decimal MONEY { get; set; }
        public decimal PRICE { get; set; }
        public string PRD_DATE { get; set; }
        public string PRD_ID { get; set; }
    

        public string SPEC { get; set; }
        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }
        public string COMMENTS { get; set; }
    }



    public class JsonMCE_PURCHASE
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string APPLY_DEPT_ID { get; set; }
        public string APPLY_USER_ID { get; set; }
        public decimal APPLY_AMOUNT { get; set; }
        public decimal APPLY_MONEY { get; set; }
        public decimal APPLY_PRICE { get; set; }
        public string TYPE_ID { get; set; }
        public string ASSET_ID { get; set; }
        public string ASSET_NAME { get; set; }
        public string SPEC { get; set; }

        public string CURRENCY_ID { get; set; }
        public string UNIT_ID { get; set; }
        public string UNIT_ID_NAME { get; set; }

        public string PRD_ID { get; set; }
        public string PRD_ID_NAME { get; set; }
        public string PRV_ID { get; set; }
        public string PRV_ID_NAME { get; set; }

        public string PURCHASE_TYPE_ID { get; set; }
        public string COMMENTS { get; set; }


        public int STATE { get; set; }

    }



    public class JsonMCE_PURCHASE_PLAN
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string APPLY_DEPT_ID { get; set; }
        public string PRV_ID { get; set; }
        public string PRV_NAME { get; set; }
        public string APPLY_USER_ID { get; set; }
        public string PURCHASE_DEPT_ID { get; set; }
        public decimal APPLY_MONEY { get; set; }

        public string CREATE_DATE { get; set; }

        public string COMMENTS { get; set; }
     
        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_PURCHASE_PLAN_D> children { get; set; }
    }


    public class JsonMCE_PURCHASE_PLAN_D
    {
        public string ID { get; set; }
        public string TYPE_ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSET_NAME { get; set; }
      
        public decimal AMOUNT { get; set; }
        public decimal MONEY { get; set; }
        public decimal PRICE { get; set; }
        public string PRD_NAME { get; set; }
        public string PRD_ID { get; set; }
        public string UNIT_ID { get; set; }

        public string SPEC { get; set; }
        public string REF_TAB_ID { get; set; }
        public string REF_TAB_NAME { get; set; }
        public string COMMENTS { get; set; }

                  
    }

}
