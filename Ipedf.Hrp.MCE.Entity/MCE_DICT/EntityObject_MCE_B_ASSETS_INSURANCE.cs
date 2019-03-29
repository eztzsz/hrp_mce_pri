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
	[DataObject("MCE_B_ASSETS_INSURANCE")]
	public partial class CauseObject_MCE_B_ASSETS_INSURANCE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _FEE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  FEE_MONEY{get{ return  _FEE_MONEY;}set{ _FEE_MONEY = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _EFFECT_DATE = null;
		[DataMember]
		public DateSpan  EFFECT_DATE{get{ return  _EFFECT_DATE;}set{ _EFFECT_DATE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		DateSpan _EXPIRE_DATE = null;
		[DataMember]
		public DateSpan  EXPIRE_DATE{get{ return  _EXPIRE_DATE;}set{ _EXPIRE_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _MATER = string.Empty;
		[DataMember]
		public System.String  MATER{get{ return  _MATER;}set{ _MATER = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal _INSURANCE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  INSURANCE_MONEY{get{ return  _INSURANCE_MONEY;}set{ _INSURANCE_MONEY = value;}}
		System.String _INSURANCE_UNIT = string.Empty;
		[DataMember]
		public System.String  INSURANCE_UNIT{get{ return  _INSURANCE_UNIT;}set{ _INSURANCE_UNIT = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_INSURANCE")]
	public partial class DisplayObject_MCE_B_ASSETS_INSURANCE:EntityObject_MCE_B_ASSETS_INSURANCE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _INSURANCE_UNIT_NAME = string.Empty;
		[DataMember]
		public System.String INSURANCE_UNIT_NAME{get{ return  _INSURANCE_UNIT_NAME;}set{ _INSURANCE_UNIT_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_INSURANCE")]
	public partial class EntityObject_MCE_B_ASSETS_INSURANCE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _FEE_MONEY;
		[DataMember]
		public System.Decimal  FEE_MONEY{get{ return  _FEE_MONEY;}set{ _FEE_MONEY = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _EFFECT_DATE;
		[DataMember]
		public System.DateTime  EFFECT_DATE{get{ return  _EFFECT_DATE;}set{ _EFFECT_DATE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.DateTime  _EXPIRE_DATE;
		[DataMember]
		public System.DateTime  EXPIRE_DATE{get{ return  _EXPIRE_DATE;}set{ _EXPIRE_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _MATER;
		[DataMember]
		public System.String  MATER{get{ return  _MATER;}set{ _MATER = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal  _INSURANCE_MONEY;
		[DataMember]
		public System.Decimal  INSURANCE_MONEY{get{ return  _INSURANCE_MONEY;}set{ _INSURANCE_MONEY = value;}}
		System.String  _INSURANCE_UNIT;
		[DataMember]
		public System.String  INSURANCE_UNIT{get{ return  _INSURANCE_UNIT;}set{ _INSURANCE_UNIT = value;}}

		#endregion 
	}	
}
