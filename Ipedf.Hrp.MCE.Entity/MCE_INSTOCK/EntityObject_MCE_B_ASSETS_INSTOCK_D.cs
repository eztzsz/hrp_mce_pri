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
	[DataObject("MCE_B_ASSETS_INSTOCK_D")]
	public partial class CauseObject_MCE_B_ASSETS_INSTOCK_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String _COUNTRY = string.Empty;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}
		DateSpan _PRD_DATE = null;
		[DataMember]
		public DateSpan  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String _PRD_CODE = string.Empty;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String _BRAND = string.Empty;
		[DataMember]
		public System.String  BRAND{get{ return  _BRAND;}set{ _BRAND = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _ASSET_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		DateSpan _AOG_DATE = null;
		[DataMember]
		public DateSpan  AOG_DATE{get{ return  _AOG_DATE;}set{ _AOG_DATE = value;}}
		System.String _ASSET_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String _ACCOUNT = string.Empty;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _SOURCES_FUNDS = string.Empty;
		[DataMember]
		public System.String  SOURCES_FUNDS{get{ return  _SOURCES_FUNDS;}set{ _SOURCES_FUNDS = value;}}
		System.Decimal _DEPR_YEAR_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DEPR_YEAR_AMOUNT{get{ return  _DEPR_YEAR_AMOUNT;}set{ _DEPR_YEAR_AMOUNT = value;}}
		System.String _DEPR_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  DEPR_TYPE_ID{get{ return  _DEPR_TYPE_ID;}set{ _DEPR_TYPE_ID = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		DateSpan _MAINTENANCE_PERIOD_DATE = null;
		[DataMember]
		public DateSpan  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String _COMMENTS_D = string.Empty;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String _PURCHARSE_PERSON = string.Empty;
		[DataMember]
		public System.String  PURCHARSE_PERSON{get{ return  _PURCHARSE_PERSON;}set{ _PURCHARSE_PERSON = value;}}
		System.String _REF_PRD_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.String _USING_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		DateSpan _PURCHARSE_DATE = null;
		[DataMember]
		public DateSpan  PURCHARSE_DATE{get{ return  _PURCHARSE_DATE;}set{ _PURCHARSE_DATE = value;}}
		DateSpan _ARRIVAL_DATE = null;
		[DataMember]
		public DateSpan  ARRIVAL_DATE{get{ return  _ARRIVAL_DATE;}set{ _ARRIVAL_DATE = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_INSTOCK_D")]
	public partial class DisplayObject_MCE_B_ASSETS_INSTOCK_D:EntityObject_MCE_B_ASSETS_INSTOCK_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _CURRENCY_ID_NAME = string.Empty;
		[DataMember]
		public System.String CURRENCY_ID_NAME{get{ return  _CURRENCY_ID_NAME;}set{ _CURRENCY_ID_NAME = value;}}
		 System.String _COUNTRY_NAME = string.Empty;
		[DataMember]
		public System.String COUNTRY_NAME{get{ return  _COUNTRY_NAME;}set{ _COUNTRY_NAME = value;}}
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _ASSET_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSET_TYPE_ID_NAME{get{ return  _ASSET_TYPE_ID_NAME;}set{ _ASSET_TYPE_ID_NAME = value;}}
		 System.String _DEPR_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPR_TYPE_ID_NAME{get{ return  _DEPR_TYPE_ID_NAME;}set{ _DEPR_TYPE_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _USING_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_INSTOCK_D")]
	public partial class EntityObject_MCE_B_ASSETS_INSTOCK_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.String  _COUNTRY;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}
		System.DateTime  _PRD_DATE;
		[DataMember]
		public System.DateTime  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _AMOUNT;
		[DataMember]
		public System.Decimal  AMOUNT{get{ return  _AMOUNT;}set{ _AMOUNT = value;}}
		System.String  _PRD_CODE;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String  _BRAND;
		[DataMember]
		public System.String  BRAND{get{ return  _BRAND;}set{ _BRAND = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _ASSET_ID;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.DateTime  _AOG_DATE;
		[DataMember]
		public System.DateTime  AOG_DATE{get{ return  _AOG_DATE;}set{ _AOG_DATE = value;}}
		System.String  _ASSET_TYPE_ID;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String  _ACCOUNT;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _SOURCES_FUNDS;
		[DataMember]
		public System.String  SOURCES_FUNDS{get{ return  _SOURCES_FUNDS;}set{ _SOURCES_FUNDS = value;}}
		System.Decimal  _DEPR_YEAR_AMOUNT;
		[DataMember]
		public System.Decimal  DEPR_YEAR_AMOUNT{get{ return  _DEPR_YEAR_AMOUNT;}set{ _DEPR_YEAR_AMOUNT = value;}}
		System.String  _DEPR_TYPE_ID;
		[DataMember]
		public System.String  DEPR_TYPE_ID{get{ return  _DEPR_TYPE_ID;}set{ _DEPR_TYPE_ID = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.DateTime  _MAINTENANCE_PERIOD_DATE;
		[DataMember]
		public System.DateTime  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String  _COMMENTS_D;
		[DataMember]
		public System.String  COMMENTS_D{get{ return  _COMMENTS_D;}set{ _COMMENTS_D = value;}}
		System.String  _PURCHARSE_PERSON;
		[DataMember]
		public System.String  PURCHARSE_PERSON{get{ return  _PURCHARSE_PERSON;}set{ _PURCHARSE_PERSON = value;}}
		System.String  _REF_PRD_ID;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.String  _USING_DEPT_ID;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.DateTime  _PURCHARSE_DATE;
		[DataMember]
		public System.DateTime  PURCHARSE_DATE{get{ return  _PURCHARSE_DATE;}set{ _PURCHARSE_DATE = value;}}
		System.DateTime  _ARRIVAL_DATE;
		[DataMember]
		public System.DateTime  ARRIVAL_DATE{get{ return  _ARRIVAL_DATE;}set{ _ARRIVAL_DATE = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}	
}
