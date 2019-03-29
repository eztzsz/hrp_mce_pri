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
	[CauseObject(typeof(CauseObject_V_MCE_ASSETS_DEPR_D))]
	public partial class HelperObject_V_MCE_ASSETS_DEPR_D
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_ASSETS_DEPR_D( ORIGINAL_VALUE, DEPT_ID, ID, FINANCE_CYCLE, BASE_ID_NAME, CURRENCY_ID, ASSERTS_ID, CURRENCY_ID_NAME, DEPT_NAME, ASSERTS_ID_NAME, COMMENTS, BASE_ID, MONEY, NET_VALUE, NEW_NET_VALUE) values ( :ORIGINAL_VALUE, :DEPT_ID, :ID, :FINANCE_CYCLE, :BASE_ID_NAME, :CURRENCY_ID, :ASSERTS_ID, :CURRENCY_ID_NAME, :DEPT_NAME, :ASSERTS_ID_NAME, :COMMENTS, :BASE_ID, :MONEY, :NET_VALUE, :NEW_NET_VALUE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ORIGINAL_VALUE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.ORIGINAL_VALUE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FINANCE_CYCLE";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.FINANCE_CYCLE == null ? String.Empty:obj.FINANCE_CYCLE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BASE_ID_NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.BASE_ID_NAME == null ? String.Empty:obj.BASE_ID_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CURRENCY_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ASSERTS_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ASSERTS_ID == null ? String.Empty:obj.ASSERTS_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CURRENCY_ID_NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CURRENCY_ID_NAME == null ? String.Empty:obj.CURRENCY_ID_NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":DEPT_NAME";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.DEPT_NAME == null ? String.Empty:obj.DEPT_NAME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ASSERTS_ID_NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.ASSERTS_ID_NAME == null ? String.Empty:obj.ASSERTS_ID_NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 200;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":BASE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MONEY";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.MONEY;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":NET_VALUE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.NET_VALUE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":NEW_NET_VALUE";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.NEW_NET_VALUE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_DEPR_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_DEPR_D obj,CauseObject_V_MCE_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_DEPR_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_ASSETS_DEPR_D where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_ASSETS_DEPR_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_ASSETS_DEPR_D Get(EntityObject_V_MCE_ASSETS_DEPR_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ORIGINAL_VALUE, DEPT_ID, ID, FINANCE_CYCLE, BASE_ID_NAME, CURRENCY_ID, ASSERTS_ID, CURRENCY_ID_NAME, DEPT_NAME, ASSERTS_ID_NAME, COMMENTS, BASE_ID, MONEY, NET_VALUE, NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_ASSETS_DEPR_D[] objs = new EntityObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_DEPR_D Get(DisplayObject_V_MCE_ASSETS_DEPR_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_ASSETS_DEPR_D Get(EntityObject_V_MCE_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ORIGINAL_VALUE, DEPT_ID, ID, FINANCE_CYCLE, BASE_ID_NAME, CURRENCY_ID, ASSERTS_ID, CURRENCY_ID_NAME, DEPT_NAME, ASSERTS_ID_NAME, COMMENTS, BASE_ID, MONEY, NET_VALUE, NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_ASSETS_DEPR_D[] objs = new EntityObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_DEPR_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_ASSETS_DEPR_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ORIGINAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE = :C_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORIGINAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "ORIGINAL_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_CYCLE))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE ").Append((cause.FINANCE_CYCLE.StartsWith("%") || cause.FINANCE_CYCLE.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_CYCLE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "FINANCE_CYCLE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.BASE_ID_NAME ").Append((cause.BASE_ID_NAME.StartsWith("%") || cause.BASE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BASE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "BASE_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "CURRENCY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSERTS_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.ASSERTS_ID ").Append((cause.ASSERTS_ID.StartsWith("%") || cause.ASSERTS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSERTS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSERTS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSERTS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSERTS_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "ASSERTS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME ").Append((cause.CURRENCY_ID_NAME.StartsWith("%") || cause.CURRENCY_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CURRENCY_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "CURRENCY_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.DEPT_NAME ").Append((cause.DEPT_NAME.StartsWith("%") || cause.DEPT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "DEPT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSERTS_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME ").Append((cause.ASSERTS_ID_NAME.StartsWith("%") || cause.ASSERTS_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSERTS_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSERTS_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSERTS_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSERTS_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "ASSERTS_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "BASE_ID"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "MONEY"));
			}
			if(cause.NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.NET_VALUE = :C_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "NET_VALUE"));
			}
			if(cause.NEW_NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE = :C_NEW_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NEW_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NEW_NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEW_NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_DEPR_D", "NEW_NET_VALUE"));
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
		public static DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_DEPR_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE, V_MCE_ASSETS_DEPR_D.DEPT_ID, V_MCE_ASSETS_DEPR_D.ID, V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE, V_MCE_ASSETS_DEPR_D.BASE_ID_NAME, V_MCE_ASSETS_DEPR_D.CURRENCY_ID, V_MCE_ASSETS_DEPR_D.ASSERTS_ID, V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME, V_MCE_ASSETS_DEPR_D.DEPT_NAME, V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME, V_MCE_ASSETS_DEPR_D.COMMENTS, V_MCE_ASSETS_DEPR_D.BASE_ID, V_MCE_ASSETS_DEPR_D.MONEY, V_MCE_ASSETS_DEPR_D.NET_VALUE, V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE from V_MCE_ASSETS_DEPR_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_DEPR_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSERTS_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSERTS_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_DEPR_D[] objs = new DisplayObject_V_MCE_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_ASSETS_DEPR_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ORIGINAL_VALUE"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.ORIGINAL_VALUE = :U_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_CYCLE"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.FINANCE_CYCLE = :U_FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_CYCLE) ? string.Empty : obj.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.BASE_ID_NAME = :U_BASE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID_NAME) ? string.Empty : obj.BASE_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSERTS_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.ASSERTS_ID = :U_ASSERTS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSERTS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSERTS_ID) ? string.Empty : obj.ASSERTS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.CURRENCY_ID_NAME = :U_CURRENCY_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID_NAME) ? string.Empty : obj.CURRENCY_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.DEPT_NAME = :U_DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEPT_NAME) ? string.Empty : obj.DEPT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSERTS_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.ASSERTS_ID_NAME = :U_ASSERTS_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSERTS_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSERTS_ID_NAME) ? string.Empty : obj.ASSERTS_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NET_VALUE"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.NET_VALUE = :U_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NET_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEW_NET_VALUE"))
			{
				strBuf.Add("  V_MCE_ASSETS_DEPR_D.NEW_NET_VALUE = :U_NEW_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NEW_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NEW_NET_VALUE;
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
