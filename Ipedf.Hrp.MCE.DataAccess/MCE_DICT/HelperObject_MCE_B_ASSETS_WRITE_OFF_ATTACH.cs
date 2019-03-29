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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH))]
	public partial class HelperObject_MCE_B_ASSETS_WRITE_OFF_ATTACH
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_WRITE_OFF_ATTACH( BASE_ID, CREATE_DATE, SAVENAME, USER_ID, FILE_NAME, ID) values ( :BASE_ID, :CREATE_DATE, :SAVENAME, :USER_ID, :FILE_NAME, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BASE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CREATE_DATE";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.CREATE_DATE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SAVENAME";
			parameters[2].Size = 300;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SAVENAME == null ? String.Empty:obj.SAVENAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":USER_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FILE_NAME";
			parameters[4].Size = 300;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FILE_NAME == null ? String.Empty:obj.FILE_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF_ATTACH set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj,CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF_ATTACH set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF_ATTACH where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF_ATTACH where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Get(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BASE_ID, CREATE_DATE, SAVENAME, USER_ID, FILE_NAME, ID from MCE_B_ASSETS_WRITE_OFF_ATTACH where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Get(DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1) and MCE_B_ASSETS_WRITE_OFF_ATTACH.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Get(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BASE_ID, CREATE_DATE, SAVENAME, USER_ID, FILE_NAME, ID from MCE_B_ASSETS_WRITE_OFF_ATTACH where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "BASE_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.SAVENAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME ").Append((cause.SAVENAME.StartsWith("%") || cause.SAVENAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SAVENAME");
				param = new OracleParameter();
				param.ParameterName =":C_SAVENAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SAVENAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SAVENAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "SAVENAME"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FILE_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME ").Append((cause.FILE_NAME.StartsWith("%") || cause.FILE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_FILE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_FILE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.FILE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "FILE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_ATTACH.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_ATTACH", "ID"));
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
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF_ATTACH",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE, MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID, MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME, MCE_B_ASSETS_WRITE_OFF_ATTACH.ID, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME, COM_USER_USER_ID.NAME as USER_ID_NAME from MCE_B_ASSETS_WRITE_OFF_ATTACH left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID left join COM_USER   COM_USER_USER_ID on MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = COM_USER_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF_ATTACH",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SAVENAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FILE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_ATTACH.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_ATTACH.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SAVENAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_ATTACH.SAVENAME = :U_SAVENAME");
				param = new OracleParameter();
				param.ParameterName = ":U_SAVENAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.SAVENAME) ? string.Empty : obj.SAVENAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_ATTACH.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FILE_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_ATTACH.FILE_NAME = :U_FILE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_FILE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.FILE_NAME) ? string.Empty : obj.FILE_NAME;
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
