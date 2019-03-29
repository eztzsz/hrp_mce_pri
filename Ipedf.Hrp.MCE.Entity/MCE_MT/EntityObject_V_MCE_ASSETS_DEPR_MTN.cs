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
	[DataObject("V_MCE_ASSETS_DEPR_MTN")]
	public partial class CauseObject_V_MCE_ASSETS_DEPR_MTN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _ORIGINAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _MTN_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  MTN_TYPE_NAME{get{ return  _MTN_TYPE_NAME;}set{ _MTN_TYPE_NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _FINANCE_CYCLE = string.Empty;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String  BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String _ASSERTS_ID = string.Empty;
		[DataMember]
		public System.String  ASSERTS_ID{get{ return  _ASSERTS_ID;}set{ _ASSERTS_ID = value;}}
		System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		System.String _DEPT_NAME = string.Empty;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.Decimal _MAINTAIN_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String _ASSERTS_ID_NAME = string.Empty;
		[DataMember]
		public System.String  ASSERTS_ID_NAME{get{ return  _ASSERTS_ID_NAME;}set{ _ASSERTS_ID_NAME = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.Decimal _NEW_NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NEW_NET_VALUE{get{ return  _NEW_NET_VALUE;}set{ _NEW_NET_VALUE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_DEPR_MTN")]
	public partial class DisplayObject_V_MCE_ASSETS_DEPR_MTN:EntityObject_V_MCE_ASSETS_DEPR_MTN
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_DEPR_MTN")]
	public partial class EntityObject_V_MCE_ASSETS_DEPR_MTN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _ORIGINAL_VALUE;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _MTN_TYPE_NAME;
		[DataMember]
		public System.String  MTN_TYPE_NAME{get{ return  _MTN_TYPE_NAME;}set{ _MTN_TYPE_NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _FINANCE_CYCLE;
		[DataMember]
		public System.String  FINANCE_CYCLE{get{ return  _FINANCE_CYCLE;}set{ _FINANCE_CYCLE = value;}}
		System.String  _BASE_ID_NAME;
		[DataMember]
		public System.String  BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String  _ASSERTS_ID;
		[DataMember]
		public System.String  ASSERTS_ID{get{ return  _ASSERTS_ID;}set{ _ASSERTS_ID = value;}}
		System.String  _CURRENCY_ID_NAME;
		[DataMember]
		public System.String  CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		System.String  _DEPT_NAME;
		[DataMember]
		public System.String  DEPT_NAME{get{ return  _DEPT_NAME;}set{ _DEPT_NAME = value;}}
		System.Decimal  _MAINTAIN_MONEY;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String  _ASSERTS_ID_NAME;
		[DataMember]
		public System.String  ASSERTS_ID_NAME{get{ return  _ASSERTS_ID_NAME;}set{ _ASSERTS_ID_NAME = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _NET_VALUE;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.Decimal  _NEW_NET_VALUE;
		[DataMember]
		public System.Decimal  NEW_NET_VALUE{get{ return  _NEW_NET_VALUE;}set{ _NEW_NET_VALUE = value;}}

		#endregion 
	}	
}
