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
	[DataObject("V_MCE_ASSETS_ROLLEQUIP")]
	public partial class CauseObject_V_MCE_ASSETS_ROLLEQUIP:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _USING_DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}
		System.String _ASSETS_STATE = string.Empty;
		[DataMember]
		public System.String  ASSETS_STATE{get{ return  _ASSETS_STATE;}set{ _ASSETS_STATE = value;}}
		System.String _PICTURE = string.Empty;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String _ASSETS_STATE_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_STATE_NAME{get{ return  _ASSETS_STATE_NAME;}set{ _ASSETS_STATE_NAME = value;}}
		System.String _USING_DEPT_ID = string.Empty;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _ROLL_ID = string.Empty;
		[DataMember]
		public System.String  ROLL_ID{get{ return  _ROLL_ID;}set{ _ROLL_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_ROLLEQUIP")]
	public partial class DisplayObject_V_MCE_ASSETS_ROLLEQUIP:EntityObject_V_MCE_ASSETS_ROLLEQUIP
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSETS_ROLLEQUIP")]
	public partial class EntityObject_V_MCE_ASSETS_ROLLEQUIP:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _USING_DEPT_ID_NAME;
		[DataMember]
		public System.String  USING_DEPT_ID_NAME{get{ return  _USING_DEPT_ID_NAME;}set{ _USING_DEPT_ID_NAME = value;}}
		System.String  _ASSETS_STATE;
		[DataMember]
		public System.String  ASSETS_STATE{get{ return  _ASSETS_STATE;}set{ _ASSETS_STATE = value;}}
		System.String  _PICTURE;
		[DataMember]
		public System.String  PICTURE{get{ return  _PICTURE;}set{ _PICTURE = value;}}
		System.String  _ASSETS_STATE_NAME;
		[DataMember]
		public System.String  ASSETS_STATE_NAME{get{ return  _ASSETS_STATE_NAME;}set{ _ASSETS_STATE_NAME = value;}}
		System.String  _USING_DEPT_ID;
		[DataMember]
		public System.String  USING_DEPT_ID{get{ return  _USING_DEPT_ID;}set{ _USING_DEPT_ID = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ROLL_ID;
		[DataMember]
		public System.String  ROLL_ID{get{ return  _ROLL_ID;}set{ _ROLL_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}

		#endregion 
	}	
}
