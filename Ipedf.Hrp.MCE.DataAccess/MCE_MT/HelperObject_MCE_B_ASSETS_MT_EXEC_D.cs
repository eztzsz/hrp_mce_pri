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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_EXEC_D))]
	public partial class HelperObject_MCE_B_ASSETS_MT_EXEC_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_MT_EXEC_D( ID, BASE_ID, SEQ_NUMBER, SPEC, COMMENTS, MONEY, RESULT_ID, ASSET_CODE, ASSETS_ID, DEPT_ID, ITEM_ID) values ( :ID, :BASE_ID, :SEQ_NUMBER, :SPEC, :COMMENTS, :MONEY, :RESULT_ID, :ASSET_CODE, :ASSETS_ID, :DEPT_ID, :ITEM_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SEQ_NUMBER";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SEQ_NUMBER == null ? String.Empty:obj.SEQ_NUMBER;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":SPEC";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":COMMENTS";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MONEY";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.MONEY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":RESULT_ID";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.RESULT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ASSET_CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.ASSET_CODE == null ? String.Empty:obj.ASSET_CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ASSETS_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DEPT_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ITEM_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_EXEC_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj,CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_EXEC_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_MT_EXEC_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_MT_EXEC_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_MT_EXEC_D Get(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, BASE_ID, SEQ_NUMBER, SPEC, COMMENTS, MONEY, RESULT_ID, ASSET_CODE, ASSETS_ID, DEPT_ID, ITEM_ID from MCE_B_ASSETS_MT_EXEC_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new EntityObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D Get(DisplayObject_MCE_B_ASSETS_MT_EXEC_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1) and MCE_B_ASSETS_MT_EXEC_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_MT_EXEC_D Get(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, BASE_ID, SEQ_NUMBER, SPEC, COMMENTS, MONEY, RESULT_ID, ASSET_CODE, ASSETS_ID, DEPT_ID, ITEM_ID from MCE_B_ASSETS_MT_EXEC_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new EntityObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SEQ_NUMBER))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER ").Append((cause.SEQ_NUMBER.StartsWith("%") || cause.SEQ_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :C_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":C_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SEQ_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEQ_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "SEQ_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "COMMENTS"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "MONEY"));
			}
			if(cause.RESULT_ID!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = :C_RESULT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_RESULT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RESULT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("RESULT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "RESULT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE ").Append((cause.ASSET_CODE.StartsWith("%") || cause.ASSET_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSET_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "ASSET_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_EXEC_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_EXEC_D", "ITEM_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_EXEC_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_EXEC_D.ID, MCE_B_ASSETS_MT_EXEC_D.BASE_ID, MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER, MCE_B_ASSETS_MT_EXEC_D.SPEC, MCE_B_ASSETS_MT_EXEC_D.COMMENTS, MCE_B_ASSETS_MT_EXEC_D.MONEY, MCE_B_ASSETS_MT_EXEC_D.RESULT_ID, MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE, MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID, MCE_B_ASSETS_MT_EXEC_D.DEPT_ID, MCE_B_ASSETS_MT_EXEC_D.ITEM_ID, MCE_B_ASSETS_MT_EXEC_BASE_ID.NAME as BASE_ID_NAME, (case  when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 1 then '正常' when MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = 2 then '异常' else '' end ) as RESULT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_MT_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from MCE_B_ASSETS_MT_EXEC_D left join MCE_B_ASSETS_MT_EXEC   MCE_B_ASSETS_MT_EXEC_BASE_ID on MCE_B_ASSETS_MT_EXEC_D.BASE_ID = MCE_B_ASSETS_MT_EXEC_BASE_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS_MT_ITEM   MCE_B_ASSETS_MT_ITEM_ITEM_ID on MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = MCE_B_ASSETS_MT_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_EXEC_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] objs = new DisplayObject_MCE_B_ASSETS_MT_EXEC_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEQ_NUMBER"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.SEQ_NUMBER = :U_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":U_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SEQ_NUMBER) ? string.Empty : obj.SEQ_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RESULT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.RESULT_ID = :U_RESULT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_RESULT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RESULT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.ASSET_CODE = :U_ASSET_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSET_CODE) ? string.Empty : obj.ASSET_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_EXEC_D.ITEM_ID = :U_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
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
