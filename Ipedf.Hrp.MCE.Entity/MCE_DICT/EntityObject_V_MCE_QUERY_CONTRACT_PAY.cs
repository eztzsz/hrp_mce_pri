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
	[DataObject("V_MCE_QUERY_CONTRACT_PAY")]
	public partial class CauseObject_V_MCE_QUERY_CONTRACT_PAY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String  STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		System.Decimal _H_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  H_STATE{get{ return  _H_STATE;}set{ _H_STATE = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _PLAN_PAY_DATE = null;
		[DataMember]
		public DateSpan  PLAN_PAY_DATE{get{ return  _PLAN_PAY_DATE;}set{ _PLAN_PAY_DATE = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _CONTRACT_STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  CONTRACT_STATE{get{ return  _CONTRACT_STATE;}set{ _CONTRACT_STATE = value;}}
		System.String _NAME = string.Empty;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		DateSpan _ACTUAL_PAY_DATE = null;
		[DataMember]
		public DateSpan  ACTUAL_PAY_DATE{get{ return  _ACTUAL_PAY_DATE;}set{ _ACTUAL_PAY_DATE = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal _MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal _PERIODS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  PERIODS{get{ return  _PERIODS;}set{ _PERIODS = value;}}
		System.String _SECOND_PARTY = string.Empty;
		[DataMember]
		public System.String  SECOND_PARTY{get{ return  _SECOND_PARTY;}set{ _SECOND_PARTY = value;}}
		System.String _SECOND_PARTY_NAME = string.Empty;
		[DataMember]
		public System.String  SECOND_PARTY_NAME{get{ return  _SECOND_PARTY_NAME;}set{ _SECOND_PARTY_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_QUERY_CONTRACT_PAY")]
	public partial class DisplayObject_V_MCE_QUERY_CONTRACT_PAY:EntityObject_V_MCE_QUERY_CONTRACT_PAY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("V_MCE_QUERY_CONTRACT_PAY")]
	public partial class EntityObject_V_MCE_QUERY_CONTRACT_PAY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _STATE_NAME;
		[DataMember]
		public System.String  STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		System.Decimal  _H_STATE;
		[DataMember]
		public System.Decimal  H_STATE{get{ return  _H_STATE;}set{ _H_STATE = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _PLAN_PAY_DATE;
		[DataMember]
		public System.DateTime  PLAN_PAY_DATE{get{ return  _PLAN_PAY_DATE;}set{ _PLAN_PAY_DATE = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _CONTRACT_STATE;
		[DataMember]
		public System.Decimal  CONTRACT_STATE{get{ return  _CONTRACT_STATE;}set{ _CONTRACT_STATE = value;}}
		System.String  _NAME;
		[DataMember]
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.DateTime  _ACTUAL_PAY_DATE;
		[DataMember]
		public System.DateTime  ACTUAL_PAY_DATE{get{ return  _ACTUAL_PAY_DATE;}set{ _ACTUAL_PAY_DATE = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.Decimal  _MONEY;
		[DataMember]
		public System.Decimal  MONEY{get{ return  _MONEY;}set{ _MONEY = value;}}
		System.Decimal  _PERIODS;
		[DataMember]
		public System.Decimal  PERIODS{get{ return  _PERIODS;}set{ _PERIODS = value;}}
		System.String  _SECOND_PARTY;
		[DataMember]
		public System.String  SECOND_PARTY{get{ return  _SECOND_PARTY;}set{ _SECOND_PARTY = value;}}
		System.String  _SECOND_PARTY_NAME;
		[DataMember]
		public System.String  SECOND_PARTY_NAME{get{ return  _SECOND_PARTY_NAME;}set{ _SECOND_PARTY_NAME = value;}}

		#endregion 
	}	
}
