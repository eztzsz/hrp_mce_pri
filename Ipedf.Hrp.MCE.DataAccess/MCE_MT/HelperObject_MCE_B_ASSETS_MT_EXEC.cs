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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_EXEC))]
	public partial class HelperObject_MCE_B_ASSETS_MT_EXEC
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_MT_EXEC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_MT_EXEC( NEXT_EXEC_DATE, APPLY_USER_ID, CREATE_DATE, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MTN_COMPANY_ID, CODE, STATE, TOTAL_MONEY, AUDIT_USER_ID, NAME, CREATE_DEPART_ID, MTN_TYPE_ID, AUDIT_TIME, COMMENTS, CREATE_TIME, EXECUTE_PERIOD, ACTUAL_EXEC_DATE, EXECUTE_PERIOD_UNIT, PLAN_ID) values ( :NEXT_EXEC_DATE, :APPLY_USER_ID, :CREATE_DATE, :DATA_ORGANISE_ID, :ID, :CREATE_USER_ID, :MTN_COMPANY_ID, :CODE, :STATE, :TOTAL_MONEY, :AUDIT_USER_ID, :NAME, :CREATE_DEPART_ID, :MTN_TYPE_ID, :AUDIT_TIME, :COMMENTS, :CREATE_TIME, :EXECUTE_PERIOD, :ACTUAL_EXEC_DATE, :EXECUTE_PERIOD_UNIT, :PLAN_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[21];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":NEXT_EXEC_DATE";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.NEXT_EXEC_DATE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":APPLY_USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.CREATE_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DATA_ORGANISE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CREATE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":MTN_COMPANY_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.MTN_COMPANY_ID == null ? String.Empty:obj.MTN_COMPANY_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CODE == null ? String.Empty:obj.CODE;
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
			parameters[10].ParameterName =":AUDIT_USER_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":NAME";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_DEPART_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":MTN_TYPE_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.MTN_TYPE_ID == null ? String.Empty:obj.MTN_TYPE_ID;
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
			parameters[16].ParameterName =":CREATE_TIME";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.CREATE_TIME;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":EXECUTE_PERIOD";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.EXECUTE_PERIOD;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":ACTUAL_EXEC_DATE";
			parameters[18].Size = 7;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[18].Value = obj.ACTUAL_EXEC_DATE;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":EXECUTE_PERIOD_UNIT";
			parameters[19].Size = 22;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[19].Value = obj.EXECUTE_PERIOD_UNIT;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":PLAN_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.PLAN_ID == null ? String.Empty:obj.PLAN_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_EXEC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_EXEC set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_EXEC obj,CauseObject_MCE_B_ASSETS_MT_EXEC cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_EXEC set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_MT_EXEC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_MT_EXEC where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_MT_EXEC cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_MT_EXEC where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_MT_EXEC Get(EntityObject_MCE_B_ASSETS_MT_EXEC obj)
		{
			
			//平台自动生成代码
			string sSql = "select  NEXT_EXEC_DATE, APPLY_USER_ID, CREATE_DATE, MODIFY_TIME, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, MTN_COMPANY_ID, CODE, STATE, TOTAL_MONEY, MODIFY_DEPART_ID, AUDIT_USER_ID, NAME, CREATE_DEPART_ID, MTN_TYPE_ID, AUDIT_TIME, COMMENTS, CREATE_TIME, EXECUTE_PERIOD, ACTUAL_EXEC_DATE, EXECUTE_PERIOD_UNIT, PLAN_ID from MCE_B_ASSETS_MT_EXEC where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_EXEC[] objs = new EntityObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC Get(DisplayObject_MCE_B_ASSETS_MT_EXEC obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1) and MCE_B_ASSETS_MT_EXEC.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_MT_EXEC Get(EntityObject_MCE_B_ASSETS_MT_EXEC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  NEXT_EXEC_DATE, APPLY_USER_ID, CREATE_DATE, MODIFY_TIME, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, MTN_COMPANY_ID, CODE, STATE, TOTAL_MONEY, MODIFY_DEPART_ID, AUDIT_USER_ID, NAME, CREATE_DEPART_ID, MTN_TYPE_ID, AUDIT_TIME, COMMENTS, CREATE_TIME, EXECUTE_PERIOD, ACTUAL_EXEC_DATE, EXECUTE_PERIOD_UNIT, PLAN_ID from MCE_B_ASSETS_MT_EXEC where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_EXEC[] objs = new EntityObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_MT_EXEC cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.NEXT_EXEC_DATE!= null)
			{
				if (cause.NEXT_EXEC_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE >= :C_NEXT_EXEC_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_NEXT_EXEC_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.NEXT_EXEC_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.NEXT_EXEC_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE < :C_NEXT_EXEC_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_NEXT_EXEC_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.NEXT_EXEC_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("NEXT_EXEC_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "NEXT_EXEC_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "APPLY_USER_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "CREATE_DATE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MTN_COMPANY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID ").Append((cause.MTN_COMPANY_ID.StartsWith("%") || cause.MTN_COMPANY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MTN_COMPANY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MTN_COMPANY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MTN_COMPANY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTN_COMPANY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "MTN_COMPANY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "CODE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "STATE"));
			}
			if(cause.TOTAL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY = :C_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.TOTAL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("TOTAL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "TOTAL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MTN_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID ").Append((cause.MTN_TYPE_ID.StartsWith("%") || cause.MTN_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MTN_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MTN_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MTN_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTN_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "MTN_TYPE_ID"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "COMMENTS"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "CREATE_TIME"));
			}
			if(cause.EXECUTE_PERIOD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD = :C_EXECUTE_PERIOD");
				param = new OracleParameter();
				param.ParameterName =":C_EXECUTE_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXECUTE_PERIOD;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTE_PERIOD"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "EXECUTE_PERIOD"));
			}
			if(cause.ACTUAL_EXEC_DATE!= null)
			{
				if (cause.ACTUAL_EXEC_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE >= :C_ACTUAL_EXEC_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_EXEC_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_EXEC_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ACTUAL_EXEC_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE < :C_ACTUAL_EXEC_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_EXEC_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_EXEC_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ACTUAL_EXEC_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "ACTUAL_EXEC_DATE"));
			}
			if(cause.EXECUTE_PERIOD_UNIT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = :C_EXECUTE_PERIOD_UNIT");
				param = new OracleParameter();
				param.ParameterName =":C_EXECUTE_PERIOD_UNIT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXECUTE_PERIOD_UNIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTE_PERIOD_UNIT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "EXECUTE_PERIOD_UNIT"));
			}
			if(!string.IsNullOrEmpty(cause.PLAN_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC.PLAN_ID ").Append((cause.PLAN_ID.StartsWith("%") || cause.PLAN_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PLAN_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PLAN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PLAN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PLAN_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC", "PLAN_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_EXEC",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID, MCE_B_ASSETS_MT_EXEC.CREATE_DATE, MCE_B_ASSETS_MT_EXEC.MODIFY_TIME, MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_EXEC.ID, MCE_B_ASSETS_MT_EXEC.CREATE_USER_ID, MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID, MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID, MCE_B_ASSETS_MT_EXEC.CODE, MCE_B_ASSETS_MT_EXEC.STATE, MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY, MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID, MCE_B_ASSETS_MT_EXEC.NAME, MCE_B_ASSETS_MT_EXEC.CREATE_DEPART_ID, MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID, MCE_B_ASSETS_MT_EXEC.AUDIT_TIME, MCE_B_ASSETS_MT_EXEC.COMMENTS, MCE_B_ASSETS_MT_EXEC.CREATE_TIME, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD, MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE, MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT, MCE_B_ASSETS_MT_EXEC.PLAN_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, MDM_D_DEPT_MTN_COMPANY_ID.NAME as MTN_COMPANY_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_EXEC.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_EXEC.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_EXEC.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_EXEC.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_EXEC.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 1 then '年' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 2 then '月' when MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = 3 then '日' else '' end ) as EXECUTE_PERIOD_UNIT_NAME from MCE_B_ASSETS_MT_EXEC left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_MTN_COMPANY_ID on MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = MDM_D_DEPT_MTN_COMPANY_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_EXEC",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_MT_EXEC dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NEXT_EXEC_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MTN_COMPANY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EXECUTE_PERIOD = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ACTUAL_EXEC_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.EXECUTE_PERIOD_UNIT = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PLAN_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MTN_COMPANY_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.STATE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EXECUTE_PERIOD_UNIT_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("NEXT_EXEC_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.NEXT_EXEC_DATE = :U_NEXT_EXEC_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_NEXT_EXEC_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.NEXT_EXEC_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.APPLY_USER_ID = :U_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTN_COMPANY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.MTN_COMPANY_ID = :U_MTN_COMPANY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MTN_COMPANY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MTN_COMPANY_ID) ? string.Empty : obj.MTN_COMPANY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TOTAL_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.TOTAL_MONEY = :U_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.TOTAL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTN_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.MTN_TYPE_ID = :U_MTN_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MTN_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MTN_TYPE_ID) ? string.Empty : obj.MTN_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXECUTE_PERIOD"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD = :U_EXECUTE_PERIOD");
				param = new OracleParameter();
				param.ParameterName = ":U_EXECUTE_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXECUTE_PERIOD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACTUAL_EXEC_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.ACTUAL_EXEC_DATE = :U_ACTUAL_EXEC_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ACTUAL_EXEC_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ACTUAL_EXEC_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXECUTE_PERIOD_UNIT"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.EXECUTE_PERIOD_UNIT = :U_EXECUTE_PERIOD_UNIT");
				param = new OracleParameter();
				param.ParameterName = ":U_EXECUTE_PERIOD_UNIT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXECUTE_PERIOD_UNIT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC.PLAN_ID = :U_PLAN_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PLAN_ID) ? string.Empty : obj.PLAN_ID;
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
