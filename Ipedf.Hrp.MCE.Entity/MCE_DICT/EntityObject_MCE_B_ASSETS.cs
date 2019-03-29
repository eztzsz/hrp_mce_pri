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
	[DataObject("MCE_B_ASSETS")]
	public partial class CauseObject_MCE_B_ASSETS:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _MAINTAIN_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.Decimal _DEPR_YEAR_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DEPR_YEAR_AMOUNT{get{ return  _DEPR_YEAR_AMOUNT;}set{ _DEPR_YEAR_AMOUNT = value;}}
		System.String _REF_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  REF_DEPT_ID{get{ return  _REF_DEPT_ID;}set{ _REF_DEPT_ID = value;}}
		System.String _EN_NAME = string.Empty;
		[DataMember]
		public System.String  EN_NAME{get{ return  _EN_NAME;}set{ _EN_NAME = value;}}
		System.String _ACQUIRE_USE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ACQUIRE_USE_TYPE_ID{get{ return  _ACQUIRE_USE_TYPE_ID;}set{ _ACQUIRE_USE_TYPE_ID = value;}}
		System.Decimal _PREDICT_NET_RUDIMENTAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PREDICT_NET_RUDIMENTAL_VALUE{get{ return  _PREDICT_NET_RUDIMENTAL_VALUE;}set{ _PREDICT_NET_RUDIMENTAL_VALUE = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal _SERVICE_LIFE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  SERVICE_LIFE{get{ return  _SERVICE_LIFE;}set{ _SERVICE_LIFE = value;}}
		System.String _CALL_CODE = string.Empty;
		[DataMember]
		public System.String  CALL_CODE{get{ return  _CALL_CODE;}set{ _CALL_CODE = value;}}
		System.String _BRAND_NAME = string.Empty;
		[DataMember]
		public System.String  BRAND_NAME{get{ return  _BRAND_NAME;}set{ _BRAND_NAME = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _FILE_CODE = string.Empty;
		[DataMember]
		public System.String  FILE_CODE{get{ return  _FILE_CODE;}set{ _FILE_CODE = value;}}
		DateSpan _MAINTENANCE_PERIOD_DATE = null;
		[DataMember]
		public DateSpan  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.Decimal _IS_SELF_RESTRAINT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_SELF_RESTRAINT{get{ return  _IS_SELF_RESTRAINT;}set{ _IS_SELF_RESTRAINT = value;}}
		System.String _OPERATING_MACHINE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  OPERATING_MACHINE_TYPE_ID{get{ return  _OPERATING_MACHINE_TYPE_ID;}set{ _OPERATING_MACHINE_TYPE_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _PURCHASE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  PURCHASE_TYPE_ID{get{ return  _PURCHASE_TYPE_ID;}set{ _PURCHASE_TYPE_ID = value;}}
		System.String _MAINTAIN_CONTACT = string.Empty;
		[DataMember]
		public System.String  MAINTAIN_CONTACT{get{ return  _MAINTAIN_CONTACT;}set{ _MAINTAIN_CONTACT = value;}}
		System.Decimal _DEPR_MONTH_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DEPR_MONTH_AMOUNT{get{ return  _DEPR_MONTH_AMOUNT;}set{ _DEPR_MONTH_AMOUNT = value;}}
		System.Decimal _MAINTAIN_PERIOD = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MAINTAIN_PERIOD{get{ return  _MAINTAIN_PERIOD;}set{ _MAINTAIN_PERIOD = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.Decimal _IS_IN_ACCOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_IN_ACCOUNT{get{ return  _IS_IN_ACCOUNT;}set{ _IS_IN_ACCOUNT = value;}}
		System.String _FINANCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  FINANCE_TYPE_ID{get{ return  _FINANCE_TYPE_ID;}set{ _FINANCE_TYPE_ID = value;}}
		System.String _SUBJECTION_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  SUBJECTION_DEPT_ID{get{ return  _SUBJECTION_DEPT_ID;}set{ _SUBJECTION_DEPT_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _RUDIMENTAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE{get{ return  _RUDIMENTAL_VALUE;}set{ _RUDIMENTAL_VALUE = value;}}
		DateSpan _OUT_ACCOUNT_DATE = null;
		[DataMember]
		public DateSpan  OUT_ACCOUNT_DATE{get{ return  _OUT_ACCOUNT_DATE;}set{ _OUT_ACCOUNT_DATE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PRD_PLACE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  PRD_PLACE_TYPE_ID{get{ return  _PRD_PLACE_TYPE_ID;}set{ _PRD_PLACE_TYPE_ID = value;}}
		System.Decimal _IS_LARGE_ME = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_LARGE_ME{get{ return  _IS_LARGE_ME;}set{ _IS_LARGE_ME = value;}}
		System.String _SEQ_NUMBER = string.Empty;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.String _USING_USER_ID = string.Empty;
		[DataMember]
		public System.String  USING_USER_ID{get{ return  _USING_USER_ID;}set{ _USING_USER_ID = value;}}
		System.String _ASSETS_STATE = string.Empty;
		[DataMember]
		public System.String  ASSETS_STATE{get{ return  _ASSETS_STATE;}set{ _ASSETS_STATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _IN_ACCOUNT_DATE = null;
		[DataMember]
		public DateSpan  IN_ACCOUNT_DATE{get{ return  _IN_ACCOUNT_DATE;}set{ _IN_ACCOUNT_DATE = value;}}
		System.Decimal _IS_FORCE_SENSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_FORCE_SENSE{get{ return  _IS_FORCE_SENSE;}set{ _IS_FORCE_SENSE = value;}}
		System.String _CAPITAL_SOURCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  CAPITAL_SOURCE_TYPE_ID{get{ return  _CAPITAL_SOURCE_TYPE_ID;}set{ _CAPITAL_SOURCE_TYPE_ID = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		DateSpan _PURCHASE_DATE = null;
		[DataMember]
		public DateSpan  PURCHASE_DATE{get{ return  _PURCHASE_DATE;}set{ _PURCHASE_DATE = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String _INTERNATIONAL_CODE = string.Empty;
		[DataMember]
		public System.String  INTERNATIONAL_CODE{get{ return  _INTERNATIONAL_CODE;}set{ _INTERNATIONAL_CODE = value;}}
		System.Decimal _NET_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NET_AMOUNT{get{ return  _NET_AMOUNT;}set{ _NET_AMOUNT = value;}}
		System.Decimal _MAINTAIN_AMOUNT = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MAINTAIN_AMOUNT{get{ return  _MAINTAIN_AMOUNT;}set{ _MAINTAIN_AMOUNT = value;}}
		System.String _BIZ_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  BIZ_TYPE_ID{get{ return  _BIZ_TYPE_ID;}set{ _BIZ_TYPE_ID = value;}}
		System.String _PROVIDER_ID = string.Empty;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.String _CUSTODY_USER_ID = string.Empty;
		[DataMember]
		public System.String  CUSTODY_USER_ID{get{ return  _CUSTODY_USER_ID;}set{ _CUSTODY_USER_ID = value;}}
		System.String _VEHICLE_USE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  VEHICLE_USE_TYPE_ID{get{ return  _VEHICLE_USE_TYPE_ID;}set{ _VEHICLE_USE_TYPE_ID = value;}}
		System.String _MACHINE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  MACHINE_TYPE_ID{get{ return  _MACHINE_TYPE_ID;}set{ _MACHINE_TYPE_ID = value;}}
		System.Decimal _RUDIMENTAL_VALUE_RATIO = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE_RATIO{get{ return  _RUDIMENTAL_VALUE_RATIO;}set{ _RUDIMENTAL_VALUE_RATIO = value;}}
		System.Decimal _ORIGINAL_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String _OWNERSHIP_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  OWNERSHIP_TYPE_ID{get{ return  _OWNERSHIP_TYPE_ID;}set{ _OWNERSHIP_TYPE_ID = value;}}
		System.String _CONTRACT_CODE = string.Empty;
		[DataMember]
		public System.String  CONTRACT_CODE{get{ return  _CONTRACT_CODE;}set{ _CONTRACT_CODE = value;}}
		System.String _SPELL_CODE = string.Empty;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String _VEHICLE_CODE = string.Empty;
		[DataMember]
		public System.String  VEHICLE_CODE{get{ return  _VEHICLE_CODE;}set{ _VEHICLE_CODE = value;}}
		System.String _USING_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String _PRD_CODE = string.Empty;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String _PICTURE = string.Empty;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		DateSpan _ENABLE_DATE = null;
		[DataMember]
		public DateSpan  ENABLE_DATE{get{ return  _ENABLE_DATE;}set{ _ENABLE_DATE = value;}}
		System.Decimal _ADD_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ADD_VALUE{get{ return  _ADD_VALUE;}set{ _ADD_VALUE = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.Decimal _NET_VALUE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String _DEPR_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  DEPR_TYPE_ID{get{ return  _DEPR_TYPE_ID;}set{ _DEPR_TYPE_ID = value;}}
		System.String _USE_STATE = string.Empty;
		[DataMember]
		public System.String  USE_STATE{get{ return  _USE_STATE;}set{ _USE_STATE = value;}}
		System.Decimal _REF_PRICE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REF_PRICE{get{ return  _REF_PRICE;}set{ _REF_PRICE = value;}}
		System.Decimal _DISPOSITION_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  DISPOSITION_MONEY{get{ return  _DISPOSITION_MONEY;}set{ _DISPOSITION_MONEY = value;}}
		System.String _FORCE_SENSE_SPAN = string.Empty;
		[DataMember]
		public System.String  FORCE_SENSE_SPAN{get{ return  _FORCE_SENSE_SPAN;}set{ _FORCE_SENSE_SPAN = value;}}
		System.Decimal _VEHICLE_CC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  VEHICLE_CC{get{ return  _VEHICLE_CC;}set{ _VEHICLE_CC = value;}}
		System.String _CUSTOM_CODE = string.Empty;
		[DataMember]
		public System.String  CUSTOM_CODE{get{ return  _CUSTOM_CODE;}set{ _CUSTOM_CODE = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal _IS_DEPR = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_DEPR{get{ return  _IS_DEPR;}set{ _IS_DEPR = value;}}
		System.String _ECONOMIC_USE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ECONOMIC_USE_TYPE_ID{get{ return  _ECONOMIC_USE_TYPE_ID;}set{ _ECONOMIC_USE_TYPE_ID = value;}}
		System.String _CUSTODY_LEVEL_ID = string.Empty;
		[DataMember]
		public System.String  CUSTODY_LEVEL_ID{get{ return  _CUSTODY_LEVEL_ID;}set{ _CUSTODY_LEVEL_ID = value;}}
		System.String _ACQUIRE_OWNERSHIP_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ACQUIRE_OWNERSHIP_TYPE_ID{get{ return  _ACQUIRE_OWNERSHIP_TYPE_ID;}set{ _ACQUIRE_OWNERSHIP_TYPE_ID = value;}}
		System.String _CUSTODY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CUSTODY_DEPT_ID{get{ return  _CUSTODY_DEPT_ID;}set{ _CUSTODY_DEPT_ID = value;}}
		System.String _NATIONALITY_ID = string.Empty;
		[DataMember]
		public System.String  NATIONALITY_ID{get{ return  _NATIONALITY_ID;}set{ _NATIONALITY_ID = value;}}
		System.String _STORE_ADDRESS = string.Empty;
		[DataMember]
		public System.String  STORE_ADDRESS{get{ return  _STORE_ADDRESS;}set{ _STORE_ADDRESS = value;}}
		System.Decimal _IS_METERING = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_METERING{get{ return  _IS_METERING;}set{ _IS_METERING = value;}}
		System.Decimal _IS_AFFIX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_AFFIX{get{ return  _IS_AFFIX;}set{ _IS_AFFIX = value;}}
		System.String _FIVE_STROKE_CODE = string.Empty;
		[DataMember]
		public System.String  FIVE_STROKE_CODE{get{ return  _FIVE_STROKE_CODE;}set{ _FIVE_STROKE_CODE = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _VALUE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  VALUE_TYPE_ID{get{ return  _VALUE_TYPE_ID;}set{ _VALUE_TYPE_ID = value;}}
		System.String _MACHINE_MANAGE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  MACHINE_MANAGE_TYPE_ID{get{ return  _MACHINE_MANAGE_TYPE_ID;}set{ _MACHINE_MANAGE_TYPE_ID = value;}}
		System.Decimal _METERING_PERIOD = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  METERING_PERIOD{get{ return  _METERING_PERIOD;}set{ _METERING_PERIOD = value;}}
		System.Decimal _IS_ASSETS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_ASSETS{get{ return  _IS_ASSETS;}set{ _IS_ASSETS = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal _ACCUMULATED_DEPRECIATION = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ACCUMULATED_DEPRECIATION{get{ return  _ACCUMULATED_DEPRECIATION;}set{ _ACCUMULATED_DEPRECIATION = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _ENERGY_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ENERGY_TYPE_ID{get{ return  _ENERGY_TYPE_ID;}set{ _ENERGY_TYPE_ID = value;}}
		System.String _LICENCE_CODE = string.Empty;
		[DataMember]
		public System.String  LICENCE_CODE{get{ return  _LICENCE_CODE;}set{ _LICENCE_CODE = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		DateSpan _PRD_DATE = null;
		[DataMember]
		public DateSpan  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _CARD_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  CARD_TYPE_ID{get{ return  _CARD_TYPE_ID;}set{ _CARD_TYPE_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS")]
	public partial class DisplayObject_MCE_B_ASSETS:EntityObject_MCE_B_ASSETS
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _REF_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String REF_DEPT_ID_NAME{get{ return  _REF_DEPT_ID_NAME;}set{ _REF_DEPT_ID_NAME = value;}}
		 System.String _ACQUIRE_USE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ACQUIRE_USE_TYPE_ID_NAME{get{ return  _ACQUIRE_USE_TYPE_ID_NAME;}set{ _ACQUIRE_USE_TYPE_ID_NAME = value;}}
		 System.String _IS_SELF_RESTRAINT_NAME = string.Empty;
		[DataMember]
		public System.String IS_SELF_RESTRAINT_NAME{get{ return  _IS_SELF_RESTRAINT_NAME;}set{ _IS_SELF_RESTRAINT_NAME = value;}}
		 System.String _OPERATING_MACHINE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String OPERATING_MACHINE_TYPE_ID_NAME{get{ return  _OPERATING_MACHINE_TYPE_ID_NAME;}set{ _OPERATING_MACHINE_TYPE_ID_NAME = value;}}
		 System.String _PURCHASE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String PURCHASE_TYPE_ID_NAME{get{ return  _PURCHASE_TYPE_ID_NAME;}set{ _PURCHASE_TYPE_ID_NAME = value;}}
		 System.String _IS_IN_ACCOUNT_NAME = string.Empty;
		[DataMember]
		public System.String IS_IN_ACCOUNT_NAME{get{ return  _IS_IN_ACCOUNT_NAME;}set{ _IS_IN_ACCOUNT_NAME = value;}}
		 System.String _FINANCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String FINANCE_TYPE_ID_NAME{get{ return  _FINANCE_TYPE_ID_NAME;}set{ _FINANCE_TYPE_ID_NAME = value;}}
		 System.String _SUBJECTION_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String SUBJECTION_DEPT_ID_NAME{get{ return  _SUBJECTION_DEPT_ID_NAME;}set{ _SUBJECTION_DEPT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _PRD_PLACE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_PLACE_TYPE_ID_NAME{get{ return  _PRD_PLACE_TYPE_ID_NAME;}set{ _PRD_PLACE_TYPE_ID_NAME = value;}}
		 System.String _IS_LARGE_ME_NAME = string.Empty;
		[DataMember]
		public System.String IS_LARGE_ME_NAME{get{ return  _IS_LARGE_ME_NAME;}set{ _IS_LARGE_ME_NAME = value;}}
		 System.String _USING_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_USER_ID_NAME{get{ return  _USING_USER_ID_NAME;}set{ _USING_USER_ID_NAME = value;}}
		 System.String _ASSETS_STATE_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_STATE_NAME{get{ return  _ASSETS_STATE_NAME;}set{ _ASSETS_STATE_NAME = value;}}
		 System.String _IS_FORCE_SENSE_NAME = string.Empty;
		[DataMember]
		public System.String IS_FORCE_SENSE_NAME{get{ return  _IS_FORCE_SENSE_NAME;}set{ _IS_FORCE_SENSE_NAME = value;}}
		 System.String _CAPITAL_SOURCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String CAPITAL_SOURCE_TYPE_ID_NAME{get{ return  _CAPITAL_SOURCE_TYPE_ID_NAME;}set{ _CAPITAL_SOURCE_TYPE_ID_NAME = value;}}
		 System.String _BIZ_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BIZ_TYPE_ID_NAME{get{ return  _BIZ_TYPE_ID_NAME;}set{ _BIZ_TYPE_ID_NAME = value;}}
		 System.String _PROVIDER_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROVIDER_ID_NAME{get{ return  _PROVIDER_ID_NAME;}set{ _PROVIDER_ID_NAME = value;}}
		 System.String _CUSTODY_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String CUSTODY_USER_ID_NAME{get{ return  _CUSTODY_USER_ID_NAME;}set{ _CUSTODY_USER_ID_NAME = value;}}
		 System.String _VEHICLE_USE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String VEHICLE_USE_TYPE_ID_NAME{get{ return  _VEHICLE_USE_TYPE_ID_NAME;}set{ _VEHICLE_USE_TYPE_ID_NAME = value;}}
		 System.String _MACHINE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String MACHINE_TYPE_ID_NAME{get{ return  _MACHINE_TYPE_ID_NAME;}set{ _MACHINE_TYPE_ID_NAME = value;}}
		 System.String _OWNERSHIP_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String OWNERSHIP_TYPE_ID_NAME{get{ return  _OWNERSHIP_TYPE_ID_NAME;}set{ _OWNERSHIP_TYPE_ID_NAME = value;}}
		 System.String _USING_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}
		 System.String _NAME_NAME = string.Empty;
		[DataMember]
		public System.String NAME_NAME{get{ return  _NAME_NAME;}set{ _NAME_NAME = value;}}
		 System.String _DEPR_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPR_TYPE_ID_NAME{get{ return  _DEPR_TYPE_ID_NAME;}set{ _DEPR_TYPE_ID_NAME = value;}}
		 System.String _USE_STATE_NAME = string.Empty;
		[DataMember]
		public System.String USE_STATE_NAME{get{ return  _USE_STATE_NAME;}set{ _USE_STATE_NAME = value;}}
		 System.String _IS_DEPR_NAME = string.Empty;
		[DataMember]
		public System.String IS_DEPR_NAME{get{ return  _IS_DEPR_NAME;}set{ _IS_DEPR_NAME = value;}}
		 System.String _ECONOMIC_USE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ECONOMIC_USE_TYPE_ID_NAME{get{ return  _ECONOMIC_USE_TYPE_ID_NAME;}set{ _ECONOMIC_USE_TYPE_ID_NAME = value;}}
		 System.String _CUSTODY_LEVEL_ID_NAME = string.Empty;
		[DataMember]
		public System.String CUSTODY_LEVEL_ID_NAME{get{ return  _CUSTODY_LEVEL_ID_NAME;}set{ _CUSTODY_LEVEL_ID_NAME = value;}}
		 System.String _ACQUIRE_OWNERSHIP_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ACQUIRE_OWNERSHIP_TYPE_ID_NAME{get{ return  _ACQUIRE_OWNERSHIP_TYPE_ID_NAME;}set{ _ACQUIRE_OWNERSHIP_TYPE_ID_NAME = value;}}
		 System.String _CUSTODY_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String CUSTODY_DEPT_ID_NAME{get{ return  _CUSTODY_DEPT_ID_NAME;}set{ _CUSTODY_DEPT_ID_NAME = value;}}
		 System.String _NATIONALITY_ID_NAME = string.Empty;
		[DataMember]
		public System.String NATIONALITY_ID_NAME{get{ return  _NATIONALITY_ID_NAME;}set{ _NATIONALITY_ID_NAME = value;}}
		 System.String _IS_METERING_NAME = string.Empty;
		[DataMember]
		public System.String IS_METERING_NAME{get{ return  _IS_METERING_NAME;}set{ _IS_METERING_NAME = value;}}
		 System.String _IS_AFFIX_NAME = string.Empty;
		[DataMember]
		public System.String IS_AFFIX_NAME{get{ return  _IS_AFFIX_NAME;}set{ _IS_AFFIX_NAME = value;}}
		 System.String _VALUE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String VALUE_TYPE_ID_NAME{get{ return  _VALUE_TYPE_ID_NAME;}set{ _VALUE_TYPE_ID_NAME = value;}}
		 System.String _MACHINE_MANAGE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String MACHINE_MANAGE_TYPE_ID_NAME{get{ return  _MACHINE_MANAGE_TYPE_ID_NAME;}set{ _MACHINE_MANAGE_TYPE_ID_NAME = value;}}
		 System.String _IS_ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String IS_ASSETS_NAME{get{ return  _IS_ASSETS_NAME;}set{ _IS_ASSETS_NAME = value;}}
		 System.String _ENERGY_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ENERGY_TYPE_ID_NAME{get{ return  _ENERGY_TYPE_ID_NAME;}set{ _ENERGY_TYPE_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _CARD_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String CARD_TYPE_ID_NAME{get{ return  _CARD_TYPE_ID_NAME;}set{ _CARD_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS")]
	public partial class EntityObject_MCE_B_ASSETS:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _MAINTAIN_MONEY;
		[DataMember]
		public System.Decimal  MAINTAIN_MONEY{get{ return  _MAINTAIN_MONEY;}set{ _MAINTAIN_MONEY = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.Decimal  _DEPR_YEAR_AMOUNT;
		[DataMember]
		public System.Decimal  DEPR_YEAR_AMOUNT{get{ return  _DEPR_YEAR_AMOUNT;}set{ _DEPR_YEAR_AMOUNT = value;}}
		System.String  _REF_DEPT_ID;
		[DataMember]
		public System.String  REF_DEPT_ID{get{ return  _REF_DEPT_ID;}set{ _REF_DEPT_ID = value;}}
		System.String  _EN_NAME;
		[DataMember]
		public System.String  EN_NAME{get{ return  _EN_NAME;}set{ _EN_NAME = value;}}
		System.String  _ACQUIRE_USE_TYPE_ID;
		[DataMember]
		public System.String  ACQUIRE_USE_TYPE_ID{get{ return  _ACQUIRE_USE_TYPE_ID;}set{ _ACQUIRE_USE_TYPE_ID = value;}}
		System.Decimal  _PREDICT_NET_RUDIMENTAL_VALUE;
		[DataMember]
		public System.Decimal  PREDICT_NET_RUDIMENTAL_VALUE{get{ return  _PREDICT_NET_RUDIMENTAL_VALUE;}set{ _PREDICT_NET_RUDIMENTAL_VALUE = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.Decimal  _SERVICE_LIFE;
		[DataMember]
		public System.Decimal  SERVICE_LIFE{get{ return  _SERVICE_LIFE;}set{ _SERVICE_LIFE = value;}}
		System.String  _CALL_CODE;
		[DataMember]
		public System.String  CALL_CODE{get{ return  _CALL_CODE;}set{ _CALL_CODE = value;}}
		System.String  _BRAND_NAME;
		[DataMember]
		public System.String  BRAND_NAME{get{ return  _BRAND_NAME;}set{ _BRAND_NAME = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _FILE_CODE;
		[DataMember]
		public System.String  FILE_CODE{get{ return  _FILE_CODE;}set{ _FILE_CODE = value;}}
		System.DateTime  _MAINTENANCE_PERIOD_DATE;
		[DataMember]
		public System.DateTime  MAINTENANCE_PERIOD_DATE{get{ return  _MAINTENANCE_PERIOD_DATE;}set{ _MAINTENANCE_PERIOD_DATE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.Decimal  _IS_SELF_RESTRAINT;
		[DataMember]
		public System.Decimal  IS_SELF_RESTRAINT{get{ return  _IS_SELF_RESTRAINT;}set{ _IS_SELF_RESTRAINT = value;}}
		System.String  _OPERATING_MACHINE_TYPE_ID;
		[DataMember]
		public System.String  OPERATING_MACHINE_TYPE_ID{get{ return  _OPERATING_MACHINE_TYPE_ID;}set{ _OPERATING_MACHINE_TYPE_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _PURCHASE_TYPE_ID;
		[DataMember]
		public System.String  PURCHASE_TYPE_ID{get{ return  _PURCHASE_TYPE_ID;}set{ _PURCHASE_TYPE_ID = value;}}
		System.String  _MAINTAIN_CONTACT;
		[DataMember]
		public System.String  MAINTAIN_CONTACT{get{ return  _MAINTAIN_CONTACT;}set{ _MAINTAIN_CONTACT = value;}}
		System.Decimal  _DEPR_MONTH_AMOUNT;
		[DataMember]
		public System.Decimal  DEPR_MONTH_AMOUNT{get{ return  _DEPR_MONTH_AMOUNT;}set{ _DEPR_MONTH_AMOUNT = value;}}
		System.Decimal  _MAINTAIN_PERIOD;
		[DataMember]
		public System.Decimal  MAINTAIN_PERIOD{get{ return  _MAINTAIN_PERIOD;}set{ _MAINTAIN_PERIOD = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.Decimal  _IS_IN_ACCOUNT;
		[DataMember]
		public System.Decimal  IS_IN_ACCOUNT{get{ return  _IS_IN_ACCOUNT;}set{ _IS_IN_ACCOUNT = value;}}
		System.String  _FINANCE_TYPE_ID;
		[DataMember]
		public System.String  FINANCE_TYPE_ID{get{ return  _FINANCE_TYPE_ID;}set{ _FINANCE_TYPE_ID = value;}}
		System.String  _SUBJECTION_DEPT_ID;
		[DataMember]
		public System.String  SUBJECTION_DEPT_ID{get{ return  _SUBJECTION_DEPT_ID;}set{ _SUBJECTION_DEPT_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _RUDIMENTAL_VALUE;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE{get{ return  _RUDIMENTAL_VALUE;}set{ _RUDIMENTAL_VALUE = value;}}
		System.DateTime  _OUT_ACCOUNT_DATE;
		[DataMember]
		public System.DateTime  OUT_ACCOUNT_DATE{get{ return  _OUT_ACCOUNT_DATE;}set{ _OUT_ACCOUNT_DATE = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PRD_PLACE_TYPE_ID;
		[DataMember]
		public System.String  PRD_PLACE_TYPE_ID{get{ return  _PRD_PLACE_TYPE_ID;}set{ _PRD_PLACE_TYPE_ID = value;}}
		System.Decimal  _IS_LARGE_ME;
		[DataMember]
		public System.Decimal  IS_LARGE_ME{get{ return  _IS_LARGE_ME;}set{ _IS_LARGE_ME = value;}}
		System.String  _SEQ_NUMBER;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.String  _USING_USER_ID;
		[DataMember]
		public System.String  USING_USER_ID{get{ return  _USING_USER_ID;}set{ _USING_USER_ID = value;}}
		System.String  _ASSETS_STATE;
		[DataMember]
		public System.String  ASSETS_STATE{get{ return  _ASSETS_STATE;}set{ _ASSETS_STATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _IN_ACCOUNT_DATE;
		[DataMember]
		public System.DateTime  IN_ACCOUNT_DATE{get{ return  _IN_ACCOUNT_DATE;}set{ _IN_ACCOUNT_DATE = value;}}
		System.Decimal  _IS_FORCE_SENSE;
		[DataMember]
		public System.Decimal  IS_FORCE_SENSE{get{ return  _IS_FORCE_SENSE;}set{ _IS_FORCE_SENSE = value;}}
		System.String  _CAPITAL_SOURCE_TYPE_ID;
		[DataMember]
		public System.String  CAPITAL_SOURCE_TYPE_ID{get{ return  _CAPITAL_SOURCE_TYPE_ID;}set{ _CAPITAL_SOURCE_TYPE_ID = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.DateTime  _PURCHASE_DATE;
		[DataMember]
		public System.DateTime  PURCHASE_DATE{get{ return  _PURCHASE_DATE;}set{ _PURCHASE_DATE = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String  _INTERNATIONAL_CODE;
		[DataMember]
		public System.String  INTERNATIONAL_CODE{get{ return  _INTERNATIONAL_CODE;}set{ _INTERNATIONAL_CODE = value;}}
		System.Decimal  _NET_AMOUNT;
		[DataMember]
		public System.Decimal  NET_AMOUNT{get{ return  _NET_AMOUNT;}set{ _NET_AMOUNT = value;}}
		System.Decimal  _MAINTAIN_AMOUNT;
		[DataMember]
		public System.Decimal  MAINTAIN_AMOUNT{get{ return  _MAINTAIN_AMOUNT;}set{ _MAINTAIN_AMOUNT = value;}}
		System.String  _BIZ_TYPE_ID;
		[DataMember]
		public System.String  BIZ_TYPE_ID{get{ return  _BIZ_TYPE_ID;}set{ _BIZ_TYPE_ID = value;}}
		System.String  _PROVIDER_ID;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.String  _CUSTODY_USER_ID;
		[DataMember]
		public System.String  CUSTODY_USER_ID{get{ return  _CUSTODY_USER_ID;}set{ _CUSTODY_USER_ID = value;}}
		System.String  _VEHICLE_USE_TYPE_ID;
		[DataMember]
		public System.String  VEHICLE_USE_TYPE_ID{get{ return  _VEHICLE_USE_TYPE_ID;}set{ _VEHICLE_USE_TYPE_ID = value;}}
		System.String  _MACHINE_TYPE_ID;
		[DataMember]
		public System.String  MACHINE_TYPE_ID{get{ return  _MACHINE_TYPE_ID;}set{ _MACHINE_TYPE_ID = value;}}
		System.Decimal  _RUDIMENTAL_VALUE_RATIO;
		[DataMember]
		public System.Decimal  RUDIMENTAL_VALUE_RATIO{get{ return  _RUDIMENTAL_VALUE_RATIO;}set{ _RUDIMENTAL_VALUE_RATIO = value;}}
		System.Decimal  _ORIGINAL_VALUE;
		[DataMember]
		public System.Decimal  ORIGINAL_VALUE{get{ return  _ORIGINAL_VALUE;}set{ _ORIGINAL_VALUE = value;}}
		System.String  _OWNERSHIP_TYPE_ID;
		[DataMember]
		public System.String  OWNERSHIP_TYPE_ID{get{ return  _OWNERSHIP_TYPE_ID;}set{ _OWNERSHIP_TYPE_ID = value;}}
		System.String  _CONTRACT_CODE;
		[DataMember]
		public System.String  CONTRACT_CODE{get{ return  _CONTRACT_CODE;}set{ _CONTRACT_CODE = value;}}
		System.String  _SPELL_CODE;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String  _VEHICLE_CODE;
		[DataMember]
		public System.String  VEHICLE_CODE{get{ return  _VEHICLE_CODE;}set{ _VEHICLE_CODE = value;}}
		System.String  _USING_DEPT_ID;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String  _PRD_CODE;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String  _PICTURE;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.DateTime  _ENABLE_DATE;
		[DataMember]
		public System.DateTime  ENABLE_DATE{get{ return  _ENABLE_DATE;}set{ _ENABLE_DATE = value;}}
		System.Decimal  _ADD_VALUE;
		[DataMember]
		public System.Decimal  ADD_VALUE{get{ return  _ADD_VALUE;}set{ _ADD_VALUE = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.Decimal  _NET_VALUE;
		[DataMember]
		public System.Decimal  NET_VALUE{get{ return  _NET_VALUE;}set{ _NET_VALUE = value;}}
		System.String  _DEPR_TYPE_ID;
		[DataMember]
		public System.String  DEPR_TYPE_ID{get{ return  _DEPR_TYPE_ID;}set{ _DEPR_TYPE_ID = value;}}
		System.String  _USE_STATE;
		[DataMember]
		public System.String  USE_STATE{get{ return  _USE_STATE;}set{ _USE_STATE = value;}}
		System.Decimal  _REF_PRICE;
		[DataMember]
		public System.Decimal  REF_PRICE{get{ return  _REF_PRICE;}set{ _REF_PRICE = value;}}
		System.Decimal  _DISPOSITION_MONEY;
		[DataMember]
		public System.Decimal  DISPOSITION_MONEY{get{ return  _DISPOSITION_MONEY;}set{ _DISPOSITION_MONEY = value;}}
		System.String  _FORCE_SENSE_SPAN;
		[DataMember]
		public System.String  FORCE_SENSE_SPAN{get{ return  _FORCE_SENSE_SPAN;}set{ _FORCE_SENSE_SPAN = value;}}
		System.Decimal  _VEHICLE_CC;
		[DataMember]
		public System.Decimal  VEHICLE_CC{get{ return  _VEHICLE_CC;}set{ _VEHICLE_CC = value;}}
		System.String  _CUSTOM_CODE;
		[DataMember]
		public System.String  CUSTOM_CODE{get{ return  _CUSTOM_CODE;}set{ _CUSTOM_CODE = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal  _IS_DEPR;
		[DataMember]
		public System.Decimal  IS_DEPR{get{ return  _IS_DEPR;}set{ _IS_DEPR = value;}}
		System.String  _ECONOMIC_USE_TYPE_ID;
		[DataMember]
		public System.String  ECONOMIC_USE_TYPE_ID{get{ return  _ECONOMIC_USE_TYPE_ID;}set{ _ECONOMIC_USE_TYPE_ID = value;}}
		System.String  _CUSTODY_LEVEL_ID;
		[DataMember]
		public System.String  CUSTODY_LEVEL_ID{get{ return  _CUSTODY_LEVEL_ID;}set{ _CUSTODY_LEVEL_ID = value;}}
		System.String  _ACQUIRE_OWNERSHIP_TYPE_ID;
		[DataMember]
		public System.String  ACQUIRE_OWNERSHIP_TYPE_ID{get{ return  _ACQUIRE_OWNERSHIP_TYPE_ID;}set{ _ACQUIRE_OWNERSHIP_TYPE_ID = value;}}
		System.String  _CUSTODY_DEPT_ID;
		[DataMember]
		public System.String  CUSTODY_DEPT_ID{get{ return  _CUSTODY_DEPT_ID;}set{ _CUSTODY_DEPT_ID = value;}}
		System.String  _NATIONALITY_ID;
		[DataMember]
		public System.String  NATIONALITY_ID{get{ return  _NATIONALITY_ID;}set{ _NATIONALITY_ID = value;}}
		System.String  _STORE_ADDRESS;
		[DataMember]
		public System.String  STORE_ADDRESS{get{ return  _STORE_ADDRESS;}set{ _STORE_ADDRESS = value;}}
		System.Decimal  _IS_METERING;
		[DataMember]
		public System.Decimal  IS_METERING{get{ return  _IS_METERING;}set{ _IS_METERING = value;}}
		System.Decimal  _IS_AFFIX;
		[DataMember]
		public System.Decimal  IS_AFFIX{get{ return  _IS_AFFIX;}set{ _IS_AFFIX = value;}}
		System.String  _FIVE_STROKE_CODE;
		[DataMember]
		public System.String  FIVE_STROKE_CODE{get{ return  _FIVE_STROKE_CODE;}set{ _FIVE_STROKE_CODE = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _VALUE_TYPE_ID;
		[DataMember]
		public System.String  VALUE_TYPE_ID{get{ return  _VALUE_TYPE_ID;}set{ _VALUE_TYPE_ID = value;}}
		System.String  _MACHINE_MANAGE_TYPE_ID;
		[DataMember]
		public System.String  MACHINE_MANAGE_TYPE_ID{get{ return  _MACHINE_MANAGE_TYPE_ID;}set{ _MACHINE_MANAGE_TYPE_ID = value;}}
		System.Decimal  _METERING_PERIOD;
		[DataMember]
		public System.Decimal  METERING_PERIOD{get{ return  _METERING_PERIOD;}set{ _METERING_PERIOD = value;}}
		System.Decimal  _IS_ASSETS;
		[DataMember]
		public System.Decimal  IS_ASSETS{get{ return  _IS_ASSETS;}set{ _IS_ASSETS = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.Decimal  _ACCUMULATED_DEPRECIATION;
		[DataMember]
		public System.Decimal  ACCUMULATED_DEPRECIATION{get{ return  _ACCUMULATED_DEPRECIATION;}set{ _ACCUMULATED_DEPRECIATION = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ENERGY_TYPE_ID;
		[DataMember]
		public System.String  ENERGY_TYPE_ID{get{ return  _ENERGY_TYPE_ID;}set{ _ENERGY_TYPE_ID = value;}}
		System.String  _LICENCE_CODE;
		[DataMember]
		public System.String  LICENCE_CODE{get{ return  _LICENCE_CODE;}set{ _LICENCE_CODE = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.DateTime  _PRD_DATE;
		[DataMember]
		public System.DateTime  PRD_DATE{get{ return  _PRD_DATE;}set{ _PRD_DATE = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _CARD_TYPE_ID;
		[DataMember]
		public System.String  CARD_TYPE_ID{get{ return  _CARD_TYPE_ID;}set{ _CARD_TYPE_ID = value;}}

		#endregion 
	}	
}
