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
	[DataObject("MCE_B_ASSETS_OUTSTOCK_D")]
	public partial class CauseObject_MCE_B_ASSETS_OUTSTOCK_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		DateSpan _USE_DATE = null;
		[DataMember]
		public DateSpan  USE_DATE{get{ return  _USE_DATE;}set{ _USE_DATE = value;}}
		System.String _ASSET_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal _IS_RETURN = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_RETURN{get{ return  _IS_RETURN;}set{ _IS_RETURN = value;}}
		System.String _ECONOMIC_USE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ECONOMIC_USE_TYPE_ID{get{ return  _ECONOMIC_USE_TYPE_ID;}set{ _ECONOMIC_USE_TYPE_ID = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _TOTAL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _SEQ_NUMBER = string.Empty;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _COUNTRY = string.Empty;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_OUTSTOCK_D")]
	public partial class DisplayObject_MCE_B_ASSETS_OUTSTOCK_D:EntityObject_MCE_B_ASSETS_OUTSTOCK_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _ASSET_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSET_TYPE_ID_NAME{get{ return  _ASSET_TYPE_ID_NAME;}set{ _ASSET_TYPE_ID_NAME = value;}}
		 System.String _ECONOMIC_USE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ECONOMIC_USE_TYPE_ID_NAME{get{ return  _ECONOMIC_USE_TYPE_ID_NAME;}set{ _ECONOMIC_USE_TYPE_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _COUNTRY_NAME = string.Empty;
		[DataMember]
		public System.String COUNTRY_NAME{get{ return  _COUNTRY_NAME;}set{ _COUNTRY_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_OUTSTOCK_D")]
	public partial class EntityObject_MCE_B_ASSETS_OUTSTOCK_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.DateTime  _USE_DATE;
		[DataMember]
		public System.DateTime  USE_DATE{get{ return  _USE_DATE;}set{ _USE_DATE = value;}}
		System.String  _ASSET_TYPE_ID;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal  _IS_RETURN;
		[DataMember]
		public System.Decimal  IS_RETURN{get{ return  _IS_RETURN;}set{ _IS_RETURN = value;}}
		System.String  _ECONOMIC_USE_TYPE_ID;
		[DataMember]
		public System.String  ECONOMIC_USE_TYPE_ID{get{ return  _ECONOMIC_USE_TYPE_ID;}set{ _ECONOMIC_USE_TYPE_ID = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _TOTAL_MONEY;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _SEQ_NUMBER;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _COUNTRY;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}

		#endregion 
	}	
}
