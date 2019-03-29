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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_INSURANCE))]
	public partial class HelperObject_MCE_B_ASSETS_INSURANCE
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_INSURANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_INSURANCE( BACKUP1, COMMENTS, FEE_MONEY, ID, EFFECT_DATE, ASSETS_ID, AUDIT_STATE, STATE, EXPIRE_DATE, AUDIT_USER_ID, NAME, CODE, MATER, AUDIT_TIME, INSURANCE_MONEY, INSURANCE_UNIT) values ( :BACKUP1, :COMMENTS, :FEE_MONEY, :ID, :EFFECT_DATE, :ASSETS_ID, :AUDIT_STATE, :STATE, :EXPIRE_DATE, :AUDIT_USER_ID, :NAME, :CODE, :MATER, :AUDIT_TIME, :INSURANCE_MONEY, :INSURANCE_UNIT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[16];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BACKUP1";
			parameters[0].Size = 1000;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COMMENTS";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FEE_MONEY";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.FEE_MONEY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":EFFECT_DATE";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.EFFECT_DATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ASSETS_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AUDIT_STATE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.AUDIT_STATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":STATE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.STATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":EXPIRE_DATE";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.EXPIRE_DATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":AUDIT_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":NAME";
			parameters[10].Size = 100;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CODE";
			parameters[11].Size = 100;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MATER";
			parameters[12].Size = 100;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.MATER == null ? String.Empty:obj.MATER;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":AUDIT_TIME";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.AUDIT_TIME;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":INSURANCE_MONEY";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.INSURANCE_MONEY;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":INSURANCE_UNIT";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.INSURANCE_UNIT == null ? String.Empty:obj.INSURANCE_UNIT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSURANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSURANCE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSURANCE obj,CauseObject_MCE_B_ASSETS_INSURANCE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSURANCE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_INSURANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_INSURANCE where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_INSURANCE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_INSURANCE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_INSURANCE Get(EntityObject_MCE_B_ASSETS_INSURANCE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, FEE_MONEY, ID, EFFECT_DATE, ASSETS_ID, AUDIT_STATE, STATE, EXPIRE_DATE, AUDIT_USER_ID, NAME, CODE, MATER, AUDIT_TIME, INSURANCE_MONEY, INSURANCE_UNIT from MCE_B_ASSETS_INSURANCE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_INSURANCE[] objs = new EntityObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSURANCE Get(DisplayObject_MCE_B_ASSETS_INSURANCE obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1) and MCE_B_ASSETS_INSURANCE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_INSURANCE Get(EntityObject_MCE_B_ASSETS_INSURANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, FEE_MONEY, ID, EFFECT_DATE, ASSETS_ID, AUDIT_STATE, STATE, EXPIRE_DATE, AUDIT_USER_ID, NAME, CODE, MATER, AUDIT_TIME, INSURANCE_MONEY, INSURANCE_UNIT from MCE_B_ASSETS_INSURANCE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_INSURANCE[] objs = new EntityObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSURANCE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_INSURANCE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "COMMENTS"));
			}
			if(cause.FEE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.FEE_MONEY = :C_FEE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_FEE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FEE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FEE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "FEE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "ID"));
			}
			if(cause.EFFECT_DATE!= null)
			{
				if (cause.EFFECT_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.EFFECT_DATE >= :C_EFFECT_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_EFFECT_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EFFECT_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.EFFECT_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.EFFECT_DATE < :C_EFFECT_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_EFFECT_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EFFECT_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("EFFECT_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "EFFECT_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "ASSETS_ID"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "AUDIT_STATE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "STATE"));
			}
			if(cause.EXPIRE_DATE!= null)
			{
				if (cause.EXPIRE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.EXPIRE_DATE >= :C_EXPIRE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_EXPIRE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXPIRE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.EXPIRE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.EXPIRE_DATE < :C_EXPIRE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_EXPIRE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXPIRE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("EXPIRE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "EXPIRE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MATER))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.MATER ").Append((cause.MATER.StartsWith("%") || cause.MATER.EndsWith("%")) ? " like " : " = ").Append(" :C_MATER");
				param = new OracleParameter();
				param.ParameterName =":C_MATER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MATER;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "MATER"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSURANCE.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "AUDIT_TIME"));
			}
			if(cause.INSURANCE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY = :C_INSURANCE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_INSURANCE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.INSURANCE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSURANCE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "INSURANCE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.INSURANCE_UNIT))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT ").Append((cause.INSURANCE_UNIT.StartsWith("%") || cause.INSURANCE_UNIT.EndsWith("%")) ? " like " : " = ").Append(" :C_INSURANCE_UNIT");
				param = new OracleParameter();
				param.ParameterName =":C_INSURANCE_UNIT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.INSURANCE_UNIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSURANCE_UNIT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSURANCE", "INSURANCE_UNIT"));
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
		public static DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSURANCE",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSURANCE.BACKUP1, MCE_B_ASSETS_INSURANCE.COMMENTS, MCE_B_ASSETS_INSURANCE.FEE_MONEY, MCE_B_ASSETS_INSURANCE.ID, MCE_B_ASSETS_INSURANCE.EFFECT_DATE, MCE_B_ASSETS_INSURANCE.ASSETS_ID, MCE_B_ASSETS_INSURANCE.AUDIT_STATE, MCE_B_ASSETS_INSURANCE.STATE, MCE_B_ASSETS_INSURANCE.EXPIRE_DATE, MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID, MCE_B_ASSETS_INSURANCE.NAME, MCE_B_ASSETS_INSURANCE.CODE, MCE_B_ASSETS_INSURANCE.MATER, MCE_B_ASSETS_INSURANCE.AUDIT_TIME, MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY, MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_INSURANCE.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, (case  when MCE_B_ASSETS_INSURANCE.STATE = 1 then '正常' when MCE_B_ASSETS_INSURANCE.STATE = 2 then '过期' else '' end ) as STATE_NAME, MDM_D_DEPT_INSURANCE_UNIT.NAME as INSURANCE_UNIT_NAME from MCE_B_ASSETS_INSURANCE left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_INSURANCE.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_INSURANCE_UNIT on MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = MDM_D_DEPT_INSURANCE_UNIT.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSURANCE",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_INSURANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSURANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FEE_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EFFECT_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATER = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.INSURANCE_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.INSURANCE_UNIT = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.INSURANCE_UNIT_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSURANCE[] objs = new DisplayObject_MCE_B_ASSETS_INSURANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_INSURANCE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FEE_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.FEE_MONEY = :U_FEE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_FEE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FEE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EFFECT_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.EFFECT_DATE = :U_EFFECT_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_EFFECT_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.EFFECT_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXPIRE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.EXPIRE_DATE = :U_EXPIRE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_EXPIRE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.EXPIRE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.MATER = :U_MATER");
				param = new OracleParameter();
				param.ParameterName = ":U_MATER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.MATER) ? string.Empty : obj.MATER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSURANCE_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.INSURANCE_MONEY = :U_INSURANCE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_INSURANCE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.INSURANCE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSURANCE_UNIT"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSURANCE.INSURANCE_UNIT = :U_INSURANCE_UNIT");
				param = new OracleParameter();
				param.ParameterName = ":U_INSURANCE_UNIT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.INSURANCE_UNIT) ? string.Empty : obj.INSURANCE_UNIT;
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
