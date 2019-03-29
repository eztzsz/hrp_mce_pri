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
	[DataObject("MCE_B_ASSETS_MT_APPLY_EN")]
	public partial class CauseObject_MCE_B_ASSETS_MT_APPLY_EN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ADVISE = string.Empty;
		[DataMember]
		public System.String  ADVISE{get{ return  _ADVISE;}set{ _ADVISE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _RESULT = string.Empty;
		[DataMember]
		public System.String  RESULT{get{ return  _RESULT;}set{ _RESULT = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _COMPLETE_TIME = null;
		[DataMember]
		public DateSpan  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _HOURS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  HOURS{get{ return  _HOURS;}set{ _HOURS = value;}}
		System.Decimal _IS_CLOSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CLOSE{get{ return  _IS_CLOSE;}set{ _IS_CLOSE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_APPLY_EN")]
	public partial class DisplayObject_MCE_B_ASSETS_MT_APPLY_EN:EntityObject_MCE_B_ASSETS_MT_APPLY_EN
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_APPLY_EN")]
	public partial class EntityObject_MCE_B_ASSETS_MT_APPLY_EN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ADVISE;
		[DataMember]
		public System.String  ADVISE{get{ return  _ADVISE;}set{ _ADVISE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _RESULT;
		[DataMember]
		public System.String  RESULT{get{ return  _RESULT;}set{ _RESULT = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _COMPLETE_TIME;
		[DataMember]
		public System.DateTime  COMPLETE_TIME{get{ return  _COMPLETE_TIME;}set{ _COMPLETE_TIME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _HOURS;
		[DataMember]
		public System.Decimal  HOURS{get{ return  _HOURS;}set{ _HOURS = value;}}
		System.Decimal  _IS_CLOSE;
		[DataMember]
		public System.Decimal  IS_CLOSE{get{ return  _IS_CLOSE;}set{ _IS_CLOSE = value;}}

		#endregion 
	}	
}
