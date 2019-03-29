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
	[DataObject("V_MCE_ASSET_SALERETURN_BACK")]
	public partial class CauseObject_V_MCE_ASSET_SALERETURN_BACK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _ORIGINAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		DateSpan _PURCHASE_DATE = null;
		[DataMember]
		public DateSpan  PURCHASE_DATE{get{ return  _PURCHASE_DATE;}set{ _PURCHASE_DATE = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _PRODUCT_NAME = string.Empty;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
		System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String  UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _BACK_D_ID = string.Empty;
		[DataMember]
		public System.String  BACK_D_ID{get{ return  _BACK_D_ID;}set{ _BACK_D_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSET_SALERETURN_BACK")]
	public partial class DisplayObject_V_MCE_ASSET_SALERETURN_BACK:EntityObject_V_MCE_ASSET_SALERETURN_BACK
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSET_SALERETURN_BACK")]
	public partial class EntityObject_V_MCE_ASSET_SALERETURN_BACK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _ORIGINAL_VALUE;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.DateTime  _PURCHASE_DATE;
		[DataMember]
		public System.DateTime  PURCHASE_DATE{get{ return  _PURCHASE_DATE;}set{ _PURCHASE_DATE = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _PRODUCT_NAME;
		[DataMember]
		public System.String  PRODUCT_NAME{get{ return  _PRODUCT_NAME;}set{ _PRODUCT_NAME = value;}}
		System.String  _UNIT_ID_NAME;
		[DataMember]
		public System.String  UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _BACK_D_ID;
		[DataMember]
		public System.String  BACK_D_ID{get{ return  _BACK_D_ID;}set{ _BACK_D_ID = value;}}

		#endregion 
	}	
}
