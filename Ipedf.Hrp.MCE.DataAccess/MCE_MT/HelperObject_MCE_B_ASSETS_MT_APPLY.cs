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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_APPLY))]
	public partial class HelperObject_MCE_B_ASSETS_MT_APPLY
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_MT_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_MT_APPLY( AUDIT_TIME, FAULT_ANALYSIS, INVOICE_CODE, MODIFY_DEPT_ID, PRD_ID, ID, DATA_ORGANISE_ID, SPEC, CODE, APPLY_USER_ID, CREATE_TIME, MTN_TYPE_ID, ASSETS_CODE, DOWN_DESC, APPLY_USER_PHONE, COMPLETE_TIME, MAINTAIN_MONEY, APPLY_DEPT_ID, USING_USER_ID, USING_DEPT_COMMENTS, STATE, FAULT_SOLUTION, MTN_ENGINEER, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, REPAIR_RESULT, MTN_TOTAL_HOURS, ASSETS_TYPE_ID, CREATE_USER_ID, APPLY_TIME, MAINTENANCE_PERIOD_DATE, MAINTAIN_DEPT_ID, FAULT_DESC, IS_CLOSE, EMERGENCY_DEGREE, USING_DEPT_ID, FAULT_TYPE, ASSETS_ID, DOWN_TIME, CREATE_DEPT_ID, COMMENTS) values ( :AUDIT_TIME, :FAULT_ANALYSIS, :INVOICE_CODE, :MODIFY_DEPT_ID, :PRD_ID, :ID, :DATA_ORGANISE_ID, :SPEC, :CODE, :APPLY_USER_ID, :CREATE_TIME, :MTN_TYPE_ID, :ASSETS_CODE, :DOWN_DESC, :APPLY_USER_PHONE, :COMPLETE_TIME, :MAINTAIN_MONEY, :APPLY_DEPT_ID, :USING_USER_ID, :USING_DEPT_COMMENTS, :STATE, :FAULT_SOLUTION, :MTN_ENGINEER, :CREATE_DATE, :AUDIT_USER_ID, :APPLY_COMMENTS, :REPAIR_RESULT, :MTN_TOTAL_HOURS, :ASSETS_TYPE_ID, :CREATE_USER_ID, :APPLY_TIME, :MAINTENANCE_PERIOD_DATE, :MAINTAIN_DEPT_ID, :FAULT_DESC, :IS_CLOSE, :EMERGENCY_DEGREE, :USING_DEPT_ID, :FAULT_TYPE, :ASSETS_ID, :DOWN_TIME, :CREATE_DEPT_ID, :COMMENTS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[42];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":AUDIT_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.AUDIT_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":FAULT_ANALYSIS";
			parameters[1].Size = 1000;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.FAULT_ANALYSIS == null ? String.Empty:obj.FAULT_ANALYSIS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":INVOICE_CODE";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.INVOICE_CODE == null ? String.Empty:obj.INVOICE_CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MODIFY_DEPT_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PRD_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DATA_ORGANISE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":SPEC";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CODE";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":APPLY_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":MTN_TYPE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.MTN_TYPE_ID == null ? String.Empty:obj.MTN_TYPE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ASSETS_CODE";
			parameters[12].Size = 100;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":DOWN_DESC";
			parameters[13].Size = 200;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.DOWN_DESC == null ? String.Empty:obj.DOWN_DESC;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":APPLY_USER_PHONE";
			parameters[14].Size = 100;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.APPLY_USER_PHONE == null ? String.Empty:obj.APPLY_USER_PHONE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":COMPLETE_TIME";
			parameters[15].Size = 7;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[15].Value = obj.COMPLETE_TIME;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":MAINTAIN_MONEY";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.MAINTAIN_MONEY;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":APPLY_DEPT_ID";
			parameters[17].Size = 36;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.APPLY_DEPT_ID == null ? String.Empty:obj.APPLY_DEPT_ID;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":USING_USER_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.USING_USER_ID == null ? String.Empty:obj.USING_USER_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":USING_DEPT_COMMENTS";
			parameters[19].Size = 200;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.USING_DEPT_COMMENTS == null ? String.Empty:obj.USING_DEPT_COMMENTS;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":STATE";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.STATE;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":FAULT_SOLUTION";
			parameters[21].Size = 1000;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.FAULT_SOLUTION == null ? String.Empty:obj.FAULT_SOLUTION;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":MTN_ENGINEER";
			parameters[22].Size = 100;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.MTN_ENGINEER == null ? String.Empty:obj.MTN_ENGINEER;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":CREATE_DATE";
			parameters[23].Size = 7;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[23].Value = obj.CREATE_DATE;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":AUDIT_USER_ID";
			parameters[24].Size = 36;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[24].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":APPLY_COMMENTS";
			parameters[25].Size = 200;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.APPLY_COMMENTS == null ? String.Empty:obj.APPLY_COMMENTS;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":REPAIR_RESULT";
			parameters[26].Size = 36;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.REPAIR_RESULT == null ? String.Empty:obj.REPAIR_RESULT;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":MTN_TOTAL_HOURS";
			parameters[27].Size = 22;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[27].Value = obj.MTN_TOTAL_HOURS;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":ASSETS_TYPE_ID";
			parameters[28].Size = 36;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[28].Value = obj.ASSETS_TYPE_ID == null ? String.Empty:obj.ASSETS_TYPE_ID;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":CREATE_USER_ID";
			parameters[29].Size = 36;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":APPLY_TIME";
			parameters[30].Size = 7;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[30].Value = obj.APPLY_TIME;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":MAINTENANCE_PERIOD_DATE";
			parameters[31].Size = 7;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[31].Value = obj.MAINTENANCE_PERIOD_DATE;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":MAINTAIN_DEPT_ID";
			parameters[32].Size = 36;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[32].Value = obj.MAINTAIN_DEPT_ID == null ? String.Empty:obj.MAINTAIN_DEPT_ID;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":FAULT_DESC";
			parameters[33].Size = 1000;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.FAULT_DESC == null ? String.Empty:obj.FAULT_DESC;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":IS_CLOSE";
			parameters[34].Size = 50;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[34].Value = obj.IS_CLOSE == null ? String.Empty:obj.IS_CLOSE;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":EMERGENCY_DEGREE";
			parameters[35].Size = 36;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[35].Value = obj.EMERGENCY_DEGREE == null ? String.Empty:obj.EMERGENCY_DEGREE;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":USING_DEPT_ID";
			parameters[36].Size = 36;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[36].Value = obj.USING_DEPT_ID == null ? String.Empty:obj.USING_DEPT_ID;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":FAULT_TYPE";
			parameters[37].Size = 36;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[37].Value = obj.FAULT_TYPE == null ? String.Empty:obj.FAULT_TYPE;
			parameters[38] = new OracleParameter();
			parameters[38].ParameterName =":ASSETS_ID";
			parameters[38].Size = 36;
			parameters[38].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[38].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[39] = new OracleParameter();
			parameters[39].ParameterName =":DOWN_TIME";
			parameters[39].Size = 7;
			parameters[39].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[39].Value = obj.DOWN_TIME;
			parameters[40] = new OracleParameter();
			parameters[40].ParameterName =":CREATE_DEPT_ID";
			parameters[40].Size = 36;
			parameters[40].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[40].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[41] = new OracleParameter();
			parameters[41].ParameterName =":COMMENTS";
			parameters[41].Size = 200;
			parameters[41].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[41].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_APPLY set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_MT_APPLY obj,CauseObject_MCE_B_ASSETS_MT_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_MT_APPLY set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_MT_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_MT_APPLY where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_MT_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_MT_APPLY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_MT_APPLY Get(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, FAULT_ANALYSIS, INVOICE_CODE, MODIFY_DEPT_ID, MODIFY_TIME, PRD_ID, ID, DATA_ORGANISE_ID, SPEC, CODE, APPLY_USER_ID, CREATE_TIME, MTN_TYPE_ID, ASSETS_CODE, DOWN_DESC, APPLY_USER_PHONE, COMPLETE_TIME, MAINTAIN_MONEY, APPLY_DEPT_ID, USING_USER_ID, USING_DEPT_COMMENTS, STATE, FAULT_SOLUTION, MTN_ENGINEER, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, REPAIR_RESULT, MTN_TOTAL_HOURS, ASSETS_TYPE_ID, CREATE_USER_ID, APPLY_TIME, MAINTENANCE_PERIOD_DATE, MODIFY_USER_ID, MAINTAIN_DEPT_ID, FAULT_DESC, IS_CLOSE, EMERGENCY_DEGREE, USING_DEPT_ID, FAULT_TYPE, ASSETS_ID, DOWN_TIME, CREATE_DEPT_ID, COMMENTS from MCE_B_ASSETS_MT_APPLY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_APPLY[] objs = new EntityObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY Get(DisplayObject_MCE_B_ASSETS_MT_APPLY obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1) and MCE_B_ASSETS_MT_APPLY.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_MT_APPLY Get(EntityObject_MCE_B_ASSETS_MT_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, FAULT_ANALYSIS, INVOICE_CODE, MODIFY_DEPT_ID, MODIFY_TIME, PRD_ID, ID, DATA_ORGANISE_ID, SPEC, CODE, APPLY_USER_ID, CREATE_TIME, MTN_TYPE_ID, ASSETS_CODE, DOWN_DESC, APPLY_USER_PHONE, COMPLETE_TIME, MAINTAIN_MONEY, APPLY_DEPT_ID, USING_USER_ID, USING_DEPT_COMMENTS, STATE, FAULT_SOLUTION, MTN_ENGINEER, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, REPAIR_RESULT, MTN_TOTAL_HOURS, ASSETS_TYPE_ID, CREATE_USER_ID, APPLY_TIME, MAINTENANCE_PERIOD_DATE, MODIFY_USER_ID, MAINTAIN_DEPT_ID, FAULT_DESC, IS_CLOSE, EMERGENCY_DEGREE, USING_DEPT_ID, FAULT_TYPE, ASSETS_ID, DOWN_TIME, CREATE_DEPT_ID, COMMENTS from MCE_B_ASSETS_MT_APPLY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_MT_APPLY[] objs = new EntityObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_MT_APPLY cause,out OracleParameter[] parameters )
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
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.FAULT_ANALYSIS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS ").Append((cause.FAULT_ANALYSIS.StartsWith("%") || cause.FAULT_ANALYSIS.EndsWith("%")) ? " like " : " = ").Append(" :C_FAULT_ANALYSIS");
				param = new OracleParameter();
				param.ParameterName =":C_FAULT_ANALYSIS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.FAULT_ANALYSIS;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAULT_ANALYSIS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "FAULT_ANALYSIS"));
			}
			if(!string.IsNullOrEmpty(cause.INVOICE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.INVOICE_CODE ").Append((cause.INVOICE_CODE.StartsWith("%") || cause.INVOICE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.INVOICE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INVOICE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "INVOICE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MODIFY_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "APPLY_USER_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MTN_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID ").Append((cause.MTN_TYPE_ID.StartsWith("%") || cause.MTN_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MTN_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MTN_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MTN_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTN_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MTN_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.DOWN_DESC))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.DOWN_DESC ").Append((cause.DOWN_DESC.StartsWith("%") || cause.DOWN_DESC.EndsWith("%")) ? " like " : " = ").Append(" :C_DOWN_DESC");
				param = new OracleParameter();
				param.ParameterName =":C_DOWN_DESC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.DOWN_DESC;
				paramList.Add(param);
			}
			if (cause.HasINValue("DOWN_DESC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "DOWN_DESC"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_PHONE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE ").Append((cause.APPLY_USER_PHONE.StartsWith("%") || cause.APPLY_USER_PHONE.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_USER_PHONE");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_USER_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.APPLY_USER_PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_PHONE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "APPLY_USER_PHONE"));
			}
			if(cause.COMPLETE_TIME!= null)
			{
				if (cause.COMPLETE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME >= :C_COMPLETE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_COMPLETE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.COMPLETE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME < :C_COMPLETE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_COMPLETE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("COMPLETE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "COMPLETE_TIME"));
			}
			if(cause.MAINTAIN_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY = :C_MAINTAIN_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MAINTAIN_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MAINTAIN_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID ").Append((cause.APPLY_DEPT_ID.StartsWith("%") || cause.APPLY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "APPLY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USING_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.USING_USER_ID ").Append((cause.USING_USER_ID.StartsWith("%") || cause.USING_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "USING_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS ").Append((cause.USING_DEPT_COMMENTS.StartsWith("%") || cause.USING_DEPT_COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.USING_DEPT_COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "USING_DEPT_COMMENTS"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.FAULT_SOLUTION))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION ").Append((cause.FAULT_SOLUTION.StartsWith("%") || cause.FAULT_SOLUTION.EndsWith("%")) ? " like " : " = ").Append(" :C_FAULT_SOLUTION");
				param = new OracleParameter();
				param.ParameterName =":C_FAULT_SOLUTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.FAULT_SOLUTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAULT_SOLUTION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "FAULT_SOLUTION"));
			}
			if(!string.IsNullOrEmpty(cause.MTN_ENGINEER))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER ").Append((cause.MTN_ENGINEER.StartsWith("%") || cause.MTN_ENGINEER.EndsWith("%")) ? " like " : " = ").Append(" :C_MTN_ENGINEER");
				param = new OracleParameter();
				param.ParameterName =":C_MTN_ENGINEER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MTN_ENGINEER;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTN_ENGINEER"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MTN_ENGINEER"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_DATE < :C_CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS ").Append((cause.APPLY_COMMENTS.StartsWith("%") || cause.APPLY_COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "APPLY_COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.REPAIR_RESULT))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT ").Append((cause.REPAIR_RESULT.StartsWith("%") || cause.REPAIR_RESULT.EndsWith("%")) ? " like " : " = ").Append(" :C_REPAIR_RESULT");
				param = new OracleParameter();
				param.ParameterName =":C_REPAIR_RESULT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REPAIR_RESULT;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPAIR_RESULT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "REPAIR_RESULT"));
			}
			if(cause.MTN_TOTAL_HOURS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS = :C_MTN_TOTAL_HOURS");
				param = new OracleParameter();
				param.ParameterName =":C_MTN_TOTAL_HOURS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MTN_TOTAL_HOURS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MTN_TOTAL_HOURS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MTN_TOTAL_HOURS"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID ").Append((cause.ASSETS_TYPE_ID.StartsWith("%") || cause.ASSETS_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "ASSETS_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "CREATE_USER_ID"));
			}
			if(cause.APPLY_TIME!= null)
			{
				if (cause.APPLY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_TIME >= :C_APPLY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_APPLY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.APPLY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.APPLY_TIME < :C_APPLY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_APPLY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("APPLY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "APPLY_TIME"));
			}
			if(cause.MAINTENANCE_PERIOD_DATE!= null)
			{
				if (cause.MAINTENANCE_PERIOD_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE >= :C_MAINTENANCE_PERIOD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MAINTENANCE_PERIOD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MAINTENANCE_PERIOD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.MAINTENANCE_PERIOD_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE < :C_MAINTENANCE_PERIOD_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MAINTENANCE_PERIOD_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MAINTENANCE_PERIOD_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MAINTENANCE_PERIOD_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MAINTENANCE_PERIOD_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MAINTAIN_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID ").Append((cause.MAINTAIN_DEPT_ID.StartsWith("%") || cause.MAINTAIN_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MAINTAIN_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MAINTAIN_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "MAINTAIN_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FAULT_DESC))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.FAULT_DESC ").Append((cause.FAULT_DESC.StartsWith("%") || cause.FAULT_DESC.EndsWith("%")) ? " like " : " = ").Append(" :C_FAULT_DESC");
				param = new OracleParameter();
				param.ParameterName =":C_FAULT_DESC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.FAULT_DESC;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAULT_DESC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "FAULT_DESC"));
			}
			if(!string.IsNullOrEmpty(cause.IS_CLOSE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.IS_CLOSE ").Append((cause.IS_CLOSE.StartsWith("%") || cause.IS_CLOSE.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_CLOSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CLOSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.IS_CLOSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CLOSE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "IS_CLOSE"));
			}
			if(!string.IsNullOrEmpty(cause.EMERGENCY_DEGREE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE ").Append((cause.EMERGENCY_DEGREE.StartsWith("%") || cause.EMERGENCY_DEGREE.EndsWith("%")) ? " like " : " = ").Append(" :C_EMERGENCY_DEGREE");
				param = new OracleParameter();
				param.ParameterName =":C_EMERGENCY_DEGREE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.EMERGENCY_DEGREE;
				paramList.Add(param);
			}
			if (cause.HasINValue("EMERGENCY_DEGREE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "EMERGENCY_DEGREE"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID ").Append((cause.USING_DEPT_ID.StartsWith("%") || cause.USING_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "USING_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FAULT_TYPE))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.FAULT_TYPE ").Append((cause.FAULT_TYPE.StartsWith("%") || cause.FAULT_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_FAULT_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_FAULT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FAULT_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAULT_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "FAULT_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "ASSETS_ID"));
			}
			if(cause.DOWN_TIME!= null)
			{
				if (cause.DOWN_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.DOWN_TIME >= :C_DOWN_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_DOWN_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DOWN_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.DOWN_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.DOWN_TIME < :C_DOWN_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_DOWN_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DOWN_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("DOWN_TIME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "DOWN_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_MT_APPLY.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_MT_APPLY", "COMMENTS"));
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
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_APPLY",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME, MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS, MCE_B_ASSETS_MT_APPLY.INVOICE_CODE, MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.MODIFY_TIME, MCE_B_ASSETS_MT_APPLY.PRD_ID, MCE_B_ASSETS_MT_APPLY.ID, MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID, MCE_B_ASSETS_MT_APPLY.SPEC, MCE_B_ASSETS_MT_APPLY.CODE, MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID, MCE_B_ASSETS_MT_APPLY.CREATE_TIME, MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID, MCE_B_ASSETS_MT_APPLY.ASSETS_CODE, MCE_B_ASSETS_MT_APPLY.DOWN_DESC, MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE, MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME, MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY, MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID, MCE_B_ASSETS_MT_APPLY.USING_USER_ID, MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS, MCE_B_ASSETS_MT_APPLY.STATE, MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION, MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER, MCE_B_ASSETS_MT_APPLY.CREATE_DATE, MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS, MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT, MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS, MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID, MCE_B_ASSETS_MT_APPLY.CREATE_USER_ID, MCE_B_ASSETS_MT_APPLY.APPLY_TIME, MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID, MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_DESC, MCE_B_ASSETS_MT_APPLY.IS_CLOSE, MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE, MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID, MCE_B_ASSETS_MT_APPLY.FAULT_TYPE, MCE_B_ASSETS_MT_APPLY.ASSETS_ID, MCE_B_ASSETS_MT_APPLY.DOWN_TIME, MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID, MCE_B_ASSETS_MT_APPLY.COMMENTS, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_TYPE_MTN_TYPE_ID.NAME as MTN_TYPE_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, (case  when MCE_B_ASSETS_MT_APPLY.STATE = 0 then '默认值' when MCE_B_ASSETS_MT_APPLY.STATE = 1 then '编辑中' when MCE_B_ASSETS_MT_APPLY.STATE = 2 then '已提交' when MCE_B_ASSETS_MT_APPLY.STATE = 3 then '已审核' when MCE_B_ASSETS_MT_APPLY.STATE = 4 then '已归档' when MCE_B_ASSETS_MT_APPLY.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_REPAIR_RESULT.NAME as REPAIR_RESULT_NAME, MCE_D_MCE_TYPE_ASSETS_TYPE_ID.NAME as ASSETS_TYPE_ID_NAME, COM_TYPE_EMERGENCY_DEGREE.NAME as EMERGENCY_DEGREE_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, COM_TYPE_FAULT_TYPE.NAME as FAULT_TYPE_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME from MCE_B_ASSETS_MT_APPLY left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_MT_APPLY.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_TYPE   COM_TYPE_MTN_TYPE_ID on MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = COM_TYPE_MTN_TYPE_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS_MT_APPLY.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_REPAIR_RESULT on MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = COM_TYPE_REPAIR_RESULT.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSETS_TYPE_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = MCE_D_MCE_TYPE_ASSETS_TYPE_ID.ID left join COM_TYPE   COM_TYPE_EMERGENCY_DEGREE on MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = COM_TYPE_EMERGENCY_DEGREE.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join COM_TYPE   COM_TYPE_FAULT_TYPE on MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = COM_TYPE_FAULT_TYPE.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_MT_APPLY.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_MT_APPLY",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_MT_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_MT_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FAULT_ANALYSIS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MTN_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DOWN_DESC = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_USER_PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.USING_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USING_DEPT_COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.STATE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FAULT_SOLUTION = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MTN_ENGINEER = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.REPAIR_RESULT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MTN_TOTAL_HOURS = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ASSETS_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.APPLY_TIME = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MAINTAIN_DEPT_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FAULT_DESC = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.IS_CLOSE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EMERGENCY_DEGREE = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.FAULT_TYPE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSETS_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.DOWN_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.COMMENTS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MTN_TYPE_ID_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.STATE_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.REPAIR_RESULT_NAME = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ASSETS_TYPE_ID_NAME = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.EMERGENCY_DEGREE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.FAULT_TYPE_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(55);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_MT_APPLY[] objs = new DisplayObject_MCE_B_ASSETS_MT_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAULT_ANALYSIS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.FAULT_ANALYSIS = :U_FAULT_ANALYSIS");
				param = new OracleParameter();
				param.ParameterName = ":U_FAULT_ANALYSIS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.FAULT_ANALYSIS) ? string.Empty : obj.FAULT_ANALYSIS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVOICE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.INVOICE_CODE = :U_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.INVOICE_CODE) ? string.Empty : obj.INVOICE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.APPLY_USER_ID = :U_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTN_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MTN_TYPE_ID = :U_MTN_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MTN_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MTN_TYPE_ID) ? string.Empty : obj.MTN_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DOWN_DESC"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.DOWN_DESC = :U_DOWN_DESC");
				param = new OracleParameter();
				param.ParameterName = ":U_DOWN_DESC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.DOWN_DESC) ? string.Empty : obj.DOWN_DESC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_PHONE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.APPLY_USER_PHONE = :U_APPLY_USER_PHONE");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_USER_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_PHONE) ? string.Empty : obj.APPLY_USER_PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMPLETE_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.COMPLETE_TIME = :U_COMPLETE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_COMPLETE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.COMPLETE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTAIN_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MAINTAIN_MONEY = :U_MAINTAIN_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MAINTAIN_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.APPLY_DEPT_ID = :U_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_DEPT_ID) ? string.Empty : obj.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.USING_USER_ID = :U_USING_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_USER_ID) ? string.Empty : obj.USING_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.USING_DEPT_COMMENTS = :U_USING_DEPT_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_COMMENTS) ? string.Empty : obj.USING_DEPT_COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAULT_SOLUTION"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.FAULT_SOLUTION = :U_FAULT_SOLUTION");
				param = new OracleParameter();
				param.ParameterName = ":U_FAULT_SOLUTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.FAULT_SOLUTION) ? string.Empty : obj.FAULT_SOLUTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTN_ENGINEER"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MTN_ENGINEER = :U_MTN_ENGINEER");
				param = new OracleParameter();
				param.ParameterName = ":U_MTN_ENGINEER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.MTN_ENGINEER) ? string.Empty : obj.MTN_ENGINEER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.APPLY_COMMENTS = :U_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.APPLY_COMMENTS) ? string.Empty : obj.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPAIR_RESULT"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.REPAIR_RESULT = :U_REPAIR_RESULT");
				param = new OracleParameter();
				param.ParameterName = ":U_REPAIR_RESULT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REPAIR_RESULT) ? string.Empty : obj.REPAIR_RESULT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MTN_TOTAL_HOURS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MTN_TOTAL_HOURS = :U_MTN_TOTAL_HOURS");
				param = new OracleParameter();
				param.ParameterName = ":U_MTN_TOTAL_HOURS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MTN_TOTAL_HOURS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.ASSETS_TYPE_ID = :U_ASSETS_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_TYPE_ID) ? string.Empty : obj.ASSETS_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.APPLY_TIME = :U_APPLY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.APPLY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTENANCE_PERIOD_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MAINTENANCE_PERIOD_DATE = :U_MAINTENANCE_PERIOD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTENANCE_PERIOD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MAINTENANCE_PERIOD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTAIN_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.MAINTAIN_DEPT_ID = :U_MAINTAIN_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MAINTAIN_DEPT_ID) ? string.Empty : obj.MAINTAIN_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAULT_DESC"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.FAULT_DESC = :U_FAULT_DESC");
				param = new OracleParameter();
				param.ParameterName = ":U_FAULT_DESC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.FAULT_DESC) ? string.Empty : obj.FAULT_DESC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CLOSE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.IS_CLOSE = :U_IS_CLOSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_CLOSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.IS_CLOSE) ? string.Empty : obj.IS_CLOSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EMERGENCY_DEGREE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.EMERGENCY_DEGREE = :U_EMERGENCY_DEGREE");
				param = new OracleParameter();
				param.ParameterName = ":U_EMERGENCY_DEGREE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.EMERGENCY_DEGREE) ? string.Empty : obj.EMERGENCY_DEGREE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.USING_DEPT_ID = :U_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID) ? string.Empty : obj.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAULT_TYPE"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.FAULT_TYPE = :U_FAULT_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_FAULT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FAULT_TYPE) ? string.Empty : obj.FAULT_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DOWN_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.DOWN_TIME = :U_DOWN_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_DOWN_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.DOWN_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_MT_APPLY.COMMENTS = :U_COMMENTS");
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
