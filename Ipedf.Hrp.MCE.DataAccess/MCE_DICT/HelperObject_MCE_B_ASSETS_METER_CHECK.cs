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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_METER_CHECK))]
	public partial class HelperObject_MCE_B_ASSETS_METER_CHECK
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_METER_CHECK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_METER_CHECK( AUDIT_TIME, ASSETS_CODE, PRD_ID, ID, NEXT_IDENTIFICATION, PRD_CODE, UNIT_ID, TIME_ZONE, METER_TYPE, HEAD_USER_ID, CREATE_TIME, ACTUAL_IDENTIFICATION, METER_CLASS, EARLY_WARNING_DAYS, CHECK_PERSON, CHECK_ORG, RESULT_ID, CODE, SPEC, STATE, MONEY, PLAN_IDENTIFICATION, IDENTIFICATION_TYPE, AUDIT_USER_ID, IDENTIFICATION_CYCLE, CREATE_USER_ID, DIVID_VALUE, AUDIT_STATE, MEASURE_RANGE, METER_ID, ACCURACY_CLASS, COMMENTS, CREATE_DEPART_ID, BACKUP1, USING_DEPT_ID, ASSETS_ID, CERTIFICATE_CODE, IS_FORCE_SENSE) values ( :AUDIT_TIME, :ASSETS_CODE, :PRD_ID, :ID, :NEXT_IDENTIFICATION, :PRD_CODE, :UNIT_ID, :TIME_ZONE, :METER_TYPE, :HEAD_USER_ID, :CREATE_TIME, :ACTUAL_IDENTIFICATION, :METER_CLASS, :EARLY_WARNING_DAYS, :CHECK_PERSON, :CHECK_ORG, :RESULT_ID, :CODE, :SPEC, :STATE, :MONEY, :PLAN_IDENTIFICATION, :IDENTIFICATION_TYPE, :AUDIT_USER_ID, :IDENTIFICATION_CYCLE, :CREATE_USER_ID, :DIVID_VALUE, :AUDIT_STATE, :MEASURE_RANGE, :METER_ID, :ACCURACY_CLASS, :COMMENTS, :CREATE_DEPART_ID, :BACKUP1, :USING_DEPT_ID, :ASSETS_ID, :CERTIFICATE_CODE, :IS_FORCE_SENSE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[38];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":AUDIT_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.AUDIT_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ASSETS_CODE";
			parameters[1].Size = 100;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PRD_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":NEXT_IDENTIFICATION";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.NEXT_IDENTIFICATION;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PRD_CODE";
			parameters[5].Size = 100;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.PRD_CODE == null ? String.Empty:obj.PRD_CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":UNIT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":TIME_ZONE";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.TIME_ZONE == null ? String.Empty:obj.TIME_ZONE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":METER_TYPE";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.METER_TYPE == null ? String.Empty:obj.METER_TYPE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":HEAD_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.HEAD_USER_ID == null ? String.Empty:obj.HEAD_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ACTUAL_IDENTIFICATION";
			parameters[11].Size = 7;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[11].Value = obj.ACTUAL_IDENTIFICATION;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":METER_CLASS";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.METER_CLASS == null ? String.Empty:obj.METER_CLASS;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":EARLY_WARNING_DAYS";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.EARLY_WARNING_DAYS;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CHECK_PERSON";
			parameters[14].Size = 100;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.CHECK_PERSON == null ? String.Empty:obj.CHECK_PERSON;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":CHECK_ORG";
			parameters[15].Size = 300;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.CHECK_ORG == null ? String.Empty:obj.CHECK_ORG;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":RESULT_ID";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.RESULT_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":CODE";
			parameters[17].Size = 100;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":SPEC";
			parameters[18].Size = 100;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":STATE";
			parameters[19].Size = 22;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[19].Value = obj.STATE;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":MONEY";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.MONEY;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":PLAN_IDENTIFICATION";
			parameters[21].Size = 7;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[21].Value = obj.PLAN_IDENTIFICATION;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":IDENTIFICATION_TYPE";
			parameters[22].Size = 22;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[22].Value = obj.IDENTIFICATION_TYPE;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":AUDIT_USER_ID";
			parameters[23].Size = 36;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[23].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":IDENTIFICATION_CYCLE";
			parameters[24].Size = 22;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[24].Value = obj.IDENTIFICATION_CYCLE;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":CREATE_USER_ID";
			parameters[25].Size = 36;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[25].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":DIVID_VALUE";
			parameters[26].Size = 100;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.DIVID_VALUE == null ? String.Empty:obj.DIVID_VALUE;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":AUDIT_STATE";
			parameters[27].Size = 22;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[27].Value = obj.AUDIT_STATE;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":MEASURE_RANGE";
			parameters[28].Size = 100;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.MEASURE_RANGE == null ? String.Empty:obj.MEASURE_RANGE;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":METER_ID";
			parameters[29].Size = 36;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.METER_ID == null ? String.Empty:obj.METER_ID;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":ACCURACY_CLASS";
			parameters[30].Size = 100;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.ACCURACY_CLASS == null ? String.Empty:obj.ACCURACY_CLASS;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":COMMENTS";
			parameters[31].Size = 200;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[31].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":CREATE_DEPART_ID";
			parameters[32].Size = 36;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[32].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":BACKUP1";
			parameters[33].Size = 1000;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":USING_DEPT_ID";
			parameters[34].Size = 36;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[34].Value = obj.USING_DEPT_ID == null ? String.Empty:obj.USING_DEPT_ID;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":ASSETS_ID";
			parameters[35].Size = 36;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[35].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":CERTIFICATE_CODE";
			parameters[36].Size = 100;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[36].Value = obj.CERTIFICATE_CODE == null ? String.Empty:obj.CERTIFICATE_CODE;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":IS_FORCE_SENSE";
			parameters[37].Size = 22;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[37].Value = obj.IS_FORCE_SENSE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_METER_CHECK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_METER_CHECK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_METER_CHECK obj,CauseObject_MCE_B_ASSETS_METER_CHECK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_METER_CHECK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_METER_CHECK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_METER_CHECK where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_METER_CHECK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_METER_CHECK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_METER_CHECK Get(EntityObject_MCE_B_ASSETS_METER_CHECK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, ASSETS_CODE, MODIFY_TIME, PRD_ID, ID, NEXT_IDENTIFICATION, MODIFY_DEPART_ID, PRD_CODE, UNIT_ID, TIME_ZONE, METER_TYPE, HEAD_USER_ID, CREATE_TIME, MODIFY_USER_ID, ACTUAL_IDENTIFICATION, METER_CLASS, EARLY_WARNING_DAYS, CHECK_PERSON, CHECK_ORG, RESULT_ID, CODE, SPEC, STATE, MONEY, PLAN_IDENTIFICATION, IDENTIFICATION_TYPE, AUDIT_USER_ID, IDENTIFICATION_CYCLE, CREATE_USER_ID, DIVID_VALUE, AUDIT_STATE, MEASURE_RANGE, METER_ID, ACCURACY_CLASS, COMMENTS, CREATE_DEPART_ID, BACKUP1, USING_DEPT_ID, ASSETS_ID, CERTIFICATE_CODE, IS_FORCE_SENSE from MCE_B_ASSETS_METER_CHECK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_METER_CHECK[] objs = new EntityObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK Get(DisplayObject_MCE_B_ASSETS_METER_CHECK obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1) and MCE_B_ASSETS_METER_CHECK.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_METER_CHECK Get(EntityObject_MCE_B_ASSETS_METER_CHECK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, ASSETS_CODE, MODIFY_TIME, PRD_ID, ID, NEXT_IDENTIFICATION, MODIFY_DEPART_ID, PRD_CODE, UNIT_ID, TIME_ZONE, METER_TYPE, HEAD_USER_ID, CREATE_TIME, MODIFY_USER_ID, ACTUAL_IDENTIFICATION, METER_CLASS, EARLY_WARNING_DAYS, CHECK_PERSON, CHECK_ORG, RESULT_ID, CODE, SPEC, STATE, MONEY, PLAN_IDENTIFICATION, IDENTIFICATION_TYPE, AUDIT_USER_ID, IDENTIFICATION_CYCLE, CREATE_USER_ID, DIVID_VALUE, AUDIT_STATE, MEASURE_RANGE, METER_ID, ACCURACY_CLASS, COMMENTS, CREATE_DEPART_ID, BACKUP1, USING_DEPT_ID, ASSETS_ID, CERTIFICATE_CODE, IS_FORCE_SENSE from MCE_B_ASSETS_METER_CHECK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_METER_CHECK[] objs = new EntityObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_METER_CHECK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "ASSETS_CODE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "ID"));
			}
			if(cause.NEXT_IDENTIFICATION!= null)
			{
				if (cause.NEXT_IDENTIFICATION.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION >= :C_NEXT_IDENTIFICATION_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_NEXT_IDENTIFICATION_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.NEXT_IDENTIFICATION.Begin;
					paramList.Add(param);
				}
				if (cause.NEXT_IDENTIFICATION.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION < :C_NEXT_IDENTIFICATION_END");
					param = new OracleParameter();
					param.ParameterName = ":C_NEXT_IDENTIFICATION_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.NEXT_IDENTIFICATION.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("NEXT_IDENTIFICATION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "NEXT_IDENTIFICATION"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.PRD_CODE ").Append((cause.PRD_CODE.StartsWith("%") || cause.PRD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "PRD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "UNIT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TIME_ZONE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.TIME_ZONE ").Append((cause.TIME_ZONE.StartsWith("%") || cause.TIME_ZONE.EndsWith("%")) ? " like " : " = ").Append(" :C_TIME_ZONE");
				param = new OracleParameter();
				param.ParameterName =":C_TIME_ZONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.TIME_ZONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TIME_ZONE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "TIME_ZONE"));
			}
			if(!string.IsNullOrEmpty(cause.METER_TYPE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.METER_TYPE ").Append((cause.METER_TYPE.StartsWith("%") || cause.METER_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_METER_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_METER_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.METER_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("METER_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "METER_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.HEAD_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID ").Append((cause.HEAD_USER_ID.StartsWith("%") || cause.HEAD_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_HEAD_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_HEAD_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.HEAD_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("HEAD_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "HEAD_USER_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "MODIFY_USER_ID"));
			}
			if(cause.ACTUAL_IDENTIFICATION!= null)
			{
				if (cause.ACTUAL_IDENTIFICATION.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION >= :C_ACTUAL_IDENTIFICATION_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_IDENTIFICATION_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_IDENTIFICATION.Begin;
					paramList.Add(param);
				}
				if (cause.ACTUAL_IDENTIFICATION.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION < :C_ACTUAL_IDENTIFICATION_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ACTUAL_IDENTIFICATION_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACTUAL_IDENTIFICATION.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ACTUAL_IDENTIFICATION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "ACTUAL_IDENTIFICATION"));
			}
			if(!string.IsNullOrEmpty(cause.METER_CLASS))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.METER_CLASS ").Append((cause.METER_CLASS.StartsWith("%") || cause.METER_CLASS.EndsWith("%")) ? " like " : " = ").Append(" :C_METER_CLASS");
				param = new OracleParameter();
				param.ParameterName =":C_METER_CLASS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.METER_CLASS;
				paramList.Add(param);
			}
			if (cause.HasINValue("METER_CLASS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "METER_CLASS"));
			}
			if(cause.EARLY_WARNING_DAYS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS = :C_EARLY_WARNING_DAYS");
				param = new OracleParameter();
				param.ParameterName =":C_EARLY_WARNING_DAYS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EARLY_WARNING_DAYS;
				paramList.Add(param);
			}
			if (cause.HasINValue("EARLY_WARNING_DAYS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "EARLY_WARNING_DAYS"));
			}
			if(!string.IsNullOrEmpty(cause.CHECK_PERSON))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CHECK_PERSON ").Append((cause.CHECK_PERSON.StartsWith("%") || cause.CHECK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :C_CHECK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":C_CHECK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CHECK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHECK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CHECK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.CHECK_ORG))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CHECK_ORG ").Append((cause.CHECK_ORG.StartsWith("%") || cause.CHECK_ORG.EndsWith("%")) ? " like " : " = ").Append(" :C_CHECK_ORG");
				param = new OracleParameter();
				param.ParameterName =":C_CHECK_ORG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.CHECK_ORG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHECK_ORG"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CHECK_ORG"));
			}
			if(cause.RESULT_ID!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.RESULT_ID = :C_RESULT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_RESULT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RESULT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("RESULT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "RESULT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "SPEC"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "STATE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "MONEY"));
			}
			if(cause.PLAN_IDENTIFICATION!= null)
			{
				if (cause.PLAN_IDENTIFICATION.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION >= :C_PLAN_IDENTIFICATION_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PLAN_IDENTIFICATION_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_IDENTIFICATION.Begin;
					paramList.Add(param);
				}
				if (cause.PLAN_IDENTIFICATION.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION < :C_PLAN_IDENTIFICATION_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PLAN_IDENTIFICATION_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_IDENTIFICATION.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PLAN_IDENTIFICATION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "PLAN_IDENTIFICATION"));
			}
			if(cause.IDENTIFICATION_TYPE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = :C_IDENTIFICATION_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_IDENTIFICATION_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IDENTIFICATION_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTIFICATION_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "IDENTIFICATION_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "AUDIT_USER_ID"));
			}
			if(cause.IDENTIFICATION_CYCLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE = :C_IDENTIFICATION_CYCLE");
				param = new OracleParameter();
				param.ParameterName =":C_IDENTIFICATION_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IDENTIFICATION_CYCLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTIFICATION_CYCLE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "IDENTIFICATION_CYCLE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DIVID_VALUE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.DIVID_VALUE ").Append((cause.DIVID_VALUE.StartsWith("%") || cause.DIVID_VALUE.EndsWith("%")) ? " like " : " = ").Append(" :C_DIVID_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_DIVID_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.DIVID_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DIVID_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "DIVID_VALUE"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MEASURE_RANGE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE ").Append((cause.MEASURE_RANGE.StartsWith("%") || cause.MEASURE_RANGE.EndsWith("%")) ? " like " : " = ").Append(" :C_MEASURE_RANGE");
				param = new OracleParameter();
				param.ParameterName =":C_MEASURE_RANGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MEASURE_RANGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEASURE_RANGE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "MEASURE_RANGE"));
			}
			if(!string.IsNullOrEmpty(cause.METER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.METER_ID ").Append((cause.METER_ID.StartsWith("%") || cause.METER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_METER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_METER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.METER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("METER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "METER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ACCURACY_CLASS))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS ").Append((cause.ACCURACY_CLASS.StartsWith("%") || cause.ACCURACY_CLASS.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCURACY_CLASS");
				param = new OracleParameter();
				param.ParameterName =":C_ACCURACY_CLASS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ACCURACY_CLASS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCURACY_CLASS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "ACCURACY_CLASS"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID ").Append((cause.USING_DEPT_ID.StartsWith("%") || cause.USING_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "USING_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CERTIFICATE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE ").Append((cause.CERTIFICATE_CODE.StartsWith("%") || cause.CERTIFICATE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CERTIFICATE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CERTIFICATE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CERTIFICATE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CERTIFICATE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "CERTIFICATE_CODE"));
			}
			if(cause.IS_FORCE_SENSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = :C_IS_FORCE_SENSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_FORCE_SENSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FORCE_SENSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FORCE_SENSE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_METER_CHECK", "IS_FORCE_SENSE"));
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
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_METER_CHECK",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME, MCE_B_ASSETS_METER_CHECK.ASSETS_CODE, MCE_B_ASSETS_METER_CHECK.MODIFY_TIME, MCE_B_ASSETS_METER_CHECK.PRD_ID, MCE_B_ASSETS_METER_CHECK.ID, MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID, MCE_B_ASSETS_METER_CHECK.PRD_CODE, MCE_B_ASSETS_METER_CHECK.UNIT_ID, MCE_B_ASSETS_METER_CHECK.TIME_ZONE, MCE_B_ASSETS_METER_CHECK.METER_TYPE, MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID, MCE_B_ASSETS_METER_CHECK.CREATE_TIME, MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID, MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.METER_CLASS, MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS, MCE_B_ASSETS_METER_CHECK.CHECK_PERSON, MCE_B_ASSETS_METER_CHECK.CHECK_ORG, MCE_B_ASSETS_METER_CHECK.RESULT_ID, MCE_B_ASSETS_METER_CHECK.CODE, MCE_B_ASSETS_METER_CHECK.SPEC, MCE_B_ASSETS_METER_CHECK.STATE, MCE_B_ASSETS_METER_CHECK.MONEY, MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE, MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID, MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE, MCE_B_ASSETS_METER_CHECK.CREATE_USER_ID, MCE_B_ASSETS_METER_CHECK.DIVID_VALUE, MCE_B_ASSETS_METER_CHECK.AUDIT_STATE, MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE, MCE_B_ASSETS_METER_CHECK.METER_ID, MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS, MCE_B_ASSETS_METER_CHECK.COMMENTS, MCE_B_ASSETS_METER_CHECK.CREATE_DEPART_ID, MCE_B_ASSETS_METER_CHECK.BACKUP1, MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID, MCE_B_ASSETS_METER_CHECK.ASSETS_ID, MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE, MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_METER_TYPE_METER_.NAME as METER_TYPE_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 1 then '合格' when MCE_B_ASSETS_METER_CHECK.RESULT_ID = 2 then '不合格' else '' end ) as RESULT_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.STATE = 0 then '默认值' when MCE_B_ASSETS_METER_CHECK.STATE = 1 then '编辑中' when MCE_B_ASSETS_METER_CHECK.STATE = 2 then '已提交' when MCE_B_ASSETS_METER_CHECK.STATE = 3 then '已审核' when MCE_B_ASSETS_METER_CHECK.STATE = 4 then '已归档' when MCE_B_ASSETS_METER_CHECK.STATE = 9 then '已作废' else '' end ) as STATE_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 1 then '院内' when MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = 2 then '外包' else '' end ) as IDENTIFICATION_TYPE_NAME, COM_USER_AUDIT_USER_ID.NAME as AUDIT_USER_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, (case  when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME from MCE_B_ASSETS_METER_CHECK left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_METER_CHECK.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_METER_CHECK.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_METER_TYPE   MCE_B_ASSETS_METER_TYPE_METER_ on MCE_B_ASSETS_METER_CHECK.METER_TYPE = MCE_B_ASSETS_METER_TYPE_METER_.ID left join COM_USER   COM_USER_HEAD_USER_ID on MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID left join COM_USER   COM_USER_AUDIT_USER_ID on MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = COM_USER_AUDIT_USER_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_METER_CHECK.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_METER_CHECK",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_METER_CHECK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_METER_CHECK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRD_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_IDENTIFICATION = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRD_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.UNIT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.TIME_ZONE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.METER_TYPE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACTUAL_IDENTIFICATION = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.METER_CLASS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EARLY_WARNING_DAYS = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CHECK_PERSON = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CHECK_ORG = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.RESULT_ID = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SPEC = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PLAN_IDENTIFICATION = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IDENTIFICATION_TYPE = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.IDENTIFICATION_CYCLE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DIVID_VALUE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MEASURE_RANGE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.METER_ID = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ACCURACY_CLASS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COMMENTS = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BACKUP1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ASSETS_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CERTIFICATE_CODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.METER_TYPE_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.RESULT_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.STATE_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.IDENTIFICATION_TYPE_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.AUDIT_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_METER_CHECK[] objs = new DisplayObject_MCE_B_ASSETS_METER_CHECK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_METER_CHECK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEXT_IDENTIFICATION"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.NEXT_IDENTIFICATION = :U_NEXT_IDENTIFICATION");
				param = new OracleParameter();
				param.ParameterName = ":U_NEXT_IDENTIFICATION";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.NEXT_IDENTIFICATION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.PRD_CODE = :U_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRD_CODE) ? string.Empty : obj.PRD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TIME_ZONE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.TIME_ZONE = :U_TIME_ZONE");
				param = new OracleParameter();
				param.ParameterName = ":U_TIME_ZONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.TIME_ZONE) ? string.Empty : obj.TIME_ZONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("METER_TYPE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.METER_TYPE = :U_METER_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_METER_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.METER_TYPE) ? string.Empty : obj.METER_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HEAD_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.HEAD_USER_ID = :U_HEAD_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_HEAD_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.HEAD_USER_ID) ? string.Empty : obj.HEAD_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACTUAL_IDENTIFICATION"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.ACTUAL_IDENTIFICATION = :U_ACTUAL_IDENTIFICATION");
				param = new OracleParameter();
				param.ParameterName = ":U_ACTUAL_IDENTIFICATION";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ACTUAL_IDENTIFICATION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("METER_CLASS"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.METER_CLASS = :U_METER_CLASS");
				param = new OracleParameter();
				param.ParameterName = ":U_METER_CLASS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.METER_CLASS) ? string.Empty : obj.METER_CLASS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EARLY_WARNING_DAYS"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.EARLY_WARNING_DAYS = :U_EARLY_WARNING_DAYS");
				param = new OracleParameter();
				param.ParameterName = ":U_EARLY_WARNING_DAYS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EARLY_WARNING_DAYS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHECK_PERSON"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.CHECK_PERSON = :U_CHECK_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":U_CHECK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CHECK_PERSON) ? string.Empty : obj.CHECK_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHECK_ORG"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.CHECK_ORG = :U_CHECK_ORG");
				param = new OracleParameter();
				param.ParameterName = ":U_CHECK_ORG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.CHECK_ORG) ? string.Empty : obj.CHECK_ORG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RESULT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.RESULT_ID = :U_RESULT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_RESULT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RESULT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_IDENTIFICATION"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.PLAN_IDENTIFICATION = :U_PLAN_IDENTIFICATION");
				param = new OracleParameter();
				param.ParameterName = ":U_PLAN_IDENTIFICATION";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PLAN_IDENTIFICATION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTIFICATION_TYPE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_TYPE = :U_IDENTIFICATION_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTIFICATION_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IDENTIFICATION_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTIFICATION_CYCLE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.IDENTIFICATION_CYCLE = :U_IDENTIFICATION_CYCLE");
				param = new OracleParameter();
				param.ParameterName = ":U_IDENTIFICATION_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IDENTIFICATION_CYCLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DIVID_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.DIVID_VALUE = :U_DIVID_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_DIVID_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.DIVID_VALUE) ? string.Empty : obj.DIVID_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEASURE_RANGE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.MEASURE_RANGE = :U_MEASURE_RANGE");
				param = new OracleParameter();
				param.ParameterName = ":U_MEASURE_RANGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.MEASURE_RANGE) ? string.Empty : obj.MEASURE_RANGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("METER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.METER_ID = :U_METER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_METER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.METER_ID) ? string.Empty : obj.METER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCURACY_CLASS"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.ACCURACY_CLASS = :U_ACCURACY_CLASS");
				param = new OracleParameter();
				param.ParameterName = ":U_ACCURACY_CLASS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ACCURACY_CLASS) ? string.Empty : obj.ACCURACY_CLASS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.USING_DEPT_ID = :U_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID) ? string.Empty : obj.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CERTIFICATE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.CERTIFICATE_CODE = :U_CERTIFICATE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CERTIFICATE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CERTIFICATE_CODE) ? string.Empty : obj.CERTIFICATE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FORCE_SENSE"))
			{
				strBuf.Add("  MCE_B_ASSETS_METER_CHECK.IS_FORCE_SENSE = :U_IS_FORCE_SENSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_FORCE_SENSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FORCE_SENSE;
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
