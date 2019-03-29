using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.DataAccess
{
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_INSTOCK))]
	public partial class HelperObject_MCE_B_ASSETS_INSTOCK
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_INSTOCK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_INSTOCK( CREATE_DATE, CREATE_DEPT_ID, DATA_ORGANISE_ID, ID, CREATE_USER_ID, DEPT_ID, INVOICE_DATE, WAREHOUSE_ID, STATE, TOTAL_MONEY, INVOICE_CODE, CREATE_TIME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, BUSINESS_TYPE, USER_ID, AUDIT_USER_ID, PROVIDER_ID) values ( :CREATE_DATE, :CREATE_DEPT_ID, :DATA_ORGANISE_ID, :ID, :CREATE_USER_ID, :DEPT_ID, :INVOICE_DATE, :WAREHOUSE_ID, :STATE, :TOTAL_MONEY, :INVOICE_CODE, :CREATE_TIME, :MODIFY_DEPT_ID, :CODE, :AUDIT_TIME, :COMMENTS, :BUSINESS_TYPE, :USER_ID, :AUDIT_USER_ID, :PROVIDER_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[20];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CREATE_DATE";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.CREATE_DATE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CREATE_DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DATA_ORGANISE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_USER_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DEPT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":INVOICE_DATE";
			parameters[6].Size = 7;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[6].Value = obj.INVOICE_DATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":WAREHOUSE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.WAREHOUSE_ID == null ? String.Empty:obj.WAREHOUSE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":STATE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.STATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":TOTAL_MONEY";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.TOTAL_MONEY;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":INVOICE_CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.INVOICE_CODE == null ? String.Empty:obj.INVOICE_CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CREATE_TIME";
			parameters[11].Size = 7;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[11].Value = obj.CREATE_TIME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MODIFY_DEPT_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CODE";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":AUDIT_TIME";
			parameters[14].Size = 7;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[14].Value = obj.AUDIT_TIME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":COMMENTS";
			parameters[15].Size = 200;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":BUSINESS_TYPE";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.BUSINESS_TYPE == null ? String.Empty:obj.BUSINESS_TYPE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":USER_ID";
			parameters[17].Size = 36;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":AUDIT_USER_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":PROVIDER_ID";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.PROVIDER_ID == null ? String.Empty:obj.PROVIDER_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSTOCK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSTOCK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSTOCK obj,CauseObject_MCE_B_ASSETS_INSTOCK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSTOCK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_INSTOCK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_INSTOCK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_MCE_B_ASSETS_INSTOCK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_INSTOCK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_INSTOCK Get(EntityObject_MCE_B_ASSETS_INSTOCK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DATE, CREATE_DEPT_ID, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, DEPT_ID, INVOICE_DATE, WAREHOUSE_ID, STATE, TOTAL_MONEY, INVOICE_CODE, CREATE_TIME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, BUSINESS_TYPE, MODIFY_TIME, USER_ID, AUDIT_USER_ID, PROVIDER_ID from MCE_B_ASSETS_INSTOCK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_INSTOCK[] objs = new EntityObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK Get(DisplayObject_MCE_B_ASSETS_INSTOCK obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1) and MCE_B_ASSETS_INSTOCK.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_INSTOCK Get(EntityObject_MCE_B_ASSETS_INSTOCK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DATE, CREATE_DEPT_ID, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, DEPT_ID, INVOICE_DATE, WAREHOUSE_ID, STATE, TOTAL_MONEY, INVOICE_CODE, CREATE_TIME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, BUSINESS_TYPE, MODIFY_TIME, USER_ID, AUDIT_USER_ID, PROVIDER_ID from MCE_B_ASSETS_INSTOCK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_INSTOCK[] objs = new EntityObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_INSTOCK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_DATE < :C_CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "DEPT_ID"));
			}
			if(cause.INVOICE_DATE!= null)
			{
				if (cause.INVOICE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.INVOICE_DATE >= :C_INVOICE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_INVOICE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INVOICE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.INVOICE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.INVOICE_DATE < :C_INVOICE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_INVOICE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INVOICE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("INVOICE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "INVOICE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.WAREHOUSE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID ").Append((cause.WAREHOUSE_ID.StartsWith("%") || cause.WAREHOUSE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_WAREHOUSE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_WAREHOUSE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.WAREHOUSE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("WAREHOUSE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "WAREHOUSE_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "STATE"));
			}
			if(cause.TOTAL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.TOTAL_MONEY = :C_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.TOTAL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("TOTAL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "TOTAL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.INVOICE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.INVOICE_CODE ").Append((cause.INVOICE_CODE.StartsWith("%") || cause.INVOICE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INVOICE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INVOICE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "INVOICE_CODE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "CODE"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.AUDIT_TIME < :C_AUDIT_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("AUDIT_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.BUSINESS_TYPE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE ").Append((cause.BUSINESS_TYPE.StartsWith("%") || cause.BUSINESS_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_BUSINESS_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_BUSINESS_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUSINESS_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUSINESS_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "BUSINESS_TYPE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK.MODIFY_TIME < :C_MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PROVIDER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK.PROVIDER_ID ").Append((cause.PROVIDER_ID.StartsWith("%") || cause.PROVIDER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROVIDER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROVIDER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK", "PROVIDER_ID"));
			}
			if (!string.IsNullOrEmpty(cause.GetCustomCondition())) 
			{ 
				strBuf.Append(cause.GetCustomCondition()); 
			} 
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSTOCK",paging, order, sSql, parameters, connection);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK.CREATE_DATE, MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID, MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID, MCE_B_ASSETS_INSTOCK.ID, MCE_B_ASSETS_INSTOCK.CREATE_USER_ID, MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID, MCE_B_ASSETS_INSTOCK.DEPT_ID, MCE_B_ASSETS_INSTOCK.INVOICE_DATE, MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID, MCE_B_ASSETS_INSTOCK.STATE, MCE_B_ASSETS_INSTOCK.TOTAL_MONEY, MCE_B_ASSETS_INSTOCK.INVOICE_CODE, MCE_B_ASSETS_INSTOCK.CREATE_TIME, MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID, MCE_B_ASSETS_INSTOCK.CODE, MCE_B_ASSETS_INSTOCK.AUDIT_TIME, MCE_B_ASSETS_INSTOCK.COMMENTS, MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE, MCE_B_ASSETS_INSTOCK.MODIFY_TIME, MCE_B_ASSETS_INSTOCK.USER_ID, MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID, MCE_B_ASSETS_INSTOCK.PROVIDER_ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MDM_D_STOCK_WAREHOUSE_ID.NAME as WAREHOUSE_ID_NAME, (case  when MCE_B_ASSETS_INSTOCK.STATE = 0 then '默认值' when MCE_B_ASSETS_INSTOCK.STATE = 1 then '编辑中' when MCE_B_ASSETS_INSTOCK.STATE = 2 then '已提交' when MCE_B_ASSETS_INSTOCK.STATE = 3 then '已审核' when MCE_B_ASSETS_INSTOCK.STATE = 4 then '已归档' when MCE_B_ASSETS_INSTOCK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME from MCE_B_ASSETS_INSTOCK left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_INSTOCK.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MDM_D_STOCK   MDM_D_STOCK_WAREHOUSE_ID on MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = MDM_D_STOCK_WAREHOUSE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_INSTOCK.USER_ID = COM_USER_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS_INSTOCK.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSTOCK",paging, order, sSql, parameters, trans);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			DisplayObject_MCE_B_ASSETS_INSTOCK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INVOICE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.WAREHOUSE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMMENTS = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.BUSINESS_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.WAREHOUSE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_INSTOCK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVOICE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.INVOICE_DATE = :U_INVOICE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_INVOICE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.INVOICE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WAREHOUSE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.WAREHOUSE_ID = :U_WAREHOUSE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_WAREHOUSE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.WAREHOUSE_ID) ? string.Empty : obj.WAREHOUSE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TOTAL_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.TOTAL_MONEY = :U_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.TOTAL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVOICE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.INVOICE_CODE = :U_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INVOICE_CODE) ? string.Empty : obj.INVOICE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUSINESS_TYPE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.BUSINESS_TYPE = :U_BUSINESS_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_BUSINESS_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUSINESS_TYPE) ? string.Empty : obj.BUSINESS_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PROVIDER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK.PROVIDER_ID = :U_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROVIDER_ID) ? string.Empty : obj.PROVIDER_ID;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = obj.ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		
		#endregion 
	}
}
