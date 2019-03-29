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
	[CauseObject(typeof(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK))]
	public partial class HelperObject_V_MCE_ASSET_OUTSTOCK_BACK
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_ASSET_OUTSTOCK_BACK( ASSETS_CODE, BASE_ID, CARD_CODE, OUT_D_ID, SPEC, ID, ASSETS_NAME) values ( :ASSETS_CODE, :BASE_ID, :CARD_CODE, :OUT_D_ID, :SPEC, :ID, :ASSETS_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ASSETS_CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CARD_CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CARD_CODE == null ? String.Empty:obj.CARD_CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":OUT_D_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.OUT_D_ID == null ? String.Empty:obj.OUT_D_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":SPEC";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ASSETS_NAME";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSET_OUTSTOCK_BACK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj,CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSET_OUTSTOCK_BACK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_ASSET_OUTSTOCK_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_ASSET_OUTSTOCK_BACK Get(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, BASE_ID, CARD_CODE, OUT_D_ID, SPEC, ID, ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK Get(DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_ASSET_OUTSTOCK_BACK Get(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, BASE_ID, CARD_CODE, OUT_D_ID, SPEC, ID, ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_CODE))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE ").Append((cause.CARD_CODE.StartsWith("%") || cause.CARD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CARD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "CARD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.OUT_D_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID ").Append((cause.OUT_D_ID.StartsWith("%") || cause.OUT_D_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_OUT_D_ID");
				param = new OracleParameter();
				param.ParameterName =":C_OUT_D_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.OUT_D_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("OUT_D_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "OUT_D_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_OUTSTOCK_BACK", "ASSETS_NAME"));
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
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSET_OUTSTOCK_BACK",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE, V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID, V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE, V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID, V_MCE_ASSET_OUTSTOCK_BACK.SPEC, V_MCE_ASSET_OUTSTOCK_BACK.ID, V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME from V_MCE_ASSET_OUTSTOCK_BACK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSET_OUTSTOCK_BACK",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CARD_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.OUT_D_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs = new DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_CODE"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.CARD_CODE = :U_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CARD_CODE) ? string.Empty : obj.CARD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("OUT_D_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.OUT_D_ID = :U_OUT_D_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_OUT_D_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.OUT_D_ID) ? string.Empty : obj.OUT_D_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  V_MCE_ASSET_OUTSTOCK_BACK.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
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
