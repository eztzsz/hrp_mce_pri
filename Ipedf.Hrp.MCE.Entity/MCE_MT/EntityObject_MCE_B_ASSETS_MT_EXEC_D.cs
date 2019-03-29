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
	[DataObject("MCE_B_ASSETS_MT_EXEC_D")]
	public partial class CauseObject_MCE_B_ASSETS_MT_EXEC_D:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String _SEQ_NUMBER = string.Empty;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.String _SPEC = string.Empty;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _RESULT_ID = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  RESULT_ID{get{ return  _RESULT_ID;}set{ _RESULT_ID = value;}}
		System.String _ASSET_CODE = string.Empty;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String _ASSETS_ID = string.Empty;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String _DEPT_ID = string.Empty;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String _ITEM_ID = string.Empty;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_EXEC_D")]
	public partial class DisplayObject_MCE_B_ASSETS_MT_EXEC_D:EntityObject_MCE_B_ASSETS_MT_EXEC_D
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _RESULT_ID_NAME = string.Empty;
		[DataMember]
		public System.String RESULT_ID_NAME{get{ return  _RESULT_ID_NAME;}set{ _RESULT_ID_NAME = value;}}
		 System.String _ASSETS_ID_NAME = string.Empty;
		[DataMember]
		public System.String ASSETS_ID_NAME{get{ return  _ASSETS_ID_NAME;}set{ _ASSETS_ID_NAME = value;}}
		 System.String _DEPT_ID_NAME = string.Empty;
		[DataMember]
		public System.String DEPT_ID_NAME{get{ return  _DEPT_ID_NAME;}set{ _DEPT_ID_NAME = value;}}
		 System.String _ITEM_ID_NAME = string.Empty;
		[DataMember]
		public System.String ITEM_ID_NAME{get{ return  _ITEM_ID_NAME;}set{ _ITEM_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_MT_EXEC_D")]
	public partial class EntityObject_MCE_B_ASSETS_MT_EXEC_D:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.String  _SEQ_NUMBER;
		[DataMember]
		public System.String  SEQ_NUMBER{get{ return  _SEQ_NUMBER;}set{ _SEQ_NUMBER = value;}}
		System.String  _SPEC;
		[DataMember]
		public System.String  SPEC{get{ return  _SPEC;}set{ _SPEC = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _RESULT_ID;
		[DataMember]
		public System.Decimal  RESULT_ID{get{ return  _RESULT_ID;}set{ _RESULT_ID = value;}}
		System.String  _ASSET_CODE;
		[DataMember]
		public System.String  ASSET_CODE{get{ return  _ASSET_CODE;}set{ _ASSET_CODE = value;}}
		System.String  _ASSETS_ID;
		[DataMember]
		public System.String  ASSETS_ID{get{ return  _ASSETS_ID;}set{ _ASSETS_ID = value;}}
		System.String  _DEPT_ID;
		[DataMember]
		public System.String  DEPT_ID{get{ return  _DEPT_ID;}set{ _DEPT_ID = value;}}
		System.String  _ITEM_ID;
		[DataMember]
		public System.String  ITEM_ID{get{ return  _ITEM_ID;}set{ _ITEM_ID = value;}}

		#endregion 
	}	
}
