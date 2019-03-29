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
	[DataObject("MCE_B_ASSETS_BACK_D")]
	public partial class CauseObject_MCE_B_ASSETS_BACK_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _REF_TAB_NAME = string.Empty;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _ASSETS_NAME = string.Empty;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.String _REF_TAB_ID = string.Empty;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _ASSETS_CODE = string.Empty;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String _ASSET_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String _CARD_CODE = string.Empty;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _SEQ_NUMBER = string.Empty;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_BACK_D")]
	public partial class DisplayObject_MCE_B_ASSETS_BACK_D:EntityObject_MCE_B_ASSETS_BACK_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _ASSET_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSET_TYPE_ID_NAME{get{ return  _ASSET_TYPE_ID_NAME;}set{ _ASSET_TYPE_ID_NAME = value;}}
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_BACK_D")]
	public partial class EntityObject_MCE_B_ASSETS_BACK_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _REF_TAB_NAME;
		[DataMember]
		public System.String  REF_TAB_NAME{get{ return  _REF_TAB_NAME;}set{ _REF_TAB_NAME = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _ASSETS_NAME;
		[DataMember]
		public System.String  ASSETS_NAME{get{ return  _ASSETS_NAME;}set{ _ASSETS_NAME = value;}}
		System.String  _REF_TAB_ID;
		[DataMember]
		public System.String  REF_TAB_ID{get{ return  _REF_TAB_ID;}set{ _REF_TAB_ID = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _ASSETS_CODE;
		[DataMember]
		public System.String  ASSETS_CODE{get{ return  _ASSETS_CODE;}set{ _ASSETS_CODE = value;}}
		System.String  _ASSET_TYPE_ID;
		[DataMember]
		public System.String  ASSET_TYPE_ID{get{ return  _ASSET_TYPE_ID;}set{ _ASSET_TYPE_ID = value;}}
		System.String  _CARD_CODE;
		[DataMember]
		public System.String  CARD_CODE{get{ return  _CARD_CODE;}set{ _CARD_CODE = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _SEQ_NUMBER;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}

		#endregion 
	}	
}
