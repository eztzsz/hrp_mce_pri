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
	[DataObject("MCE_D_MCE_TYPE")]
	public partial class CauseObject_MCE_D_MCE_TYPE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _IS_END = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _FINANCE_CODE = string.Empty;
		[DataMember]
		public System.String  FINANCE_CODE{get{ return  _FINANCE_CODE;}set{ _FINANCE_CODE = value;}}
		System.String _UNIT_ID = string.Empty;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _FINANCE_NAME = string.Empty;
		[DataMember]
		public System.String  FINANCE_NAME{get{ return  _FINANCE_NAME;}set{ _FINANCE_NAME = value;}}
		System.String _PARENT_ID = string.Empty;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String _CUSTOM_CODE = string.Empty;
		[DataMember]
		public System.String  CUSTOM_CODE{get{ return  _CUSTOM_CODE;}set{ _CUSTOM_CODE = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _FIVE_STROKE_CODE = string.Empty;
		[DataMember]
		public System.String  FIVE_STROKE_CODE{get{ return  _FIVE_STROKE_CODE;}set{ _FIVE_STROKE_CODE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _SPELL_CODE = string.Empty;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String _INTERNATIONAL_CODE = string.Empty;
		[DataMember]
		public System.String  INTERNATIONAL_CODE{get{ return  _INTERNATIONAL_CODE;}set{ _INTERNATIONAL_CODE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _IDIENTY_TYPE = string.Empty;
		[DataMember]
		public System.String  IDIENTY_TYPE{get{ return  _IDIENTY_TYPE;}set{ _IDIENTY_TYPE = value;}}
		System.Decimal _ORDER_INDEX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORDER_INDEX{get{ return  _ORDER_INDEX;}set{ _ORDER_INDEX = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_D_MCE_TYPE")]
	public partial class DisplayObject_MCE_D_MCE_TYPE:EntityObject_MCE_D_MCE_TYPE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _UNIT_ID_NAME = string.Empty;
		[DataMember]
		public System.String UNIT_ID_NAME{get{ return  _UNIT_ID_NAME;}set{ _UNIT_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _PARENT_ID_NAME = string.Empty;
		[DataMember]
		public System.String PARENT_ID_NAME{get{ return  _PARENT_ID_NAME;}set{ _PARENT_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_D_MCE_TYPE")]
	public partial class EntityObject_MCE_D_MCE_TYPE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _IS_END;
		[DataMember]
		public System.Decimal  IS_END{get{ return  _IS_END;}set{ _IS_END = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.Decimal  _STATUS;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _FINANCE_CODE;
		[DataMember]
		public System.String  FINANCE_CODE{get{ return  _FINANCE_CODE;}set{ _FINANCE_CODE = value;}}
		System.String  _UNIT_ID;
		[DataMember]
		public System.String  UNIT_ID{get{ return  _UNIT_ID;}set{ _UNIT_ID = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _FINANCE_NAME;
		[DataMember]
		public System.String  FINANCE_NAME{get{ return  _FINANCE_NAME;}set{ _FINANCE_NAME = value;}}
		System.String  _PARENT_ID;
		[DataMember]
		public System.String  PARENT_ID{get{ return  _PARENT_ID;}set{ _PARENT_ID = value;}}
		System.String  _CUSTOM_CODE;
		[DataMember]
		public System.String  CUSTOM_CODE{get{ return  _CUSTOM_CODE;}set{ _CUSTOM_CODE = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _FIVE_STROKE_CODE;
		[DataMember]
		public System.String  FIVE_STROKE_CODE{get{ return  _FIVE_STROKE_CODE;}set{ _FIVE_STROKE_CODE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _SPELL_CODE;
		[DataMember]
		public System.String  SPELL_CODE{get{ return  _SPELL_CODE;}set{ _SPELL_CODE = value;}}
		System.String  _INTERNATIONAL_CODE;
		[DataMember]
		public System.String  INTERNATIONAL_CODE{get{ return  _INTERNATIONAL_CODE;}set{ _INTERNATIONAL_CODE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _IDIENTY_TYPE;
		[DataMember]
		public System.String  IDIENTY_TYPE{get{ return  _IDIENTY_TYPE;}set{ _IDIENTY_TYPE = value;}}
		System.Decimal  _ORDER_INDEX;
		[DataMember]
		public System.Decimal  ORDER_INDEX{get{ return  _ORDER_INDEX;}set{ _ORDER_INDEX = value;}}

		#endregion 
	}	
}
