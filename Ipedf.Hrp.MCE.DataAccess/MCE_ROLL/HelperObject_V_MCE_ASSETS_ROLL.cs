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
	[CauseObject(typeof(CauseObject_V_MCE_ASSETS_ROLL))]
	public partial class HelperObject_V_MCE_ASSETS_ROLL
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_ASSETS_ROLL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_ASSETS_ROLL( BACKUP1, COMMENTS, CODE, CREATE_USER_ID_NAME, PLAN_TYPE, CREATE_USER_ID, AUDIT_STATE_NAME, NAME, ASSETS_ID, ASSETS_CODE, SAVELIMIT_NAME, ROLL_TYPE, AUDIT_STATE, SAVELIMIT, AUDIT_USER_ID, CREATE_TIME, ROLL_TYPE_NAME, ROLL_PROPERTY_NAME, AUDIT_TIME, ROLL_PROPERTY, ID, ASSETS_NAME, PLAN_TYPE_NAME) values ( :BACKUP1, :COMMENTS, :CODE, :CREATE_USER_ID_NAME, :PLAN_TYPE, :CREATE_USER_ID, :AUDIT_STATE_NAME, :NAME, :ASSETS_ID, :ASSETS_CODE, :SAVELIMIT_NAME, :ROLL_TYPE, :AUDIT_STATE, :SAVELIMIT, :AUDIT_USER_ID, :CREATE_TIME, :ROLL_TYPE_NAME, :ROLL_PROPERTY_NAME, :AUDIT_TIME, :ROLL_PROPERTY, :ID, :ASSETS_NAME, :PLAN_TYPE_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[23];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BACKUP1";
			parameters[0].Size = 1000;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COMMENTS";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CODE";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CREATE_USER_ID_NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.CREATE_USER_ID_NAME == null ? String.Empty:obj.CREATE_USER_ID_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PLAN_TYPE";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.PLAN_TYPE == null ? String.Empty:obj.PLAN_TYPE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CREATE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AUDIT_STATE_NAME";
			parameters[6].Size = 6;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.AUDIT_STATE_NAME == null ? String.Empty:obj.AUDIT_STATE_NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NAME";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ASSETS_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ASSETS_CODE";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":SAVELIMIT_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.SAVELIMIT_NAME == null ? String.Empty:obj.SAVELIMIT_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ROLL_TYPE";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.ROLL_TYPE == null ? String.Empty:obj.ROLL_TYPE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":AUDIT_STATE";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.AUDIT_STATE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":SAVELIMIT";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.SAVELIMIT == null ? String.Empty:obj.SAVELIMIT;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":AUDIT_USER_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":CREATE_TIME";
			parameters[15].Size = 7;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[15].Value = obj.CREATE_TIME;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":ROLL_TYPE_NAME";
			parameters[16].Size = 50;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.ROLL_TYPE_NAME == null ? String.Empty:obj.ROLL_TYPE_NAME;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":ROLL_PROPERTY_NAME";
			parameters[17].Size = 50;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.ROLL_PROPERTY_NAME == null ? String.Empty:obj.ROLL_PROPERTY_NAME;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":AUDIT_TIME";
			parameters[18].Size = 7;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[18].Value = obj.AUDIT_TIME;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":ROLL_PROPERTY";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.ROLL_PROPERTY == null ? String.Empty:obj.ROLL_PROPERTY;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":ASSETS_NAME";
			parameters[21].Size = 50;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":PLAN_TYPE_NAME";
			parameters[22].Size = 50;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.PLAN_TYPE_NAME == null ? String.Empty:obj.PLAN_TYPE_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_ROLL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_ROLL set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_ROLL obj,CauseObject_V_MCE_ASSETS_ROLL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_ROLL set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_ASSETS_ROLL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_ASSETS_ROLL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_ASSETS_ROLL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_ASSETS_ROLL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_ASSETS_ROLL Get(EntityObject_V_MCE_ASSETS_ROLL obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, CODE, CREATE_USER_ID_NAME, PLAN_TYPE, CREATE_USER_ID, AUDIT_STATE_NAME, NAME, ASSETS_ID, ASSETS_CODE, SAVELIMIT_NAME, ROLL_TYPE, AUDIT_STATE, SAVELIMIT, AUDIT_USER_ID, CREATE_TIME, ROLL_TYPE_NAME, ROLL_PROPERTY_NAME, AUDIT_TIME, ROLL_PROPERTY, ID, ASSETS_NAME, PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_ASSETS_ROLL[] objs = new EntityObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_ROLL Get(DisplayObject_V_MCE_ASSETS_ROLL obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_ASSETS_ROLL Get(EntityObject_V_MCE_ASSETS_ROLL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, COMMENTS, CODE, CREATE_USER_ID_NAME, PLAN_TYPE, CREATE_USER_ID, AUDIT_STATE_NAME, NAME, ASSETS_ID, ASSETS_CODE, SAVELIMIT_NAME, ROLL_TYPE, AUDIT_STATE, SAVELIMIT, AUDIT_USER_ID, CREATE_TIME, ROLL_TYPE_NAME, ROLL_PROPERTY_NAME, AUDIT_TIME, ROLL_PROPERTY, ID, ASSETS_NAME, PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_ASSETS_ROLL[] objs = new EntityObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_ROLL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_ASSETS_ROLL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME ").Append((cause.CREATE_USER_ID_NAME.StartsWith("%") || cause.CREATE_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CREATE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "CREATE_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PLAN_TYPE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.PLAN_TYPE ").Append((cause.PLAN_TYPE.StartsWith("%") || cause.PLAN_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_PLAN_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_PLAN_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PLAN_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PLAN_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "PLAN_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_STATE_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME ").Append((cause.AUDIT_STATE_NAME.StartsWith("%") || cause.AUDIT_STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.AUDIT_STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "AUDIT_STATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SAVELIMIT_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.SAVELIMIT_NAME ").Append((cause.SAVELIMIT_NAME.StartsWith("%") || cause.SAVELIMIT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SAVELIMIT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SAVELIMIT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SAVELIMIT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SAVELIMIT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "SAVELIMIT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ROLL_TYPE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ROLL_TYPE ").Append((cause.ROLL_TYPE.StartsWith("%") || cause.ROLL_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_ROLL_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_ROLL_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ROLL_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLL_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ROLL_TYPE"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SAVELIMIT))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.SAVELIMIT ").Append((cause.SAVELIMIT.StartsWith("%") || cause.SAVELIMIT.EndsWith("%")) ? " like " : " = ").Append(" :C_SAVELIMIT");
				param = new OracleParameter();
				param.ParameterName =":C_SAVELIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SAVELIMIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("SAVELIMIT"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "SAVELIMIT"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "AUDIT_USER_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_MCE_ASSETS_ROLL.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_MCE_ASSETS_ROLL.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ROLL_TYPE_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME ").Append((cause.ROLL_TYPE_NAME.StartsWith("%") || cause.ROLL_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ROLL_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ROLL_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ROLL_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLL_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ROLL_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ROLL_PROPERTY_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME ").Append((cause.ROLL_PROPERTY_NAME.StartsWith("%") || cause.ROLL_PROPERTY_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ROLL_PROPERTY_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ROLL_PROPERTY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ROLL_PROPERTY_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLL_PROPERTY_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ROLL_PROPERTY_NAME"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And V_MCE_ASSETS_ROLL.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And V_MCE_ASSETS_ROLL.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ROLL_PROPERTY))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ROLL_PROPERTY ").Append((cause.ROLL_PROPERTY.StartsWith("%") || cause.ROLL_PROPERTY.EndsWith("%")) ? " like " : " = ").Append(" :C_ROLL_PROPERTY");
				param = new OracleParameter();
				param.ParameterName =":C_ROLL_PROPERTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ROLL_PROPERTY;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLL_PROPERTY"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ROLL_PROPERTY"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "ASSETS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PLAN_TYPE_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME ").Append((cause.PLAN_TYPE_NAME.StartsWith("%") || cause.PLAN_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PLAN_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PLAN_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PLAN_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PLAN_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLL", "PLAN_TYPE_NAME"));
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
		public static DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_ROLL",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLL.BACKUP1, V_MCE_ASSETS_ROLL.COMMENTS, V_MCE_ASSETS_ROLL.CODE, V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE, V_MCE_ASSETS_ROLL.CREATE_USER_ID, V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME, V_MCE_ASSETS_ROLL.NAME, V_MCE_ASSETS_ROLL.ASSETS_ID, V_MCE_ASSETS_ROLL.ASSETS_CODE, V_MCE_ASSETS_ROLL.SAVELIMIT_NAME, V_MCE_ASSETS_ROLL.ROLL_TYPE, V_MCE_ASSETS_ROLL.AUDIT_STATE, V_MCE_ASSETS_ROLL.SAVELIMIT, V_MCE_ASSETS_ROLL.AUDIT_USER_ID, V_MCE_ASSETS_ROLL.CREATE_TIME, V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME, V_MCE_ASSETS_ROLL.AUDIT_TIME, V_MCE_ASSETS_ROLL.ROLL_PROPERTY, V_MCE_ASSETS_ROLL.ID, V_MCE_ASSETS_ROLL.ASSETS_NAME, V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME from V_MCE_ASSETS_ROLL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_ROLL",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_ASSETS_ROLL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_USER_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PLAN_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SAVELIMIT_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ROLL_TYPE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SAVELIMIT = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ROLL_TYPE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ROLL_PROPERTY_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ROLL_PROPERTY = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PLAN_TYPE_NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLL[] objs = new DisplayObject_V_MCE_ASSETS_ROLL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_ASSETS_ROLL obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_USER_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.CREATE_USER_ID_NAME = :U_CREATE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CREATE_USER_ID_NAME) ? string.Empty : obj.CREATE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_TYPE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.PLAN_TYPE = :U_PLAN_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PLAN_TYPE) ? string.Empty : obj.PLAN_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.AUDIT_STATE_NAME = :U_AUDIT_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_STATE_NAME) ? string.Empty : obj.AUDIT_STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SAVELIMIT_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.SAVELIMIT_NAME = :U_SAVELIMIT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_SAVELIMIT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SAVELIMIT_NAME) ? string.Empty : obj.SAVELIMIT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLL_TYPE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ROLL_TYPE = :U_ROLL_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_ROLL_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ROLL_TYPE) ? string.Empty : obj.ROLL_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SAVELIMIT"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.SAVELIMIT = :U_SAVELIMIT");
				param = new OracleParameter();
				param.ParameterName = ":U_SAVELIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SAVELIMIT) ? string.Empty : obj.SAVELIMIT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLL_TYPE_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ROLL_TYPE_NAME = :U_ROLL_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ROLL_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ROLL_TYPE_NAME) ? string.Empty : obj.ROLL_TYPE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLL_PROPERTY_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ROLL_PROPERTY_NAME = :U_ROLL_PROPERTY_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ROLL_PROPERTY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ROLL_PROPERTY_NAME) ? string.Empty : obj.ROLL_PROPERTY_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLL_PROPERTY"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ROLL_PROPERTY = :U_ROLL_PROPERTY");
				param = new OracleParameter();
				param.ParameterName = ":U_ROLL_PROPERTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ROLL_PROPERTY) ? string.Empty : obj.ROLL_PROPERTY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_TYPE_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLL.PLAN_TYPE_NAME = :U_PLAN_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PLAN_TYPE_NAME) ? string.Empty : obj.PLAN_TYPE_NAME;
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
