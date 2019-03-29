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
	[DataObject("MCE_B_ASSETS_WRITE_OFF")]
	public partial class CauseObject_MCE_B_ASSETS_WRITE_OFF:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _IDENTITY_USER_ID = string.Empty;
		[DataMember]
		public System.String  IDENTITY_USER_ID{get{ return  _IDENTITY_USER_ID;}set{ _IDENTITY_USER_ID = value;}}
		System.String _IDENTITY_PARAM = string.Empty;
		[DataMember]
		public System.String  IDENTITY_PARAM{get{ return  _IDENTITY_PARAM;}set{ _IDENTITY_PARAM = value;}}
		System.Decimal _NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String _WRITE_OFF_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  WRITE_OFF_TYPE_ID{get{ return  _WRITE_OFF_TYPE_ID;}set{ _WRITE_OFF_TYPE_ID = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _FINANCE_CYCLE = string.Empty;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		DateSpan _IDENTITY_TIME = null;
		[DataMember]
		public DateSpan  IDENTITY_TIME{get{ return  _IDENTITY_TIME;}set{ _IDENTITY_TIME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal _ORIGINAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.Decimal _IDENTITY_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IDENTITY_STATE{get{ return  _IDENTITY_STATE;}set{ _IDENTITY_STATE = value;}}
		System.Decimal _RUDIMENTAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE{get{ return  _RUDIMENTAL_VALUE;}set{ _RUDIMENTAL_VALUE = value;}}
		System.String _INCOME = string.Empty;
		[DataMember]
		public System.String  INCOME{get{ return  _INCOME;}set{ _INCOME = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _WRITE_OFF_CAUSE_ID = string.Empty;
		[DataMember]
		public System.String  WRITE_OFF_CAUSE_ID{get{ return  _WRITE_OFF_CAUSE_ID;}set{ _WRITE_OFF_CAUSE_ID = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String _SUMARRY = string.Empty;
		[DataMember]
		public System.String  SUMARRY{get{ return  _SUMARRY;}set{ _SUMARRY = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _USAGE = string.Empty;
		[DataMember]
		public System.String  USAGE{get{ return  _USAGE;}set{ _USAGE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_WRITE_OFF")]
	public partial class DisplayObject_MCE_B_ASSETS_WRITE_OFF:EntityObject_MCE_B_ASSETS_WRITE_OFF
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _IDENTITY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String IDENTITY_USER_ID_NAME{get{ return  _IDENTITY_USER_ID_NAME;}set{ _IDENTITY_USER_ID_NAME = value;}}
		 System.String _WRITE_OFF_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String WRITE_OFF_TYPE_ID_NAME{get{ return  _WRITE_OFF_TYPE_ID_NAME;}set{ _WRITE_OFF_TYPE_ID_NAME = value;}}
		 System.String _IDENTITY_STATE_NAME = string.Empty;
		[DataMember]
		public System.String IDENTITY_STATE_NAME{get{ return  _IDENTITY_STATE_NAME;}set{ _IDENTITY_STATE_NAME = value;}}
		 System.String _DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_ID_NAME{get{ return  _DEPT_ID_NAME;}set{ _DEPT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _WRITE_OFF_CAUSE_ID_NAME = string.Empty;
		[DataMember]
		public System.String WRITE_OFF_CAUSE_ID_NAME{get{ return  _WRITE_OFF_CAUSE_ID_NAME;}set{ _WRITE_OFF_CAUSE_ID_NAME = value;}}
		 System.String _AUDIT_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_USER_ID_NAME{get{ return  _AUDIT_USER_ID_NAME;}set{ _AUDIT_USER_ID_NAME = value;}}
		 System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_WRITE_OFF")]
	public partial class EntityObject_MCE_B_ASSETS_WRITE_OFF:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _IDENTITY_USER_ID;
		[DataMember]
		public System.String  IDENTITY_USER_ID{get{ return  _IDENTITY_USER_ID;}set{ _IDENTITY_USER_ID = value;}}
		System.String  _IDENTITY_PARAM;
		[DataMember]
		public System.String  IDENTITY_PARAM{get{ return  _IDENTITY_PARAM;}set{ _IDENTITY_PARAM = value;}}
		System.Decimal  _NET_VALUE;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String  _WRITE_OFF_TYPE_ID;
		[DataMember]
		public System.String  WRITE_OFF_TYPE_ID{get{ return  _WRITE_OFF_TYPE_ID;}set{ _WRITE_OFF_TYPE_ID = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _FINANCE_CYCLE;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.DateTime  _IDENTITY_TIME;
		[DataMember]
		public System.DateTime  IDENTITY_TIME{get{ return  _IDENTITY_TIME;}set{ _IDENTITY_TIME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.Decimal  _ORIGINAL_VALUE;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.Decimal  _IDENTITY_STATE;
		[DataMember]
		public System.Decimal  IDENTITY_STATE{get{ return  _IDENTITY_STATE;}set{ _IDENTITY_STATE = value;}}
		System.Decimal  _RUDIMENTAL_VALUE;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE{get{ return  _RUDIMENTAL_VALUE;}set{ _RUDIMENTAL_VALUE = value;}}
		System.String  _INCOME;
		[DataMember]
		public System.String  INCOME{get{ return  _INCOME;}set{ _INCOME = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _WRITE_OFF_CAUSE_ID;
		[DataMember]
		public System.String  WRITE_OFF_CAUSE_ID{get{ return  _WRITE_OFF_CAUSE_ID;}set{ _WRITE_OFF_CAUSE_ID = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String  _SUMARRY;
		[DataMember]
		public System.String  SUMARRY{get{ return  _SUMARRY;}set{ _SUMARRY = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _USAGE;
		[DataMember]
		public System.String  USAGE{get{ return  _USAGE;}set{ _USAGE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}

		#endregion 
	}	
}
