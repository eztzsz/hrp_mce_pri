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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_APPLY_EN))]
	public partial class HelperObject_MCE_B_ASSETS_MT_APPLY_EN
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_MT_APPLY_EN( ADVISE, BASE_ID, RESULT, COMMENTS, USER_ID, COMPLETE_TIME, ID, HOURS, IS_CLOSE) values ( :ADVISE, :BASE_ID, :RESULT, :COMMENTS, :USER_ID, :COMPLETE_TIME, :ID, :HOURS, :IS_CLOSE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ADVISE";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ADVISE == null ? String.Empty:obj.ADVISE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":RESULT";
			parameters[2].Size = 200;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.RESULT == null ? String.Empty:obj.RESULT;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":USER_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":COMPLETE_TIME";
			parameters[5].Size = 7;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[5].Value = obj.COMPLETE_TIME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":HOURS";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.HOURS;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":IS_CLOSE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.IS_CLOSE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_APPLY_EN set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj,CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_APPLY_EN set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_MT_APPLY_EN where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_MT_APPLY_EN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_MT_APPLY_EN Get(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ADVISE, BASE_ID, RESULT, COMMENTS, USER_ID, COMPLETE_TIME, ID, HOURS, IS_CLOSE from MCE_B_ASSETS_MT_APPLY_EN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new EntityObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN Get(DisplayObject_MCE_B_ASSETS_MT_APPLY_EN obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1) and MCE_B_ASSETS_MT_APPLY_EN.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_MT_APPLY_EN Get(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ADVISE, BASE_ID, RESULT, COMMENTS, USER_ID, COMPLETE_TIME, ID, HOURS, IS_CLOSE from MCE_B_ASSETS_MT_APPLY_EN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new EntityObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ADVISE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.ADVISE ").Append((cause.ADVISE.StartsWith("%") || cause.ADVISE.EndsWith("%")) ? " like " : " = ").Append(" :C_ADVISE");
				param = new OracleParameter();
				param.ParameterName =":C_ADVISE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ADVISE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADVISE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "ADVISE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.RESULT))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.RESULT ").Append((cause.RESULT.StartsWith("%") || cause.RESULT.EndsWith("%")) ? " like " : " = ").Append(" :C_RESULT");
				param = new OracleParameter();
				param.ParameterName =":C_RESULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.RESULT;
				paramList.Add(param);
			}
			if (cause.HasINValue("RESULT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "RESULT"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "USER_ID"));
			}
			if(cause.COMPLETE_TIME!= null)
			{
				if (cause.COMPLETE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME >= :C_COMPLETE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_COMPLETE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.COMPLETE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME < :C_COMPLETE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_COMPLETE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("COMPLETE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "COMPLETE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "ID"));
			}
			if(cause.HOURS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.HOURS = :C_HOURS");
				param = new OracleParameter();
				param.ParameterName =":C_HOURS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.HOURS;
				paramList.Add(param);
			}
			if (cause.HasINValue("HOURS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "HOURS"));
			}
			if(cause.IS_CLOSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE = :C_IS_CLOSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CLOSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CLOSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CLOSE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY_EN", "IS_CLOSE"));
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
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_APPLY_EN",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY_EN.ADVISE, MCE_B_ASSETS_MT_APPLY_EN.BASE_ID, MCE_B_ASSETS_MT_APPLY_EN.RESULT, MCE_B_ASSETS_MT_APPLY_EN.COMMENTS, MCE_B_ASSETS_MT_APPLY_EN.USER_ID, MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY_EN.ID, MCE_B_ASSETS_MT_APPLY_EN.HOURS, MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE, MCE_B_ASSETS_MT_APPLY_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_MT_APPLY_EN left join MCE_B_ASSETS_MT_APPLY   MCE_B_ASSETS_MT_APPLY_BASE_ID on MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = MCE_B_ASSETS_MT_APPLY_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_MT_APPLY_EN.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_APPLY_EN",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ADVISE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.RESULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HOURS = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_CLOSE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ADVISE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.ADVISE = :U_ADVISE");
				param = new OracleParameter();
				param.ParameterName = ":U_ADVISE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ADVISE) ? string.Empty : obj.ADVISE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RESULT"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.RESULT = :U_RESULT");
				param = new OracleParameter();
				param.ParameterName = ":U_RESULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.RESULT) ? string.Empty : obj.RESULT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMPLETE_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.COMPLETE_TIME = :U_COMPLETE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_COMPLETE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.COMPLETE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HOURS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.HOURS = :U_HOURS");
				param = new OracleParameter();
				param.ParameterName = ":U_HOURS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.HOURS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CLOSE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY_EN.IS_CLOSE = :U_IS_CLOSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_CLOSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CLOSE;
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
