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
	[DataObject("MCE_B_ASSETS_MT_PLAN")]
	public partial class CauseObject_MCE_B_ASSETS_MT_PLAN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal _PLAN_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PLAN_STATE{get{ return  _PLAN_STATE;}set{ _PLAN_STATE = value;}}
		System.String _MTN_COMPANY_ID = string.Empty;
		[DataMember]
		public System.String  MTN_COMPANY_ID{get{ return  _MTN_COMPANY_ID;}set{ _MTN_COMPANY_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _MTN_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  MTN_TYPE_ID{get{ return  _MTN_TYPE_ID;}set{ _MTN_TYPE_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal _EXECUTE_PERIOD = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTE_PERIOD{get{ return  _EXECUTE_PERIOD;}set{ _EXECUTE_PERIOD = value;}}
		System.Decimal _EXECUTE_PERIOD_UNIT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EXECUTE_PERIOD_UNIT{get{ return  _EXECUTE_PERIOD_UNIT;}set{ _EXECUTE_PERIOD_UNIT = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_PLAN")]
	public partial class DisplayObject_MCE_B_ASSETS_MT_PLAN:EntityObject_MCE_B_ASSETS_MT_PLAN
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _PLAN_STATE_NAME = string.Empty;
		[DataMember]
		public System.String PLAN_STATE_NAME{get{ return  _PLAN_STATE_NAME;}set{ _PLAN_STATE_NAME = value;}}
		 System.String _MTN_COMPANY_ID_NAME = string.Empty;
		[DataMember]
		public System.String MTN_COMPANY_ID_NAME{get{ return  _MTN_COMPANY_ID_NAME;}set{ _MTN_COMPANY_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _MTN_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String MTN_TYPE_ID_NAME{get{ return  _MTN_TYPE_ID_NAME;}set{ _MTN_TYPE_ID_NAME = value;}}
		 System.String _EXECUTE_PERIOD_UNIT_NAME = string.Empty;
		[DataMember]
		public System.String EXECUTE_PERIOD_UNIT_NAME{get{ return  _EXECUTE_PERIOD_UNIT_NAME;}set{ _EXECUTE_PERIOD_UNIT_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_PLAN")]
	public partial class EntityObject_MCE_B_ASSETS_MT_PLAN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal  _PLAN_STATE;
		[DataMember]
		public System.Decimal  PLAN_STATE{get{ return  _PLAN_STATE;}set{ _PLAN_STATE = value;}}
		System.String  _MTN_COMPANY_ID;
		[DataMember]
		public System.String  MTN_COMPANY_ID{get{ return  _MTN_COMPANY_ID;}set{ _MTN_COMPANY_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _MTN_TYPE_ID;
		[DataMember]
		public System.String  MTN_TYPE_ID{get{ return  _MTN_TYPE_ID;}set{ _MTN_TYPE_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal  _EXECUTE_PERIOD;
		[DataMember]
		public System.Decimal  EXECUTE_PERIOD{get{ return  _EXECUTE_PERIOD;}set{ _EXECUTE_PERIOD = value;}}
		System.Decimal  _EXECUTE_PERIOD_UNIT;
		[DataMember]
		public System.Decimal  EXECUTE_PERIOD_UNIT{get{ return  _EXECUTE_PERIOD_UNIT;}set{ _EXECUTE_PERIOD_UNIT = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}

		#endregion 
	}	
}
