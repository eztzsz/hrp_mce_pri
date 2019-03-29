using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{

    public class JsonMCE_METER
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string ASSETS_ID { get; set; }
        public string ASSETS_CODE { get; set; }
        public string SPEC { get; set; }
        public string PRD_ID { get; set; }
        public string UNIT_ID { get; set; }

        public string USING_DEPT_ID { get; set; }
        public string PRD_CODE { get; set; }
        public string IDENTIFICATION_CYCLE { get; set; }
        public string METER_TYPE { get; set; }
        public string HEAD_USER_ID { get; set; }

        public string IDENTIFICATION_TYPE { get; set; }
        public string IS_FORCE_SENSE { get; set; }
        public string NEXT_IDENTIFICATION { get; set; }
        public string EARLY_WARNING_DAYS { get; set; }
        public string COMMENTS { get; set; }

        public int STATE { get; set; }

    }




    public class JsonMCE_Meter_Check
    {
        public string ID { get; set; }

        public string ACTUAL_IDENTIFICATION { get; set; }
        public string RESULT_ID { get; set; }
        public string CERTIFICATE_CODE { get; set; }
        public string MONEY { get; set; }
        public string CHECK_PERSON { get; set; }

       
        public string COMMENTS { get; set; }

        public List<JsonMCEMT_APPLY_MTN_ATTACH> listAttach { get; set; }
    }




    [Serializable]
    public class JSON_PAGER_Meter
    {

        public object head { get; set; }
        public int total { get; set; }
        public object attach { get; set; }

    }


}
