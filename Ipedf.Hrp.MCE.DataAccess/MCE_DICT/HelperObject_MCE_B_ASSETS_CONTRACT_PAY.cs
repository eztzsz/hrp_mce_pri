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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_CONTRACT_PAY))]
	public partial class HelperObject_MCE_B_ASSETS_CONTRACT_PAY
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_CONTRACT_PAY( PERIODS, BASE_ID, PLAN_PAY_DATE, COMMENTS, STATE, MONEY, ID, ACTUAL_PAY_DATE) values ( :PERIODS, :BASE_ID, :PLAN_PAY_DATE, :COMMENTS, :STATE, :MONEY, :ID, :ACTUAL_PAY_DATE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":PERIODS";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.PERIODS;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PLAN_PAY_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.PLAN_PAY_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MONEY";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.MONEY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ACTUAL_PAY_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.ACTUAL_PAY_DATE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CONTRACT_PAY set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj,CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CONTRACT_PAY set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_CONTRACT_PAY where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_CONTRACT_PAY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_CONTRACT_PAY Get(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PERIODS, BASE_ID, PLAN_PAY_DATE, COMMENTS, STATE, MONEY, ID, ACTUAL_PAY_DATE from MCE_B_ASSETS_CONTRACT_PAY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY Get(DisplayObject_MCE_B_ASSETS_CONTRACT_PAY obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1) and MCE_B_ASSETS_CONTRACT_PAY.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_CONTRACT_PAY Get(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PERIODS, BASE_ID, PLAN_PAY_DATE, COMMENTS, STATE, MONEY, ID, ACTUAL_PAY_DATE from MCE_B_ASSETS_CONTRACT_PAY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.PERIODS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.PERIODS = :C_PERIODS");
				param = new OracleParameter();
				param.ParameterName =":C_PERIODS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PERIODS;
				paramList.Add(param);
			}
			if (cause.HasINValue("PERIODS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "PERIODS"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "BASE_ID"));
			}
			if(cause.PLAN_PAY_DATE!= null)
			{
				if (cause.PLAN_PAY_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE >= :C_PLAN_PAY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PLAN_PAY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_PAY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PLAN_PAY_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE < :C_PLAN_PAY_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "PLAN_PAY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "COMMENTS"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "STATE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "ID"));
			}
			if(cause.ACTUAL_PAY_DATE!= null)
			{
				if (cause.ACTUAL_PAY_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE >= :C_ACTUAL_PAY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_PAY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_PAY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ACTUAL_PAY_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE < :C_ACTUAL_PAY_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT_PAY", "ACTUAL_PAY_DATE"));
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
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CONTRACT_PAY",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT_PAY.PERIODS, MCE_B_ASSETS_CONTRACT_PAY.BASE_ID, MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE, MCE_B_ASSETS_CONTRACT_PAY.COMMENTS, MCE_B_ASSETS_CONTRACT_PAY.STATE, MCE_B_ASSETS_CONTRACT_PAY.MONEY, MCE_B_ASSETS_CONTRACT_PAY.ID, MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE, MCE_B_ASSETS_CONTRACT_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT_PAY.STATE = 1 then '已付款' when MCE_B_ASSETS_CONTRACT_PAY.STATE = 2 then '未付款' else '' end ) as STATE_NAME from MCE_B_ASSETS_CONTRACT_PAY left join MCE_B_ASSETS_CONTRACT   MCE_B_ASSETS_CONTRACT_BASE_ID on MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = MCE_B_ASSETS_CONTRACT_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CONTRACT_PAY",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PERIODS = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PLAN_PAY_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ACTUAL_PAY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PERIODS"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.PERIODS = :U_PERIODS");
				param = new OracleParameter();
				param.ParameterName = ":U_PERIODS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PERIODS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_PAY_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.PLAN_PAY_DATE = :U_PLAN_PAY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_PAY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PLAN_PAY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACTUAL_PAY_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT_PAY.ACTUAL_PAY_DATE = :U_ACTUAL_PAY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ACTUAL_PAY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ACTUAL_PAY_DATE;
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
