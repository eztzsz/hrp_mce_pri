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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_AFFIX))]
	public partial class HelperObject_MCE_B_ASSETS_AFFIX
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_AFFIX obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_AFFIX( BACKUP1, COMMENTS, SPEC, ID, ASSETS_ID, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, NAME, CODE, AMOUNT, BACKUP2) values ( :BACKUP1, :COMMENTS, :SPEC, :ID, :ASSETS_ID, :AUDIT_TIME, :AUDIT_STATE, :AUDIT_USER_ID, :NAME, :CODE, :AMOUNT, :BACKUP2)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
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
			parameters[2].ParameterName =":SPEC";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ASSETS_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":AUDIT_TIME";
			parameters[5].Size = 7;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[5].Value = obj.AUDIT_TIME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AUDIT_STATE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.AUDIT_STATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":AUDIT_USER_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":NAME";
			parameters[8].Size = 100;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CODE";
			parameters[9].Size = 100;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":AMOUNT";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.AMOUNT;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":BACKUP2";
			parameters[11].Size = 1000;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.BACKUP2 == null ? String.Empty:obj.BACKUP2;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_AFFIX obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_AFFIX set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_AFFIX obj,CauseObject_MCE_B_ASSETS_AFFIX cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_AFFIX set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_AFFIX obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_AFFIX where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_AFFIX cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_AFFIX where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_AFFIX Get(EntityObject_MCE_B_ASSETS_AFFIX obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, SPEC, ID, ASSETS_ID, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, NAME, CODE, AMOUNT, BACKUP2 from MCE_B_ASSETS_AFFIX where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_AFFIX[] objs = new EntityObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_AFFIX Get(DisplayObject_MCE_B_ASSETS_AFFIX obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1) and MCE_B_ASSETS_AFFIX.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_AFFIX Get(EntityObject_MCE_B_ASSETS_AFFIX obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, SPEC, ID, ASSETS_ID, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, NAME, CODE, AMOUNT, BACKUP2 from MCE_B_ASSETS_AFFIX where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_AFFIX[] objs = new EntityObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_AFFIX[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_AFFIX cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "ASSETS_ID"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_AFFIX.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_AFFIX.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "AUDIT_TIME"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "CODE"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.AMOUNT = :C_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP2))
			{
				strBuf.Append(" And MCE_B_ASSETS_AFFIX.BACKUP2 ").Append((cause.BACKUP2.StartsWith("%") || cause.BACKUP2.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP2");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP2;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP2"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_AFFIX", "BACKUP2"));
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
		public static DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_AFFIX",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_AFFIX.BACKUP1, MCE_B_ASSETS_AFFIX.COMMENTS, MCE_B_ASSETS_AFFIX.SPEC, MCE_B_ASSETS_AFFIX.ID, MCE_B_ASSETS_AFFIX.ASSETS_ID, MCE_B_ASSETS_AFFIX.AUDIT_TIME, MCE_B_ASSETS_AFFIX.AUDIT_STATE, MCE_B_ASSETS_AFFIX.AUDIT_USER_ID, MCE_B_ASSETS_AFFIX.NAME, MCE_B_ASSETS_AFFIX.CODE, MCE_B_ASSETS_AFFIX.AMOUNT, MCE_B_ASSETS_AFFIX.BACKUP2, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_AFFIX.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME from MCE_B_ASSETS_AFFIX left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_AFFIX.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_AFFIX",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_AFFIX dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_AFFIX();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BACKUP2 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_AFFIX[] objs = new DisplayObject_MCE_B_ASSETS_AFFIX[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_AFFIX obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.AMOUNT = :U_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP2"))
			{
				strBuf.Add("  MCE_B_ASSETS_AFFIX.BACKUP2 = :U_BACKUP2");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP2) ? string.Empty : obj.BACKUP2;
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
