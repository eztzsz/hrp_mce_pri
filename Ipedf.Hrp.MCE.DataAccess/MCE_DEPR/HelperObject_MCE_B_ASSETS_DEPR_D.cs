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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_DEPR_D))]
	public partial class HelperObject_MCE_B_ASSETS_DEPR_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_DEPR_D( ASSETS_CODE, BASE_ID, NEW_NET_VALUE, COMMENTS, MONEY, ORIGINAL_VALUE, CURRENCY_ID, NET_VALUE, ASSETS_ID, ID) values ( :ASSETS_CODE, :BASE_ID, :NEW_NET_VALUE, :COMMENTS, :MONEY, :ORIGINAL_VALUE, :CURRENCY_ID, :NET_VALUE, :ASSETS_ID, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ASSETS_CODE";
			parameters[0].Size = 100;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":NEW_NET_VALUE";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.NEW_NET_VALUE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MONEY";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.MONEY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ORIGINAL_VALUE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.ORIGINAL_VALUE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CURRENCY_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NET_VALUE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.NET_VALUE;
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
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_DEPR_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_DEPR_D obj,CauseObject_MCE_B_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_DEPR_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_DEPR_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_DEPR_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_DEPR_D Get(EntityObject_MCE_B_ASSETS_DEPR_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, BASE_ID, NEW_NET_VALUE, COMMENTS, MONEY, ORIGINAL_VALUE, CURRENCY_ID, NET_VALUE, ASSETS_ID, ID from MCE_B_ASSETS_DEPR_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_DEPR_D[] objs = new EntityObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_D Get(DisplayObject_MCE_B_ASSETS_DEPR_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1) and MCE_B_ASSETS_DEPR_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_DEPR_D Get(EntityObject_MCE_B_ASSETS_DEPR_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, BASE_ID, NEW_NET_VALUE, COMMENTS, MONEY, ORIGINAL_VALUE, CURRENCY_ID, NET_VALUE, ASSETS_ID, ID from MCE_B_ASSETS_DEPR_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_DEPR_D[] objs = new EntityObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_DEPR_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "BASE_ID"));
			}
			if(cause.NEW_NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE = :C_NEW_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NEW_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NEW_NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEW_NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "NEW_NET_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "COMMENTS"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "MONEY"));
			}
			if(cause.ORIGINAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE = :C_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORIGINAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "ORIGINAL_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "CURRENCY_ID"));
			}
			if(cause.NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.NET_VALUE = :C_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "NET_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_D", "ID"));
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
		public static DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_DEPR_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_D.ASSETS_CODE, MCE_B_ASSETS_DEPR_D.BASE_ID, MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE, MCE_B_ASSETS_DEPR_D.COMMENTS, MCE_B_ASSETS_DEPR_D.MONEY, MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE, MCE_B_ASSETS_DEPR_D.CURRENCY_ID, MCE_B_ASSETS_DEPR_D.NET_VALUE, MCE_B_ASSETS_DEPR_D.ASSETS_ID, MCE_B_ASSETS_DEPR_D.ID, MCE_B_ASSETS_DEPR_BASE_ID.CODE as BASE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_DEPR_D left join MCE_B_ASSETS_DEPR   MCE_B_ASSETS_DEPR_BASE_ID on MCE_B_ASSETS_DEPR_D.BASE_ID = MCE_B_ASSETS_DEPR_BASE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_DEPR_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_D.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_DEPR_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_DEPR_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEW_NET_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_D[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_DEPR_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEW_NET_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.NEW_NET_VALUE = :U_NEW_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NEW_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NEW_NET_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORIGINAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.ORIGINAL_VALUE = :U_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NET_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.NET_VALUE = :U_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NET_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_D.ASSETS_ID = :U_ASSETS_ID");
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
