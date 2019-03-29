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
	[DataObject("MCE_B_ASSETS_CONTRACT_PAY")]
	public partial class CauseObject_MCE_B_ASSETS_CONTRACT_PAY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _PERIODS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PERIODS{get{ return  _PERIODS;}set{ _PERIODS = value;}}
		System.String _BASE_ID = string.Empty;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		DateSpan _PLAN_PAY_DATE = null;
		[DataMember]
		public DateSpan  PLAN_PAY_DATE{get{ return  _PLAN_PAY_DATE;}set{ _PLAN_PAY_DATE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _ACTUAL_PAY_DATE = null;
		[DataMember]
		public DateSpan  ACTUAL_PAY_DATE{get{ return  _ACTUAL_PAY_DATE;}set{ _ACTUAL_PAY_DATE = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CONTRACT_PAY")]
	public partial class DisplayObject_MCE_B_ASSETS_CONTRACT_PAY:EntityObject_MCE_B_ASSETS_CONTRACT_PAY
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _BASE_ID_NAME = string.Empty;
		[DataMember]
		public System.String BASE_ID_NAME{get{ return  _BASE_ID_NAME;}set{ _BASE_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_ASSETS_CONTRACT_PAY")]
	public partial class EntityObject_MCE_B_ASSETS_CONTRACT_PAY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _PERIODS;
		[DataMember]
		public System.Decimal  PERIODS{get{ return  _PERIODS;}set{ _PERIODS = value;}}
		System.String  _BASE_ID;
		[DataMember]
		public System.String  BASE_ID{get{ return  _BASE_ID;}set{ _BASE_ID = value;}}
		System.DateTime  _PLAN_PAY_DATE;
		[DataMember]
		public System.DateTime  PLAN_PAY_DATE{get{ return  _PLAN_PAY_DATE;}set{ _PLAN_PAY_DATE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _ACTUAL_PAY_DATE;
		[DataMember]
		public System.DateTime  ACTUAL_PAY_DATE{get{ return  _ACTUAL_PAY_DATE;}set{ _ACTUAL_PAY_DATE = value;}}

		#endregion 
	}	
}
