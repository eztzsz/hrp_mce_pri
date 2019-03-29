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
	[DataObject("MCE_B_ASSETS_IMPORTATION")]
	public partial class CauseObject_MCE_B_ASSETS_IMPORTATION:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _APPROVE_FILE_CODE = string.Empty;
		[DataMember]
		public System.String  APPROVE_FILE_CODE{get{ return  _APPROVE_FILE_CODE;}set{ _APPROVE_FILE_CODE = value;}}
		System.String _EXEMPTION_CODE = string.Empty;
		[DataMember]
		public System.String  EXEMPTION_CODE{get{ return  _EXEMPTION_CODE;}set{ _EXEMPTION_CODE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.Decimal _PURCHASE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PURCHASE_MONEY{get{ return  _PURCHASE_MONEY;}set{ _PURCHASE_MONEY = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.Decimal _CUSTOMS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CUSTOMS{get{ return  _CUSTOMS;}set{ _CUSTOMS = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _FOREIGN_CURRENCY_SOURCE_ID = string.Empty;
		[DataMember]
		public System.String  FOREIGN_CURRENCY_SOURCE_ID{get{ return  _FOREIGN_CURRENCY_SOURCE_ID;}set{ _FOREIGN_CURRENCY_SOURCE_ID = value;}}
		System.Decimal _FOREIGN_CURRENCY_RATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  FOREIGN_CURRENCY_RATE{get{ return  _FOREIGN_CURRENCY_RATE;}set{ _FOREIGN_CURRENCY_RATE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _COUNTRY_ID = string.Empty;
		[DataMember]
		public System.String  COUNTRY_ID{get{ return  _COUNTRY_ID;}set{ _COUNTRY_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_IMPORTATION")]
	public partial class DisplayObject_MCE_B_ASSETS_IMPORTATION:EntityObject_MCE_B_ASSETS_IMPORTATION
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		 System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		 System.String _FOREIGN_CURRENCY_SOURCE_ID_NAM = string.Empty;
		[DataMember]
		public System.String FOREIGN_CURRENCY_SOURCE_ID_NAM{get{ return  _FOREIGN_CURRENCY_SOURCE_ID_NAM;}set{ _FOREIGN_CURRENCY_SOURCE_ID_NAM = value;}}
		 System.String _COUNTRY_ID_NAME = string.Empty;
		[DataMember]
		public System.String COUNTRY_ID_NAME{get{ return  _COUNTRY_ID_NAME;}set{ _COUNTRY_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_IMPORTATION")]
	public partial class EntityObject_MCE_B_ASSETS_IMPORTATION:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _APPROVE_FILE_CODE;
		[DataMember]
		public System.String  APPROVE_FILE_CODE{get{ return  _APPROVE_FILE_CODE;}set{ _APPROVE_FILE_CODE = value;}}
		System.String  _EXEMPTION_CODE;
		[DataMember]
		public System.String  EXEMPTION_CODE{get{ return  _EXEMPTION_CODE;}set{ _EXEMPTION_CODE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.Decimal  _PURCHASE_MONEY;
		[DataMember]
		public System.Decimal  PURCHASE_MONEY{get{ return  _PURCHASE_MONEY;}set{ _PURCHASE_MONEY = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.Decimal  _CUSTOMS;
		[DataMember]
		public System.Decimal  CUSTOMS{get{ return  _CUSTOMS;}set{ _CUSTOMS = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _FOREIGN_CURRENCY_SOURCE_ID;
		[DataMember]
		public System.String  FOREIGN_CURRENCY_SOURCE_ID{get{ return  _FOREIGN_CURRENCY_SOURCE_ID;}set{ _FOREIGN_CURRENCY_SOURCE_ID = value;}}
		System.Decimal  _FOREIGN_CURRENCY_RATE;
		[DataMember]
		public System.Decimal  FOREIGN_CURRENCY_RATE{get{ return  _FOREIGN_CURRENCY_RATE;}set{ _FOREIGN_CURRENCY_RATE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _COUNTRY_ID;
		[DataMember]
		public System.String  COUNTRY_ID{get{ return  _COUNTRY_ID;}set{ _COUNTRY_ID = value;}}

		#endregion 
	}	
}
