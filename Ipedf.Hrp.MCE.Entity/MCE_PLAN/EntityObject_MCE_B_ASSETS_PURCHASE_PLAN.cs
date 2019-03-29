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
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN")]
	public partial class CauseObject_MCE_B_ASSETS_PURCHASE_PLAN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PURCHASE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  PURCHASE_DEPT_ID{get{ return  _PURCHASE_DEPT_ID;}set{ _PURCHASE_DEPT_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String _PRV_ID = string.Empty;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.String _PRV_NAME = string.Empty;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _APPLY_COMMENTS = string.Empty;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _APPLY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String _REF_PRV_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN")]
	public partial class DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN:EntityObject_MCE_B_ASSETS_PURCHASE_PLAN
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _PURCHASE_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String PURCHASE_DEPT_ID_NAME{get{ return  _PURCHASE_DEPT_ID_NAME;}set{ _PURCHASE_DEPT_ID_NAME = value;}}
		 System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _APPLY_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_DEPT_ID_NAME{get{ return  _APPLY_DEPT_ID_NAME;}set{ _APPLY_DEPT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN")]
	public partial class EntityObject_MCE_B_ASSETS_PURCHASE_PLAN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PURCHASE_DEPT_ID;
		[DataMember]
		public System.String  PURCHASE_DEPT_ID{get{ return  _PURCHASE_DEPT_ID;}set{ _PURCHASE_DEPT_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String  _PRV_ID;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.String  _PRV_NAME;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _APPLY_COMMENTS;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _APPLY_DEPT_ID;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.String  _REF_PRV_ID;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}

		#endregion 
	}	
}
