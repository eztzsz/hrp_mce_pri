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
	[DataObject("MCE_B_ASSETS_DEPR_D")]
	public partial class CauseObject_MCE_B_ASSETS_DEPR_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _NEW_NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NEW_NET_VALUE{get{ return  _NEW_NET_VALUE;}set{ _NEW_NET_VALUE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _ORIGINAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.Decimal _NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_DEPR_D")]
	public partial class DisplayObject_MCE_B_ASSETS_DEPR_D:EntityObject_MCE_B_ASSETS_DEPR_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_DEPR_D")]
	public partial class EntityObject_MCE_B_ASSETS_DEPR_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _NEW_NET_VALUE;
		[DataMember]
		public System.Decimal  NEW_NET_VALUE{get{ return  _NEW_NET_VALUE;}set{ _NEW_NET_VALUE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _ORIGINAL_VALUE;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.Decimal  _NET_VALUE;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
