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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_DEPR_ALLOT))]
	public partial class HelperObject_MCE_B_ASSETS_DEPR_ALLOT
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_DEPR_ALLOT( RATIO, DEPT_ID, ASSETS_ID, BACKUP1, DEPR_YEARS, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, DEPR_ID, COMMENTS, CREATE_TIME, ID) values ( :RATIO, :DEPT_ID, :ASSETS_ID, :BACKUP1, :DEPR_YEARS, :AUDIT_TIME, :AUDIT_STATE, :AUDIT_USER_ID, :DEPR_ID, :COMMENTS, :CREATE_TIME, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":RATIO";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.RATIO;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ASSETS_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BACKUP1";
			parameters[3].Size = 1000;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":DEPR_YEARS";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.DEPR_YEARS;
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
			parameters[8].ParameterName =":DEPR_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.DEPR_ID == null ? String.Empty:obj.DEPR_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":COMMENTS";
			parameters[9].Size = 200;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_DEPR_ALLOT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj,CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_DEPR_ALLOT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_DEPR_ALLOT where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_DEPR_ALLOT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_DEPR_ALLOT Get(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  RATIO, DEPT_ID, ASSETS_ID, BACKUP1, DEPR_YEARS, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, DEPR_ID, COMMENTS, CREATE_TIME, ID from MCE_B_ASSETS_DEPR_ALLOT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new EntityObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT Get(DisplayObject_MCE_B_ASSETS_DEPR_ALLOT obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1) and MCE_B_ASSETS_DEPR_ALLOT.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_DEPR_ALLOT Get(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  RATIO, DEPT_ID, ASSETS_ID, BACKUP1, DEPR_YEARS, AUDIT_TIME, AUDIT_STATE, AUDIT_USER_ID, DEPR_ID, COMMENTS, CREATE_TIME, ID from MCE_B_ASSETS_DEPR_ALLOT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new EntityObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.RATIO!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.RATIO = :C_RATIO");
				param = new OracleParameter();
				param.ParameterName =":C_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RATIO;
				paramList.Add(param);
			}
			if (cause.HasINValue("RATIO"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "RATIO"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "BACKUP1"));
			}
			if(cause.DEPR_YEARS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS = :C_DEPR_YEARS");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_YEARS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPR_YEARS;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_YEARS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "DEPR_YEARS"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "AUDIT_TIME"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPR_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID ").Append((cause.DEPR_ID.StartsWith("%") || cause.DEPR_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPR_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "DEPR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "COMMENTS"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_DEPR_ALLOT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_DEPR_ALLOT", "ID"));
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
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] Query(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] Query(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] Query(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_DEPR_ALLOT",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] Query(CauseObject_MCE_B_ASSETS_DEPR_ALLOT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_DEPR_ALLOT.RATIO, MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID, MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID, MCE_B_ASSETS_DEPR_ALLOT.BACKUP1, MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE, MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID, MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID, MCE_B_ASSETS_DEPR_ALLOT.COMMENTS, MCE_B_ASSETS_DEPR_ALLOT.CREATE_TIME, MCE_B_ASSETS_DEPR_ALLOT.ID, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MCE_D_DEPR_TYPE_DEPR_ID.NAME as DEPR_ID_NAME from MCE_B_ASSETS_DEPR_ALLOT left join COM_DEPART   COM_DEPART_DEPT_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = COM_DEPART_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_ID on MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = MCE_D_DEPR_TYPE_DEPR_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_DEPR_ALLOT",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.RATIO = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BACKUP1 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPR_YEARS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPR_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COMMENTS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPR_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[] objs = new DisplayObject_MCE_B_ASSETS_DEPR_ALLOT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_DEPR_ALLOT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("RATIO"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.RATIO = :U_RATIO");
				param = new OracleParameter();
				param.ParameterName = ":U_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RATIO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_YEARS"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.DEPR_YEARS = :U_DEPR_YEARS");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_YEARS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DEPR_YEARS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.DEPR_ID = :U_DEPR_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPR_ID) ? string.Empty : obj.DEPR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_DEPR_ALLOT.COMMENTS = :U_COMMENTS");
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
