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
	[DataObject("MCE_B_SALES_RETURN")]
	public partial class CauseObject_MCE_B_SALES_RETURN:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _COMMENTS = string.Empty;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		DateSpan _MODIFY_TIME = null;
		[DataMember]
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _DATA_ORGANISE_ID = string.Empty;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _CREATE_USER_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String _PROVIDER_ID = string.Empty;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.Decimal _ORDER_INDEX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ORDER_INDEX{get{ return  _ORDER_INDEX;}set{ _ORDER_INDEX = value;}}
		System.Decimal _STATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal _TOTAL_MONEY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.String _SUMMARY = string.Empty;
		[DataMember]
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.String _AUDIT_USER_ID = string.Empty;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String _CODE = string.Empty;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		DateSpan _AUDIT_TIME = null;
		[DataMember]
		public DateSpan  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String _STOCK_ID = string.Empty;
		[DataMember]
		public System.String  STOCK_ID{get{ return  _STOCK_ID;}set{ _STOCK_ID = value;}}
		DateSpan _CREATE_TIME = null;
		[DataMember]
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _RETURN_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  RETURN_TYPE_ID{get{ return  _RETURN_TYPE_ID;}set{ _RETURN_TYPE_ID = value;}}
		System.String _CREATE_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String _MODIFY_DEPART_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_SALES_RETURN")]
	public partial class DisplayObject_MCE_B_SALES_RETURN:EntityObject_MCE_B_SALES_RETURN
	{
		#region Attribute Block
		
			//平台自动生成代码
		 System.String _PROVIDER_ID_NAME = string.Empty;
		[DataMember]
		public System.String PROVIDER_ID_NAME{get{ return  _PROVIDER_ID_NAME;}set{ _PROVIDER_ID_NAME = value;}}
		 System.String _STATE_NAME = string.Empty;
		[DataMember]
		public System.String STATE_NAME{get{ return  _STATE_NAME;}set{ _STATE_NAME = value;}}
		 System.String _STOCK_ID_NAME = string.Empty;
		[DataMember]
		public System.String STOCK_ID_NAME{get{ return  _STOCK_ID_NAME;}set{ _STOCK_ID_NAME = value;}}
		 System.String _USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}

		#endregion 
	}
	[Serializable]
	[DataContract]
	[DataObject("MCE_B_SALES_RETURN")]
	public partial class EntityObject_MCE_B_SALES_RETURN:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _COMMENTS;
		[DataMember]
		public System.String  COMMENTS{get{ return  _COMMENTS;}set{ _COMMENTS = value;}}
		System.DateTime  _MODIFY_TIME;
		[DataMember]
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _DATA_ORGANISE_ID;
		[DataMember]
		public System.String  DATA_ORGANISE_ID{get{ return  _DATA_ORGANISE_ID;}set{ _DATA_ORGANISE_ID = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _CREATE_USER_ID;
		[DataMember]
		public System.String  CREATE_USER_ID{get{ return  _CREATE_USER_ID;}set{ _CREATE_USER_ID = value;}}
		System.String  _PROVIDER_ID;
		[DataMember]
		public System.String  PROVIDER_ID{get{ return  _PROVIDER_ID;}set{ _PROVIDER_ID = value;}}
		System.Decimal  _ORDER_INDEX;
		[DataMember]
		public System.Decimal  ORDER_INDEX{get{ return  _ORDER_INDEX;}set{ _ORDER_INDEX = value;}}
		System.Decimal  _STATE;
		[DataMember]
		public System.Decimal  STATE{get{ return  _STATE;}set{ _STATE = value;}}
		System.Decimal  _TOTAL_MONEY;
		[DataMember]
		public System.Decimal  TOTAL_MONEY{get{ return  _TOTAL_MONEY;}set{ _TOTAL_MONEY = value;}}
		System.String  _SUMMARY;
		[DataMember]
		public System.String  SUMMARY{get{ return  _SUMMARY;}set{ _SUMMARY = value;}}
		System.String  _AUDIT_USER_ID;
		[DataMember]
		public System.String  AUDIT_USER_ID{get{ return  _AUDIT_USER_ID;}set{ _AUDIT_USER_ID = value;}}
		System.String  _CODE;
		[DataMember]
		public System.String  CODE{get{ return  _CODE;}set{ _CODE = value;}}
		System.DateTime  _AUDIT_TIME;
		[DataMember]
		public System.DateTime  AUDIT_TIME{get{ return  _AUDIT_TIME;}set{ _AUDIT_TIME = value;}}
		System.String  _STOCK_ID;
		[DataMember]
		public System.String  STOCK_ID{get{ return  _STOCK_ID;}set{ _STOCK_ID = value;}}
		System.DateTime  _CREATE_TIME;
		[DataMember]
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _RETURN_TYPE_ID;
		[DataMember]
		public System.String  RETURN_TYPE_ID{get{ return  _RETURN_TYPE_ID;}set{ _RETURN_TYPE_ID = value;}}
		System.String  _CREATE_DEPART_ID;
		[DataMember]
		public System.String  CREATE_DEPART_ID{get{ return  _CREATE_DEPART_ID;}set{ _CREATE_DEPART_ID = value;}}
		System.String  _MODIFY_DEPART_ID;
		[DataMember]
		public System.String  MODIFY_DEPART_ID{get{ return  _MODIFY_DEPART_ID;}set{ _MODIFY_DEPART_ID = value;}}
		System.String  _MODIFY_USER_ID;
		[DataMember]
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}

		#endregion 
	}	
}
