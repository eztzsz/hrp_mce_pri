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
	[DataObject("MCE_B_ASSETS_CONTRACT")]
	public partial class CauseObject_MCE_B_ASSETS_CONTRACT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _INPUT_PERSON = string.Empty;
		[DataMember]
		public System.String  INPUT_PERSON{get{ return  _INPUT_PERSON;}set{ _INPUT_PERSON = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _MODIFY_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String _CONTRACT_CONTENT = string.Empty;
		[DataMember]
		public System.String  CONTRACT_CONTENT{get{ return  _CONTRACT_CONTENT;}set{ _CONTRACT_CONTENT = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _EXPIRE_DATE = null;
		[DataMember]
		public DateSpan  EXPIRE_DATE{get{ return  _EXPIRE_DATE;}set{ _EXPIRE_DATE = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal _AUDIT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String _SECOND_PARTY = string.Empty;
		[DataMember]
		public System.String  SECOND_PARTY{get{ return  _SECOND_PARTY;}set{ _SECOND_PARTY = value;}}
		System.String _FIRST_PARTY = string.Empty;
		[DataMember]
		public System.String  FIRST_PARTY{get{ return  _FIRST_PARTY;}set{ _FIRST_PARTY = value;}}
		System.Decimal _CONTRACT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTRACT_STATE{get{ return  _CONTRACT_STATE;}set{ _CONTRACT_STATE = value;}}
		System.String _ARCHIVE_NO = string.Empty;
		[DataMember]
		public System.String  ARCHIVE_NO{get{ return  _ARCHIVE_NO;}set{ _ARCHIVE_NO = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		DateSpan _SIGN_DATE = null;
		[DataMember]
		public DateSpan  SIGN_DATE{get{ return  _SIGN_DATE;}set{ _SIGN_DATE = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _SECOND_LINK_PERSON = string.Empty;
		[DataMember]
		public System.String  SECOND_LINK_PERSON{get{ return  _SECOND_LINK_PERSON;}set{ _SECOND_LINK_PERSON = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		DateSpan _CHECK_DATE = null;
		[DataMember]
		public DateSpan  CHECK_DATE{get{ return  _CHECK_DATE;}set{ _CHECK_DATE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String _SECOND_LINK_PHONE = string.Empty;
		[DataMember]
		public System.String  SECOND_LINK_PHONE{get{ return  _SECOND_LINK_PHONE;}set{ _SECOND_LINK_PHONE = value;}}
		System.String _ARCHIVIST = string.Empty;
		[DataMember]
		public System.String  ARCHIVIST{get{ return  _ARCHIVIST;}set{ _ARCHIVIST = value;}}
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _CREATE_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CONTRACT")]
	public partial class DisplayObject_MCE_B_ASSETS_CONTRACT:EntityObject_MCE_B_ASSETS_CONTRACT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _INPUT_PERSON_NAME = string.Empty;
		[DataMember]
		public System.String INPUT_PERSON_NAME{get{ return  _INPUT_PERSON_NAME;}set{ _INPUT_PERSON_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		 System.String _AUDIT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String AUDIT_STATE_NAME{get{ return  _AUDIT_STATE_NAME;}set{ _AUDIT_STATE_NAME = value;}}
		 System.String _SECOND_PARTY_NAME = string.Empty;
		[DataMember]
		public System.String SECOND_PARTY_NAME{get{ return  _SECOND_PARTY_NAME;}set{ _SECOND_PARTY_NAME = value;}}
		 System.String _FIRST_PARTY_NAME = string.Empty;
		[DataMember]
		public System.String FIRST_PARTY_NAME{get{ return  _FIRST_PARTY_NAME;}set{ _FIRST_PARTY_NAME = value;}}
		 System.String _CONTRACT_STATE_NAME = string.Empty;
		[DataMember]
		public System.String CONTRACT_STATE_NAME{get{ return  _CONTRACT_STATE_NAME;}set{ _CONTRACT_STATE_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _ARCHIVIST_NAME = string.Empty;
		[DataMember]
		public System.String ARCHIVIST_NAME{get{ return  _ARCHIVIST_NAME;}set{ _ARCHIVIST_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CONTRACT")]
	public partial class EntityObject_MCE_B_ASSETS_CONTRACT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _INPUT_PERSON;
		[DataMember]
		public System.String  INPUT_PERSON{get{ return  _INPUT_PERSON;}set{ _INPUT_PERSON = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _MODIFY_DEPT_ID;
		[DataMember]
		public System.String  MODIFY_DEPT_ID{get{ return  _MODIFY_DEPT_ID;}set{ _MODIFY_DEPT_ID = value;}}
		System.String  _CONTRACT_CONTENT;
		[DataMember]
		public System.String  CONTRACT_CONTENT{get{ return  _CONTRACT_CONTENT;}set{ _CONTRACT_CONTENT = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.DateTime  _EXPIRE_DATE;
		[DataMember]
		public System.DateTime  EXPIRE_DATE{get{ return  _EXPIRE_DATE;}set{ _EXPIRE_DATE = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.Decimal  _AUDIT_STATE;
		[DataMember]
		public System.Decimal  AUDIT_STATE{get{ return  _AUDIT_STATE;}set{ _AUDIT_STATE = value;}}
		System.String  _SECOND_PARTY;
		[DataMember]
		public System.String  SECOND_PARTY{get{ return  _SECOND_PARTY;}set{ _SECOND_PARTY = value;}}
		System.String  _FIRST_PARTY;
		[DataMember]
		public System.String  FIRST_PARTY{get{ return  _FIRST_PARTY;}set{ _FIRST_PARTY = value;}}
		System.Decimal  _CONTRACT_STATE;
		[DataMember]
		public System.Decimal  CONTRACT_STATE{get{ return  _CONTRACT_STATE;}set{ _CONTRACT_STATE = value;}}
		System.String  _ARCHIVE_NO;
		[DataMember]
		public System.String  ARCHIVE_NO{get{ return  _ARCHIVE_NO;}set{ _ARCHIVE_NO = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.DateTime  _SIGN_DATE;
		[DataMember]
		public System.DateTime  SIGN_DATE{get{ return  _SIGN_DATE;}set{ _SIGN_DATE = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _SECOND_LINK_PERSON;
		[DataMember]
		public System.String  SECOND_LINK_PERSON{get{ return  _SECOND_LINK_PERSON;}set{ _SECOND_LINK_PERSON = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.DateTime  _CHECK_DATE;
		[DataMember]
		public System.DateTime  CHECK_DATE{get{ return  _CHECK_DATE;}set{ _CHECK_DATE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.String  _SECOND_LINK_PHONE;
		[DataMember]
		public System.String  SECOND_LINK_PHONE{get{ return  _SECOND_LINK_PHONE;}set{ _SECOND_LINK_PHONE = value;}}
		System.String  _ARCHIVIST;
		[DataMember]
		public System.String  ARCHIVIST{get{ return  _ARCHIVIST;}set{ _ARCHIVIST = value;}}
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _CREATE_DEPT_ID;
		[DataMember]
		public System.String  CREATE_DEPT_ID{get{ return  _CREATE_DEPT_ID;}set{ _CREATE_DEPT_ID = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}

		#endregion 
	}	
}
