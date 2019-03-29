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
	[DataObject("V_MCE_ASSET_OUTSTOCK_BACK")]
	public partial class CauseObject_V_MCE_ASSET_OUTSTOCK_BACK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String _OUT_D_ID = string.Empty;
		[DataMember]
		public System.String  OUT_D_ID{get{ return  _OUT_D_ID;}set{ _OUT_D_ID = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
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
	[DataObject("V_MCE_ASSET_OUTSTOCK_BACK")]
	public partial class DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK:EntityObject_V_MCE_ASSET_OUTSTOCK_BACK
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_ASSET_OUTSTOCK_BACK")]
	public partial class EntityObject_V_MCE_ASSET_OUTSTOCK_BACK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String  _OUT_D_ID;
		[DataMember]
		public System.String  OUT_D_ID{get{ return  _OUT_D_ID;}set{ _OUT_D_ID = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}

		#endregion 
	}	
}
