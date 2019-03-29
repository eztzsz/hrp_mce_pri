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
	[DataObject("MCE_B_ASSETS_METER_CHECK")]
	public partial class CauseObject_MCE_B_ASSETS_METER_CHECK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _PRD_ID = string.Empty;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _NEXT_IDENTIFICATION = null;
		[DataMember]
		public DateSpan  NEXT_IDENTIFICATION{get{ return  _NEXT_IDENTIFICATION;}set{ _NEXT_IDENTIFICATION = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _PRD_CODE = string.Empty;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String _TIME_ZONE = string.Empty;
		[DataMember]
		public System.String  TIME_ZONE{get{ return  _TIME_ZONE;}set{ _TIME_ZONE = value;}}
		System.String _METER_TYPE = string.Empty;
		[DataMember]
		public System.String  METER_TYPE{get{ return  _METER_TYPE;}set{ _METER_TYPE = value;}}
		System.String _HEAD_USER_ID = string.Empty;
		[DataMember]
		public System.String  HEAD_USER_ID{get{ return  _HEAD_USER_ID;}set{ _HEAD_USER_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		DateSpan _ACTUAL_IDENTIFICATION = null;
		[DataMember]
		public DateSpan  ACTUAL_IDENTIFICATION{get{ return  _ACTUAL_IDENTIFICATION;}set{ _ACTUAL_IDENTIFICATION = value;}}
		System.String _METER_CLASS = string.Empty;
		[DataMember]
		public System.String  METER_CLASS{get{ return  _METER_CLASS;}set{ _METER_CLASS = value;}}
		System.Decimal _EARLY_WARNING_DAYS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EARLY_WARNING_DAYS{get{ return  _EARLY_WARNING_DAYS;}set{ _EARLY_WARNING_DAYS = value;}}
		System.String _CHECK_PERSON = string.Empty;
		[DataMember]
		public System.String  CHECK_PERSON{get{ return  _CHECK_PERSON;}set{ _CHECK_PERSON = value;}}
		System.String _CHECK_ORG = string.Empty;
		[DataMember]
		public System.String  CHECK_ORG{get{ return  _CHECK_ORG;}set{ _CHECK_ORG = value;}}
		System.Decimal _RESULT_ID = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RESULT_ID{get{ return  _RESULT_ID;}set{ _RESULT_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		DateSpan _PLAN_IDENTIFICATION = null;
		[DataMember]
		public DateSpan  PLAN_IDENTIFICATION{get{ return  _PLAN_IDENTIFICATION;}set{ _PLAN_IDENTIFICATION = value;}}
		System.Decimal _IDENTIFICATION_TYPE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IDENTIFICATION_TYPE{get{ return  _IDENTIFICATION_TYPE;}set{ _IDENTIFICATION_TYPE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.Decimal _IDENTIFICATION_CYCLE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IDENTIFICATION_CYCLE{get{ return  _IDENTIFICATION_CYCLE;}set{ _IDENTIFICATION_CYCLE = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _DIVID_VALUE = string.Empty;
		[DataMember]
		public System.String  DIVID_VALUE{get{ return  _DIVID_VALUE;}set{ _DIVID_VALUE = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String _MEASURE_RANGE = string.Empty;
		[DataMember]
		public System.String  MEASURE_RANGE{get{ return  _MEASURE_RANGE;}set{ _MEASURE_RANGE = value;}}
		System.String _METER_ID = string.Empty;
		[DataMember]
		public System.String  METER_ID{get{ return  _METER_ID;}set{ _METER_ID = value;}}
		System.String _ACCURACY_CLASS = string.Empty;
		[DataMember]
		public System.String  ACCURACY_CLASS{get{ return  _ACCURACY_CLASS;}set{ _ACCURACY_CLASS = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _USING_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _CERTIFICATE_CODE = string.Empty;
		[DataMember]
		public System.String  CERTIFICATE_CODE{get{ return  _CERTIFICATE_CODE;}set{ _CERTIFICATE_CODE = value;}}
		System.Decimal _IS_FORCE_SENSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_FORCE_SENSE{get{ return  _IS_FORCE_SENSE;}set{ _IS_FORCE_SENSE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_METER_CHECK")]
	public partial class DisplayObject_MCE_B_ASSETS_METER_CHECK:EntityObject_MCE_B_ASSETS_METER_CHECK
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PRD_ID_NAME = string.Empty;
		[DataMember]
		public System.String PRD_ID_NAME{get{ return  _PRD_ID_NAME;}set{ _PRD_ID_NAME = value;}}
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _METER_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String METER_TYPE_NAME{get{ return  _METER_TYPE_NAME;}set{ _METER_TYPE_NAME = value;}}
		 System.String _HEAD_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String HEAD_USER_ID_NAME{get{ return  _HEAD_USER_ID_NAME;}set{ _HEAD_USER_ID_NAME = value;}}
		 System.String _RESULT_ID_NAME = string.Empty;
		[DataMember]
		public System.String RESULT_ID_NAME{get{ return  _RESULT_ID_NAME;}set{ _RESULT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _IDENTIFICATION_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String IDENTIFICATION_TYPE_NAME{get{ return  _IDENTIFICATION_TYPE_NAME;}set{ _IDENTIFICATION_TYPE_NAME = value;}}
		 System.String _AUDIT_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_USER_ID_NAME{get{ return  _AUDIT_USER_ID_NAME;}set{ _AUDIT_USER_ID_NAME = value;}}
		 System.String _USING_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _IS_FORCE_SENSE_NAME = string.Empty;
		[DataMember]
		public System.String IS_FORCE_SENSE_NAME{get{ return  _IS_FORCE_SENSE_NAME;}set{ _IS_FORCE_SENSE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_METER_CHECK")]
	public partial class EntityObject_MCE_B_ASSETS_METER_CHECK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _PRD_ID;
		[DataMember]
		public System.String  PRD_ID{get{ return  _PRD_ID;}set{ _PRD_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _NEXT_IDENTIFICATION;
		[DataMember]
		public System.DateTime  NEXT_IDENTIFICATION{get{ return  _NEXT_IDENTIFICATION;}set{ _NEXT_IDENTIFICATION = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _PRD_CODE;
		[DataMember]
		public System.String  PRD_CODE{get{ return  _PRD_CODE;}set{ _PRD_CODE = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.String  _TIME_ZONE;
		[DataMember]
		public System.String  TIME_ZONE{get{ return  _TIME_ZONE;}set{ _TIME_ZONE = value;}}
		System.String  _METER_TYPE;
		[DataMember]
		public System.String  METER_TYPE{get{ return  _METER_TYPE;}set{ _METER_TYPE = value;}}
		System.String  _HEAD_USER_ID;
		[DataMember]
		public System.String  HEAD_USER_ID{get{ return  _HEAD_USER_ID;}set{ _HEAD_USER_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.DateTime  _ACTUAL_IDENTIFICATION;
		[DataMember]
		public System.DateTime  ACTUAL_IDENTIFICATION{get{ return  _ACTUAL_IDENTIFICATION;}set{ _ACTUAL_IDENTIFICATION = value;}}
		System.String  _METER_CLASS;
		[DataMember]
		public System.String  METER_CLASS{get{ return  _METER_CLASS;}set{ _METER_CLASS = value;}}
		System.Decimal  _EARLY_WARNING_DAYS;
		[DataMember]
		public System.Decimal  EARLY_WARNING_DAYS{get{ return  _EARLY_WARNING_DAYS;}set{ _EARLY_WARNING_DAYS = value;}}
		System.String  _CHECK_PERSON;
		[DataMember]
		public System.String  CHECK_PERSON{get{ return  _CHECK_PERSON;}set{ _CHECK_PERSON = value;}}
		System.String  _CHECK_ORG;
		[DataMember]
		public System.String  CHECK_ORG{get{ return  _CHECK_ORG;}set{ _CHECK_ORG = value;}}
		System.Decimal  _RESULT_ID;
		[DataMember]
		public System.Decimal  RESULT_ID{get{ return  _RESULT_ID;}set{ _RESULT_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.DateTime  _PLAN_IDENTIFICATION;
		[DataMember]
		public System.DateTime  PLAN_IDENTIFICATION{get{ return  _PLAN_IDENTIFICATION;}set{ _PLAN_IDENTIFICATION = value;}}
		System.Decimal  _IDENTIFICATION_TYPE;
		[DataMember]
		public System.Decimal  IDENTIFICATION_TYPE{get{ return  _IDENTIFICATION_TYPE;}set{ _IDENTIFICATION_TYPE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.Decimal  _IDENTIFICATION_CYCLE;
		[DataMember]
		public System.Decimal  IDENTIFICATION_CYCLE{get{ return  _IDENTIFICATION_CYCLE;}set{ _IDENTIFICATION_CYCLE = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _DIVID_VALUE;
		[DataMember]
		public System.String  DIVID_VALUE{get{ return  _DIVID_VALUE;}set{ _DIVID_VALUE = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String  _MEASURE_RANGE;
		[DataMember]
		public System.String  MEASURE_RANGE{get{ return  _MEASURE_RANGE;}set{ _MEASURE_RANGE = value;}}
		System.String  _METER_ID;
		[DataMember]
		public System.String  METER_ID{get{ return  _METER_ID;}set{ _METER_ID = value;}}
		System.String  _ACCURACY_CLASS;
		[DataMember]
		public System.String  ACCURACY_CLASS{get{ return  _ACCURACY_CLASS;}set{ _ACCURACY_CLASS = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _USING_DEPT_ID;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _CERTIFICATE_CODE;
		[DataMember]
		public System.String  CERTIFICATE_CODE{get{ return  _CERTIFICATE_CODE;}set{ _CERTIFICATE_CODE = value;}}
		System.Decimal  _IS_FORCE_SENSE;
		[DataMember]
		public System.Decimal  IS_FORCE_SENSE{get{ return  _IS_FORCE_SENSE;}set{ _IS_FORCE_SENSE = value;}}

		#endregion 
	}	
}
