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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_IMPORTATION))]
	public partial class HelperObject_MCE_B_ASSETS_IMPORTATION
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_IMPORTATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_IMPORTATION( BACKUP1, APPROVE_FILE_CODE, EXEMPTION_CODE, ASSETS_ID, CURRENCY_ID, PURCHASE_MONEY, AUDIT_TIME, AUDIT_STATE, CUSTOMS, AUDIT_USER_ID, FOREIGN_CURRENCY_SOURCE_ID, FOREIGN_CURRENCY_RATE, COMMENTS, CREATE_TIME, ID, COUNTRY_ID) values ( :BACKUP1, :APPROVE_FILE_CODE, :EXEMPTION_CODE, :ASSETS_ID, :CURRENCY_ID, :PURCHASE_MONEY, :AUDIT_TIME, :AUDIT_STATE, :CUSTOMS, :AUDIT_USER_ID, :FOREIGN_CURRENCY_SOURCE_ID, :FOREIGN_CURRENCY_RATE, :COMMENTS, :CREATE_TIME, :ID, :COUNTRY_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[16];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BACKUP1";
			parameters[0].Size = 1000;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":APPROVE_FILE_CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.APPROVE_FILE_CODE == null ? String.Empty:obj.APPROVE_FILE_CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":EXEMPTION_CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.EXEMPTION_CODE == null ? String.Empty:obj.EXEMPTION_CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ASSETS_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CURRENCY_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PURCHASE_MONEY";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.PURCHASE_MONEY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AUDIT_TIME";
			parameters[6].Size = 7;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[6].Value = obj.AUDIT_TIME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":AUDIT_STATE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.AUDIT_STATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CUSTOMS";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.CUSTOMS;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":AUDIT_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FOREIGN_CURRENCY_SOURCE_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.FOREIGN_CURRENCY_SOURCE_ID == null ? String.Empty:obj.FOREIGN_CURRENCY_SOURCE_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":FOREIGN_CURRENCY_RATE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.FOREIGN_CURRENCY_RATE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":COMMENTS";
			parameters[12].Size = 200;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CREATE_TIME";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.CREATE_TIME;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":COUNTRY_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.COUNTRY_ID == null ? String.Empty:obj.COUNTRY_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_IMPORTATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_IMPORTATION set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_IMPORTATION obj,CauseObject_MCE_B_ASSETS_IMPORTATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_IMPORTATION set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_IMPORTATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_IMPORTATION where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_IMPORTATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_IMPORTATION where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_IMPORTATION Get(EntityObject_MCE_B_ASSETS_IMPORTATION obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, APPROVE_FILE_CODE, EXEMPTION_CODE, ASSETS_ID, CURRENCY_ID, PURCHASE_MONEY, AUDIT_TIME, AUDIT_STATE, CUSTOMS, AUDIT_USER_ID, FOREIGN_CURRENCY_SOURCE_ID, FOREIGN_CURRENCY_RATE, COMMENTS, CREATE_TIME, ID, COUNTRY_ID from MCE_B_ASSETS_IMPORTATION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_IMPORTATION[] objs = new EntityObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION Get(DisplayObject_MCE_B_ASSETS_IMPORTATION obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1) and MCE_B_ASSETS_IMPORTATION.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_IMPORTATION Get(EntityObject_MCE_B_ASSETS_IMPORTATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BACKUP1, APPROVE_FILE_CODE, EXEMPTION_CODE, ASSETS_ID, CURRENCY_ID, PURCHASE_MONEY, AUDIT_TIME, AUDIT_STATE, CUSTOMS, AUDIT_USER_ID, FOREIGN_CURRENCY_SOURCE_ID, FOREIGN_CURRENCY_RATE, COMMENTS, CREATE_TIME, ID, COUNTRY_ID from MCE_B_ASSETS_IMPORTATION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_IMPORTATION[] objs = new EntityObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_IMPORTATION cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.APPROVE_FILE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE ").Append((cause.APPROVE_FILE_CODE.StartsWith("%") || cause.APPROVE_FILE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_APPROVE_FILE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_APPROVE_FILE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.APPROVE_FILE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPROVE_FILE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "APPROVE_FILE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.EXEMPTION_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE ").Append((cause.EXEMPTION_CODE.StartsWith("%") || cause.EXEMPTION_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_EXEMPTION_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_EXEMPTION_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EXEMPTION_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXEMPTION_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "EXEMPTION_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "CURRENCY_ID"));
			}
			if(cause.PURCHASE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY = :C_PURCHASE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHASE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PURCHASE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "PURCHASE_MONEY"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "AUDIT_TIME"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "AUDIT_STATE"));
			}
			if(cause.CUSTOMS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.CUSTOMS = :C_CUSTOMS");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTOMS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CUSTOMS;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTOMS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "CUSTOMS"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FOREIGN_CURRENCY_SOURCE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID ").Append((cause.FOREIGN_CURRENCY_SOURCE_ID.StartsWith("%") || cause.FOREIGN_CURRENCY_SOURCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_FOREIGN_CURRENCY_SOURCE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_FOREIGN_CURRENCY_SOURCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FOREIGN_CURRENCY_SOURCE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FOREIGN_CURRENCY_SOURCE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "FOREIGN_CURRENCY_SOURCE_ID"));
			}
			if(cause.FOREIGN_CURRENCY_RATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE = :C_FOREIGN_CURRENCY_RATE");
				param = new OracleParameter();
				param.ParameterName =":C_FOREIGN_CURRENCY_RATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FOREIGN_CURRENCY_RATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FOREIGN_CURRENCY_RATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "FOREIGN_CURRENCY_RATE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "COMMENTS"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.COUNTRY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_IMPORTATION.COUNTRY_ID ").Append((cause.COUNTRY_ID.StartsWith("%") || cause.COUNTRY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_COUNTRY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_COUNTRY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.COUNTRY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("COUNTRY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_IMPORTATION", "COUNTRY_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_IMPORTATION",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_IMPORTATION.BACKUP1, MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE, MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE, MCE_B_ASSETS_IMPORTATION.ASSETS_ID, MCE_B_ASSETS_IMPORTATION.CURRENCY_ID, MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY, MCE_B_ASSETS_IMPORTATION.AUDIT_TIME, MCE_B_ASSETS_IMPORTATION.AUDIT_STATE, MCE_B_ASSETS_IMPORTATION.CUSTOMS, MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID, MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE, MCE_B_ASSETS_IMPORTATION.COMMENTS, MCE_B_ASSETS_IMPORTATION.CREATE_TIME, MCE_B_ASSETS_IMPORTATION.ID, MCE_B_ASSETS_IMPORTATION.COUNTRY_ID, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, (case  when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, COM_TYPE_FOREIGN_CURRENCY_SOUR.NAME as FOREIGN_CURRENCY_SOURCE_ID_NAM, COM_TYPE_COUNTRY_ID.NAME as COUNTRY_ID_NAME from MCE_B_ASSETS_IMPORTATION left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_IMPORTATION.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_FOREIGN_CURRENCY_SOUR on MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = COM_TYPE_FOREIGN_CURRENCY_SOUR.ID left join COM_TYPE   COM_TYPE_COUNTRY_ID on MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = COM_TYPE_COUNTRY_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_IMPORTATION",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_IMPORTATION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_IMPORTATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BACKUP1 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.APPROVE_FILE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXEMPTION_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PURCHASE_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CUSTOMS = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FOREIGN_CURRENCY_RATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COUNTRY_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FOREIGN_CURRENCY_SOURCE_ID_NAM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COUNTRY_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_IMPORTATION[] objs = new DisplayObject_MCE_B_ASSETS_IMPORTATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_IMPORTATION obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPROVE_FILE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.APPROVE_FILE_CODE = :U_APPROVE_FILE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_APPROVE_FILE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.APPROVE_FILE_CODE) ? string.Empty : obj.APPROVE_FILE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXEMPTION_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.EXEMPTION_CODE = :U_EXEMPTION_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_EXEMPTION_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.EXEMPTION_CODE) ? string.Empty : obj.EXEMPTION_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.PURCHASE_MONEY = :U_PURCHASE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PURCHASE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTOMS"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.CUSTOMS = :U_CUSTOMS");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTOMS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CUSTOMS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FOREIGN_CURRENCY_SOURCE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_SOURCE_ID = :U_FOREIGN_CURRENCY_SOURCE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_FOREIGN_CURRENCY_SOURCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FOREIGN_CURRENCY_SOURCE_ID) ? string.Empty : obj.FOREIGN_CURRENCY_SOURCE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FOREIGN_CURRENCY_RATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.FOREIGN_CURRENCY_RATE = :U_FOREIGN_CURRENCY_RATE");
				param = new OracleParameter();
				param.ParameterName = ":U_FOREIGN_CURRENCY_RATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FOREIGN_CURRENCY_RATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COUNTRY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_IMPORTATION.COUNTRY_ID = :U_COUNTRY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_COUNTRY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.COUNTRY_ID) ? string.Empty : obj.COUNTRY_ID;
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
