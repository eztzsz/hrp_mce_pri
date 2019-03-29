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
	[DataObject("MCE_B_ASSETS_CHECK_TYPE")]
	public partial class CauseObject_MCE_B_ASSETS_CHECK_TYPE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CHECK_TYPE")]
	public partial class DisplayObject_MCE_B_ASSETS_CHECK_TYPE:EntityObject_MCE_B_ASSETS_CHECK_TYPE
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CHECK_TYPE")]
	public partial class EntityObject_MCE_B_ASSETS_CHECK_TYPE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
