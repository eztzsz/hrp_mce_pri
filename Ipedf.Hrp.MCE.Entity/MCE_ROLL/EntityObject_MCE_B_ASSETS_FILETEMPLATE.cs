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
	[DataObject("MCE_B_ASSETS_FILETEMPLATE")]
	public partial class CauseObject_MCE_B_ASSETS_FILETEMPLATE:CauseBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_FILETEMPLATE")]
	public partial class DisplayObject_MCE_B_ASSETS_FILETEMPLATE:EntityObject_MCE_B_ASSETS_FILETEMPLATE
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_FILETEMPLATE")]
	public partial class EntityObject_MCE_B_ASSETS_FILETEMPLATE:EntityBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}

		#endregion 
	}	
}
