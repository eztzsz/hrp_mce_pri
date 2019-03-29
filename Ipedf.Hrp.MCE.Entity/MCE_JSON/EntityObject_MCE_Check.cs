using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{



    public class JsonMCE_Check
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string DEPT_ID { get; set; }
        public string USER_ID { get; set; }
        public string CHECK_TYPE_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string COMMENTS { get; set; }
        public int STATE { get; set; }

        public List<JsonMCE_Check_D> children { get; set; }
    }

    public class JsonMCE_Check_D
    {
        public string ID { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string USING_DEPT_ID { get; set; }
        public string OLD_ASSETS_STATE { get; set; }
        public string NEW_ASSETS_STATE { get; set; }
     
    }



    public class JsonMCE_Asser_Check
    {
        public List<string> idList { get; set; }
        public string State { get; set; }
        public string Reason { get; set; }
     

    }

}
