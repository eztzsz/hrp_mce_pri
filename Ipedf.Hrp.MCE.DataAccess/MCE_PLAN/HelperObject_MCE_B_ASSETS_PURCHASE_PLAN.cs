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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN))]
	public partial class HelperObject_MCE_B_ASSETS_PURCHASE_PLAN
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_PURCHASE_PLAN( CREATE_TIME, APPLY_USER_ID, CREATE_DEPT_ID, CREATE_DATE, DATA_ORGANISE_ID, ID, CREATE_USER_ID, PURCHASE_DEPT_ID, CURRENCY_ID, PRV_ID, PRV_NAME, STATE, APPLY_MONEY, AUDIT_USER_ID, NAME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, APPLY_COMMENTS, APPLY_DEPT_ID, REF_PRV_ID) values ( :CREATE_TIME, :APPLY_USER_ID, :CREATE_DEPT_ID, :CREATE_DATE, :DATA_ORGANISE_ID, :ID, :CREATE_USER_ID, :PURCHASE_DEPT_ID, :CURRENCY_ID, :PRV_ID, :PRV_NAME, :STATE, :APPLY_MONEY, :AUDIT_USER_ID, :NAME, :MODIFY_DEPT_ID, :CODE, :AUDIT_TIME, :COMMENTS, :APPLY_COMMENTS, :APPLY_DEPT_ID, :REF_PRV_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[22];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CREATE_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.CREATE_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":APPLY_USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_DEPT_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CREATE_DATE";
			parameters[3].Size = 7;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[3].Value = obj.CREATE_DATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":DATA_ORGANISE_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PURCHASE_DEPT_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.PURCHASE_DEPT_ID == null ? String.Empty:obj.PURCHASE_DEPT_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CURRENCY_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PRV_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.PRV_ID == null ? String.Empty:obj.PRV_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PRV_NAME";
			parameters[10].Size = 100;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.PRV_NAME == null ? String.Empty:obj.PRV_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":STATE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.STATE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":APPLY_MONEY";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.APPLY_MONEY;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":AUDIT_USER_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":NAME";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":MODIFY_DEPT_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CODE";
			parameters[16].Size = 50;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":AUDIT_TIME";
			parameters[17].Size = 7;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[17].Value = obj.AUDIT_TIME;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":COMMENTS";
			parameters[18].Size = 200;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":APPLY_COMMENTS";
			parameters[19].Size = 200;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.APPLY_COMMENTS == null ? String.Empty:obj.APPLY_COMMENTS;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":APPLY_DEPT_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.APPLY_DEPT_ID == null ? String.Empty:obj.APPLY_DEPT_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":REF_PRV_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.REF_PRV_ID == null ? String.Empty:obj.REF_PRV_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE_PLAN set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj,CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE_PLAN set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_PURCHASE_PLAN where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_PURCHASE_PLAN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_TIME, APPLY_USER_ID, CREATE_DEPT_ID, CREATE_DATE, DATA_ORGANISE_ID, ID, CREATE_USER_ID, PURCHASE_DEPT_ID, MODIFY_USER_ID, CURRENCY_ID, PRV_ID, PRV_NAME, STATE, APPLY_MONEY, AUDIT_USER_ID, NAME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, APPLY_COMMENTS, MODIFY_TIME, APPLY_DEPT_ID, REF_PRV_ID from MCE_B_ASSETS_PURCHASE_PLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN Get(DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1) and MCE_B_ASSETS_PURCHASE_PLAN.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_TIME, APPLY_USER_ID, CREATE_DEPT_ID, CREATE_DATE, DATA_ORGANISE_ID, ID, CREATE_USER_ID, PURCHASE_DEPT_ID, MODIFY_USER_ID, CURRENCY_ID, PRV_ID, PRV_NAME, STATE, APPLY_MONEY, AUDIT_USER_ID, NAME, MODIFY_DEPT_ID, CODE, AUDIT_TIME, COMMENTS, APPLY_COMMENTS, MODIFY_TIME, APPLY_DEPT_ID, REF_PRV_ID from MCE_B_ASSETS_PURCHASE_PLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "APPLY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CREATE_DEPT_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHASE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID ").Append((cause.PURCHASE_DEPT_ID.StartsWith("%") || cause.PURCHASE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHASE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHASE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PURCHASE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "PURCHASE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CURRENCY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID ").Append((cause.PRV_ID.StartsWith("%") || cause.PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "PRV_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME ").Append((cause.PRV_NAME.StartsWith("%") || cause.PRV_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRV_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "PRV_NAME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "STATE"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY = :C_APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "APPLY_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "CODE"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS ").Append((cause.APPLY_COMMENTS.StartsWith("%") || cause.APPLY_COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "APPLY_COMMENTS"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID ").Append((cause.APPLY_DEPT_ID.StartsWith("%") || cause.APPLY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "APPLY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID ").Append((cause.REF_PRV_ID.StartsWith("%") || cause.REF_PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN", "REF_PRV_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE_PLAN",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE, MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE_PLAN.ID, MCE_B_ASSETS_PURCHASE_PLAN.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN.STATE, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE_PLAN.NAME, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.CODE, MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME, MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME, MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_PURCHASE_DEPT_ID.NAME as PURCHASE_DEPT_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE_PLAN.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_PURCHASE_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = COM_DEPART_PURCHASE_DEPT_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE_PLAN",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PURCHASE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRV_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PURCHASE_DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(28);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.APPLY_USER_ID = :U_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.PURCHASE_DEPT_ID = :U_PURCHASE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PURCHASE_DEPT_ID) ? string.Empty : obj.PURCHASE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.PRV_ID = :U_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRV_ID) ? string.Empty : obj.PRV_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.PRV_NAME = :U_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRV_NAME) ? string.Empty : obj.PRV_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.APPLY_MONEY = :U_APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.APPLY_COMMENTS = :U_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.APPLY_COMMENTS) ? string.Empty : obj.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.APPLY_DEPT_ID = :U_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_DEPT_ID) ? string.Empty : obj.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN.REF_PRV_ID = :U_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRV_ID) ? string.Empty : obj.REF_PRV_ID;
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
