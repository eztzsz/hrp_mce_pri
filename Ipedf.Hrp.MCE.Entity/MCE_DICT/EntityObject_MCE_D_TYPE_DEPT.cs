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
	[DataObject("MCE_D_TYPE_DEPT")]
	public partial class CauseObject_MCE_D_TYPE_DEPT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _MCE_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  MCE_TYPE_ID{get{ return  _MCE_TYPE_ID;}set{ _MCE_TYPE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_D_TYPE_DEPT")]
	public partial class DisplayObject_MCE_D_TYPE_DEPT:EntityObject_MCE_D_TYPE_DEPT
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_ID_NAME{get{ return  _DEPT_ID_NAME;}set{ _DEPT_ID_NAME = value;}}
		 System.String _MCE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String MCE_TYPE_ID_NAME{get{ return  _MCE_TYPE_ID_NAME;}set{ _MCE_TYPE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_D_TYPE_DEPT")]
	public partial class EntityObject_MCE_D_TYPE_DEPT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _MCE_TYPE_ID;
		[DataMember]
		public System.String  MCE_TYPE_ID{get{ return  _MCE_TYPE_ID;}set{ _MCE_TYPE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
