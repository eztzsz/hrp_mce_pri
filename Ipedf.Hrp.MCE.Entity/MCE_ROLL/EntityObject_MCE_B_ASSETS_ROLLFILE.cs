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
	[DataObject("MCE_B_ASSETS_ROLLFILE")]
	public partial class CauseObject_MCE_B_ASSETS_ROLLFILE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _SUMMARYS = string.Empty;
		[DataMember]
		public System.String  SUMMARYS{get{ return  _SUMMARYS;}set{ _SUMMARYS = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String _BACKUP1 = string.Empty;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal _PAGE_NUM = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PAGE_NUM{get{ return  _PAGE_NUM;}set{ _PAGE_NUM = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_ROLLFILE")]
	public partial class DisplayObject_MCE_B_ASSETS_ROLLFILE:EntityObject_MCE_B_ASSETS_ROLLFILE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_ROLLFILE")]
	public partial class EntityObject_MCE_B_ASSETS_ROLLFILE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _SUMMARYS;
		[DataMember]
		public System.String  SUMMARYS{get{ return  _SUMMARYS;}set{ _SUMMARYS = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.String  _BACKUP1;
		[DataMember]
		public System.String  BACKUP1{get{ return  _BACKUP1;}set{ _BACKUP1 = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal  _PAGE_NUM;
		[DataMember]
		public System.Decimal  PAGE_NUM{get{ return  _PAGE_NUM;}set{ _PAGE_NUM = value;}}

		#endregion 
	}	
}
