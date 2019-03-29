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
	[DataObject("MCE_B_ASSETS_CONTRACT_D")]
	public partial class CauseObject_MCE_B_ASSETS_CONTRACT_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ASSET_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
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
	[DataObject("MCE_B_ASSETS_CONTRACT_D")]
	public partial class DisplayObject_MCE_B_ASSETS_CONTRACT_D:EntityObject_MCE_B_ASSETS_CONTRACT_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ASSET_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSET_ID_NAME{get{ return  _ASSET_ID_NAME;}set{ _ASSET_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CONTRACT_D")]
	public partial class EntityObject_MCE_B_ASSETS_CONTRACT_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ASSET_ID;
		[DataMember]
		public System.String  ASSET_ID{get{ return  _ASSET_ID;}set{ _ASSET_ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}

		#endregion 
	}	
}
