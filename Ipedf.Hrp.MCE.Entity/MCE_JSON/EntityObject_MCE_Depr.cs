using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{



    public class JsonMCE_Depr
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string DEPT_ID { get; set; }
        public string USER_ID { get; set; }
        public string FINANCE_CYCLE { get; set; }
        public string CREATE_DATE { get; set; }
        public string COMMENTS { get; set; }
        public int STATE { get; set; }
 
        public List<JsonMceDepr_D> children { get; set; }
    }

    public class JsonMceDepr_D
    {
        public string ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_NAME { get; set; }
        public string ASSETS_CODE { get; set; }
        public string CURRENCY_ID { get; set; }
        public string CURRENCY_ID_NAME { get; set; }
        public decimal ORIGINAL_VALUE { get; set; }
        public decimal NET_VALUE { get; set; }
        public decimal MONEY { get; set; }
        public decimal NEW_NET_VALUE { get; set; }

       
    }
}
