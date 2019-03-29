using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.Entity
{
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_AOG")]
	public partial class CauseObject_MCE_B_AOG:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _USE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USE_DEPT_ID{get{ return  _USE_DEPT_ID;}set{ _USE_DEPT_ID = value;}}
		System.String _INVOICE_CODE = string.Empty;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _USE_USER_ID = string.Empty;
		[DataMember]
		public System.String  USE_USER_ID{get{ return  _USE_USER_ID;}set{ _USE_USER_ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _IS_INSTOCK = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_INSTOCK{get{ return  _IS_INSTOCK;}set{ _IS_INSTOCK = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _PROVIDER_ID = string.Empty;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _PURCHARSE_HT_NUM = string.Empty;
		[DataMember]
		public System.String  PURCHARSE_HT_NUM{get{ return  _PURCHARSE_HT_NUM;}set{ _PURCHARSE_HT_NUM = value;}}
		System.String _INSTALL_USER_ID = string.Empty;
		[DataMember]
		public System.String  INSTALL_USER_ID{get{ return  _INSTALL_USER_ID;}set{ _INSTALL_USER_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _PURCHARSE_PERSON = string.Empty;
		[DataMember]
		public System.String  PURCHARSE_PERSON{get{ return  _PURCHARSE_PERSON;}set{ _PURCHARSE_PERSON = value;}}
		System.String _DEALER_ID = string.Empty;
		[DataMember]
		public System.String  DEALER_ID{get{ return  _DEALER_ID;}set{ _DEALER_ID = value;}}
		System.String _PURCHARSE_PERSON_ID = string.Empty;
		[DataMember]
		public System.String  PURCHARSE_PERSON_ID{get{ return  _PURCHARSE_PERSON_ID;}set{ _PURCHARSE_PERSON_ID = value;}}
		System.Decimal _TOTAL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_AOG")]
	public partial class DisplayObject_MCE_B_AOG:EntityObject_MCE_B_AOG
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _USE_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String USE_DEPT_ID_NAME{get{ return  _USE_DEPT_ID_NAME;}set{ _USE_DEPT_ID_NAME = value;}}
		 System.String _USE_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USE_USER_ID_NAME{get{ return  _USE_USER_ID_NAME;}set{ _USE_USER_ID_NAME = value;}}
		 System.String _IS_INSTOCK_NAME = string.Empty;
		[DataMember]
		public System.String IS_INSTOCK_NAME{get{ return  _IS_INSTOCK_NAME;}set{ _IS_INSTOCK_NAME = value;}}
		 System.String _PROVIDER_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROVIDER_ID_NAME{get{ return  _PROVIDER_ID_NAME;}set{ _PROVIDER_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _INSTALL_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String INSTALL_USER_ID_NAME{get{ return  _INSTALL_USER_ID_NAME;}set{ _INSTALL_USER_ID_NAME = value;}}
		 System.String _DEALER_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEALER_ID_NAME{get{ return  _DEALER_ID_NAME;}set{ _DEALER_ID_NAME = value;}}
		 System.String _PURCHARSE_PERSON_ID_NAME = string.Empty;
		[DataMember]
		public System.String PURCHARSE_PERSON_ID_NAME{get{ return  _PURCHARSE_PERSON_ID_NAME;}set{ _PURCHARSE_PERSON_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_AOG")]
	public partial class EntityObject_MCE_B_AOG:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _USE_DEPT_ID;
		[DataMember]
		public System.String  USE_DEPT_ID{get{ return  _USE_DEPT_ID;}set{ _USE_DEPT_ID = value;}}
		System.String  _INVOICE_CODE;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _USE_USER_ID;
		[DataMember]
		public System.String  USE_USER_ID{get{ return  _USE_USER_ID;}set{ _USE_USER_ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _IS_INSTOCK;
		[DataMember]
		public System.Decimal  IS_INSTOCK{get{ return  _IS_INSTOCK;}set{ _IS_INSTOCK = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _PROVIDER_ID;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _PURCHARSE_HT_NUM;
		[DataMember]
		public System.String  PURCHARSE_HT_NUM{get{ return  _PURCHARSE_HT_NUM;}set{ _PURCHARSE_HT_NUM = value;}}
		System.String  _INSTALL_USER_ID;
		[DataMember]
		public System.String  INSTALL_USER_ID{get{ return  _INSTALL_USER_ID;}set{ _INSTALL_USER_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _PURCHARSE_PERSON;
		[DataMember]
		public System.String  PURCHARSE_PERSON{get{ return  _PURCHARSE_PERSON;}set{ _PURCHARSE_PERSON = value;}}
		System.String  _DEALER_ID;
		[DataMember]
		public System.String  DEALER_ID{get{ return  _DEALER_ID;}set{ _DEALER_ID = value;}}
		System.String  _PURCHARSE_PERSON_ID;
		[DataMember]
		public System.String  PURCHARSE_PERSON_ID{get{ return  _PURCHARSE_PERSON_ID;}set{ _PURCHARSE_PERSON_ID = value;}}
		System.Decimal  _TOTAL_MONEY;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}

		#endregion 
	}	
}
