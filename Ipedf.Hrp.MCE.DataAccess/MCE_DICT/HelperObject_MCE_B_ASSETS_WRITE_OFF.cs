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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_WRITE_OFF))]
	public partial class HelperObject_MCE_B_ASSETS_WRITE_OFF
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_WRITE_OFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_WRITE_OFF( AUDIT_TIME, IDENTITY_USER_ID, IDENTITY_PARAM, NET_VALUE, WRITE_OFF_TYPE_ID, MODIFY_DEPT_ID, FINANCE_CYCLE, ID, DATA_ORGANISE_ID, IDENTITY_TIME, CODE, CREATE_TIME, ORIGINAL_VALUE, IDENTITY_STATE, RUDIMENTAL_VALUE, INCOME, DEPT_ID, STATE, WRITE_OFF_CAUSE_ID, CREATE_DATE, AUDIT_USER_ID, CREATE_USER_ID, AUDIT_STATE, SUMARRY, COMMENTS, BACKUP1, USAGE, ASSETS_ID, CREATE_DEPT_ID, USER_ID) values ( :AUDIT_TIME, :IDENTITY_USER_ID, :IDENTITY_PARAM, :NET_VALUE, :WRITE_OFF_TYPE_ID, :MODIFY_DEPT_ID, :FINANCE_CYCLE, :ID, :DATA_ORGANISE_ID, :IDENTITY_TIME, :CODE, :CREATE_TIME, :ORIGINAL_VALUE, :IDENTITY_STATE, :RUDIMENTAL_VALUE, :INCOME, :DEPT_ID, :STATE, :WRITE_OFF_CAUSE_ID, :CREATE_DATE, :AUDIT_USER_ID, :CREATE_USER_ID, :AUDIT_STATE, :SUMARRY, :COMMENTS, :BACKUP1, :USAGE, :ASSETS_ID, :CREATE_DEPT_ID, :USER_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[30];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":AUDIT_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.AUDIT_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":IDENTITY_USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.IDENTITY_USER_ID == null ? String.Empty:obj.IDENTITY_USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":IDENTITY_PARAM";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.IDENTITY_PARAM == null ? String.Empty:obj.IDENTITY_PARAM;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":NET_VALUE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.NET_VALUE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":WRITE_OFF_TYPE_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.WRITE_OFF_TYPE_ID == null ? String.Empty:obj.WRITE_OFF_TYPE_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MODIFY_DEPT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":FINANCE_CYCLE";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.FINANCE_CYCLE == null ? String.Empty:obj.FINANCE_CYCLE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":DATA_ORGANISE_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":IDENTITY_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.IDENTITY_TIME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CREATE_TIME";
			parameters[11].Size = 7;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[11].Value = obj.CREATE_TIME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ORIGINAL_VALUE";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.ORIGINAL_VALUE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":IDENTITY_STATE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.IDENTITY_STATE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":RUDIMENTAL_VALUE";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.RUDIMENTAL_VALUE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":INCOME";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.INCOME == null ? String.Empty:obj.INCOME;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":DEPT_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":STATE";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.STATE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":WRITE_OFF_CAUSE_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.WRITE_OFF_CAUSE_ID == null ? String.Empty:obj.WRITE_OFF_CAUSE_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":CREATE_DATE";
			parameters[19].Size = 7;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[19].Value = obj.CREATE_DATE;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":AUDIT_USER_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":CREATE_USER_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":AUDIT_STATE";
			parameters[22].Size = 22;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[22].Value = obj.AUDIT_STATE;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":SUMARRY";
			parameters[23].Size = 200;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.SUMARRY == null ? String.Empty:obj.SUMARRY;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":COMMENTS";
			parameters[24].Size = 200;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":BACKUP1";
			parameters[25].Size = 1000;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":USAGE";
			parameters[26].Size = 200;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.USAGE == null ? String.Empty:obj.USAGE;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":ASSETS_ID";
			parameters[27].Size = 36;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[27].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":CREATE_DEPT_ID";
			parameters[28].Size = 36;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[28].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":USER_ID";
			parameters[29].Size = 36;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF obj,CauseObject_MCE_B_ASSETS_WRITE_OFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_WRITE_OFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF Get(EntityObject_MCE_B_ASSETS_WRITE_OFF obj)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, IDENTITY_USER_ID, IDENTITY_PARAM, NET_VALUE, WRITE_OFF_TYPE_ID, MODIFY_DEPT_ID, FINANCE_CYCLE, ID, DATA_ORGANISE_ID, IDENTITY_TIME, CODE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, ORIGINAL_VALUE, IDENTITY_STATE, RUDIMENTAL_VALUE, INCOME, DEPT_ID, STATE, WRITE_OFF_CAUSE_ID, CREATE_DATE, AUDIT_USER_ID, CREATE_USER_ID, AUDIT_STATE, SUMARRY, COMMENTS, BACKUP1, USAGE, ASSETS_ID, CREATE_DEPT_ID, USER_ID from MCE_B_ASSETS_WRITE_OFF where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF Get(DisplayObject_MCE_B_ASSETS_WRITE_OFF obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1) and MCE_B_ASSETS_WRITE_OFF.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF Get(EntityObject_MCE_B_ASSETS_WRITE_OFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, IDENTITY_USER_ID, IDENTITY_PARAM, NET_VALUE, WRITE_OFF_TYPE_ID, MODIFY_DEPT_ID, FINANCE_CYCLE, ID, DATA_ORGANISE_ID, IDENTITY_TIME, CODE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, ORIGINAL_VALUE, IDENTITY_STATE, RUDIMENTAL_VALUE, INCOME, DEPT_ID, STATE, WRITE_OFF_CAUSE_ID, CREATE_DATE, AUDIT_USER_ID, CREATE_USER_ID, AUDIT_STATE, SUMARRY, COMMENTS, BACKUP1, USAGE, ASSETS_ID, CREATE_DEPT_ID, USER_ID from MCE_B_ASSETS_WRITE_OFF where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.IDENTITY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID ").Append((cause.IDENTITY_USER_ID.StartsWith("%") || cause.IDENTITY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_IDENTITY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_IDENTITY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.IDENTITY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTITY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "IDENTITY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.IDENTITY_PARAM))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM ").Append((cause.IDENTITY_PARAM.StartsWith("%") || cause.IDENTITY_PARAM.EndsWith("%")) ? " like " : " = ").Append(" :C_IDENTITY_PARAM");
				param = new OracleParameter();
				param.ParameterName =":C_IDENTITY_PARAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.IDENTITY_PARAM;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTITY_PARAM"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "IDENTITY_PARAM"));
			}
			if(cause.NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.NET_VALUE = :C_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "NET_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.WRITE_OFF_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID ").Append((cause.WRITE_OFF_TYPE_ID.StartsWith("%") || cause.WRITE_OFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_WRITE_OFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_WRITE_OFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.WRITE_OFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITE_OFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "WRITE_OFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_CYCLE))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE ").Append((cause.FINANCE_CYCLE.StartsWith("%") || cause.FINANCE_CYCLE.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_CYCLE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "FINANCE_CYCLE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "DATA_ORGANISE_ID"));
			}
			if(cause.IDENTITY_TIME!= null)
			{
				if (cause.IDENTITY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME >= :C_IDENTITY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_IDENTITY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.IDENTITY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.IDENTITY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME < :C_IDENTITY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_IDENTITY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.IDENTITY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("IDENTITY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "IDENTITY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "CODE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "MODIFY_TIME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "MODIFY_USER_ID"));
			}
			if(cause.ORIGINAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE = :C_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORIGINAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "ORIGINAL_VALUE"));
			}
			if(cause.IDENTITY_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = :C_IDENTITY_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_IDENTITY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IDENTITY_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTITY_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "IDENTITY_STATE"));
			}
			if(cause.RUDIMENTAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE = :C_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("RUDIMENTAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "RUDIMENTAL_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.INCOME))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.INCOME ").Append((cause.INCOME.StartsWith("%") || cause.INCOME.EndsWith("%")) ? " like " : " = ").Append(" :C_INCOME");
				param = new OracleParameter();
				param.ParameterName =":C_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.INCOME;
				paramList.Add(param);
			}
			if (cause.HasINValue("INCOME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "INCOME"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "DEPT_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.WRITE_OFF_CAUSE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID ").Append((cause.WRITE_OFF_CAUSE_ID.StartsWith("%") || cause.WRITE_OFF_CAUSE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_WRITE_OFF_CAUSE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_WRITE_OFF_CAUSE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.WRITE_OFF_CAUSE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITE_OFF_CAUSE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "WRITE_OFF_CAUSE_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "CREATE_USER_ID"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SUMARRY))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.SUMARRY ").Append((cause.SUMARRY.StartsWith("%") || cause.SUMARRY.EndsWith("%")) ? " like " : " = ").Append(" :C_SUMARRY");
				param = new OracleParameter();
				param.ParameterName =":C_SUMARRY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SUMARRY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMARRY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "SUMARRY"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.USAGE))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.USAGE ").Append((cause.USAGE.StartsWith("%") || cause.USAGE.EndsWith("%")) ? " like " : " = ").Append(" :C_USAGE");
				param = new OracleParameter();
				param.ParameterName =":C_USAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.USAGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("USAGE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "USAGE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF", "USER_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME, MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM, MCE_B_ASSETS_WRITE_OFF.NET_VALUE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID, MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE, MCE_B_ASSETS_WRITE_OFF.ID, MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID, MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME, MCE_B_ASSETS_WRITE_OFF.CODE, MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME, MCE_B_ASSETS_WRITE_OFF.CREATE_TIME, MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID, MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE, MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE, MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE, MCE_B_ASSETS_WRITE_OFF.INCOME, MCE_B_ASSETS_WRITE_OFF.DEPT_ID, MCE_B_ASSETS_WRITE_OFF.STATE, MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_USER_ID, MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE, MCE_B_ASSETS_WRITE_OFF.SUMARRY, MCE_B_ASSETS_WRITE_OFF.COMMENTS, MCE_B_ASSETS_WRITE_OFF.BACKUP1, MCE_B_ASSETS_WRITE_OFF.USAGE, MCE_B_ASSETS_WRITE_OFF.ASSETS_ID, MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID, MCE_B_ASSETS_WRITE_OFF.USER_ID, COM_USER_IDENTITY_USER_ID.NAME as IDENTITY_USER_ID_NAME, COM_TYPE_WRITE_OFF_TYPE_ID.NAME as WRITE_OFF_TYPE_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = 6 then '审批不通过' else '' end ) as IDENTITY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.STATE = 3 then '鉴定同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 4 then '鉴定不同意' when MCE_B_ASSETS_WRITE_OFF.STATE = 5 then '审批通过' when MCE_B_ASSETS_WRITE_OFF.STATE = 6 then '审批不通过' else '' end ) as STATE_NAME, COM_TYPE_WRITE_OFF_CAUSE_ID.NAME as WRITE_OFF_CAUSE_ID_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, (case  when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF left join COM_USER   COM_USER_IDENTITY_USER_ID on MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = COM_USER_IDENTITY_USER_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_TYPE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = COM_TYPE_WRITE_OFF_TYPE_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_WRITE_OFF.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_WRITE_OFF_CAUSE_ID on MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = COM_TYPE_WRITE_OFF_CAUSE_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IDENTITY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_PARAM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.WRITE_OFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IDENTITY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IDENTITY_STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.INCOME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WRITE_OFF_CAUSE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SUMARRY = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.USAGE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.USER_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IDENTITY_USER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.WRITE_OFF_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IDENTITY_STATE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.WRITE_OFF_CAUSE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(41);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTITY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.IDENTITY_USER_ID = :U_IDENTITY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTITY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.IDENTITY_USER_ID) ? string.Empty : obj.IDENTITY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTITY_PARAM"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.IDENTITY_PARAM = :U_IDENTITY_PARAM");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTITY_PARAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.IDENTITY_PARAM) ? string.Empty : obj.IDENTITY_PARAM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NET_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.NET_VALUE = :U_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NET_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WRITE_OFF_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_TYPE_ID = :U_WRITE_OFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_WRITE_OFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.WRITE_OFF_TYPE_ID) ? string.Empty : obj.WRITE_OFF_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_CYCLE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.FINANCE_CYCLE = :U_FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_CYCLE) ? string.Empty : obj.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTITY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.IDENTITY_TIME = :U_IDENTITY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTITY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.IDENTITY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORIGINAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.ORIGINAL_VALUE = :U_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTITY_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.IDENTITY_STATE = :U_IDENTITY_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTITY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IDENTITY_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RUDIMENTAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.RUDIMENTAL_VALUE = :U_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INCOME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.INCOME = :U_INCOME");
				param = new OracleParameter();
				param.ParameterName = ":U_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.INCOME) ? string.Empty : obj.INCOME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WRITE_OFF_CAUSE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.WRITE_OFF_CAUSE_ID = :U_WRITE_OFF_CAUSE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_WRITE_OFF_CAUSE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.WRITE_OFF_CAUSE_ID) ? string.Empty : obj.WRITE_OFF_CAUSE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMARRY"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.SUMARRY = :U_SUMARRY");
				param = new OracleParameter();
				param.ParameterName = ":U_SUMARRY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SUMARRY) ? string.Empty : obj.SUMARRY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USAGE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.USAGE = :U_USAGE");
				param = new OracleParameter();
				param.ParameterName = ":U_USAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.USAGE) ? string.Empty : obj.USAGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
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
