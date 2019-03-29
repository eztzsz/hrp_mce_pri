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
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN_D")]
	public partial class CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal _REF_USED_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
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
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _PRV_NAME = string.Empty;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		DateSpan _DELIVERY_DATE = null;
		[DataMember]
		public DateSpan  DELIVERY_DATE{get{ return  _DELIVERY_DATE;}set{ _DELIVERY_DATE = value;}}
		System.String _ASSET_NAME = string.Empty;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String _REF_PRV_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _ASSET_CODE = string.Empty;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String _PRD_NAME = string.Empty;
		[DataMember]
		public System.String  PRD_NAME{get{ return  _PRD_NAME;}set{ _PRD_NAME = value;}}
		System.String _PRV_ID = string.Empty;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.String _REF_PRD_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN_D")]
	public partial class DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D:EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		 System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE_PLAN_D")]
	public partial class EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal  _REF_USED_AMOUNT;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
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
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _PRV_NAME;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.DateTime  _DELIVERY_DATE;
		[DataMember]
		public System.DateTime  DELIVERY_DATE{get{ return  _DELIVERY_DATE;}set{ _DELIVERY_DATE = value;}}
		System.String  _ASSET_NAME;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String  _REF_PRV_ID;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _ASSET_CODE;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String  _PRD_NAME;
		[DataMember]
		public System.String  PRD_NAME{get{ return  _PRD_NAME;}set{ _PRD_NAME = value;}}
		System.String  _PRV_ID;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.String  _REF_PRD_ID;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}

		#endregion 
	}	
}
