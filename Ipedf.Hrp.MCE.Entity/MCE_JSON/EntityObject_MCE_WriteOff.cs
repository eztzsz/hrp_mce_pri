using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ipedf.Web.Entity
{

    public class JsonMCE_Write_Off
    {
        public string ID { get; set; }
        public string CODE { get; set; }
        public string DEPT_ID { get; set; }
        public string USER_ID { get; set; }
        public string FINANCE_CYCLE { get; set; }
        public string WRITE_OFF_TYPE_ID { get; set; }
        public string WRITE_OFF_CAUSE_ID { get; set; }
        public string INCOME { get; set; }
        public string USAGE { get; set; }

        public string CREATE_DATE { get; set; }
        public string COMMENTS { get; set; }
        public int STATE { get; set; }
   //     public List<string> DELETEIDS { get; set; }
        public List<JsonMCE_Write_Off_D> children { get; set; }

        public List<JsonMCE_Write_Off__ATTACH> listAttach { get; set; }
    }

    public class JsonMCE_Write_Off_D
    {
        public string ID { get; set; }
        public string ASSET_ID { get; set; }
    }


    public class JsonMCE_Write_Off__ATTACH
    {
        public string ID { get; set; }
        public string FILE_NAME { get; set; }
        public string SAVENAME { get; set; }
        public string USER_ID { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }


    public class JSON_PAGER_Write_Off
    {
    
        public object head { get; set; }
        public object rows { get; set; }
        public object attach { get; set; }
        public int total { get; set; }
    }


    public class JsonWriteOffFile
    {
      
        public string fileId { get; set; }
        public string fileName { get; set; }
        public string fileUrl { get; set; }
        public string saveName { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public DateTime createdate { get; set; }
    }


    //报废鉴定
    public class JsonWriteOffIdentity
    {

        public string ID { get; set; }
        public string IDENTITY_USER_ID { get; set; }
        public string IDENTITY_PARAM { get; set; }
        public string IDENTITY_STATE { get; set; }

        public string IDENTITY_TIME { get; set; }

    }



    //报废审核
    public class JsonWriteOffAudit
    {

        public string ID { get; set; }
        public string AUDIT_USER_ID { get; set; }
        public string SUMARRY { get; set; }
        public string AUDIT_STATE { get; set; }

        public string AUDIT_TIME { get; set; }

    }

}
