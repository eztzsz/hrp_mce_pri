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
	[DataObject("MCE_B_ASSETS_WRITE_OFF_ATTACH")]
	public partial class CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _SAVENAME = string.Empty;
		[DataMember]
		public System.String  SAVENAME{get{ return  _SAVENAME;}set{ _SAVENAME = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _FILE_NAME = string.Empty;
		[DataMember]
		public System.String  FILE_NAME{get{ return  _FILE_NAME;}set{ _FILE_NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_WRITE_OFF_ATTACH")]
	public partial class DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH:EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH
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
	[DataObject("MCE_B_ASSETS_WRITE_OFF_ATTACH")]
	public partial class EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _SAVENAME;
		[DataMember]
		public System.String  SAVENAME{get{ return  _SAVENAME;}set{ _SAVENAME = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _FILE_NAME;
		[DataMember]
		public System.String  FILE_NAME{get{ return  _FILE_NAME;}set{ _FILE_NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
