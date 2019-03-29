using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{

    public class JsonMCE_MT_APPLY
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string APPLY_DEPT_ID { get; set; }
        public string APPLY_USER_ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string ASSETS_TYPE_ID { get; set; }
        public string PRD_ID { get; set; }
        public string MTN_TYPE_ID { get; set; }
        public string FAULT_TYPE { get; set; }
        public string EMERGENCY_DEGREE { get; set; }
        public string REPAIR_RESULT { get; set; }
        public string CREATE_DATE { get; set; }
        public string APPLY_USER_PHONE { get; set; }
        public string COMPLETE_TIME { get; set; }
        public string MTN_ENGINEER { get; set; }
        public string MTN_TOTAL_HOURS { get; set; }
        public string MAINTAIN_MONEY { get; set; }
        public string INVOICE_CODE { get; set; }
        public string FAULT_DESC { get; set; }
        public string FAULT_ANALYSIS { get; set; }
        public string FAULT_SOLUTION { get; set; }
    
 
        public int STATE { get; set; }

        public List<JsonMCEMT_APPLY_MTN_ATTACH> listAttach { get; set; }
    }


    public class JsonMCEMT_APPLY_MTN_ATTACH
    {
        public string ID { get; set; }
        public string CLIENT_NAME { get; set; }
        public string SERVER_NAME { get; set; }
        public string CREATE_USER_ID { get; set; }
        public string CREATE_USER_ID_NAME { get; set; }
        public DateTime CREATE_TIME { get; set; }
    }


    [Serializable]
    public class JSON_PAGER_APPLY_MTN_ATTACH
    {

        public object head { get; set; }
        public object attach { get; set; }

    }




    public class JsonMCE_MT_PLAN
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string MTN_TYPE_ID { get; set; }
        public string MTN_COMPANY_ID { get; set; }
        public string EXECUTE_PERIOD { get; set; }
        public string EXECUTE_PERIOD_UNIT { get; set; }
        public string APPLY_USER_ID { get; set; }
        public string CREATE_DATE { get; set; }

        public string COMMENTS { get; set; }

        public int PLAN_STATE { get; set; }
        public int STATE { get; set; }
        public List<string> DELETEIDS { get; set; }

        public List<JsonMCE_MT_PLAN_D> children { get; set; }
    }


    public class JsonMCE_MT_PLAN_D
    {
        public string ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSET_CODE { get; set; }
        public string SPEC { get; set; }
        public string DEPT_ID { get; set; }
        public string ITEM_ID { get; set; }
        public string SEQ_NUMBER { get; set; }
        public string COMMENTS { get; set; }


    }




    public class JsonMCE_MT_EXEC
    {
        public string ID { get; set; }
    
        public string ACTUAL_EXEC_DATE { get; set; }

        public string COMMENTS { get; set; }

        public List<JsonMCE_MT_EXEC_D> children { get; set; }
        public List<JsonMCEMT_APPLY_MTN_ATTACH> listAttach { get; set; }
    }


    public class JsonMCE_MT_EXEC_D
    {
        public string ID { get; set; }
        public string RESULT_ID { get; set; }
        public string MONEY { get; set; }
     
        public string COMMENTS { get; set; }


    }



    [Serializable]
    public class JSON_PAGER_MT_EXEC
    {

        public object head { get; set; }
        public object rows { get; set; }
        public int total { get; set; }
        public object attach { get; set; }

    }

}
