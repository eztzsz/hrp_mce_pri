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
	[DataObject("V_MCE_ASSETS_ROLL")]
	public partial class CauseObject_V_MCE_ASSETS_ROLL:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _CREATE_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID_NAME{get{ return  _CREATE_USER_ID_NAME;}set{ _CREATE_USER_ID_NAME = value;}}
		System.String _PLAN_TYPE = string.Empty;
		[DataMember]
		public System.String  PLAN_TYPE{get{ return  _PLAN_TYPE;}set{ _PLAN_TYPE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String  AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _SAVELIMIT_NAME = string.Empty;
		[DataMember]
		public System.String  SAVELIMIT_NAME{get{ return  _SAVELIMIT_NAME;}set{ _SAVELIMIT_NAME = value;}}
		System.String _ROLL_TYPE = string.Empty;
		[DataMember]
		public System.String  ROLL_TYPE{get{ return  _ROLL_TYPE;}set{ _ROLL_TYPE = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String _SAVELIMIT = string.Empty;
		[DataMember]
		public System.String  SAVELIMIT{get{ return  _SAVELIMIT;}set{ _SAVELIMIT = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _ROLL_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  ROLL_TYPE_NAME{get{ return  _ROLL_TYPE_NAME;}set{ _ROLL_TYPE_NAME = value;}}
		System.String _ROLL_PROPERTY_NAME = string.Empty;
		[DataMember]
		public System.String  ROLL_PROPERTY_NAME{get{ return  _ROLL_PROPERTY_NAME;}set{ _ROLL_PROPERTY_NAME = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _ROLL_PROPERTY = string.Empty;
		[DataMember]
		public System.String  ROLL_PROPERTY{get{ return  _ROLL_PROPERTY;}set{ _ROLL_PROPERTY = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.String _PLAN_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  PLAN_TYPE_NAME{get{ return  _PLAN_TYPE_NAME;}set{ _PLAN_TYPE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_ROLL")]
	public partial class DisplayObject_V_MCE_ASSETS_ROLL:EntityObject_V_MCE_ASSETS_ROLL
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_ROLL")]
	public partial class EntityObject_V_MCE_ASSETS_ROLL:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _CREATE_USER_ID_NAME;
		[DataMember]
		public System.String  CREATE_USER_ID_NAME{get{ return  _CREATE_USER_ID_NAME;}set{ _CREATE_USER_ID_NAME = value;}}
		System.String  _PLAN_TYPE;
		[DataMember]
		public System.String  PLAN_TYPE{get{ return  _PLAN_TYPE;}set{ _PLAN_TYPE = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _AUDIT_STATE_NAME;
		[DataMember]
		public System.String  AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _SAVELIMIT_NAME;
		[DataMember]
		public System.String  SAVELIMIT_NAME{get{ return  _SAVELIMIT_NAME;}set{ _SAVELIMIT_NAME = value;}}
		System.String  _ROLL_TYPE;
		[DataMember]
		public System.String  ROLL_TYPE{get{ return  _ROLL_TYPE;}set{ _ROLL_TYPE = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String  _SAVELIMIT;
		[DataMember]
		public System.String  SAVELIMIT{get{ return  _SAVELIMIT;}set{ _SAVELIMIT = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _ROLL_TYPE_NAME;
		[DataMember]
		public System.String  ROLL_TYPE_NAME{get{ return  _ROLL_TYPE_NAME;}set{ _ROLL_TYPE_NAME = value;}}
		System.String  _ROLL_PROPERTY_NAME;
		[DataMember]
		public System.String  ROLL_PROPERTY_NAME{get{ return  _ROLL_PROPERTY_NAME;}set{ _ROLL_PROPERTY_NAME = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _ROLL_PROPERTY;
		[DataMember]
		public System.String  ROLL_PROPERTY{get{ return  _ROLL_PROPERTY;}set{ _ROLL_PROPERTY = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.String  _PLAN_TYPE_NAME;
		[DataMember]
		public System.String  PLAN_TYPE_NAME{get{ return  _PLAN_TYPE_NAME;}set{ _PLAN_TYPE_NAME = value;}}

		#endregion 
	}	
}
