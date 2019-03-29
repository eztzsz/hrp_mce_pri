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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_BACK_D))]
	public partial class HelperObject_MCE_B_ASSETS_BACK_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_BACK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_BACK_D( COMMENTS, REF_TAB_NAME, SPEC, ASSETS_NAME, REF_TAB_ID, ASSETS_ID, ASSETS_CODE, ASSET_TYPE_ID, CARD_CODE, BASE_ID, ID, SEQ_NUMBER) values ( :COMMENTS, :REF_TAB_NAME, :SPEC, :ASSETS_NAME, :REF_TAB_ID, :ASSETS_ID, :ASSETS_CODE, :ASSET_TYPE_ID, :CARD_CODE, :BASE_ID, :ID, :SEQ_NUMBER)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":COMMENTS";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":REF_TAB_NAME";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SPEC";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ASSETS_NAME";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":REF_TAB_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ASSETS_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ASSETS_CODE";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ASSET_TYPE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ASSET_TYPE_ID == null ? String.Empty:obj.ASSET_TYPE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CARD_CODE";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.CARD_CODE == null ? String.Empty:obj.CARD_CODE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BASE_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SEQ_NUMBER";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.SEQ_NUMBER == null ? String.Empty:obj.SEQ_NUMBER;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_BACK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_BACK_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_BACK_D obj,CauseObject_MCE_B_ASSETS_BACK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_BACK_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_BACK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_BACK_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_BACK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_BACK_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_BACK_D Get(EntityObject_MCE_B_ASSETS_BACK_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS, REF_TAB_NAME, SPEC, ASSETS_NAME, REF_TAB_ID, ASSETS_ID, ASSETS_CODE, ASSET_TYPE_ID, CARD_CODE, BASE_ID, ID, SEQ_NUMBER from MCE_B_ASSETS_BACK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_BACK_D[] objs = new EntityObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_BACK_D Get(DisplayObject_MCE_B_ASSETS_BACK_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1) and MCE_B_ASSETS_BACK_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_BACK_D Get(EntityObject_MCE_B_ASSETS_BACK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS, REF_TAB_NAME, SPEC, ASSETS_NAME, REF_TAB_ID, ASSETS_ID, ASSETS_CODE, ASSET_TYPE_ID, CARD_CODE, BASE_ID, ID, SEQ_NUMBER from MCE_B_ASSETS_BACK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_BACK_D[] objs = new EntityObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_BACK_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_BACK_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "REF_TAB_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "ASSETS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID ").Append((cause.ASSET_TYPE_ID.StartsWith("%") || cause.ASSET_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "ASSET_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.CARD_CODE ").Append((cause.CARD_CODE.StartsWith("%") || cause.CARD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CARD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "CARD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.SEQ_NUMBER))
			{
				strBuf.Append(" And MCE_B_ASSETS_BACK_D.SEQ_NUMBER ").Append((cause.SEQ_NUMBER.StartsWith("%") || cause.SEQ_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :C_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":C_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SEQ_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEQ_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_BACK_D", "SEQ_NUMBER"));
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
		public static DisplayObject_MCE_B_ASSETS_BACK_D[] Query(CauseObject_MCE_B_ASSETS_BACK_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_BACK_D[] Query(CauseObject_MCE_B_ASSETS_BACK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_BACK_D[] Query(CauseObject_MCE_B_ASSETS_BACK_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_BACK_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_BACK_D[] Query(CauseObject_MCE_B_ASSETS_BACK_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_BACK_D.COMMENTS, MCE_B_ASSETS_BACK_D.REF_TAB_NAME, MCE_B_ASSETS_BACK_D.SPEC, MCE_B_ASSETS_BACK_D.ASSETS_NAME, MCE_B_ASSETS_BACK_D.REF_TAB_ID, MCE_B_ASSETS_BACK_D.ASSETS_ID, MCE_B_ASSETS_BACK_D.ASSETS_CODE, MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID, MCE_B_ASSETS_BACK_D.CARD_CODE, MCE_B_ASSETS_BACK_D.BASE_ID, MCE_B_ASSETS_BACK_D.ID, MCE_B_ASSETS_BACK_D.SEQ_NUMBER, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_B_ASSETS_BACK_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_BACK_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_B_ASSETS_BACK   MCE_B_ASSETS_BACK_BASE_ID on MCE_B_ASSETS_BACK_D.BASE_ID = MCE_B_ASSETS_BACK_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_BACK_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_BACK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_BACK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CARD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_BACK_D[] objs = new DisplayObject_MCE_B_ASSETS_BACK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_BACK_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.REF_TAB_NAME = :U_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.REF_TAB_ID = :U_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.ASSET_TYPE_ID = :U_ASSET_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_TYPE_ID) ? string.Empty : obj.ASSET_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.CARD_CODE = :U_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CARD_CODE) ? string.Empty : obj.CARD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEQ_NUMBER"))
			{
				strBuf.Add("  MCE_B_ASSETS_BACK_D.SEQ_NUMBER = :U_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":U_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SEQ_NUMBER) ? string.Empty : obj.SEQ_NUMBER;
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
