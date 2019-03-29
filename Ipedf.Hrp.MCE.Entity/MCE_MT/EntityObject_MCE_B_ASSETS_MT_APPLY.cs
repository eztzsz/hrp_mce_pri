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
	[DataObject("MCE_B_ASSETS_MT_APPLY")]
	public partial class CauseObject_MCE_B_ASSETS_MT_APPLY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _FAULT_ANALYSIS = string.Empty;
		[DataMember]
		public System.String  FAULT_ANALYSIS{get{ return  _FAULT_ANALYSIS;}set{ _FAULT_ANALYSIS = value;}}
		System.String _INVOICE_CODE = string.Empty;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MTN_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  MTN_TYPE_ID{get{ return  _MTN_TYPE_ID;}set{ _MTN_TYPE_ID = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _DOWN_DESC = string.Empty;
		[DataMember]
		public System.String  DOWN_DESC{get{ return  _DOWN_DESC;}set{ _DOWN_DESC = value;}}
		System.String _APPLY_USER_PHONE = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_PHONE{get{ return  _APPLY_USER_PHONE;}set{ _APPLY_USER_PHONE = value;}}
		DateSpan _COMPLETE_TIME = null;
		[DataMember]
		public DateSpan  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.Decimal _MAINTAIN_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String _APPLY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String _USING_USER_ID = string.Empty;
		[DataMember]
		public System.String  USING_USER_ID{get{ return  _USING_USER_ID;}set{ _USING_USER_ID = value;}}
		System.String _USING_DEPT_COMMENTS = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_COMMENTS{get{ return  _USING_DEPT_COMMENTS;}set{ _USING_DEPT_COMMENTS = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _FAULT_SOLUTION = string.Empty;
		[DataMember]
		public System.String  FAULT_SOLUTION{get{ return  _FAULT_SOLUTION;}set{ _FAULT_SOLUTION = value;}}
		System.String _MTN_ENGINEER = string.Empty;
		[DataMember]
		public System.String  MTN_ENGINEER{get{ return  _MTN_ENGINEER;}set{ _MTN_ENGINEER = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _APPLY_COMMENTS = string.Empty;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		System.String _REPAIR_RESULT = string.Empty;
		[DataMember]
		public System.String  REPAIR_RESULT{get{ return  _REPAIR_RESULT;}set{ _REPAIR_RESULT = value;}}
		System.Decimal _MTN_TOTAL_HOURS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MTN_TOTAL_HOURS{get{ return  _MTN_TOTAL_HOURS;}set{ _MTN_TOTAL_HOURS = value;}}
		System.String _ASSETS_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_TYPE_ID{get{ return  _ASSETS_TYPE_ID;}set{ _ASSETS_TYPE_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		DateSpan _APPLY_TIME = null;
		[DataMember]
		public DateSpan  APPLY_TIME{get{ return  _APPLY_TIME;}set{ _APPLY_TIME = value;}}
		DateSpan _MAINTENANCE_PERIOD_DATE = null;
		[DataMember]
		public DateSpan  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _MAINTAIN_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MAINTAIN_DEPT_ID{get{ return  _MAINTAIN_DEPT_ID;}set{ _MAINTAIN_DEPT_ID = value;}}
		System.String _FAULT_DESC = string.Empty;
		[DataMember]
		public System.String  FAULT_DESC{get{ return  _FAULT_DESC;}set{ _FAULT_DESC = value;}}
		System.String _IS_CLOSE = string.Empty;
		[DataMember]
		public System.String  IS_CLOSE{get{ return  _IS_CLOSE;}set{ _IS_CLOSE = value;}}
		System.String _EMERGENCY_DEGREE = string.Empty;
		[DataMember]
		public System.String  EMERGENCY_DEGREE{get{ return  _EMERGENCY_DEGREE;}set{ _EMERGENCY_DEGREE = value;}}
		System.String _USING_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String _FAULT_TYPE = string.Empty;
		[DataMember]
		public System.String  FAULT_TYPE{get{ return  _FAULT_TYPE;}set{ _FAULT_TYPE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		DateSpan _DOWN_TIME = null;
		[DataMember]
		public DateSpan  DOWN_TIME{get{ return  _DOWN_TIME;}set{ _DOWN_TIME = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_APPLY")]
	public partial class DisplayObject_MCE_B_ASSETS_MT_APPLY:EntityObject_MCE_B_ASSETS_MT_APPLY
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _MTN_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String MTN_TYPE_ID_NAME{get{ return  _MTN_TYPE_ID_NAME;}set{ _MTN_TYPE_ID_NAME = value;}}
		 System.String _APPLY_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_DEPT_ID_NAME{get{ return  _APPLY_DEPT_ID_NAME;}set{ _APPLY_DEPT_ID_NAME = value;}}
		 System.String _USING_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_USER_ID_NAME{get{ return  _USING_USER_ID_NAME;}set{ _USING_USER_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _REPAIR_RESULT_NAME = string.Empty;
		[DataMember]
		public System.String REPAIR_RESULT_NAME{get{ return  _REPAIR_RESULT_NAME;}set{ _REPAIR_RESULT_NAME = value;}}
		 System.String _ASSETS_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_TYPE_ID_NAME{get{ return  _ASSETS_TYPE_ID_NAME;}set{ _ASSETS_TYPE_ID_NAME = value;}}
		 System.String _EMERGENCY_DEGREE_NAME = string.Empty;
		[DataMember]
		public System.String EMERGENCY_DEGREE_NAME{get{ return  _EMERGENCY_DEGREE_NAME;}set{ _EMERGENCY_DEGREE_NAME = value;}}
		 System.String _USING_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}
		 System.String _FAULT_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String FAULT_TYPE_NAME{get{ return  _FAULT_TYPE_NAME;}set{ _FAULT_TYPE_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_APPLY")]
	public partial class EntityObject_MCE_B_ASSETS_MT_APPLY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _FAULT_ANALYSIS;
		[DataMember]
		public System.String  FAULT_ANALYSIS{get{ return  _FAULT_ANALYSIS;}set{ _FAULT_ANALYSIS = value;}}
		System.String  _INVOICE_CODE;
		[DataMember]
		public System.String  INVOICE_CODE{get{ return  _INVOICE_CODE;}set{ _INVOICE_CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MTN_TYPE_ID;
		[DataMember]
		public System.String  MTN_TYPE_ID{get{ return  _MTN_TYPE_ID;}set{ _MTN_TYPE_ID = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _DOWN_DESC;
		[DataMember]
		public System.String  DOWN_DESC{get{ return  _DOWN_DESC;}set{ _DOWN_DESC = value;}}
		System.String  _APPLY_USER_PHONE;
		[DataMember]
		public System.String  APPLY_USER_PHONE{get{ return  _APPLY_USER_PHONE;}set{ _APPLY_USER_PHONE = value;}}
		System.DateTime  _COMPLETE_TIME;
		[DataMember]
		public System.DateTime  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.Decimal  _MAINTAIN_MONEY;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String  _APPLY_DEPT_ID;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String  _USING_USER_ID;
		[DataMember]
		public System.String  USING_USER_ID{get{ return  _USING_USER_ID;}set{ _USING_USER_ID = value;}}
		System.String  _USING_DEPT_COMMENTS;
		[DataMember]
		public System.String  USING_DEPT_COMMENTS{get{ return  _USING_DEPT_COMMENTS;}set{ _USING_DEPT_COMMENTS = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _FAULT_SOLUTION;
		[DataMember]
		public System.String  FAULT_SOLUTION{get{ return  _FAULT_SOLUTION;}set{ _FAULT_SOLUTION = value;}}
		System.String  _MTN_ENGINEER;
		[DataMember]
		public System.String  MTN_ENGINEER{get{ return  _MTN_ENGINEER;}set{ _MTN_ENGINEER = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _APPLY_COMMENTS;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		System.String  _REPAIR_RESULT;
		[DataMember]
		public System.String  REPAIR_RESULT{get{ return  _REPAIR_RESULT;}set{ _REPAIR_RESULT = value;}}
		System.Decimal  _MTN_TOTAL_HOURS;
		[DataMember]
		public System.Decimal  MTN_TOTAL_HOURS{get{ return  _MTN_TOTAL_HOURS;}set{ _MTN_TOTAL_HOURS = value;}}
		System.String  _ASSETS_TYPE_ID;
		[DataMember]
		public System.String  ASSETS_TYPE_ID{get{ return  _ASSETS_TYPE_ID;}set{ _ASSETS_TYPE_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.DateTime  _APPLY_TIME;
		[DataMember]
		public System.DateTime  APPLY_TIME{get{ return  _APPLY_TIME;}set{ _APPLY_TIME = value;}}
		System.DateTime  _MAINTENANCE_PERIOD_DATE;
		[DataMember]
		public System.DateTime  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _MAINTAIN_DEPT_ID;
		[DataMember]
		public System.String  MAINTAIN_DEPT_ID{get{ return  _MAINTAIN_DEPT_ID;}set{ _MAINTAIN_DEPT_ID = value;}}
		System.String  _FAULT_DESC;
		[DataMember]
		public System.String  FAULT_DESC{get{ return  _FAULT_DESC;}set{ _FAULT_DESC = value;}}
		System.String  _IS_CLOSE;
		[DataMember]
		public System.String  IS_CLOSE{get{ return  _IS_CLOSE;}set{ _IS_CLOSE = value;}}
		System.String  _EMERGENCY_DEGREE;
		[DataMember]
		public System.String  EMERGENCY_DEGREE{get{ return  _EMERGENCY_DEGREE;}set{ _EMERGENCY_DEGREE = value;}}
		System.String  _USING_DEPT_ID;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String  _FAULT_TYPE;
		[DataMember]
		public System.String  FAULT_TYPE{get{ return  _FAULT_TYPE;}set{ _FAULT_TYPE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.DateTime  _DOWN_TIME;
		[DataMember]
		public System.DateTime  DOWN_TIME{get{ return  _DOWN_TIME;}set{ _DOWN_TIME = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
