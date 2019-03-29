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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_WRITE_OFF_D))]
	public partial class HelperObject_MCE_B_ASSETS_WRITE_OFF_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_WRITE_OFF_D( ASSET_ID, BASE_ID, ID) values ( :ASSET_ID, :BASE_ID, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ASSET_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ASSET_ID == null ? String.Empty:obj.ASSET_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj,CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_WRITE_OFF_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_WRITE_OFF_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF_D Get(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSET_ID, BASE_ID, ID from MCE_B_ASSETS_WRITE_OFF_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D Get(DisplayObject_MCE_B_ASSETS_WRITE_OFF_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1) and MCE_B_ASSETS_WRITE_OFF_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_WRITE_OFF_D Get(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSET_ID, BASE_ID, ID from MCE_B_ASSETS_WRITE_OFF_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new EntityObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ASSET_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID ").Append((cause.ASSET_ID.StartsWith("%") || cause.ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_D", "ASSET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_WRITE_OFF_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_WRITE_OFF_D", "ID"));
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
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID, MCE_B_ASSETS_WRITE_OFF_D.BASE_ID, MCE_B_ASSETS_WRITE_OFF_D.ID, MCE_B_ASSETS_ASSET_ID.ASSETS_NAME as ASSET_ID_NAME, MCE_B_ASSETS_WRITE_OFF_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_WRITE_OFF_D left join MCE_B_ASSETS   MCE_B_ASSETS_ASSET_ID on MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = MCE_B_ASSETS_ASSET_ID.ID left join MCE_B_ASSETS_WRITE_OFF   MCE_B_ASSETS_WRITE_OFF_BASE_ID on MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = MCE_B_ASSETS_WRITE_OFF_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_WRITE_OFF_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSET_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSET_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] objs = new DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ASSET_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_D.ASSET_ID = :U_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_ID) ? string.Empty : obj.ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_WRITE_OFF_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
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
