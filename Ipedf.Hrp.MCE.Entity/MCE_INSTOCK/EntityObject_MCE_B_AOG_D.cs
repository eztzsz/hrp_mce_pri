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
	[DataObject("MCE_B_AOG_D")]
	public partial class CauseObject_MCE_B_AOG_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _USING_PERSON = string.Empty;
		[DataMember]
		public System.String  USING_PERSON{get{ return  _USING_PERSON;}set{ _USING_PERSON = value;}}
		System.String _ASSET_CODE = string.Empty;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String _COUNTRY = string.Empty;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}
		DateSpan _PRD_DATE = null;
		[DataMember]
		public DateSpan  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
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
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
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
		System.String _USING_ID = string.Empty;
		[DataMember]
		public System.String  USING_ID{get{ return  _USING_ID;}set{ _USING_ID = value;}}
		System.String _ASSET_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		DateSpan _USE_DATE = null;
		[DataMember]
		public DateSpan  USE_DATE{get{ return  _USE_DATE;}set{ _USE_DATE = value;}}
		System.String _REG_CODE = string.Empty;
		[DataMember]
		public System.String  REG_CODE{get{ return  _REG_CODE;}set{ _REG_CODE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _REF_USED_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
		System.String _STORE_ADDRESS = string.Empty;
		[DataMember]
		public System.String  STORE_ADDRESS{get{ return  _STORE_ADDRESS;}set{ _STORE_ADDRESS = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _REF_PRD_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.String _CAPACITY = string.Empty;
		[DataMember]
		public System.String  CAPACITY{get{ return  _CAPACITY;}set{ _CAPACITY = value;}}
		System.Decimal _PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_AOG_D")]
	public partial class DisplayObject_MCE_B_AOG_D:EntityObject_MCE_B_AOG_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _COUNTRY_NAME = string.Empty;
		[DataMember]
		public System.String COUNTRY_NAME{get{ return  _COUNTRY_NAME;}set{ _COUNTRY_NAME = value;}}
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _ASSET_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSET_TYPE_ID_NAME{get{ return  _ASSET_TYPE_ID_NAME;}set{ _ASSET_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_AOG_D")]
	public partial class EntityObject_MCE_B_AOG_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _USING_PERSON;
		[DataMember]
		public System.String  USING_PERSON{get{ return  _USING_PERSON;}set{ _USING_PERSON = value;}}
		System.String  _ASSET_CODE;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String  _COUNTRY;
		[DataMember]
		public System.String  COUNTRY{get{ return  _COUNTRY;}set{ _COUNTRY = value;}}
		System.DateTime  _PRD_DATE;
		[DataMember]
		public System.DateTime  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
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
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
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
		System.String  _USING_ID;
		[DataMember]
		public System.String  USING_ID{get{ return  _USING_ID;}set{ _USING_ID = value;}}
		System.String  _ASSET_TYPE_ID;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.DateTime  _USE_DATE;
		[DataMember]
		public System.DateTime  USE_DATE{get{ return  _USE_DATE;}set{ _USE_DATE = value;}}
		System.String  _REG_CODE;
		[DataMember]
		public System.String  REG_CODE{get{ return  _REG_CODE;}set{ _REG_CODE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _REF_USED_AMOUNT;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
		System.String  _STORE_ADDRESS;
		[DataMember]
		public System.String  STORE_ADDRESS{get{ return  _STORE_ADDRESS;}set{ _STORE_ADDRESS = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _REF_PRD_ID;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.String  _CAPACITY;
		[DataMember]
		public System.String  CAPACITY{get{ return  _CAPACITY;}set{ _CAPACITY = value;}}
		System.Decimal  _PRICE;
		[DataMember]
		public System.Decimal  PRICE{get{ return  _PRICE;}set{ _PRICE = value;}}

		#endregion 
	}	
}
