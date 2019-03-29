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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT))]
	public partial class HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_CAPITAL_ALLOT( AUDIT_STATE, BACKUP1, ALLOT_MONEY, COMMENTS, AUDIT_TIME, RATIO, AUDIT_USER_ID, CAPITAL_SOURCE_TYPE_ID, ASSETS_ID, ID, CREATE_TIME) values ( :AUDIT_STATE, :BACKUP1, :ALLOT_MONEY, :COMMENTS, :AUDIT_TIME, :RATIO, :AUDIT_USER_ID, :CAPITAL_SOURCE_TYPE_ID, :ASSETS_ID, :ID, :CREATE_TIME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":AUDIT_STATE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.AUDIT_STATE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BACKUP1";
			parameters[1].Size = 1000;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ALLOT_MONEY";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.ALLOT_MONEY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":AUDIT_TIME";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.AUDIT_TIME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":RATIO";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.RATIO;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AUDIT_USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CAPITAL_SOURCE_TYPE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.CAPITAL_SOURCE_TYPE_ID == null ? String.Empty:obj.CAPITAL_SOURCE_TYPE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ASSETS_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CAPITAL_ALLOT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj,CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CAPITAL_ALLOT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_CAPITAL_ALLOT where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_CAPITAL_ALLOT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT Get(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_STATE, BACKUP1, ALLOT_MONEY, COMMENTS, AUDIT_TIME, RATIO, AUDIT_USER_ID, CAPITAL_SOURCE_TYPE_ID, ASSETS_ID, ID, CREATE_TIME from MCE_B_ASSETS_CAPITAL_ALLOT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT Get(DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1) and MCE_B_ASSETS_CAPITAL_ALLOT.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT Get(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_STATE, BACKUP1, ALLOT_MONEY, COMMENTS, AUDIT_TIME, RATIO, AUDIT_USER_ID, CAPITAL_SOURCE_TYPE_ID, ASSETS_ID, ID, CREATE_TIME from MCE_B_ASSETS_CAPITAL_ALLOT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "BACKUP1"));
			}
			if(cause.ALLOT_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY = :C_ALLOT_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_ALLOT_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ALLOT_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("ALLOT_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "ALLOT_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "COMMENTS"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "AUDIT_TIME"));
			}
			if(cause.RATIO!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.RATIO = :C_RATIO");
				param = new OracleParameter();
				param.ParameterName =":C_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RATIO;
				paramList.Add(param);
			}
			if (cause.HasINValue("RATIO"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "RATIO"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CAPITAL_SOURCE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID ").Append((cause.CAPITAL_SOURCE_TYPE_ID.StartsWith("%") || cause.CAPITAL_SOURCE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CAPITAL_SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CAPITAL_SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CAPITAL_SOURCE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CAPITAL_SOURCE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "CAPITAL_SOURCE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CAPITAL_ALLOT", "CREATE_TIME"));
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
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CAPITAL_ALLOT",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE, MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1, MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY, MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME, MCE_B_ASSETS_CAPITAL_ALLOT.RATIO, MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID, MCE_B_ASSETS_CAPITAL_ALLOT.ID, MCE_B_ASSETS_CAPITAL_ALLOT.CREATE_TIME, (case  when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_CAPITAL_ALLOT left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CAPITAL_ALLOT",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BACKUP1 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ALLOT_MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.RATIO = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ALLOT_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.ALLOT_MONEY = :U_ALLOT_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_ALLOT_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ALLOT_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RATIO"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.RATIO = :U_RATIO");
				param = new OracleParameter();
				param.ParameterName = ":U_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RATIO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CAPITAL_SOURCE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.CAPITAL_SOURCE_TYPE_ID = :U_CAPITAL_SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CAPITAL_SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CAPITAL_SOURCE_TYPE_ID) ? string.Empty : obj.CAPITAL_SOURCE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CAPITAL_ALLOT.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
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
