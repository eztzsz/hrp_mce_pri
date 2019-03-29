using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{
    public  class JsonMCE_Contract
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string SIGN_DATE { get; set; }
        public string EXPIRE_DATE { get; set; }
        public string TYPE_ID { get; set; }
        public string FIRST_PARTY { get; set; }

        public string SECOND_PARTY { get; set; }
        public string SECOND_LINK_PERSON { get; set; }
        public string SECOND_LINK_PHONE { get; set; }
        public string MONEY { get; set; }
        public string ARCHIVE_NO { get; set; }
        public string CHECK_DATE { get; set; }
        public string ARCHIVIST { get; set; }
        public string INPUT_PERSON { get; set; }
        public string CONTRACT_CONTENT { get; set; }
      
        public int STATE { get; set; }

        public List<JsonMCE_Contract_D> children { get; set; }
        public List<JsonMCE_Contract_Pay> listPay { get; set; }

        public List<JsonMCEMT_APPLY_MTN_ATTACH> listAttach { get; set; }
    }


    public class JsonMCE_Contract_D
    {
        public string ID { get; set; }
        public string ASSET_ID { get; set; }
    }


    public class JsonMCE_Contract_Pay
    {
        public string ID { get; set; }
        public int PERIODS { get; set; }
        public string MONEY { get; set; }
        public string PLAN_PAY_DATE { get; set; }
    }

    public class JSON_PAGER_Contract
    {

        public object head { get; set; }
        public object rows { get; set; }
        public object attach { get; set; }
        public object payRows { get; set; }
        public int total { get; set; }
    }



}
