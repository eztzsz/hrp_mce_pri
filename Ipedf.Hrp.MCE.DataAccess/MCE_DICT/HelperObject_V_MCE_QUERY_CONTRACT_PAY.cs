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
	[CauseObject(typeof(CauseObject_V_MCE_QUERY_CONTRACT_PAY))]
	public partial class HelperObject_V_MCE_QUERY_CONTRACT_PAY
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_QUERY_CONTRACT_PAY( STATE_NAME, H_STATE, ID, PLAN_PAY_DATE, STATE, CONTRACT_STATE, NAME, ACTUAL_PAY_DATE, CODE, MONEY, PERIODS, SECOND_PARTY, SECOND_PARTY_NAME) values ( :STATE_NAME, :H_STATE, :ID, :PLAN_PAY_DATE, :STATE, :CONTRACT_STATE, :NAME, :ACTUAL_PAY_DATE, :CODE, :MONEY, :PERIODS, :SECOND_PARTY, :SECOND_PARTY_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[13];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":STATE_NAME";
			parameters[0].Size = 6;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.STATE_NAME == null ? String.Empty:obj.STATE_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":H_STATE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.H_STATE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":PLAN_PAY_DATE";
			parameters[3].Size = 7;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[3].Value = obj.PLAN_PAY_DATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CONTRACT_STATE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.CONTRACT_STATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NAME";
			parameters[6].Size = 100;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ACTUAL_PAY_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.ACTUAL_PAY_DATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CODE";
			parameters[8].Size = 100;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":MONEY";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.MONEY;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PERIODS";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.PERIODS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SECOND_PARTY";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.SECOND_PARTY == null ? String.Empty:obj.SECOND_PARTY;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":SECOND_PARTY_NAME";
			parameters[12].Size = 200;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.SECOND_PARTY_NAME == null ? String.Empty:obj.SECOND_PARTY_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_QUERY_CONTRACT_PAY set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj,CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_QUERY_CONTRACT_PAY set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_QUERY_CONTRACT_PAY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_QUERY_CONTRACT_PAY Get(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  STATE_NAME, H_STATE, ID, PLAN_PAY_DATE, STATE, CONTRACT_STATE, NAME, ACTUAL_PAY_DATE, CODE, MONEY, PERIODS, SECOND_PARTY, SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new EntityObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY Get(DisplayObject_V_MCE_QUERY_CONTRACT_PAY obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_QUERY_CONTRACT_PAY Get(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  STATE_NAME, H_STATE, ID, PLAN_PAY_DATE, STATE, CONTRACT_STATE, NAME, ACTUAL_PAY_DATE, CODE, MONEY, PERIODS, SECOND_PARTY, SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new EntityObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.STATE_NAME))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.STATE_NAME ").Append((cause.STATE_NAME.StartsWith("%") || cause.STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "STATE_NAME"));
			}
			if(cause.H_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.H_STATE = :C_H_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_H_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.H_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("H_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "H_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "ID"));
			}
			if(cause.PLAN_PAY_DATE!= null)
			{
				if (cause.PLAN_PAY_DATE.Begin != null)
				{
					strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE >= :C_PLAN_PAY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PLAN_PAY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_PAY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PLAN_PAY_DATE.End != null)
				{
					strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE < :C_PLAN_PAY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PLAN_PAY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_PAY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PLAN_PAY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "PLAN_PAY_DATE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "STATE"));
			}
			if(cause.CONTRACT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE = :C_CONTRACT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_CONTRACT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTRACT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTRACT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "CONTRACT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "NAME"));
			}
			if(cause.ACTUAL_PAY_DATE!= null)
			{
				if (cause.ACTUAL_PAY_DATE.Begin != null)
				{
					strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE >= :C_ACTUAL_PAY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_PAY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_PAY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ACTUAL_PAY_DATE.End != null)
				{
					strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE < :C_ACTUAL_PAY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_PAY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_PAY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ACTUAL_PAY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "ACTUAL_PAY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "CODE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "MONEY"));
			}
			if(cause.PERIODS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.PERIODS = :C_PERIODS");
				param = new OracleParameter();
				param.ParameterName =":C_PERIODS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PERIODS;
				paramList.Add(param);
			}
			if (cause.HasINValue("PERIODS"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "PERIODS"));
			}
			if(!string.IsNullOrEmpty(cause.SECOND_PARTY))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY ").Append((cause.SECOND_PARTY.StartsWith("%") || cause.SECOND_PARTY.EndsWith("%")) ? " like " : " = ").Append(" :C_SECOND_PARTY");
				param = new OracleParameter();
				param.ParameterName =":C_SECOND_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SECOND_PARTY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECOND_PARTY"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "SECOND_PARTY"));
			}
			if(!string.IsNullOrEmpty(cause.SECOND_PARTY_NAME))
			{
				strBuf.Append(" And V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME ").Append((cause.SECOND_PARTY_NAME.StartsWith("%") || cause.SECOND_PARTY_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SECOND_PARTY_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SECOND_PARTY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SECOND_PARTY_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECOND_PARTY_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_QUERY_CONTRACT_PAY", "SECOND_PARTY_NAME"));
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
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_QUERY_CONTRACT_PAY",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME, V_MCE_QUERY_CONTRACT_PAY.H_STATE, V_MCE_QUERY_CONTRACT_PAY.ID, V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.STATE, V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE, V_MCE_QUERY_CONTRACT_PAY.NAME, V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE, V_MCE_QUERY_CONTRACT_PAY.CODE, V_MCE_QUERY_CONTRACT_PAY.MONEY, V_MCE_QUERY_CONTRACT_PAY.PERIODS, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY, V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME from V_MCE_QUERY_CONTRACT_PAY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_QUERY_CONTRACT_PAY",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STATE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.H_STATE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PERIODS = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] objs = new DisplayObject_V_MCE_QUERY_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("STATE_NAME"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.STATE_NAME = :U_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.STATE_NAME) ? string.Empty : obj.STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("H_STATE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.H_STATE = :U_H_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_H_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.H_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_PAY_DATE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.PLAN_PAY_DATE = :U_PLAN_PAY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_PAY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PLAN_PAY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTRACT_STATE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.CONTRACT_STATE = :U_CONTRACT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTRACT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTRACT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACTUAL_PAY_DATE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.ACTUAL_PAY_DATE = :U_ACTUAL_PAY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ACTUAL_PAY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ACTUAL_PAY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PERIODS"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.PERIODS = :U_PERIODS");
				param = new OracleParameter();
				param.ParameterName = ":U_PERIODS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PERIODS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECOND_PARTY"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY = :U_SECOND_PARTY");
				param = new OracleParameter();
				param.ParameterName = ":U_SECOND_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SECOND_PARTY) ? string.Empty : obj.SECOND_PARTY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECOND_PARTY_NAME"))
			{
				strBuf.Add("  V_MCE_QUERY_CONTRACT_PAY.SECOND_PARTY_NAME = :U_SECOND_PARTY_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_SECOND_PARTY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SECOND_PARTY_NAME) ? string.Empty : obj.SECOND_PARTY_NAME;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		
		#endregion 
	}
}
