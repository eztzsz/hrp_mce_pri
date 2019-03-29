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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS))]
	public partial class HelperObject_MCE_B_ASSETS
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS( MAINTAIN_MONEY, PRD_ID, DEPR_YEAR_AMOUNT, REF_DEPT_ID, EN_NAME, ACQUIRE_USE_TYPE_ID, PREDICT_NET_RUDIMENTAL_VALUE, ASSETS_NAME, SERVICE_LIFE, CALL_CODE, BRAND_NAME, DATA_ORGANISE_ID, FILE_CODE, MAINTENANCE_PERIOD_DATE, MODIFY_DEPT_ID, IS_SELF_RESTRAINT, OPERATING_MACHINE_TYPE_ID, COMMENTS, PURCHASE_TYPE_ID, MAINTAIN_CONTACT, DEPR_MONTH_AMOUNT, MAINTAIN_PERIOD, AUDIT_USER_ID, IS_IN_ACCOUNT, FINANCE_TYPE_ID, SUBJECTION_DEPT_ID, STATE, RUDIMENTAL_VALUE, OUT_ACCOUNT_DATE, CREATE_USER_ID, PRD_PLACE_TYPE_ID, IS_LARGE_ME, SEQ_NUMBER, USING_USER_ID, ASSETS_STATE, ID, IN_ACCOUNT_DATE, IS_FORCE_SENSE, CAPITAL_SOURCE_TYPE_ID, CREATE_DEPT_ID, CREATE_TIME, PURCHASE_DATE, CARD_CODE, INTERNATIONAL_CODE, NET_AMOUNT, MAINTAIN_AMOUNT, BIZ_TYPE_ID, PROVIDER_ID, CUSTODY_USER_ID, VEHICLE_USE_TYPE_ID, MACHINE_TYPE_ID, RUDIMENTAL_VALUE_RATIO, ORIGINAL_VALUE, OWNERSHIP_TYPE_ID, CONTRACT_CODE, SPELL_CODE, VEHICLE_CODE, USING_DEPT_ID, PRD_CODE, PICTURE, NAME, ENABLE_DATE, ADD_VALUE, REF_TAB_NAME, NET_VALUE, DEPR_TYPE_ID, USE_STATE, REF_PRICE, DISPOSITION_MONEY, FORCE_SENSE_SPAN, VEHICLE_CC, CUSTOM_CODE, AUDIT_TIME, IS_DEPR, ECONOMIC_USE_TYPE_ID, CUSTODY_LEVEL_ID, ACQUIRE_OWNERSHIP_TYPE_ID, CUSTODY_DEPT_ID, NATIONALITY_ID, STORE_ADDRESS, IS_METERING, IS_AFFIX, FIVE_STROKE_CODE, VALUE_TYPE_ID, MACHINE_MANAGE_TYPE_ID, METERING_PERIOD, IS_ASSETS, REF_TAB_ID, ACCUMULATED_DEPRECIATION, SPEC, ENERGY_TYPE_ID, LICENCE_CODE, UNIT_ID, PRD_DATE, ASSETS_CODE, CARD_TYPE_ID) values ( :MAINTAIN_MONEY, :PRD_ID, :DEPR_YEAR_AMOUNT, :REF_DEPT_ID, :EN_NAME, :ACQUIRE_USE_TYPE_ID, :PREDICT_NET_RUDIMENTAL_VALUE, :ASSETS_NAME, :SERVICE_LIFE, :CALL_CODE, :BRAND_NAME, :DATA_ORGANISE_ID, :FILE_CODE, :MAINTENANCE_PERIOD_DATE, :MODIFY_DEPT_ID, :IS_SELF_RESTRAINT, :OPERATING_MACHINE_TYPE_ID, :COMMENTS, :PURCHASE_TYPE_ID, :MAINTAIN_CONTACT, :DEPR_MONTH_AMOUNT, :MAINTAIN_PERIOD, :AUDIT_USER_ID, :IS_IN_ACCOUNT, :FINANCE_TYPE_ID, :SUBJECTION_DEPT_ID, :STATE, :RUDIMENTAL_VALUE, :OUT_ACCOUNT_DATE, :CREATE_USER_ID, :PRD_PLACE_TYPE_ID, :IS_LARGE_ME, :SEQ_NUMBER, :USING_USER_ID, :ASSETS_STATE, :ID, :IN_ACCOUNT_DATE, :IS_FORCE_SENSE, :CAPITAL_SOURCE_TYPE_ID, :CREATE_DEPT_ID, :CREATE_TIME, :PURCHASE_DATE, :CARD_CODE, :INTERNATIONAL_CODE, :NET_AMOUNT, :MAINTAIN_AMOUNT, :BIZ_TYPE_ID, :PROVIDER_ID, :CUSTODY_USER_ID, :VEHICLE_USE_TYPE_ID, :MACHINE_TYPE_ID, :RUDIMENTAL_VALUE_RATIO, :ORIGINAL_VALUE, :OWNERSHIP_TYPE_ID, :CONTRACT_CODE, :SPELL_CODE, :VEHICLE_CODE, :USING_DEPT_ID, :PRD_CODE, :PICTURE, :NAME, :ENABLE_DATE, :ADD_VALUE, :REF_TAB_NAME, :NET_VALUE, :DEPR_TYPE_ID, :USE_STATE, :REF_PRICE, :DISPOSITION_MONEY, :FORCE_SENSE_SPAN, :VEHICLE_CC, :CUSTOM_CODE, :AUDIT_TIME, :IS_DEPR, :ECONOMIC_USE_TYPE_ID, :CUSTODY_LEVEL_ID, :ACQUIRE_OWNERSHIP_TYPE_ID, :CUSTODY_DEPT_ID, :NATIONALITY_ID, :STORE_ADDRESS, :IS_METERING, :IS_AFFIX, :FIVE_STROKE_CODE, :VALUE_TYPE_ID, :MACHINE_MANAGE_TYPE_ID, :METERING_PERIOD, :IS_ASSETS, :REF_TAB_ID, :ACCUMULATED_DEPRECIATION, :SPEC, :ENERGY_TYPE_ID, :LICENCE_CODE, :UNIT_ID, :PRD_DATE, :ASSETS_CODE, :CARD_TYPE_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[96];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":MAINTAIN_MONEY";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.MAINTAIN_MONEY;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PRD_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DEPR_YEAR_AMOUNT";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.DEPR_YEAR_AMOUNT;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":REF_DEPT_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.REF_DEPT_ID == null ? String.Empty:obj.REF_DEPT_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":EN_NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.EN_NAME == null ? String.Empty:obj.EN_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ACQUIRE_USE_TYPE_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ACQUIRE_USE_TYPE_ID == null ? String.Empty:obj.ACQUIRE_USE_TYPE_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PREDICT_NET_RUDIMENTAL_VALUE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.PREDICT_NET_RUDIMENTAL_VALUE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ASSETS_NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":SERVICE_LIFE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.SERVICE_LIFE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CALL_CODE";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.CALL_CODE == null ? String.Empty:obj.CALL_CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":BRAND_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.BRAND_NAME == null ? String.Empty:obj.BRAND_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":DATA_ORGANISE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":FILE_CODE";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.FILE_CODE == null ? String.Empty:obj.FILE_CODE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":MAINTENANCE_PERIOD_DATE";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.MAINTENANCE_PERIOD_DATE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":MODIFY_DEPT_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":IS_SELF_RESTRAINT";
			parameters[15].Size = 22;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[15].Value = obj.IS_SELF_RESTRAINT;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":OPERATING_MACHINE_TYPE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.OPERATING_MACHINE_TYPE_ID == null ? String.Empty:obj.OPERATING_MACHINE_TYPE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":COMMENTS";
			parameters[17].Size = 200;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":PURCHASE_TYPE_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.PURCHASE_TYPE_ID == null ? String.Empty:obj.PURCHASE_TYPE_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":MAINTAIN_CONTACT";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.MAINTAIN_CONTACT == null ? String.Empty:obj.MAINTAIN_CONTACT;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":DEPR_MONTH_AMOUNT";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.DEPR_MONTH_AMOUNT;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":MAINTAIN_PERIOD";
			parameters[21].Size = 22;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[21].Value = obj.MAINTAIN_PERIOD;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":AUDIT_USER_ID";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":IS_IN_ACCOUNT";
			parameters[23].Size = 22;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[23].Value = obj.IS_IN_ACCOUNT;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":FINANCE_TYPE_ID";
			parameters[24].Size = 36;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[24].Value = obj.FINANCE_TYPE_ID == null ? String.Empty:obj.FINANCE_TYPE_ID;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":SUBJECTION_DEPT_ID";
			parameters[25].Size = 36;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[25].Value = obj.SUBJECTION_DEPT_ID == null ? String.Empty:obj.SUBJECTION_DEPT_ID;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":STATE";
			parameters[26].Size = 22;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[26].Value = obj.STATE;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":RUDIMENTAL_VALUE";
			parameters[27].Size = 22;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[27].Value = obj.RUDIMENTAL_VALUE;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":OUT_ACCOUNT_DATE";
			parameters[28].Size = 7;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[28].Value = obj.OUT_ACCOUNT_DATE;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":CREATE_USER_ID";
			parameters[29].Size = 36;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":PRD_PLACE_TYPE_ID";
			parameters[30].Size = 36;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[30].Value = obj.PRD_PLACE_TYPE_ID == null ? String.Empty:obj.PRD_PLACE_TYPE_ID;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":IS_LARGE_ME";
			parameters[31].Size = 22;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[31].Value = obj.IS_LARGE_ME;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":SEQ_NUMBER";
			parameters[32].Size = 50;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[32].Value = obj.SEQ_NUMBER == null ? String.Empty:obj.SEQ_NUMBER;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":USING_USER_ID";
			parameters[33].Size = 36;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[33].Value = obj.USING_USER_ID == null ? String.Empty:obj.USING_USER_ID;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":ASSETS_STATE";
			parameters[34].Size = 36;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[34].Value = obj.ASSETS_STATE == null ? String.Empty:obj.ASSETS_STATE;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":ID";
			parameters[35].Size = 36;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[35].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":IN_ACCOUNT_DATE";
			parameters[36].Size = 7;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[36].Value = obj.IN_ACCOUNT_DATE;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":IS_FORCE_SENSE";
			parameters[37].Size = 22;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[37].Value = obj.IS_FORCE_SENSE;
			parameters[38] = new OracleParameter();
			parameters[38].ParameterName =":CAPITAL_SOURCE_TYPE_ID";
			parameters[38].Size = 36;
			parameters[38].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[38].Value = obj.CAPITAL_SOURCE_TYPE_ID == null ? String.Empty:obj.CAPITAL_SOURCE_TYPE_ID;
			parameters[39] = new OracleParameter();
			parameters[39].ParameterName =":CREATE_DEPT_ID";
			parameters[39].Size = 36;
			parameters[39].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[39].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[40] = new OracleParameter();
			parameters[40].ParameterName =":CREATE_TIME";
			parameters[40].Size = 7;
			parameters[40].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[40].Value = obj.CREATE_TIME;
			parameters[41] = new OracleParameter();
			parameters[41].ParameterName =":PURCHASE_DATE";
			parameters[41].Size = 7;
			parameters[41].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[41].Value = obj.PURCHASE_DATE;
			parameters[42] = new OracleParameter();
			parameters[42].ParameterName =":CARD_CODE";
			parameters[42].Size = 50;
			parameters[42].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[42].Value = obj.CARD_CODE == null ? String.Empty:obj.CARD_CODE;
			parameters[43] = new OracleParameter();
			parameters[43].ParameterName =":INTERNATIONAL_CODE";
			parameters[43].Size = 50;
			parameters[43].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[43].Value = obj.INTERNATIONAL_CODE == null ? String.Empty:obj.INTERNATIONAL_CODE;
			parameters[44] = new OracleParameter();
			parameters[44].ParameterName =":NET_AMOUNT";
			parameters[44].Size = 22;
			parameters[44].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[44].Value = obj.NET_AMOUNT;
			parameters[45] = new OracleParameter();
			parameters[45].ParameterName =":MAINTAIN_AMOUNT";
			parameters[45].Size = 22;
			parameters[45].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[45].Value = obj.MAINTAIN_AMOUNT;
			parameters[46] = new OracleParameter();
			parameters[46].ParameterName =":BIZ_TYPE_ID";
			parameters[46].Size = 36;
			parameters[46].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[46].Value = obj.BIZ_TYPE_ID == null ? String.Empty:obj.BIZ_TYPE_ID;
			parameters[47] = new OracleParameter();
			parameters[47].ParameterName =":PROVIDER_ID";
			parameters[47].Size = 36;
			parameters[47].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[47].Value = obj.PROVIDER_ID == null ? String.Empty:obj.PROVIDER_ID;
			parameters[48] = new OracleParameter();
			parameters[48].ParameterName =":CUSTODY_USER_ID";
			parameters[48].Size = 36;
			parameters[48].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[48].Value = obj.CUSTODY_USER_ID == null ? String.Empty:obj.CUSTODY_USER_ID;
			parameters[49] = new OracleParameter();
			parameters[49].ParameterName =":VEHICLE_USE_TYPE_ID";
			parameters[49].Size = 36;
			parameters[49].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[49].Value = obj.VEHICLE_USE_TYPE_ID == null ? String.Empty:obj.VEHICLE_USE_TYPE_ID;
			parameters[50] = new OracleParameter();
			parameters[50].ParameterName =":MACHINE_TYPE_ID";
			parameters[50].Size = 36;
			parameters[50].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[50].Value = obj.MACHINE_TYPE_ID == null ? String.Empty:obj.MACHINE_TYPE_ID;
			parameters[51] = new OracleParameter();
			parameters[51].ParameterName =":RUDIMENTAL_VALUE_RATIO";
			parameters[51].Size = 22;
			parameters[51].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[51].Value = obj.RUDIMENTAL_VALUE_RATIO;
			parameters[52] = new OracleParameter();
			parameters[52].ParameterName =":ORIGINAL_VALUE";
			parameters[52].Size = 22;
			parameters[52].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[52].Value = obj.ORIGINAL_VALUE;
			parameters[53] = new OracleParameter();
			parameters[53].ParameterName =":OWNERSHIP_TYPE_ID";
			parameters[53].Size = 36;
			parameters[53].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[53].Value = obj.OWNERSHIP_TYPE_ID == null ? String.Empty:obj.OWNERSHIP_TYPE_ID;
			parameters[54] = new OracleParameter();
			parameters[54].ParameterName =":CONTRACT_CODE";
			parameters[54].Size = 50;
			parameters[54].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[54].Value = obj.CONTRACT_CODE == null ? String.Empty:obj.CONTRACT_CODE;
			parameters[55] = new OracleParameter();
			parameters[55].ParameterName =":SPELL_CODE";
			parameters[55].Size = 50;
			parameters[55].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[55].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[56] = new OracleParameter();
			parameters[56].ParameterName =":VEHICLE_CODE";
			parameters[56].Size = 50;
			parameters[56].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[56].Value = obj.VEHICLE_CODE == null ? String.Empty:obj.VEHICLE_CODE;
			parameters[57] = new OracleParameter();
			parameters[57].ParameterName =":USING_DEPT_ID";
			parameters[57].Size = 36;
			parameters[57].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[57].Value = obj.USING_DEPT_ID == null ? String.Empty:obj.USING_DEPT_ID;
			parameters[58] = new OracleParameter();
			parameters[58].ParameterName =":PRD_CODE";
			parameters[58].Size = 50;
			parameters[58].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[58].Value = obj.PRD_CODE == null ? String.Empty:obj.PRD_CODE;
			parameters[59] = new OracleParameter();
			parameters[59].ParameterName =":PICTURE";
			parameters[59].Size = 200;
			parameters[59].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[59].Value = obj.PICTURE == null ? String.Empty:obj.PICTURE;
			parameters[60] = new OracleParameter();
			parameters[60].ParameterName =":NAME";
			parameters[60].Size = 50;
			parameters[60].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[60].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[61] = new OracleParameter();
			parameters[61].ParameterName =":ENABLE_DATE";
			parameters[61].Size = 7;
			parameters[61].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[61].Value = obj.ENABLE_DATE;
			parameters[62] = new OracleParameter();
			parameters[62].ParameterName =":ADD_VALUE";
			parameters[62].Size = 22;
			parameters[62].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[62].Value = obj.ADD_VALUE;
			parameters[63] = new OracleParameter();
			parameters[63].ParameterName =":REF_TAB_NAME";
			parameters[63].Size = 50;
			parameters[63].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[63].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[64] = new OracleParameter();
			parameters[64].ParameterName =":NET_VALUE";
			parameters[64].Size = 22;
			parameters[64].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[64].Value = obj.NET_VALUE;
			parameters[65] = new OracleParameter();
			parameters[65].ParameterName =":DEPR_TYPE_ID";
			parameters[65].Size = 36;
			parameters[65].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[65].Value = obj.DEPR_TYPE_ID == null ? String.Empty:obj.DEPR_TYPE_ID;
			parameters[66] = new OracleParameter();
			parameters[66].ParameterName =":USE_STATE";
			parameters[66].Size = 36;
			parameters[66].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[66].Value = obj.USE_STATE == null ? String.Empty:obj.USE_STATE;
			parameters[67] = new OracleParameter();
			parameters[67].ParameterName =":REF_PRICE";
			parameters[67].Size = 22;
			parameters[67].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[67].Value = obj.REF_PRICE;
			parameters[68] = new OracleParameter();
			parameters[68].ParameterName =":DISPOSITION_MONEY";
			parameters[68].Size = 22;
			parameters[68].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[68].Value = obj.DISPOSITION_MONEY;
			parameters[69] = new OracleParameter();
			parameters[69].ParameterName =":FORCE_SENSE_SPAN";
			parameters[69].Size = 36;
			parameters[69].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[69].Value = obj.FORCE_SENSE_SPAN == null ? String.Empty:obj.FORCE_SENSE_SPAN;
			parameters[70] = new OracleParameter();
			parameters[70].ParameterName =":VEHICLE_CC";
			parameters[70].Size = 22;
			parameters[70].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[70].Value = obj.VEHICLE_CC;
			parameters[71] = new OracleParameter();
			parameters[71].ParameterName =":CUSTOM_CODE";
			parameters[71].Size = 50;
			parameters[71].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[71].Value = obj.CUSTOM_CODE == null ? String.Empty:obj.CUSTOM_CODE;
			parameters[72] = new OracleParameter();
			parameters[72].ParameterName =":AUDIT_TIME";
			parameters[72].Size = 7;
			parameters[72].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[72].Value = obj.AUDIT_TIME;
			parameters[73] = new OracleParameter();
			parameters[73].ParameterName =":IS_DEPR";
			parameters[73].Size = 22;
			parameters[73].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[73].Value = obj.IS_DEPR;
			parameters[74] = new OracleParameter();
			parameters[74].ParameterName =":ECONOMIC_USE_TYPE_ID";
			parameters[74].Size = 36;
			parameters[74].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[74].Value = obj.ECONOMIC_USE_TYPE_ID == null ? String.Empty:obj.ECONOMIC_USE_TYPE_ID;
			parameters[75] = new OracleParameter();
			parameters[75].ParameterName =":CUSTODY_LEVEL_ID";
			parameters[75].Size = 36;
			parameters[75].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[75].Value = obj.CUSTODY_LEVEL_ID == null ? String.Empty:obj.CUSTODY_LEVEL_ID;
			parameters[76] = new OracleParameter();
			parameters[76].ParameterName =":ACQUIRE_OWNERSHIP_TYPE_ID";
			parameters[76].Size = 36;
			parameters[76].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[76].Value = obj.ACQUIRE_OWNERSHIP_TYPE_ID == null ? String.Empty:obj.ACQUIRE_OWNERSHIP_TYPE_ID;
			parameters[77] = new OracleParameter();
			parameters[77].ParameterName =":CUSTODY_DEPT_ID";
			parameters[77].Size = 36;
			parameters[77].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[77].Value = obj.CUSTODY_DEPT_ID == null ? String.Empty:obj.CUSTODY_DEPT_ID;
			parameters[78] = new OracleParameter();
			parameters[78].ParameterName =":NATIONALITY_ID";
			parameters[78].Size = 36;
			parameters[78].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[78].Value = obj.NATIONALITY_ID == null ? String.Empty:obj.NATIONALITY_ID;
			parameters[79] = new OracleParameter();
			parameters[79].ParameterName =":STORE_ADDRESS";
			parameters[79].Size = 200;
			parameters[79].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[79].Value = obj.STORE_ADDRESS == null ? String.Empty:obj.STORE_ADDRESS;
			parameters[80] = new OracleParameter();
			parameters[80].ParameterName =":IS_METERING";
			parameters[80].Size = 22;
			parameters[80].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[80].Value = obj.IS_METERING;
			parameters[81] = new OracleParameter();
			parameters[81].ParameterName =":IS_AFFIX";
			parameters[81].Size = 22;
			parameters[81].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[81].Value = obj.IS_AFFIX;
			parameters[82] = new OracleParameter();
			parameters[82].ParameterName =":FIVE_STROKE_CODE";
			parameters[82].Size = 50;
			parameters[82].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[82].Value = obj.FIVE_STROKE_CODE == null ? String.Empty:obj.FIVE_STROKE_CODE;
			parameters[83] = new OracleParameter();
			parameters[83].ParameterName =":VALUE_TYPE_ID";
			parameters[83].Size = 36;
			parameters[83].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[83].Value = obj.VALUE_TYPE_ID == null ? String.Empty:obj.VALUE_TYPE_ID;
			parameters[84] = new OracleParameter();
			parameters[84].ParameterName =":MACHINE_MANAGE_TYPE_ID";
			parameters[84].Size = 36;
			parameters[84].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[84].Value = obj.MACHINE_MANAGE_TYPE_ID == null ? String.Empty:obj.MACHINE_MANAGE_TYPE_ID;
			parameters[85] = new OracleParameter();
			parameters[85].ParameterName =":METERING_PERIOD";
			parameters[85].Size = 22;
			parameters[85].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[85].Value = obj.METERING_PERIOD;
			parameters[86] = new OracleParameter();
			parameters[86].ParameterName =":IS_ASSETS";
			parameters[86].Size = 22;
			parameters[86].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[86].Value = obj.IS_ASSETS;
			parameters[87] = new OracleParameter();
			parameters[87].ParameterName =":REF_TAB_ID";
			parameters[87].Size = 36;
			parameters[87].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[87].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[88] = new OracleParameter();
			parameters[88].ParameterName =":ACCUMULATED_DEPRECIATION";
			parameters[88].Size = 22;
			parameters[88].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[88].Value = obj.ACCUMULATED_DEPRECIATION;
			parameters[89] = new OracleParameter();
			parameters[89].ParameterName =":SPEC";
			parameters[89].Size = 50;
			parameters[89].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[89].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[90] = new OracleParameter();
			parameters[90].ParameterName =":ENERGY_TYPE_ID";
			parameters[90].Size = 36;
			parameters[90].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[90].Value = obj.ENERGY_TYPE_ID == null ? String.Empty:obj.ENERGY_TYPE_ID;
			parameters[91] = new OracleParameter();
			parameters[91].ParameterName =":LICENCE_CODE";
			parameters[91].Size = 50;
			parameters[91].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[91].Value = obj.LICENCE_CODE == null ? String.Empty:obj.LICENCE_CODE;
			parameters[92] = new OracleParameter();
			parameters[92].ParameterName =":UNIT_ID";
			parameters[92].Size = 36;
			parameters[92].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[92].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[93] = new OracleParameter();
			parameters[93].ParameterName =":PRD_DATE";
			parameters[93].Size = 7;
			parameters[93].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[93].Value = obj.PRD_DATE;
			parameters[94] = new OracleParameter();
			parameters[94].ParameterName =":ASSETS_CODE";
			parameters[94].Size = 50;
			parameters[94].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[94].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[95] = new OracleParameter();
			parameters[95].ParameterName =":CARD_TYPE_ID";
			parameters[95].Size = 36;
			parameters[95].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[95].Value = obj.CARD_TYPE_ID == null ? String.Empty:obj.CARD_TYPE_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS obj,CauseObject_MCE_B_ASSETS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS Get(EntityObject_MCE_B_ASSETS obj)
		{
			
			//平台自动生成代码
			string sSql = "select  MAINTAIN_MONEY, PRD_ID, DEPR_YEAR_AMOUNT, REF_DEPT_ID, EN_NAME, ACQUIRE_USE_TYPE_ID, PREDICT_NET_RUDIMENTAL_VALUE, ASSETS_NAME, SERVICE_LIFE, CALL_CODE, BRAND_NAME, MODIFY_TIME, DATA_ORGANISE_ID, FILE_CODE, MAINTENANCE_PERIOD_DATE, MODIFY_DEPT_ID, IS_SELF_RESTRAINT, OPERATING_MACHINE_TYPE_ID, COMMENTS, PURCHASE_TYPE_ID, MAINTAIN_CONTACT, DEPR_MONTH_AMOUNT, MAINTAIN_PERIOD, AUDIT_USER_ID, IS_IN_ACCOUNT, FINANCE_TYPE_ID, SUBJECTION_DEPT_ID, STATE, RUDIMENTAL_VALUE, OUT_ACCOUNT_DATE, CREATE_USER_ID, PRD_PLACE_TYPE_ID, IS_LARGE_ME, SEQ_NUMBER, USING_USER_ID, ASSETS_STATE, ID, IN_ACCOUNT_DATE, IS_FORCE_SENSE, CAPITAL_SOURCE_TYPE_ID, CREATE_DEPT_ID, CREATE_TIME, PURCHASE_DATE, CARD_CODE, INTERNATIONAL_CODE, NET_AMOUNT, MAINTAIN_AMOUNT, BIZ_TYPE_ID, PROVIDER_ID, CUSTODY_USER_ID, VEHICLE_USE_TYPE_ID, MACHINE_TYPE_ID, RUDIMENTAL_VALUE_RATIO, ORIGINAL_VALUE, OWNERSHIP_TYPE_ID, CONTRACT_CODE, SPELL_CODE, VEHICLE_CODE, USING_DEPT_ID, PRD_CODE, PICTURE, NAME, ENABLE_DATE, ADD_VALUE, REF_TAB_NAME, NET_VALUE, DEPR_TYPE_ID, USE_STATE, REF_PRICE, DISPOSITION_MONEY, FORCE_SENSE_SPAN, VEHICLE_CC, CUSTOM_CODE, AUDIT_TIME, IS_DEPR, ECONOMIC_USE_TYPE_ID, CUSTODY_LEVEL_ID, ACQUIRE_OWNERSHIP_TYPE_ID, CUSTODY_DEPT_ID, NATIONALITY_ID, STORE_ADDRESS, IS_METERING, IS_AFFIX, FIVE_STROKE_CODE, MODIFY_USER_ID, VALUE_TYPE_ID, MACHINE_MANAGE_TYPE_ID, METERING_PERIOD, IS_ASSETS, REF_TAB_ID, ACCUMULATED_DEPRECIATION, SPEC, ENERGY_TYPE_ID, LICENCE_CODE, UNIT_ID, PRD_DATE, ASSETS_CODE, CARD_TYPE_ID from MCE_B_ASSETS where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS[] objs = new EntityObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS Get(DisplayObject_MCE_B_ASSETS obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1) and MCE_B_ASSETS.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS Get(EntityObject_MCE_B_ASSETS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  MAINTAIN_MONEY, PRD_ID, DEPR_YEAR_AMOUNT, REF_DEPT_ID, EN_NAME, ACQUIRE_USE_TYPE_ID, PREDICT_NET_RUDIMENTAL_VALUE, ASSETS_NAME, SERVICE_LIFE, CALL_CODE, BRAND_NAME, MODIFY_TIME, DATA_ORGANISE_ID, FILE_CODE, MAINTENANCE_PERIOD_DATE, MODIFY_DEPT_ID, IS_SELF_RESTRAINT, OPERATING_MACHINE_TYPE_ID, COMMENTS, PURCHASE_TYPE_ID, MAINTAIN_CONTACT, DEPR_MONTH_AMOUNT, MAINTAIN_PERIOD, AUDIT_USER_ID, IS_IN_ACCOUNT, FINANCE_TYPE_ID, SUBJECTION_DEPT_ID, STATE, RUDIMENTAL_VALUE, OUT_ACCOUNT_DATE, CREATE_USER_ID, PRD_PLACE_TYPE_ID, IS_LARGE_ME, SEQ_NUMBER, USING_USER_ID, ASSETS_STATE, ID, IN_ACCOUNT_DATE, IS_FORCE_SENSE, CAPITAL_SOURCE_TYPE_ID, CREATE_DEPT_ID, CREATE_TIME, PURCHASE_DATE, CARD_CODE, INTERNATIONAL_CODE, NET_AMOUNT, MAINTAIN_AMOUNT, BIZ_TYPE_ID, PROVIDER_ID, CUSTODY_USER_ID, VEHICLE_USE_TYPE_ID, MACHINE_TYPE_ID, RUDIMENTAL_VALUE_RATIO, ORIGINAL_VALUE, OWNERSHIP_TYPE_ID, CONTRACT_CODE, SPELL_CODE, VEHICLE_CODE, USING_DEPT_ID, PRD_CODE, PICTURE, NAME, ENABLE_DATE, ADD_VALUE, REF_TAB_NAME, NET_VALUE, DEPR_TYPE_ID, USE_STATE, REF_PRICE, DISPOSITION_MONEY, FORCE_SENSE_SPAN, VEHICLE_CC, CUSTOM_CODE, AUDIT_TIME, IS_DEPR, ECONOMIC_USE_TYPE_ID, CUSTODY_LEVEL_ID, ACQUIRE_OWNERSHIP_TYPE_ID, CUSTODY_DEPT_ID, NATIONALITY_ID, STORE_ADDRESS, IS_METERING, IS_AFFIX, FIVE_STROKE_CODE, MODIFY_USER_ID, VALUE_TYPE_ID, MACHINE_MANAGE_TYPE_ID, METERING_PERIOD, IS_ASSETS, REF_TAB_ID, ACCUMULATED_DEPRECIATION, SPEC, ENERGY_TYPE_ID, LICENCE_CODE, UNIT_ID, PRD_DATE, ASSETS_CODE, CARD_TYPE_ID from MCE_B_ASSETS where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS[] objs = new EntityObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.MAINTAIN_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.MAINTAIN_MONEY = :C_MAINTAIN_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MAINTAIN_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MAINTAIN_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PRD_ID"));
			}
			if(cause.DEPR_YEAR_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.DEPR_YEAR_AMOUNT = :C_DEPR_YEAR_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_YEAR_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPR_YEAR_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_YEAR_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "DEPR_YEAR_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.REF_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.REF_DEPT_ID ").Append((cause.REF_DEPT_ID.StartsWith("%") || cause.REF_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "REF_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.EN_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS.EN_NAME ").Append((cause.EN_NAME.StartsWith("%") || cause.EN_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_EN_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_EN_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EN_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("EN_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "EN_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ACQUIRE_USE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID ").Append((cause.ACQUIRE_USE_TYPE_ID.StartsWith("%") || cause.ACQUIRE_USE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ACQUIRE_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ACQUIRE_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ACQUIRE_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACQUIRE_USE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ACQUIRE_USE_TYPE_ID"));
			}
			if(cause.PREDICT_NET_RUDIMENTAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE = :C_PREDICT_NET_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_PREDICT_NET_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PREDICT_NET_RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PREDICT_NET_RUDIMENTAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PREDICT_NET_RUDIMENTAL_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ASSETS_NAME"));
			}
			if(cause.SERVICE_LIFE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.SERVICE_LIFE = :C_SERVICE_LIFE");
				param = new OracleParameter();
				param.ParameterName =":C_SERVICE_LIFE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SERVICE_LIFE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SERVICE_LIFE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "SERVICE_LIFE"));
			}
			if(!string.IsNullOrEmpty(cause.CALL_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.CALL_CODE ").Append((cause.CALL_CODE.StartsWith("%") || cause.CALL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CALL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CALL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CALL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CALL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CALL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BRAND_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS.BRAND_NAME ").Append((cause.BRAND_NAME.StartsWith("%") || cause.BRAND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BRAND_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BRAND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BRAND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BRAND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "BRAND_NAME"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FILE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.FILE_CODE ").Append((cause.FILE_CODE.StartsWith("%") || cause.FILE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_FILE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_FILE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FILE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "FILE_CODE"));
			}
			if(cause.MAINTENANCE_PERIOD_DATE!= null)
			{
				if (cause.MAINTENANCE_PERIOD_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE >= :C_MAINTENANCE_PERIOD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MAINTENANCE_PERIOD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MAINTENANCE_PERIOD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.MAINTENANCE_PERIOD_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE < :C_MAINTENANCE_PERIOD_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MAINTENANCE_PERIOD_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MODIFY_DEPT_ID"));
			}
			if(cause.IS_SELF_RESTRAINT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_SELF_RESTRAINT = :C_IS_SELF_RESTRAINT");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SELF_RESTRAINT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_SELF_RESTRAINT;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SELF_RESTRAINT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_SELF_RESTRAINT"));
			}
			if(!string.IsNullOrEmpty(cause.OPERATING_MACHINE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID ").Append((cause.OPERATING_MACHINE_TYPE_ID.StartsWith("%") || cause.OPERATING_MACHINE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_OPERATING_MACHINE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_OPERATING_MACHINE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.OPERATING_MACHINE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("OPERATING_MACHINE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "OPERATING_MACHINE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHASE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.PURCHASE_TYPE_ID ").Append((cause.PURCHASE_TYPE_ID.StartsWith("%") || cause.PURCHASE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHASE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHASE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PURCHASE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PURCHASE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MAINTAIN_CONTACT))
			{
				strBuf.Append(" And MCE_B_ASSETS.MAINTAIN_CONTACT ").Append((cause.MAINTAIN_CONTACT.StartsWith("%") || cause.MAINTAIN_CONTACT.EndsWith("%")) ? " like " : " = ").Append(" :C_MAINTAIN_CONTACT");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_CONTACT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MAINTAIN_CONTACT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_CONTACT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MAINTAIN_CONTACT"));
			}
			if(cause.DEPR_MONTH_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.DEPR_MONTH_AMOUNT = :C_DEPR_MONTH_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_MONTH_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPR_MONTH_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_MONTH_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "DEPR_MONTH_AMOUNT"));
			}
			if(cause.MAINTAIN_PERIOD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.MAINTAIN_PERIOD = :C_MAINTAIN_PERIOD");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MAINTAIN_PERIOD;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_PERIOD"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MAINTAIN_PERIOD"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "AUDIT_USER_ID"));
			}
			if(cause.IS_IN_ACCOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_IN_ACCOUNT = :C_IS_IN_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_IS_IN_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_IN_ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_IN_ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_IN_ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.FINANCE_TYPE_ID ").Append((cause.FINANCE_TYPE_ID.StartsWith("%") || cause.FINANCE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FINANCE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "FINANCE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SUBJECTION_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.SUBJECTION_DEPT_ID ").Append((cause.SUBJECTION_DEPT_ID.StartsWith("%") || cause.SUBJECTION_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_SUBJECTION_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_SUBJECTION_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SUBJECTION_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUBJECTION_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "SUBJECTION_DEPT_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "STATE"));
			}
			if(cause.RUDIMENTAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.RUDIMENTAL_VALUE = :C_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("RUDIMENTAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "RUDIMENTAL_VALUE"));
			}
			if(cause.OUT_ACCOUNT_DATE!= null)
			{
				if (cause.OUT_ACCOUNT_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.OUT_ACCOUNT_DATE >= :C_OUT_ACCOUNT_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_OUT_ACCOUNT_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.OUT_ACCOUNT_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.OUT_ACCOUNT_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.OUT_ACCOUNT_DATE < :C_OUT_ACCOUNT_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_OUT_ACCOUNT_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.OUT_ACCOUNT_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("OUT_ACCOUNT_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "OUT_ACCOUNT_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_PLACE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.PRD_PLACE_TYPE_ID ").Append((cause.PRD_PLACE_TYPE_ID.StartsWith("%") || cause.PRD_PLACE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_PLACE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_PLACE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_PLACE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_PLACE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PRD_PLACE_TYPE_ID"));
			}
			if(cause.IS_LARGE_ME!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_LARGE_ME = :C_IS_LARGE_ME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_LARGE_ME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_LARGE_ME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_LARGE_ME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_LARGE_ME"));
			}
			if(!string.IsNullOrEmpty(cause.SEQ_NUMBER))
			{
				strBuf.Append(" And MCE_B_ASSETS.SEQ_NUMBER ").Append((cause.SEQ_NUMBER.StartsWith("%") || cause.SEQ_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :C_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":C_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SEQ_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEQ_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "SEQ_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.USING_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.USING_USER_ID ").Append((cause.USING_USER_ID.StartsWith("%") || cause.USING_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "USING_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_STATE))
			{
				strBuf.Append(" And MCE_B_ASSETS.ASSETS_STATE ").Append((cause.ASSETS_STATE.StartsWith("%") || cause.ASSETS_STATE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ASSETS_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ID"));
			}
			if(cause.IN_ACCOUNT_DATE!= null)
			{
				if (cause.IN_ACCOUNT_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.IN_ACCOUNT_DATE >= :C_IN_ACCOUNT_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_IN_ACCOUNT_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.IN_ACCOUNT_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.IN_ACCOUNT_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.IN_ACCOUNT_DATE < :C_IN_ACCOUNT_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_IN_ACCOUNT_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.IN_ACCOUNT_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("IN_ACCOUNT_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IN_ACCOUNT_DATE"));
			}
			if(cause.IS_FORCE_SENSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_FORCE_SENSE = :C_IS_FORCE_SENSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_FORCE_SENSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FORCE_SENSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FORCE_SENSE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_FORCE_SENSE"));
			}
			if(!string.IsNullOrEmpty(cause.CAPITAL_SOURCE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID ").Append((cause.CAPITAL_SOURCE_TYPE_ID.StartsWith("%") || cause.CAPITAL_SOURCE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CAPITAL_SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CAPITAL_SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CAPITAL_SOURCE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CAPITAL_SOURCE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CAPITAL_SOURCE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CREATE_DEPT_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CREATE_TIME"));
			}
			if(cause.PURCHASE_DATE!= null)
			{
				if (cause.PURCHASE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.PURCHASE_DATE >= :C_PURCHASE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PURCHASE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PURCHASE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PURCHASE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.PURCHASE_DATE < :C_PURCHASE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PURCHASE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PURCHASE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PURCHASE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PURCHASE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.CARD_CODE ").Append((cause.CARD_CODE.StartsWith("%") || cause.CARD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CARD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CARD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.INTERNATIONAL_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.INTERNATIONAL_CODE ").Append((cause.INTERNATIONAL_CODE.StartsWith("%") || cause.INTERNATIONAL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_INTERNATIONAL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_INTERNATIONAL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INTERNATIONAL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INTERNATIONAL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "INTERNATIONAL_CODE"));
			}
			if(cause.NET_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.NET_AMOUNT = :C_NET_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_NET_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NET_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("NET_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "NET_AMOUNT"));
			}
			if(cause.MAINTAIN_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.MAINTAIN_AMOUNT = :C_MAINTAIN_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_MAINTAIN_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MAINTAIN_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAINTAIN_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MAINTAIN_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.BIZ_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.BIZ_TYPE_ID ").Append((cause.BIZ_TYPE_ID.StartsWith("%") || cause.BIZ_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BIZ_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BIZ_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BIZ_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BIZ_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "BIZ_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PROVIDER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.PROVIDER_ID ").Append((cause.PROVIDER_ID.StartsWith("%") || cause.PROVIDER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROVIDER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROVIDER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PROVIDER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CUSTODY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CUSTODY_USER_ID ").Append((cause.CUSTODY_USER_ID.StartsWith("%") || cause.CUSTODY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CUSTODY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTODY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CUSTODY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTODY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CUSTODY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.VEHICLE_USE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.VEHICLE_USE_TYPE_ID ").Append((cause.VEHICLE_USE_TYPE_ID.StartsWith("%") || cause.VEHICLE_USE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_VEHICLE_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_VEHICLE_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.VEHICLE_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("VEHICLE_USE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "VEHICLE_USE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MACHINE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.MACHINE_TYPE_ID ").Append((cause.MACHINE_TYPE_ID.StartsWith("%") || cause.MACHINE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MACHINE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MACHINE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MACHINE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MACHINE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MACHINE_TYPE_ID"));
			}
			if(cause.RUDIMENTAL_VALUE_RATIO!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO = :C_RUDIMENTAL_VALUE_RATIO");
				param = new OracleParameter();
				param.ParameterName =":C_RUDIMENTAL_VALUE_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RUDIMENTAL_VALUE_RATIO;
				paramList.Add(param);
			}
			if (cause.HasINValue("RUDIMENTAL_VALUE_RATIO"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "RUDIMENTAL_VALUE_RATIO"));
			}
			if(cause.ORIGINAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.ORIGINAL_VALUE = :C_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORIGINAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ORIGINAL_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.OWNERSHIP_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.OWNERSHIP_TYPE_ID ").Append((cause.OWNERSHIP_TYPE_ID.StartsWith("%") || cause.OWNERSHIP_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_OWNERSHIP_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_OWNERSHIP_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.OWNERSHIP_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("OWNERSHIP_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "OWNERSHIP_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CONTRACT_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.CONTRACT_CODE ").Append((cause.CONTRACT_CODE.StartsWith("%") || cause.CONTRACT_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTRACT_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CONTRACT_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CONTRACT_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTRACT_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CONTRACT_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.VEHICLE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.VEHICLE_CODE ").Append((cause.VEHICLE_CODE.StartsWith("%") || cause.VEHICLE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_VEHICLE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_VEHICLE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.VEHICLE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("VEHICLE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "VEHICLE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.USING_DEPT_ID ").Append((cause.USING_DEPT_ID.StartsWith("%") || cause.USING_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "USING_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.PRD_CODE ").Append((cause.PRD_CODE.StartsWith("%") || cause.PRD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PRD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.PICTURE))
			{
				strBuf.Append(" And MCE_B_ASSETS.PICTURE ").Append((cause.PICTURE.StartsWith("%") || cause.PICTURE.EndsWith("%")) ? " like " : " = ").Append(" :C_PICTURE");
				param = new OracleParameter();
				param.ParameterName =":C_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PICTURE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PICTURE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PICTURE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "NAME"));
			}
			if(cause.ENABLE_DATE!= null)
			{
				if (cause.ENABLE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.ENABLE_DATE >= :C_ENABLE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ENABLE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENABLE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ENABLE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.ENABLE_DATE < :C_ENABLE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ENABLE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENABLE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ENABLE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ENABLE_DATE"));
			}
			if(cause.ADD_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.ADD_VALUE = :C_ADD_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ADD_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ADD_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADD_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ADD_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "REF_TAB_NAME"));
			}
			if(cause.NET_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.NET_VALUE = :C_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NET_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NET_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "NET_VALUE"));
			}
			if(!string.IsNullOrEmpty(cause.DEPR_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.DEPR_TYPE_ID ").Append((cause.DEPR_TYPE_ID.StartsWith("%") || cause.DEPR_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPR_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPR_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "DEPR_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USE_STATE))
			{
				strBuf.Append(" And MCE_B_ASSETS.USE_STATE ").Append((cause.USE_STATE.StartsWith("%") || cause.USE_STATE.EndsWith("%")) ? " like " : " = ").Append(" :C_USE_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_USE_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USE_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("USE_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "USE_STATE"));
			}
			if(cause.REF_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.REF_PRICE = :C_REF_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REF_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "REF_PRICE"));
			}
			if(cause.DISPOSITION_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.DISPOSITION_MONEY = :C_DISPOSITION_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_DISPOSITION_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPOSITION_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPOSITION_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "DISPOSITION_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FORCE_SENSE_SPAN))
			{
				strBuf.Append(" And MCE_B_ASSETS.FORCE_SENSE_SPAN ").Append((cause.FORCE_SENSE_SPAN.StartsWith("%") || cause.FORCE_SENSE_SPAN.EndsWith("%")) ? " like " : " = ").Append(" :C_FORCE_SENSE_SPAN");
				param = new OracleParameter();
				param.ParameterName =":C_FORCE_SENSE_SPAN";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FORCE_SENSE_SPAN;
				paramList.Add(param);
			}
			if (cause.HasINValue("FORCE_SENSE_SPAN"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "FORCE_SENSE_SPAN"));
			}
			if(cause.VEHICLE_CC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.VEHICLE_CC = :C_VEHICLE_CC");
				param = new OracleParameter();
				param.ParameterName =":C_VEHICLE_CC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.VEHICLE_CC;
				paramList.Add(param);
			}
			if (cause.HasINValue("VEHICLE_CC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "VEHICLE_CC"));
			}
			if(!string.IsNullOrEmpty(cause.CUSTOM_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.CUSTOM_CODE ").Append((cause.CUSTOM_CODE.StartsWith("%") || cause.CUSTOM_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CUSTOM_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTOM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CUSTOM_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTOM_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CUSTOM_CODE"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "AUDIT_TIME"));
			}
			if(cause.IS_DEPR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_DEPR = :C_IS_DEPR");
				param = new OracleParameter();
				param.ParameterName =":C_IS_DEPR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_DEPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_DEPR"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_DEPR"));
			}
			if(!string.IsNullOrEmpty(cause.ECONOMIC_USE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID ").Append((cause.ECONOMIC_USE_TYPE_ID.StartsWith("%") || cause.ECONOMIC_USE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ECONOMIC_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ECONOMIC_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ECONOMIC_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ECONOMIC_USE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ECONOMIC_USE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CUSTODY_LEVEL_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CUSTODY_LEVEL_ID ").Append((cause.CUSTODY_LEVEL_ID.StartsWith("%") || cause.CUSTODY_LEVEL_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CUSTODY_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTODY_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CUSTODY_LEVEL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTODY_LEVEL_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CUSTODY_LEVEL_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ACQUIRE_OWNERSHIP_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID ").Append((cause.ACQUIRE_OWNERSHIP_TYPE_ID.StartsWith("%") || cause.ACQUIRE_OWNERSHIP_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ACQUIRE_OWNERSHIP_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ACQUIRE_OWNERSHIP_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ACQUIRE_OWNERSHIP_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACQUIRE_OWNERSHIP_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ACQUIRE_OWNERSHIP_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CUSTODY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CUSTODY_DEPT_ID ").Append((cause.CUSTODY_DEPT_ID.StartsWith("%") || cause.CUSTODY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CUSTODY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTODY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CUSTODY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTODY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CUSTODY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NATIONALITY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.NATIONALITY_ID ").Append((cause.NATIONALITY_ID.StartsWith("%") || cause.NATIONALITY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_NATIONALITY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_NATIONALITY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.NATIONALITY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("NATIONALITY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "NATIONALITY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STORE_ADDRESS))
			{
				strBuf.Append(" And MCE_B_ASSETS.STORE_ADDRESS ").Append((cause.STORE_ADDRESS.StartsWith("%") || cause.STORE_ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :C_STORE_ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":C_STORE_ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.STORE_ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STORE_ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "STORE_ADDRESS"));
			}
			if(cause.IS_METERING!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_METERING = :C_IS_METERING");
				param = new OracleParameter();
				param.ParameterName =":C_IS_METERING";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_METERING;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_METERING"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_METERING"));
			}
			if(cause.IS_AFFIX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_AFFIX = :C_IS_AFFIX");
				param = new OracleParameter();
				param.ParameterName =":C_IS_AFFIX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_AFFIX;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_AFFIX"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_AFFIX"));
			}
			if(!string.IsNullOrEmpty(cause.FIVE_STROKE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.FIVE_STROKE_CODE ").Append((cause.FIVE_STROKE_CODE.StartsWith("%") || cause.FIVE_STROKE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIVE_STROKE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "FIVE_STROKE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.VALUE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.VALUE_TYPE_ID ").Append((cause.VALUE_TYPE_ID.StartsWith("%") || cause.VALUE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_VALUE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_VALUE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.VALUE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("VALUE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "VALUE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MACHINE_MANAGE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID ").Append((cause.MACHINE_MANAGE_TYPE_ID.StartsWith("%") || cause.MACHINE_MANAGE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MACHINE_MANAGE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MACHINE_MANAGE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MACHINE_MANAGE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MACHINE_MANAGE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "MACHINE_MANAGE_TYPE_ID"));
			}
			if(cause.METERING_PERIOD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.METERING_PERIOD = :C_METERING_PERIOD");
				param = new OracleParameter();
				param.ParameterName =":C_METERING_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.METERING_PERIOD;
				paramList.Add(param);
			}
			if (cause.HasINValue("METERING_PERIOD"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "METERING_PERIOD"));
			}
			if(cause.IS_ASSETS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.IS_ASSETS = :C_IS_ASSETS");
				param = new OracleParameter();
				param.ParameterName =":C_IS_ASSETS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ASSETS;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ASSETS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "IS_ASSETS"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "REF_TAB_ID"));
			}
			if(cause.ACCUMULATED_DEPRECIATION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS.ACCUMULATED_DEPRECIATION = :C_ACCUMULATED_DEPRECIATION");
				param = new OracleParameter();
				param.ParameterName =":C_ACCUMULATED_DEPRECIATION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ACCUMULATED_DEPRECIATION;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCUMULATED_DEPRECIATION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ACCUMULATED_DEPRECIATION"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ENERGY_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.ENERGY_TYPE_ID ").Append((cause.ENERGY_TYPE_ID.StartsWith("%") || cause.ENERGY_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ENERGY_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ENERGY_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ENERGY_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ENERGY_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ENERGY_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.LICENCE_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.LICENCE_CODE ").Append((cause.LICENCE_CODE.StartsWith("%") || cause.LICENCE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_LICENCE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_LICENCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LICENCE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("LICENCE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "LICENCE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "UNIT_ID"));
			}
			if(cause.PRD_DATE!= null)
			{
				if (cause.PRD_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.PRD_DATE >= :C_PRD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PRD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PRD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PRD_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS.PRD_DATE < :C_PRD_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PRD_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PRD_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PRD_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "PRD_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS.CARD_TYPE_ID ").Append((cause.CARD_TYPE_ID.StartsWith("%") || cause.CARD_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CARD_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS", "CARD_TYPE_ID"));
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
		public static DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS.MAINTAIN_MONEY, MCE_B_ASSETS.PRD_ID, MCE_B_ASSETS.DEPR_YEAR_AMOUNT, MCE_B_ASSETS.REF_DEPT_ID, MCE_B_ASSETS.EN_NAME, MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID, MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE, MCE_B_ASSETS.ASSETS_NAME, MCE_B_ASSETS.SERVICE_LIFE, MCE_B_ASSETS.CALL_CODE, MCE_B_ASSETS.BRAND_NAME, MCE_B_ASSETS.MODIFY_TIME, MCE_B_ASSETS.DATA_ORGANISE_ID, MCE_B_ASSETS.FILE_CODE, MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS.MODIFY_DEPT_ID, MCE_B_ASSETS.IS_SELF_RESTRAINT, MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID, MCE_B_ASSETS.COMMENTS, MCE_B_ASSETS.PURCHASE_TYPE_ID, MCE_B_ASSETS.MAINTAIN_CONTACT, MCE_B_ASSETS.DEPR_MONTH_AMOUNT, MCE_B_ASSETS.MAINTAIN_PERIOD, MCE_B_ASSETS.AUDIT_USER_ID, MCE_B_ASSETS.IS_IN_ACCOUNT, MCE_B_ASSETS.FINANCE_TYPE_ID, MCE_B_ASSETS.SUBJECTION_DEPT_ID, MCE_B_ASSETS.STATE, MCE_B_ASSETS.RUDIMENTAL_VALUE, MCE_B_ASSETS.OUT_ACCOUNT_DATE, MCE_B_ASSETS.CREATE_USER_ID, MCE_B_ASSETS.PRD_PLACE_TYPE_ID, MCE_B_ASSETS.IS_LARGE_ME, MCE_B_ASSETS.SEQ_NUMBER, MCE_B_ASSETS.USING_USER_ID, MCE_B_ASSETS.ASSETS_STATE, MCE_B_ASSETS.ID, MCE_B_ASSETS.IN_ACCOUNT_DATE, MCE_B_ASSETS.IS_FORCE_SENSE, MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID, MCE_B_ASSETS.CREATE_DEPT_ID, MCE_B_ASSETS.CREATE_TIME, MCE_B_ASSETS.PURCHASE_DATE, MCE_B_ASSETS.CARD_CODE, MCE_B_ASSETS.INTERNATIONAL_CODE, MCE_B_ASSETS.NET_AMOUNT, MCE_B_ASSETS.MAINTAIN_AMOUNT, MCE_B_ASSETS.BIZ_TYPE_ID, MCE_B_ASSETS.PROVIDER_ID, MCE_B_ASSETS.CUSTODY_USER_ID, MCE_B_ASSETS.VEHICLE_USE_TYPE_ID, MCE_B_ASSETS.MACHINE_TYPE_ID, MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO, MCE_B_ASSETS.ORIGINAL_VALUE, MCE_B_ASSETS.OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CONTRACT_CODE, MCE_B_ASSETS.SPELL_CODE, MCE_B_ASSETS.VEHICLE_CODE, MCE_B_ASSETS.USING_DEPT_ID, MCE_B_ASSETS.PRD_CODE, MCE_B_ASSETS.PICTURE, MCE_B_ASSETS.NAME, MCE_B_ASSETS.ENABLE_DATE, MCE_B_ASSETS.ADD_VALUE, MCE_B_ASSETS.REF_TAB_NAME, MCE_B_ASSETS.NET_VALUE, MCE_B_ASSETS.DEPR_TYPE_ID, MCE_B_ASSETS.USE_STATE, MCE_B_ASSETS.REF_PRICE, MCE_B_ASSETS.DISPOSITION_MONEY, MCE_B_ASSETS.FORCE_SENSE_SPAN, MCE_B_ASSETS.VEHICLE_CC, MCE_B_ASSETS.CUSTOM_CODE, MCE_B_ASSETS.AUDIT_TIME, MCE_B_ASSETS.IS_DEPR, MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID, MCE_B_ASSETS.CUSTODY_LEVEL_ID, MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID, MCE_B_ASSETS.CUSTODY_DEPT_ID, MCE_B_ASSETS.NATIONALITY_ID, MCE_B_ASSETS.STORE_ADDRESS, MCE_B_ASSETS.IS_METERING, MCE_B_ASSETS.IS_AFFIX, MCE_B_ASSETS.FIVE_STROKE_CODE, MCE_B_ASSETS.MODIFY_USER_ID, MCE_B_ASSETS.VALUE_TYPE_ID, MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID, MCE_B_ASSETS.METERING_PERIOD, MCE_B_ASSETS.IS_ASSETS, MCE_B_ASSETS.REF_TAB_ID, MCE_B_ASSETS.ACCUMULATED_DEPRECIATION, MCE_B_ASSETS.SPEC, MCE_B_ASSETS.ENERGY_TYPE_ID, MCE_B_ASSETS.LICENCE_CODE, MCE_B_ASSETS.UNIT_ID, MCE_B_ASSETS.PRD_DATE, MCE_B_ASSETS.ASSETS_CODE, MCE_B_ASSETS.CARD_TYPE_ID, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MDM_D_DEPT_REF_DEPT_ID.NAME as REF_DEPT_ID_NAME, COM_TYPE_ACQUIRE_USE_TYPE_ID.NAME as ACQUIRE_USE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_SELF_RESTRAINT = 1 then '是' when MCE_B_ASSETS.IS_SELF_RESTRAINT = 2 then '否' else '' end ) as IS_SELF_RESTRAINT_NAME, COM_TYPE_OPERATING_MACHINE_TYP.NAME as OPERATING_MACHINE_TYPE_ID_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_IN_ACCOUNT = 1 then '是' when MCE_B_ASSETS.IS_IN_ACCOUNT = 2 then '否' else '' end ) as IS_IN_ACCOUNT_NAME, COM_TYPE_FINANCE_TYPE_ID.NAME as FINANCE_TYPE_ID_NAME, COM_DEPART_SUBJECTION_DEPT_ID.NAME as SUBJECTION_DEPT_ID_NAME, (case  when MCE_B_ASSETS.STATE = 0 then '默认值' when MCE_B_ASSETS.STATE = 1 then '编辑中' when MCE_B_ASSETS.STATE = 2 then '已提交' when MCE_B_ASSETS.STATE = 3 then '已审核' when MCE_B_ASSETS.STATE = 4 then '已归档' when MCE_B_ASSETS.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PRD_PLACE_TYPE_ID.NAME as PRD_PLACE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_LARGE_ME = 1 then '是' when MCE_B_ASSETS.IS_LARGE_ME = 2 then '否' else '' end ) as IS_LARGE_ME_NAME, COM_USER_USING_USER_ID.NAME as USING_USER_ID_NAME, COM_TYPE_ASSETS_STATE.NAME as ASSETS_STATE_NAME, (case  when MCE_B_ASSETS.IS_FORCE_SENSE = 1 then '是' when MCE_B_ASSETS.IS_FORCE_SENSE = 2 then '否' else '' end ) as IS_FORCE_SENSE_NAME, COM_TYPE_CAPITAL_SOURCE_TYPE_I.NAME as CAPITAL_SOURCE_TYPE_ID_NAME, COM_TYPE_BIZ_TYPE_ID.NAME as BIZ_TYPE_ID_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, COM_USER_CUSTODY_USER_ID.NAME as CUSTODY_USER_ID_NAME, COM_TYPE_VEHICLE_USE_TYPE_ID.NAME as VEHICLE_USE_TYPE_ID_NAME, MCE_D_MCE_TYPE_MACHINE_TYPE_ID.NAME as MACHINE_TYPE_ID_NAME, COM_TYPE_OWNERSHIP_TYPE_ID.NAME as OWNERSHIP_TYPE_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME, MCE_D_MCE_TYPE_NAME.NAME as NAME_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_USE_STATE.NAME as USE_STATE_NAME, (case  when MCE_B_ASSETS.IS_DEPR = 1 then '是' when MCE_B_ASSETS.IS_DEPR = 2 then '否' else '' end ) as IS_DEPR_NAME, COM_TYPE_ECONOMIC_USE_TYPE_ID.NAME as ECONOMIC_USE_TYPE_ID_NAME, COM_TYPE_CUSTODY_LEVEL_ID.NAME as CUSTODY_LEVEL_ID_NAME, COM_TYPE_ACQUIRE_OWNERSHIP_TYP.NAME as ACQUIRE_OWNERSHIP_TYPE_ID_NAME, COM_DEPART_CUSTODY_DEPT_ID.NAME as CUSTODY_DEPT_ID_NAME, COM_TYPE_NATIONALITY_ID.NAME as NATIONALITY_ID_NAME, (case  when MCE_B_ASSETS.IS_METERING = 1 then '是' when MCE_B_ASSETS.IS_METERING = 2 then '否' else '' end ) as IS_METERING_NAME, (case  when MCE_B_ASSETS.IS_AFFIX = 1 then '是' when MCE_B_ASSETS.IS_AFFIX = 2 then '否' else '' end ) as IS_AFFIX_NAME, COM_TYPE_VALUE_TYPE_ID.NAME as VALUE_TYPE_ID_NAME, COM_TYPE_MACHINE_MANAGE_TYPE_I.NAME as MACHINE_MANAGE_TYPE_ID_NAME, (case  when MCE_B_ASSETS.IS_ASSETS = 1 then '是' when MCE_B_ASSETS.IS_ASSETS = 2 then '否' else '' end ) as IS_ASSETS_NAME, COM_TYPE_ENERGY_TYPE_ID.NAME as ENERGY_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_CARD_TYPE_ID.NAME as CARD_TYPE_ID_NAME from MCE_B_ASSETS left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_REF_DEPT_ID on MCE_B_ASSETS.REF_DEPT_ID = MDM_D_DEPT_REF_DEPT_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_USE_TYPE_ID on MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = COM_TYPE_ACQUIRE_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OPERATING_MACHINE_TYP on MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = COM_TYPE_OPERATING_MACHINE_TYP.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_FINANCE_TYPE_ID on MCE_B_ASSETS.FINANCE_TYPE_ID = COM_TYPE_FINANCE_TYPE_ID.ID left join COM_DEPART   COM_DEPART_SUBJECTION_DEPT_ID on MCE_B_ASSETS.SUBJECTION_DEPT_ID = COM_DEPART_SUBJECTION_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PRD_PLACE_TYPE_ID on MCE_B_ASSETS.PRD_PLACE_TYPE_ID = COM_TYPE_PRD_PLACE_TYPE_ID.ID left join COM_USER   COM_USER_USING_USER_ID on MCE_B_ASSETS.USING_USER_ID = COM_USER_USING_USER_ID.ID left join COM_TYPE   COM_TYPE_ASSETS_STATE on MCE_B_ASSETS.ASSETS_STATE = COM_TYPE_ASSETS_STATE.ID left join COM_TYPE   COM_TYPE_CAPITAL_SOURCE_TYPE_I on MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = COM_TYPE_CAPITAL_SOURCE_TYPE_I.ID left join COM_TYPE   COM_TYPE_BIZ_TYPE_ID on MCE_B_ASSETS.BIZ_TYPE_ID = COM_TYPE_BIZ_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_ASSETS.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_CUSTODY_USER_ID on MCE_B_ASSETS.CUSTODY_USER_ID = COM_USER_CUSTODY_USER_ID.ID left join COM_TYPE   COM_TYPE_VEHICLE_USE_TYPE_ID on MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = COM_TYPE_VEHICLE_USE_TYPE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_MACHINE_TYPE_ID on MCE_B_ASSETS.MACHINE_TYPE_ID = MCE_D_MCE_TYPE_MACHINE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_OWNERSHIP_TYPE_ID on MCE_B_ASSETS.OWNERSHIP_TYPE_ID = COM_TYPE_OWNERSHIP_TYPE_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_NAME on MCE_B_ASSETS.NAME = MCE_D_MCE_TYPE_NAME.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_USE_STATE on MCE_B_ASSETS.USE_STATE = COM_TYPE_USE_STATE.ID left join COM_TYPE   COM_TYPE_ECONOMIC_USE_TYPE_ID on MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = COM_TYPE_ECONOMIC_USE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CUSTODY_LEVEL_ID on MCE_B_ASSETS.CUSTODY_LEVEL_ID = COM_TYPE_CUSTODY_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_ACQUIRE_OWNERSHIP_TYP on MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = COM_TYPE_ACQUIRE_OWNERSHIP_TYP.ID left join COM_DEPART   COM_DEPART_CUSTODY_DEPT_ID on MCE_B_ASSETS.CUSTODY_DEPT_ID = COM_DEPART_CUSTODY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_NATIONALITY_ID on MCE_B_ASSETS.NATIONALITY_ID = COM_TYPE_NATIONALITY_ID.ID left join COM_TYPE   COM_TYPE_VALUE_TYPE_ID on MCE_B_ASSETS.VALUE_TYPE_ID = COM_TYPE_VALUE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_MACHINE_MANAGE_TYPE_I on MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = COM_TYPE_MACHINE_MANAGE_TYPE_I.ID left join COM_TYPE   COM_TYPE_ENERGY_TYPE_ID on MCE_B_ASSETS.ENERGY_TYPE_ID = COM_TYPE_ENERGY_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_CARD_TYPE_ID on MCE_B_ASSETS.CARD_TYPE_ID = COM_TYPE_CARD_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MAINTAIN_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PRD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.EN_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ACQUIRE_USE_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREDICT_NET_RUDIMENTAL_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SERVICE_LIFE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CALL_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BRAND_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FILE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_SELF_RESTRAINT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.OPERATING_MACHINE_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MAINTAIN_CONTACT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_MONTH_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MAINTAIN_PERIOD = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_IN_ACCOUNT = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.FINANCE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SUBJECTION_DEPT_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.STATE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.RUDIMENTAL_VALUE = sqlReader.GetDecimal(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.OUT_ACCOUNT_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.PRD_PLACE_TYPE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.IS_LARGE_ME = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SEQ_NUMBER = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USING_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.IN_ACCOUNT_DATE = sqlReader.GetDateTime(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_FORCE_SENSE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.CARD_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.NET_AMOUNT = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MAINTAIN_AMOUNT = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.BIZ_TYPE_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CUSTODY_USER_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.VEHICLE_USE_TYPE_ID = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.MACHINE_TYPE_ID = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.RUDIMENTAL_VALUE_RATIO = sqlReader.GetDecimal(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.OWNERSHIP_TYPE_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.CONTRACT_CODE = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.SPELL_CODE = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.VEHICLE_CODE = sqlReader.GetString(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.PRD_CODE = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.PICTURE = sqlReader.GetString(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.NAME = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.ENABLE_DATE = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.ADD_VALUE = sqlReader.GetDecimal(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.NET_VALUE = sqlReader.GetDecimal(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.USE_STATE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.REF_PRICE = sqlReader.GetDecimal(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.DISPOSITION_MONEY = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.FORCE_SENSE_SPAN = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.VEHICLE_CC = sqlReader.GetDecimal(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.IS_DEPR = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.ECONOMIC_USE_TYPE_ID = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.CUSTODY_LEVEL_ID = sqlReader.GetString(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID = sqlReader.GetString(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.CUSTODY_DEPT_ID = sqlReader.GetString(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.NATIONALITY_ID = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.STORE_ADDRESS = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.IS_METERING = sqlReader.GetDecimal(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.IS_AFFIX = sqlReader.GetDecimal(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.VALUE_TYPE_ID = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.MACHINE_MANAGE_TYPE_ID = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.METERING_PERIOD = sqlReader.GetDecimal(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.IS_ASSETS = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.ACCUMULATED_DEPRECIATION = sqlReader.GetDecimal(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.SPEC = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ENERGY_TYPE_ID = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.LICENCE_CODE = sqlReader.GetString(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.UNIT_ID = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(95);
				if(!sqlReader.IsDBNull(96)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(96);
				if(!sqlReader.IsDBNull(97)) 
					dataObj.CARD_TYPE_ID = sqlReader.GetString(97);
				if(!sqlReader.IsDBNull(98)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(98);
				if(!sqlReader.IsDBNull(99)) 
					dataObj.REF_DEPT_ID_NAME = sqlReader.GetString(99);
				if(!sqlReader.IsDBNull(100)) 
					dataObj.ACQUIRE_USE_TYPE_ID_NAME = sqlReader.GetString(100);
				if(!sqlReader.IsDBNull(101)) 
					dataObj.IS_SELF_RESTRAINT_NAME = sqlReader.GetString(101);
				if(!sqlReader.IsDBNull(102)) 
					dataObj.OPERATING_MACHINE_TYPE_ID_NAME = sqlReader.GetString(102);
				if(!sqlReader.IsDBNull(103)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(103);
				if(!sqlReader.IsDBNull(104)) 
					dataObj.IS_IN_ACCOUNT_NAME = sqlReader.GetString(104);
				if(!sqlReader.IsDBNull(105)) 
					dataObj.FINANCE_TYPE_ID_NAME = sqlReader.GetString(105);
				if(!sqlReader.IsDBNull(106)) 
					dataObj.SUBJECTION_DEPT_ID_NAME = sqlReader.GetString(106);
				if(!sqlReader.IsDBNull(107)) 
					dataObj.STATE_NAME = sqlReader.GetString(107);
				if(!sqlReader.IsDBNull(108)) 
					dataObj.PRD_PLACE_TYPE_ID_NAME = sqlReader.GetString(108);
				if(!sqlReader.IsDBNull(109)) 
					dataObj.IS_LARGE_ME_NAME = sqlReader.GetString(109);
				if(!sqlReader.IsDBNull(110)) 
					dataObj.USING_USER_ID_NAME = sqlReader.GetString(110);
				if(!sqlReader.IsDBNull(111)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(111);
				if(!sqlReader.IsDBNull(112)) 
					dataObj.IS_FORCE_SENSE_NAME = sqlReader.GetString(112);
				if(!sqlReader.IsDBNull(113)) 
					dataObj.CAPITAL_SOURCE_TYPE_ID_NAME = sqlReader.GetString(113);
				if(!sqlReader.IsDBNull(114)) 
					dataObj.BIZ_TYPE_ID_NAME = sqlReader.GetString(114);
				if(!sqlReader.IsDBNull(115)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(115);
				if(!sqlReader.IsDBNull(116)) 
					dataObj.CUSTODY_USER_ID_NAME = sqlReader.GetString(116);
				if(!sqlReader.IsDBNull(117)) 
					dataObj.VEHICLE_USE_TYPE_ID_NAME = sqlReader.GetString(117);
				if(!sqlReader.IsDBNull(118)) 
					dataObj.MACHINE_TYPE_ID_NAME = sqlReader.GetString(118);
				if(!sqlReader.IsDBNull(119)) 
					dataObj.OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(119);
				if(!sqlReader.IsDBNull(120)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(120);
				if(!sqlReader.IsDBNull(121)) 
					dataObj.NAME_NAME = sqlReader.GetString(121);
				if(!sqlReader.IsDBNull(122)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(122);
				if(!sqlReader.IsDBNull(123)) 
					dataObj.USE_STATE_NAME = sqlReader.GetString(123);
				if(!sqlReader.IsDBNull(124)) 
					dataObj.IS_DEPR_NAME = sqlReader.GetString(124);
				if(!sqlReader.IsDBNull(125)) 
					dataObj.ECONOMIC_USE_TYPE_ID_NAME = sqlReader.GetString(125);
				if(!sqlReader.IsDBNull(126)) 
					dataObj.CUSTODY_LEVEL_ID_NAME = sqlReader.GetString(126);
				if(!sqlReader.IsDBNull(127)) 
					dataObj.ACQUIRE_OWNERSHIP_TYPE_ID_NAME = sqlReader.GetString(127);
				if(!sqlReader.IsDBNull(128)) 
					dataObj.CUSTODY_DEPT_ID_NAME = sqlReader.GetString(128);
				if(!sqlReader.IsDBNull(129)) 
					dataObj.NATIONALITY_ID_NAME = sqlReader.GetString(129);
				if(!sqlReader.IsDBNull(130)) 
					dataObj.IS_METERING_NAME = sqlReader.GetString(130);
				if(!sqlReader.IsDBNull(131)) 
					dataObj.IS_AFFIX_NAME = sqlReader.GetString(131);
				if(!sqlReader.IsDBNull(132)) 
					dataObj.VALUE_TYPE_ID_NAME = sqlReader.GetString(132);
				if(!sqlReader.IsDBNull(133)) 
					dataObj.MACHINE_MANAGE_TYPE_ID_NAME = sqlReader.GetString(133);
				if(!sqlReader.IsDBNull(134)) 
					dataObj.IS_ASSETS_NAME = sqlReader.GetString(134);
				if(!sqlReader.IsDBNull(135)) 
					dataObj.ENERGY_TYPE_ID_NAME = sqlReader.GetString(135);
				if(!sqlReader.IsDBNull(136)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(136);
				if(!sqlReader.IsDBNull(137)) 
					dataObj.CARD_TYPE_ID_NAME = sqlReader.GetString(137);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MAINTAIN_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS.MAINTAIN_MONEY = :U_MAINTAIN_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MAINTAIN_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_YEAR_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS.DEPR_YEAR_AMOUNT = :U_DEPR_YEAR_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_YEAR_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DEPR_YEAR_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.REF_DEPT_ID = :U_REF_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_DEPT_ID) ? string.Empty : obj.REF_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EN_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS.EN_NAME = :U_EN_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_EN_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.EN_NAME) ? string.Empty : obj.EN_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACQUIRE_USE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.ACQUIRE_USE_TYPE_ID = :U_ACQUIRE_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ACQUIRE_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ACQUIRE_USE_TYPE_ID) ? string.Empty : obj.ACQUIRE_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PREDICT_NET_RUDIMENTAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS.PREDICT_NET_RUDIMENTAL_VALUE = :U_PREDICT_NET_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_PREDICT_NET_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PREDICT_NET_RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SERVICE_LIFE"))
			{
				strBuf.Add("  MCE_B_ASSETS.SERVICE_LIFE = :U_SERVICE_LIFE");
				param = new OracleParameter();
				param.ParameterName = ":U_SERVICE_LIFE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.SERVICE_LIFE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CALL_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.CALL_CODE = :U_CALL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CALL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CALL_CODE) ? string.Empty : obj.CALL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BRAND_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS.BRAND_NAME = :U_BRAND_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BRAND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BRAND_NAME) ? string.Empty : obj.BRAND_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FILE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.FILE_CODE = :U_FILE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_FILE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FILE_CODE) ? string.Empty : obj.FILE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTENANCE_PERIOD_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.MAINTENANCE_PERIOD_DATE = :U_MAINTENANCE_PERIOD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTENANCE_PERIOD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MAINTENANCE_PERIOD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_SELF_RESTRAINT"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_SELF_RESTRAINT = :U_IS_SELF_RESTRAINT");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_SELF_RESTRAINT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_SELF_RESTRAINT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("OPERATING_MACHINE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.OPERATING_MACHINE_TYPE_ID = :U_OPERATING_MACHINE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_OPERATING_MACHINE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.OPERATING_MACHINE_TYPE_ID) ? string.Empty : obj.OPERATING_MACHINE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.PURCHASE_TYPE_ID = :U_PURCHASE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PURCHASE_TYPE_ID) ? string.Empty : obj.PURCHASE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTAIN_CONTACT"))
			{
				strBuf.Add("  MCE_B_ASSETS.MAINTAIN_CONTACT = :U_MAINTAIN_CONTACT");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_CONTACT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MAINTAIN_CONTACT) ? string.Empty : obj.MAINTAIN_CONTACT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_MONTH_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS.DEPR_MONTH_AMOUNT = :U_DEPR_MONTH_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_MONTH_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DEPR_MONTH_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTAIN_PERIOD"))
			{
				strBuf.Add("  MCE_B_ASSETS.MAINTAIN_PERIOD = :U_MAINTAIN_PERIOD");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MAINTAIN_PERIOD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_IN_ACCOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_IN_ACCOUNT = :U_IS_IN_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_IN_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_IN_ACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.FINANCE_TYPE_ID = :U_FINANCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_TYPE_ID) ? string.Empty : obj.FINANCE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUBJECTION_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.SUBJECTION_DEPT_ID = :U_SUBJECTION_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_SUBJECTION_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SUBJECTION_DEPT_ID) ? string.Empty : obj.SUBJECTION_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RUDIMENTAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS.RUDIMENTAL_VALUE = :U_RUDIMENTAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_RUDIMENTAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RUDIMENTAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("OUT_ACCOUNT_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.OUT_ACCOUNT_DATE = :U_OUT_ACCOUNT_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_OUT_ACCOUNT_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.OUT_ACCOUNT_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_PLACE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.PRD_PLACE_TYPE_ID = :U_PRD_PLACE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_PLACE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_PLACE_TYPE_ID) ? string.Empty : obj.PRD_PLACE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_LARGE_ME"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_LARGE_ME = :U_IS_LARGE_ME");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_LARGE_ME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_LARGE_ME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEQ_NUMBER"))
			{
				strBuf.Add("  MCE_B_ASSETS.SEQ_NUMBER = :U_SEQ_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":U_SEQ_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SEQ_NUMBER) ? string.Empty : obj.SEQ_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.USING_USER_ID = :U_USING_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_USER_ID) ? string.Empty : obj.USING_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.ASSETS_STATE = :U_ASSETS_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_STATE) ? string.Empty : obj.ASSETS_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IN_ACCOUNT_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.IN_ACCOUNT_DATE = :U_IN_ACCOUNT_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_IN_ACCOUNT_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.IN_ACCOUNT_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FORCE_SENSE"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_FORCE_SENSE = :U_IS_FORCE_SENSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_FORCE_SENSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FORCE_SENSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CAPITAL_SOURCE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CAPITAL_SOURCE_TYPE_ID = :U_CAPITAL_SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CAPITAL_SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CAPITAL_SOURCE_TYPE_ID) ? string.Empty : obj.CAPITAL_SOURCE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.PURCHASE_DATE = :U_PURCHASE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PURCHASE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.CARD_CODE = :U_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CARD_CODE) ? string.Empty : obj.CARD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INTERNATIONAL_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.INTERNATIONAL_CODE = :U_INTERNATIONAL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_INTERNATIONAL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INTERNATIONAL_CODE) ? string.Empty : obj.INTERNATIONAL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NET_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS.NET_AMOUNT = :U_NET_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_NET_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NET_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTAIN_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS.MAINTAIN_AMOUNT = :U_MAINTAIN_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTAIN_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MAINTAIN_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BIZ_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.BIZ_TYPE_ID = :U_BIZ_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BIZ_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BIZ_TYPE_ID) ? string.Empty : obj.BIZ_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PROVIDER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.PROVIDER_ID = :U_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROVIDER_ID) ? string.Empty : obj.PROVIDER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTODY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CUSTODY_USER_ID = :U_CUSTODY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTODY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CUSTODY_USER_ID) ? string.Empty : obj.CUSTODY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VEHICLE_USE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.VEHICLE_USE_TYPE_ID = :U_VEHICLE_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_VEHICLE_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.VEHICLE_USE_TYPE_ID) ? string.Empty : obj.VEHICLE_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MACHINE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.MACHINE_TYPE_ID = :U_MACHINE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MACHINE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MACHINE_TYPE_ID) ? string.Empty : obj.MACHINE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RUDIMENTAL_VALUE_RATIO"))
			{
				strBuf.Add("  MCE_B_ASSETS.RUDIMENTAL_VALUE_RATIO = :U_RUDIMENTAL_VALUE_RATIO");
				param = new OracleParameter();
				param.ParameterName = ":U_RUDIMENTAL_VALUE_RATIO";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RUDIMENTAL_VALUE_RATIO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORIGINAL_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS.ORIGINAL_VALUE = :U_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("OWNERSHIP_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.OWNERSHIP_TYPE_ID = :U_OWNERSHIP_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_OWNERSHIP_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.OWNERSHIP_TYPE_ID) ? string.Empty : obj.OWNERSHIP_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTRACT_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.CONTRACT_CODE = :U_CONTRACT_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTRACT_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CONTRACT_CODE) ? string.Empty : obj.CONTRACT_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.SPELL_CODE = :U_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VEHICLE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.VEHICLE_CODE = :U_VEHICLE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_VEHICLE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.VEHICLE_CODE) ? string.Empty : obj.VEHICLE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.USING_DEPT_ID = :U_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID) ? string.Empty : obj.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.PRD_CODE = :U_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PRD_CODE) ? string.Empty : obj.PRD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PICTURE"))
			{
				strBuf.Add("  MCE_B_ASSETS.PICTURE = :U_PICTURE");
				param = new OracleParameter();
				param.ParameterName = ":U_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PICTURE) ? string.Empty : obj.PICTURE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENABLE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.ENABLE_DATE = :U_ENABLE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ENABLE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ENABLE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADD_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS.ADD_VALUE = :U_ADD_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ADD_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ADD_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS.REF_TAB_NAME = :U_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NET_VALUE"))
			{
				strBuf.Add("  MCE_B_ASSETS.NET_VALUE = :U_NET_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_NET_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NET_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.DEPR_TYPE_ID = :U_DEPR_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPR_TYPE_ID) ? string.Empty : obj.DEPR_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USE_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.USE_STATE = :U_USE_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_USE_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USE_STATE) ? string.Empty : obj.USE_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRICE"))
			{
				strBuf.Add("  MCE_B_ASSETS.REF_PRICE = :U_REF_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REF_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPOSITION_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS.DISPOSITION_MONEY = :U_DISPOSITION_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_DISPOSITION_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPOSITION_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FORCE_SENSE_SPAN"))
			{
				strBuf.Add("  MCE_B_ASSETS.FORCE_SENSE_SPAN = :U_FORCE_SENSE_SPAN");
				param = new OracleParameter();
				param.ParameterName = ":U_FORCE_SENSE_SPAN";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FORCE_SENSE_SPAN) ? string.Empty : obj.FORCE_SENSE_SPAN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VEHICLE_CC"))
			{
				strBuf.Add("  MCE_B_ASSETS.VEHICLE_CC = :U_VEHICLE_CC");
				param = new OracleParameter();
				param.ParameterName = ":U_VEHICLE_CC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.VEHICLE_CC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTOM_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.CUSTOM_CODE = :U_CUSTOM_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTOM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CUSTOM_CODE) ? string.Empty : obj.CUSTOM_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_DEPR"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_DEPR = :U_IS_DEPR");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_DEPR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_DEPR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ECONOMIC_USE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.ECONOMIC_USE_TYPE_ID = :U_ECONOMIC_USE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ECONOMIC_USE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ECONOMIC_USE_TYPE_ID) ? string.Empty : obj.ECONOMIC_USE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTODY_LEVEL_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CUSTODY_LEVEL_ID = :U_CUSTODY_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTODY_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CUSTODY_LEVEL_ID) ? string.Empty : obj.CUSTODY_LEVEL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACQUIRE_OWNERSHIP_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.ACQUIRE_OWNERSHIP_TYPE_ID = :U_ACQUIRE_OWNERSHIP_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ACQUIRE_OWNERSHIP_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ACQUIRE_OWNERSHIP_TYPE_ID) ? string.Empty : obj.ACQUIRE_OWNERSHIP_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTODY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CUSTODY_DEPT_ID = :U_CUSTODY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTODY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CUSTODY_DEPT_ID) ? string.Empty : obj.CUSTODY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NATIONALITY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.NATIONALITY_ID = :U_NATIONALITY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_NATIONALITY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.NATIONALITY_ID) ? string.Empty : obj.NATIONALITY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STORE_ADDRESS"))
			{
				strBuf.Add("  MCE_B_ASSETS.STORE_ADDRESS = :U_STORE_ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":U_STORE_ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.STORE_ADDRESS) ? string.Empty : obj.STORE_ADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_METERING"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_METERING = :U_IS_METERING");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_METERING";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_METERING;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_AFFIX"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_AFFIX = :U_IS_AFFIX");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_AFFIX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_AFFIX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FIVE_STROKE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.FIVE_STROKE_CODE = :U_FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FIVE_STROKE_CODE) ? string.Empty : obj.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VALUE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.VALUE_TYPE_ID = :U_VALUE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_VALUE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.VALUE_TYPE_ID) ? string.Empty : obj.VALUE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MACHINE_MANAGE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.MACHINE_MANAGE_TYPE_ID = :U_MACHINE_MANAGE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MACHINE_MANAGE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MACHINE_MANAGE_TYPE_ID) ? string.Empty : obj.MACHINE_MANAGE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("METERING_PERIOD"))
			{
				strBuf.Add("  MCE_B_ASSETS.METERING_PERIOD = :U_METERING_PERIOD");
				param = new OracleParameter();
				param.ParameterName = ":U_METERING_PERIOD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.METERING_PERIOD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_ASSETS"))
			{
				strBuf.Add("  MCE_B_ASSETS.IS_ASSETS = :U_IS_ASSETS");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_ASSETS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_ASSETS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.REF_TAB_ID = :U_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCUMULATED_DEPRECIATION"))
			{
				strBuf.Add("  MCE_B_ASSETS.ACCUMULATED_DEPRECIATION = :U_ACCUMULATED_DEPRECIATION");
				param = new OracleParameter();
				param.ParameterName = ":U_ACCUMULATED_DEPRECIATION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ACCUMULATED_DEPRECIATION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENERGY_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.ENERGY_TYPE_ID = :U_ENERGY_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ENERGY_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ENERGY_TYPE_ID) ? string.Empty : obj.ENERGY_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LICENCE_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.LICENCE_CODE = :U_LICENCE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_LICENCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LICENCE_CODE) ? string.Empty : obj.LICENCE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS.PRD_DATE = :U_PRD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PRD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS.CARD_TYPE_ID = :U_CARD_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CARD_TYPE_ID) ? string.Empty : obj.CARD_TYPE_ID;
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
