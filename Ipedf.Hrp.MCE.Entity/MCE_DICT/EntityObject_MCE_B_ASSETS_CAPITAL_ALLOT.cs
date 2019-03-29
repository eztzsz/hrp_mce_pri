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
	[DataObject("MCE_B_ASSETS_CAPITAL_ALLOT")]
	public partial class CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.Decimal _ALLOT_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ALLOT_MONEY{get{ return  _ALLOT_MONEY;}set{ _ALLOT_MONEY = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal _RATIO = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RATIO{get{ return  _RATIO;}set{ _RATIO = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _CAPITAL_SOURCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  CAPITAL_SOURCE_TYPE_ID{get{ return  _CAPITAL_SOURCE_TYPE_ID;}set{ _CAPITAL_SOURCE_TYPE_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CAPITAL_ALLOT")]
	public partial class DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT:EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		 System.String _CAPITAL_SOURCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String CAPITAL_SOURCE_TYPE_ID_NAME{get{ return  _CAPITAL_SOURCE_TYPE_ID_NAME;}set{ _CAPITAL_SOURCE_TYPE_ID_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CAPITAL_ALLOT")]
	public partial class EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.Decimal  _ALLOT_MONEY;
		[DataMember]
		public System.Decimal  ALLOT_MONEY{get{ return  _ALLOT_MONEY;}set{ _ALLOT_MONEY = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal  _RATIO;
		[DataMember]
		public System.Decimal  RATIO{get{ return  _RATIO;}set{ _RATIO = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _CAPITAL_SOURCE_TYPE_ID;
		[DataMember]
		public System.String  CAPITAL_SOURCE_TYPE_ID{get{ return  _CAPITAL_SOURCE_TYPE_ID;}set{ _CAPITAL_SOURCE_TYPE_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}

		#endregion 
	}	
}
