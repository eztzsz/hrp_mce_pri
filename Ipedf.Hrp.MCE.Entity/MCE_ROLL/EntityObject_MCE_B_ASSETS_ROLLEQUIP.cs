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
	[DataObject("MCE_B_ASSETS_ROLLEQUIP")]
	public partial class CauseObject_MCE_B_ASSETS_ROLLEQUIP:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ROLL_ID = string.Empty;
		[DataMember]
		public System.String  ROLL_ID{get{ return  _ROLL_ID;}set{ _ROLL_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_ROLLEQUIP")]
	public partial class DisplayObject_MCE_B_ASSETS_ROLLEQUIP:EntityObject_MCE_B_ASSETS_ROLLEQUIP
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ROLL_ID_NAME = string.Empty;
		[DataMember]
		public System.String ROLL_ID_NAME{get{ return  _ROLL_ID_NAME;}set{ _ROLL_ID_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_ROLLEQUIP")]
	public partial class EntityObject_MCE_B_ASSETS_ROLLEQUIP:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ROLL_ID;
		[DataMember]
		public System.String  ROLL_ID{get{ return  _ROLL_ID;}set{ _ROLL_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}

		#endregion 
	}	
}
