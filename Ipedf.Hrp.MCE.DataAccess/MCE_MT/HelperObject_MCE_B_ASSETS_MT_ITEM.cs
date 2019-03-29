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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_ITEM))]
	public partial class HelperObject_MCE_B_ASSETS_MT_ITEM
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_MT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_MT_ITEM( CREATE_DEPT_ID, ID, CREATE_USER_ID, MTNMETHOD, MODIFY_DEPT_ID, NAME, ATTENTION, CODE, COMMENTS, CREATE_TIME) values ( :CREATE_DEPT_ID, :ID, :CREATE_USER_ID, :MTNMETHOD, :MODIFY_DEPT_ID, :NAME, :ATTENTION, :CODE, :COMMENTS, :CREATE_TIME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CREATE_DEPT_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MTNMETHOD";
			parameters[3].Size = 1000;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.MTNMETHOD == null ? String.Empty:obj.MTNMETHOD;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MODIFY_DEPT_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NAME";
			parameters[5].Size = 100;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ATTENTION";
			parameters[6].Size = 1000;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ATTENTION == null ? String.Empty:obj.ATTENTION;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CODE";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":COMMENTS";
			parameters[8].Size = 200;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.CREATE_TIME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_ITEM obj,CauseObject_MCE_B_ASSETS_MT_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_MT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_MT_ITEM where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_MT_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_MT_ITEM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_MT_ITEM Get(EntityObject_MCE_B_ASSETS_MT_ITEM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DEPT_ID, MODIFY_TIME, ID, CREATE_USER_ID, MODIFY_USER_ID, MTNMETHOD, MODIFY_DEPT_ID, NAME, ATTENTION, CODE, COMMENTS, CREATE_TIME from MCE_B_ASSETS_MT_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_ITEM[] objs = new EntityObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM Get(DisplayObject_MCE_B_ASSETS_MT_ITEM obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1) and MCE_B_ASSETS_MT_ITEM.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_MT_ITEM Get(EntityObject_MCE_B_ASSETS_MT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DEPT_ID, MODIFY_TIME, ID, CREATE_USER_ID, MODIFY_USER_ID, MTNMETHOD, MODIFY_DEPT_ID, NAME, ATTENTION, CODE, COMMENTS, CREATE_TIME from MCE_B_ASSETS_MT_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_ITEM[] objs = new EntityObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_MT_ITEM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "CREATE_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MTNMETHOD))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.MTNMETHOD ").Append((cause.MTNMETHOD.StartsWith("%") || cause.MTNMETHOD.EndsWith("%")) ? " like " : " = ").Append(" :C_MTNMETHOD");
				param = new OracleParameter();
				param.ParameterName =":C_MTNMETHOD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.MTNMETHOD;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTNMETHOD"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "MTNMETHOD"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ATTENTION))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.ATTENTION ").Append((cause.ATTENTION.StartsWith("%") || cause.ATTENTION.EndsWith("%")) ? " like " : " = ").Append(" :C_ATTENTION");
				param = new OracleParameter();
				param.ParameterName =":C_ATTENTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.ATTENTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("ATTENTION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "ATTENTION"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "COMMENTS"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_ITEM.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_ITEM", "CREATE_TIME"));
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
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_ITEM",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_TIME, MCE_B_ASSETS_MT_ITEM.ID, MCE_B_ASSETS_MT_ITEM.CREATE_USER_ID, MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID, MCE_B_ASSETS_MT_ITEM.MTNMETHOD, MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_ITEM.NAME, MCE_B_ASSETS_MT_ITEM.ATTENTION, MCE_B_ASSETS_MT_ITEM.CODE, MCE_B_ASSETS_MT_ITEM.COMMENTS, MCE_B_ASSETS_MT_ITEM.CREATE_TIME from MCE_B_ASSETS_MT_ITEM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_ITEM",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_MT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MTNMETHOD = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ATTENTION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_ITEM[] objs = new DisplayObject_MCE_B_ASSETS_MT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_MT_ITEM obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTNMETHOD"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.MTNMETHOD = :U_MTNMETHOD");
				param = new OracleParameter();
				param.ParameterName = ":U_MTNMETHOD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.MTNMETHOD) ? string.Empty : obj.MTNMETHOD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ATTENTION"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.ATTENTION = :U_ATTENTION");
				param = new OracleParameter();
				param.ParameterName = ":U_ATTENTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.ATTENTION) ? string.Empty : obj.ATTENTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_ITEM.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
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
