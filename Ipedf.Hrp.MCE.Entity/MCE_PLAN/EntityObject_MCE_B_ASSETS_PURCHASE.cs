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
	[DataObject("MCE_B_ASSETS_PURCHASE")]
	public partial class CauseObject_MCE_B_ASSETS_PURCHASE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CURRENCY_ID = string.Empty;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _FREEUSE2 = string.Empty;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String _FREEUSE3 = string.Empty;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String _REF_PRD_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.Decimal _MONTH_INCOME = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONTH_INCOME{get{ return  _MONTH_INCOME;}set{ _MONTH_INCOME = value;}}
		System.String _REF_PRV_ID = string.Empty;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _APPLY_SITUATION_3 = string.Empty;
		[DataMember]
		public System.String  APPLY_SITUATION_3{get{ return  _APPLY_SITUATION_3;}set{ _APPLY_SITUATION_3 = value;}}
		System.String _APPLY_SITUATION_2 = string.Empty;
		[DataMember]
		public System.String  APPLY_SITUATION_2{get{ return  _APPLY_SITUATION_2;}set{ _APPLY_SITUATION_2 = value;}}
		System.String _APPLY_SITUATION_1 = string.Empty;
		[DataMember]
		public System.String  APPLY_SITUATION_1{get{ return  _APPLY_SITUATION_1;}set{ _APPLY_SITUATION_1 = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal _REF_USED_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _ASSET_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String _APPLY_USER_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _PRD_NAME = string.Empty;
		[DataMember]
		public System.String  PRD_NAME{get{ return  _PRD_NAME;}set{ _PRD_NAME = value;}}
		System.Decimal _YEAR_INCOME = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  YEAR_INCOME{get{ return  _YEAR_INCOME;}set{ _YEAR_INCOME = value;}}
		System.Decimal _APPLY_PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_PRICE{get{ return  _APPLY_PRICE;}set{ _APPLY_PRICE = value;}}
		System.Decimal _APPLY_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String _UNIT_NAME = string.Empty;
		[DataMember]
		public System.String  UNIT_NAME{get{ return  _UNIT_NAME;}set{ _UNIT_NAME = value;}}
		System.String _APPLY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.Decimal _IS_REPORT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_REPORT{get{ return  _IS_REPORT;}set{ _IS_REPORT = value;}}
		System.String _FREEUSE1 = string.Empty;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String _CONFIGURATION = string.Empty;
		[DataMember]
		public System.String  CONFIGURATION{get{ return  _CONFIGURATION;}set{ _CONFIGURATION = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _APPLY_COMMENTS = string.Empty;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		System.String _ENCONOMY_EFFECT = string.Empty;
		[DataMember]
		public System.String  ENCONOMY_EFFECT{get{ return  _ENCONOMY_EFFECT;}set{ _ENCONOMY_EFFECT = value;}}
		System.String _PICTURE = string.Empty;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _ASSET_NAME = string.Empty;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String _PRV_NAME = string.Empty;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal _APPLY_ESTIMATE_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_ESTIMATE_MONEY{get{ return  _APPLY_ESTIMATE_MONEY;}set{ _APPLY_ESTIMATE_MONEY = value;}}
		System.String _PURCHASE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  PURCHASE_TYPE_ID{get{ return  _PURCHASE_TYPE_ID;}set{ _PURCHASE_TYPE_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _MONTH_EXAMINE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONTH_EXAMINE{get{ return  _MONTH_EXAMINE;}set{ _MONTH_EXAMINE = value;}}
		System.String _PRV_ID = string.Empty;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.Decimal _ASSET_HOUSE_MAP = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ASSET_HOUSE_MAP{get{ return  _ASSET_HOUSE_MAP;}set{ _ASSET_HOUSE_MAP = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal _APPLY_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  APPLY_AMOUNT{get{ return  _APPLY_AMOUNT;}set{ _APPLY_AMOUNT = value;}}
		System.Decimal _IS_ASSET_HOUSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_ASSET_HOUSE{get{ return  _IS_ASSET_HOUSE;}set{ _IS_ASSET_HOUSE = value;}}
		System.String _PRODUCT_AREA = string.Empty;
		[DataMember]
		public System.String  PRODUCT_AREA{get{ return  _PRODUCT_AREA;}set{ _PRODUCT_AREA = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE")]
	public partial class DisplayObject_MCE_B_ASSETS_PURCHASE:EntityObject_MCE_B_ASSETS_PURCHASE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		 System.String _APPLY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_USER_ID_NAME{get{ return  _APPLY_USER_ID_NAME;}set{ _APPLY_USER_ID_NAME = value;}}
		 System.String _APPLY_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String APPLY_DEPT_ID_NAME{get{ return  _APPLY_DEPT_ID_NAME;}set{ _APPLY_DEPT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _PURCHASE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String PURCHASE_TYPE_ID_NAME{get{ return  _PURCHASE_TYPE_ID_NAME;}set{ _PURCHASE_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_PURCHASE")]
	public partial class EntityObject_MCE_B_ASSETS_PURCHASE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CURRENCY_ID;
		[DataMember]
		public System.String  CURRENCY_ID{get{ return  _CURRENCY_ID;}set{ _CURRENCY_ID = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _FREEUSE2;
		[DataMember]
		public System.String  FREEUSE2{get{ return  _FREEUSE2;}set{ _FREEUSE2 = value;}}
		System.String  _FREEUSE3;
		[DataMember]
		public System.String  FREEUSE3{get{ return  _FREEUSE3;}set{ _FREEUSE3 = value;}}
		System.String  _REF_PRD_ID;
		[DataMember]
		public System.String  REF_PRD_ID{get{ return  _REF_PRD_ID;}set{ _REF_PRD_ID = value;}}
		System.Decimal  _MONTH_INCOME;
		[DataMember]
		public System.Decimal  MONTH_INCOME{get{ return  _MONTH_INCOME;}set{ _MONTH_INCOME = value;}}
		System.String  _REF_PRV_ID;
		[DataMember]
		public System.String  REF_PRV_ID{get{ return  _REF_PRV_ID;}set{ _REF_PRV_ID = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _APPLY_SITUATION_3;
		[DataMember]
		public System.String  APPLY_SITUATION_3{get{ return  _APPLY_SITUATION_3;}set{ _APPLY_SITUATION_3 = value;}}
		System.String  _APPLY_SITUATION_2;
		[DataMember]
		public System.String  APPLY_SITUATION_2{get{ return  _APPLY_SITUATION_2;}set{ _APPLY_SITUATION_2 = value;}}
		System.String  _APPLY_SITUATION_1;
		[DataMember]
		public System.String  APPLY_SITUATION_1{get{ return  _APPLY_SITUATION_1;}set{ _APPLY_SITUATION_1 = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.Decimal  _REF_USED_AMOUNT;
		[DataMember]
		public System.Decimal  REF_USED_AMOUNT{get{ return  _REF_USED_AMOUNT;}set{ _REF_USED_AMOUNT = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _ASSET_ID;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String  _APPLY_USER_ID;
		[DataMember]
		public System.String  APPLY_USER_ID{get{ return  _APPLY_USER_ID;}set{ _APPLY_USER_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _PRD_NAME;
		[DataMember]
		public System.String  PRD_NAME{get{ return  _PRD_NAME;}set{ _PRD_NAME = value;}}
		System.Decimal  _YEAR_INCOME;
		[DataMember]
		public System.Decimal  YEAR_INCOME{get{ return  _YEAR_INCOME;}set{ _YEAR_INCOME = value;}}
		System.Decimal  _APPLY_PRICE;
		[DataMember]
		public System.Decimal  APPLY_PRICE{get{ return  _APPLY_PRICE;}set{ _APPLY_PRICE = value;}}
		System.Decimal  _APPLY_MONEY;
		[DataMember]
		public System.Decimal  APPLY_MONEY{get{ return  _APPLY_MONEY;}set{ _APPLY_MONEY = value;}}
		System.String  _UNIT_NAME;
		[DataMember]
		public System.String  UNIT_NAME{get{ return  _UNIT_NAME;}set{ _UNIT_NAME = value;}}
		System.String  _APPLY_DEPT_ID;
		[DataMember]
		public System.String  APPLY_DEPT_ID{get{ return  _APPLY_DEPT_ID;}set{ _APPLY_DEPT_ID = value;}}
		System.Decimal  _IS_REPORT;
		[DataMember]
		public System.Decimal  IS_REPORT{get{ return  _IS_REPORT;}set{ _IS_REPORT = value;}}
		System.String  _FREEUSE1;
		[DataMember]
		public System.String  FREEUSE1{get{ return  _FREEUSE1;}set{ _FREEUSE1 = value;}}
		System.String  _CONFIGURATION;
		[DataMember]
		public System.String  CONFIGURATION{get{ return  _CONFIGURATION;}set{ _CONFIGURATION = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _APPLY_COMMENTS;
		[DataMember]
		public System.String  APPLY_COMMENTS{get{ return  _APPLY_COMMENTS;}set{ _APPLY_COMMENTS = value;}}
		System.String  _ENCONOMY_EFFECT;
		[DataMember]
		public System.String  ENCONOMY_EFFECT{get{ return  _ENCONOMY_EFFECT;}set{ _ENCONOMY_EFFECT = value;}}
		System.String  _PICTURE;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _ASSET_NAME;
		[DataMember]
		public System.String  ASSET_NAME{get{ return  _ASSET_NAME;}set{ _ASSET_NAME = value;}}
		System.String  _PRV_NAME;
		[DataMember]
		public System.String  PRV_NAME{get{ return  _PRV_NAME;}set{ _PRV_NAME = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal  _APPLY_ESTIMATE_MONEY;
		[DataMember]
		public System.Decimal  APPLY_ESTIMATE_MONEY{get{ return  _APPLY_ESTIMATE_MONEY;}set{ _APPLY_ESTIMATE_MONEY = value;}}
		System.String  _PURCHASE_TYPE_ID;
		[DataMember]
		public System.String  PURCHASE_TYPE_ID{get{ return  _PURCHASE_TYPE_ID;}set{ _PURCHASE_TYPE_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _MONTH_EXAMINE;
		[DataMember]
		public System.Decimal  MONTH_EXAMINE{get{ return  _MONTH_EXAMINE;}set{ _MONTH_EXAMINE = value;}}
		System.String  _PRV_ID;
		[DataMember]
		public System.String  PRV_ID{get{ return  _PRV_ID;}set{ _PRV_ID = value;}}
		System.Decimal  _ASSET_HOUSE_MAP;
		[DataMember]
		public System.Decimal  ASSET_HOUSE_MAP{get{ return  _ASSET_HOUSE_MAP;}set{ _ASSET_HOUSE_MAP = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.Decimal  _APPLY_AMOUNT;
		[DataMember]
		public System.Decimal  APPLY_AMOUNT{get{ return  _APPLY_AMOUNT;}set{ _APPLY_AMOUNT = value;}}
		System.Decimal  _IS_ASSET_HOUSE;
		[DataMember]
		public System.Decimal  IS_ASSET_HOUSE{get{ return  _IS_ASSET_HOUSE;}set{ _IS_ASSET_HOUSE = value;}}
		System.String  _PRODUCT_AREA;
		[DataMember]
		public System.String  PRODUCT_AREA{get{ return  _PRODUCT_AREA;}set{ _PRODUCT_AREA = value;}}

		#endregion 
	}	
}
