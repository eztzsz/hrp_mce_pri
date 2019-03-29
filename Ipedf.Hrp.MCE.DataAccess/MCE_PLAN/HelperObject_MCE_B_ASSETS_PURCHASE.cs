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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_PURCHASE))]
	public partial class HelperObject_MCE_B_ASSETS_PURCHASE
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_PURCHASE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_PURCHASE( CURRENCY_ID, AUDIT_TIME, NAME, FREEUSE2, FREEUSE3, REF_PRD_ID, MONTH_INCOME, REF_PRV_ID, MODIFY_DEPT_ID, PRD_ID, ID, DATA_ORGANISE_ID, APPLY_SITUATION_3, APPLY_SITUATION_2, APPLY_SITUATION_1, SPEC, TYPE_ID, REF_USED_AMOUNT, CODE, ASSET_ID, APPLY_USER_ID, CREATE_TIME, PRD_NAME, YEAR_INCOME, APPLY_PRICE, APPLY_MONEY, UNIT_NAME, APPLY_DEPT_ID, IS_REPORT, FREEUSE1, CONFIGURATION, STATE, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, ENCONOMY_EFFECT, PICTURE, CREATE_USER_ID, ASSET_NAME, PRV_NAME, UNIT_ID, APPLY_ESTIMATE_MONEY, PURCHASE_TYPE_ID, COMMENTS, MONTH_EXAMINE, PRV_ID, ASSET_HOUSE_MAP, CREATE_DEPT_ID, APPLY_AMOUNT, IS_ASSET_HOUSE, PRODUCT_AREA) values ( :CURRENCY_ID, :AUDIT_TIME, :NAME, :FREEUSE2, :FREEUSE3, :REF_PRD_ID, :MONTH_INCOME, :REF_PRV_ID, :MODIFY_DEPT_ID, :PRD_ID, :ID, :DATA_ORGANISE_ID, :APPLY_SITUATION_3, :APPLY_SITUATION_2, :APPLY_SITUATION_1, :SPEC, :TYPE_ID, :REF_USED_AMOUNT, :CODE, :ASSET_ID, :APPLY_USER_ID, :CREATE_TIME, :PRD_NAME, :YEAR_INCOME, :APPLY_PRICE, :APPLY_MONEY, :UNIT_NAME, :APPLY_DEPT_ID, :IS_REPORT, :FREEUSE1, :CONFIGURATION, :STATE, :CREATE_DATE, :AUDIT_USER_ID, :APPLY_COMMENTS, :ENCONOMY_EFFECT, :PICTURE, :CREATE_USER_ID, :ASSET_NAME, :PRV_NAME, :UNIT_ID, :APPLY_ESTIMATE_MONEY, :PURCHASE_TYPE_ID, :COMMENTS, :MONTH_EXAMINE, :PRV_ID, :ASSET_HOUSE_MAP, :CREATE_DEPT_ID, :APPLY_AMOUNT, :IS_ASSET_HOUSE, :PRODUCT_AREA)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[51];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CURRENCY_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":AUDIT_TIME";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.AUDIT_TIME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FREEUSE2";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FREEUSE3";
			parameters[4].Size = 500;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":REF_PRD_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.REF_PRD_ID == null ? String.Empty:obj.REF_PRD_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":MONTH_INCOME";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.MONTH_INCOME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_PRV_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.REF_PRV_ID == null ? String.Empty:obj.REF_PRV_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":MODIFY_DEPT_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PRD_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":DATA_ORGANISE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":APPLY_SITUATION_3";
			parameters[12].Size = 400;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.APPLY_SITUATION_3 == null ? String.Empty:obj.APPLY_SITUATION_3;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":APPLY_SITUATION_2";
			parameters[13].Size = 400;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.APPLY_SITUATION_2 == null ? String.Empty:obj.APPLY_SITUATION_2;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":APPLY_SITUATION_1";
			parameters[14].Size = 400;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.APPLY_SITUATION_1 == null ? String.Empty:obj.APPLY_SITUATION_1;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":SPEC";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":TYPE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":REF_USED_AMOUNT";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.REF_USED_AMOUNT;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":CODE";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":ASSET_ID";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.ASSET_ID == null ? String.Empty:obj.ASSET_ID;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":APPLY_USER_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":CREATE_TIME";
			parameters[21].Size = 7;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[21].Value = obj.CREATE_TIME;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":PRD_NAME";
			parameters[22].Size = 100;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.PRD_NAME == null ? String.Empty:obj.PRD_NAME;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":YEAR_INCOME";
			parameters[23].Size = 22;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[23].Value = obj.YEAR_INCOME;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":APPLY_PRICE";
			parameters[24].Size = 22;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[24].Value = obj.APPLY_PRICE;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":APPLY_MONEY";
			parameters[25].Size = 22;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[25].Value = obj.APPLY_MONEY;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":UNIT_NAME";
			parameters[26].Size = 50;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.UNIT_NAME == null ? String.Empty:obj.UNIT_NAME;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":APPLY_DEPT_ID";
			parameters[27].Size = 36;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[27].Value = obj.APPLY_DEPT_ID == null ? String.Empty:obj.APPLY_DEPT_ID;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":IS_REPORT";
			parameters[28].Size = 22;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[28].Value = obj.IS_REPORT;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":FREEUSE1";
			parameters[29].Size = 10;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":CONFIGURATION";
			parameters[30].Size = 800;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.CONFIGURATION == null ? String.Empty:obj.CONFIGURATION;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":STATE";
			parameters[31].Size = 22;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[31].Value = obj.STATE;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":CREATE_DATE";
			parameters[32].Size = 7;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[32].Value = obj.CREATE_DATE;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":AUDIT_USER_ID";
			parameters[33].Size = 36;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[33].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":APPLY_COMMENTS";
			parameters[34].Size = 200;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[34].Value = obj.APPLY_COMMENTS == null ? String.Empty:obj.APPLY_COMMENTS;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":ENCONOMY_EFFECT";
			parameters[35].Size = 1000;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[35].Value = obj.ENCONOMY_EFFECT == null ? String.Empty:obj.ENCONOMY_EFFECT;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":PICTURE";
			parameters[36].Size = 500;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[36].Value = obj.PICTURE == null ? String.Empty:obj.PICTURE;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":CREATE_USER_ID";
			parameters[37].Size = 36;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[37].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[38] = new OracleParameter();
			parameters[38].ParameterName =":ASSET_NAME";
			parameters[38].Size = 100;
			parameters[38].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[38].Value = obj.ASSET_NAME == null ? String.Empty:obj.ASSET_NAME;
			parameters[39] = new OracleParameter();
			parameters[39].ParameterName =":PRV_NAME";
			parameters[39].Size = 100;
			parameters[39].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[39].Value = obj.PRV_NAME == null ? String.Empty:obj.PRV_NAME;
			parameters[40] = new OracleParameter();
			parameters[40].ParameterName =":UNIT_ID";
			parameters[40].Size = 36;
			parameters[40].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[40].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[41] = new OracleParameter();
			parameters[41].ParameterName =":APPLY_ESTIMATE_MONEY";
			parameters[41].Size = 22;
			parameters[41].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[41].Value = obj.APPLY_ESTIMATE_MONEY;
			parameters[42] = new OracleParameter();
			parameters[42].ParameterName =":PURCHASE_TYPE_ID";
			parameters[42].Size = 36;
			parameters[42].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[42].Value = obj.PURCHASE_TYPE_ID == null ? String.Empty:obj.PURCHASE_TYPE_ID;
			parameters[43] = new OracleParameter();
			parameters[43].ParameterName =":COMMENTS";
			parameters[43].Size = 200;
			parameters[43].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[43].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[44] = new OracleParameter();
			parameters[44].ParameterName =":MONTH_EXAMINE";
			parameters[44].Size = 22;
			parameters[44].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[44].Value = obj.MONTH_EXAMINE;
			parameters[45] = new OracleParameter();
			parameters[45].ParameterName =":PRV_ID";
			parameters[45].Size = 36;
			parameters[45].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[45].Value = obj.PRV_ID == null ? String.Empty:obj.PRV_ID;
			parameters[46] = new OracleParameter();
			parameters[46].ParameterName =":ASSET_HOUSE_MAP";
			parameters[46].Size = 22;
			parameters[46].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[46].Value = obj.ASSET_HOUSE_MAP;
			parameters[47] = new OracleParameter();
			parameters[47].ParameterName =":CREATE_DEPT_ID";
			parameters[47].Size = 36;
			parameters[47].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[47].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[48] = new OracleParameter();
			parameters[48].ParameterName =":APPLY_AMOUNT";
			parameters[48].Size = 22;
			parameters[48].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[48].Value = obj.APPLY_AMOUNT;
			parameters[49] = new OracleParameter();
			parameters[49].ParameterName =":IS_ASSET_HOUSE";
			parameters[49].Size = 22;
			parameters[49].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[49].Value = obj.IS_ASSET_HOUSE;
			parameters[50] = new OracleParameter();
			parameters[50].ParameterName =":PRODUCT_AREA";
			parameters[50].Size = 300;
			parameters[50].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[50].Value = obj.PRODUCT_AREA == null ? String.Empty:obj.PRODUCT_AREA;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE obj,CauseObject_MCE_B_ASSETS_PURCHASE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_PURCHASE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_PURCHASE where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_PURCHASE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_PURCHASE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE Get(EntityObject_MCE_B_ASSETS_PURCHASE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CURRENCY_ID, AUDIT_TIME, NAME, FREEUSE2, FREEUSE3, REF_PRD_ID, MONTH_INCOME, REF_PRV_ID, MODIFY_DEPT_ID, MODIFY_TIME, PRD_ID, ID, DATA_ORGANISE_ID, APPLY_SITUATION_3, APPLY_SITUATION_2, APPLY_SITUATION_1, SPEC, TYPE_ID, REF_USED_AMOUNT, CODE, ASSET_ID, APPLY_USER_ID, CREATE_TIME, MODIFY_USER_ID, PRD_NAME, YEAR_INCOME, APPLY_PRICE, APPLY_MONEY, UNIT_NAME, APPLY_DEPT_ID, IS_REPORT, FREEUSE1, CONFIGURATION, STATE, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, ENCONOMY_EFFECT, PICTURE, CREATE_USER_ID, ASSET_NAME, PRV_NAME, UNIT_ID, APPLY_ESTIMATE_MONEY, PURCHASE_TYPE_ID, COMMENTS, MONTH_EXAMINE, PRV_ID, ASSET_HOUSE_MAP, CREATE_DEPT_ID, APPLY_AMOUNT, IS_ASSET_HOUSE, PRODUCT_AREA from MCE_B_ASSETS_PURCHASE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE Get(DisplayObject_MCE_B_ASSETS_PURCHASE obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1) and MCE_B_ASSETS_PURCHASE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE Get(EntityObject_MCE_B_ASSETS_PURCHASE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CURRENCY_ID, AUDIT_TIME, NAME, FREEUSE2, FREEUSE3, REF_PRD_ID, MONTH_INCOME, REF_PRV_ID, MODIFY_DEPT_ID, MODIFY_TIME, PRD_ID, ID, DATA_ORGANISE_ID, APPLY_SITUATION_3, APPLY_SITUATION_2, APPLY_SITUATION_1, SPEC, TYPE_ID, REF_USED_AMOUNT, CODE, ASSET_ID, APPLY_USER_ID, CREATE_TIME, MODIFY_USER_ID, PRD_NAME, YEAR_INCOME, APPLY_PRICE, APPLY_MONEY, UNIT_NAME, APPLY_DEPT_ID, IS_REPORT, FREEUSE1, CONFIGURATION, STATE, CREATE_DATE, AUDIT_USER_ID, APPLY_COMMENTS, ENCONOMY_EFFECT, PICTURE, CREATE_USER_ID, ASSET_NAME, PRV_NAME, UNIT_ID, APPLY_ESTIMATE_MONEY, PURCHASE_TYPE_ID, COMMENTS, MONTH_EXAMINE, PRV_ID, ASSET_HOUSE_MAP, CREATE_DEPT_ID, APPLY_AMOUNT, IS_ASSET_HOUSE, PRODUCT_AREA from MCE_B_ASSETS_PURCHASE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_PURCHASE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CURRENCY_ID"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.REF_PRD_ID ").Append((cause.REF_PRD_ID.StartsWith("%") || cause.REF_PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "REF_PRD_ID"));
			}
			if(cause.MONTH_INCOME!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MONTH_INCOME = :C_MONTH_INCOME");
				param = new OracleParameter();
				param.ParameterName =":C_MONTH_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONTH_INCOME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONTH_INCOME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "MONTH_INCOME"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.REF_PRV_ID ").Append((cause.REF_PRV_ID.StartsWith("%") || cause.REF_PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "REF_PRV_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "MODIFY_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_SITUATION_3))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3 ").Append((cause.APPLY_SITUATION_3.StartsWith("%") || cause.APPLY_SITUATION_3.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_SITUATION_3");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_SITUATION_3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = cause.APPLY_SITUATION_3;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_SITUATION_3"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_SITUATION_3"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_SITUATION_2))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2 ").Append((cause.APPLY_SITUATION_2.StartsWith("%") || cause.APPLY_SITUATION_2.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_SITUATION_2");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_SITUATION_2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = cause.APPLY_SITUATION_2;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_SITUATION_2"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_SITUATION_2"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_SITUATION_1))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1 ").Append((cause.APPLY_SITUATION_1.StartsWith("%") || cause.APPLY_SITUATION_1.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_SITUATION_1");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_SITUATION_1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = cause.APPLY_SITUATION_1;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_SITUATION_1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_SITUATION_1"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "TYPE_ID"));
			}
			if(cause.REF_USED_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT = :C_REF_USED_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_REF_USED_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REF_USED_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_USED_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "REF_USED_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.ASSET_ID ").Append((cause.ASSET_ID.StartsWith("%") || cause.ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "ASSET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_USER_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PRD_NAME ").Append((cause.PRD_NAME.StartsWith("%") || cause.PRD_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRD_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PRD_NAME"));
			}
			if(cause.YEAR_INCOME!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.YEAR_INCOME = :C_YEAR_INCOME");
				param = new OracleParameter();
				param.ParameterName =":C_YEAR_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.YEAR_INCOME;
				paramList.Add(param);
			}
			if (cause.HasINValue("YEAR_INCOME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "YEAR_INCOME"));
			}
			if(cause.APPLY_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_PRICE = :C_APPLY_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_PRICE"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_MONEY = :C_APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.UNIT_NAME ").Append((cause.UNIT_NAME.StartsWith("%") || cause.UNIT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.UNIT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "UNIT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID ").Append((cause.APPLY_DEPT_ID.StartsWith("%") || cause.APPLY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_DEPT_ID"));
			}
			if(cause.IS_REPORT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.IS_REPORT = :C_IS_REPORT");
				param = new OracleParameter();
				param.ParameterName =":C_IS_REPORT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_REPORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_REPORT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "IS_REPORT"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.CONFIGURATION))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CONFIGURATION ").Append((cause.CONFIGURATION.StartsWith("%") || cause.CONFIGURATION.EndsWith("%")) ? " like " : " = ").Append(" :C_CONFIGURATION");
				param = new OracleParameter();
				param.ParameterName =":C_CONFIGURATION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = cause.CONFIGURATION;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONFIGURATION"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CONFIGURATION"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "STATE"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS ").Append((cause.APPLY_COMMENTS.StartsWith("%") || cause.APPLY_COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.ENCONOMY_EFFECT))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT ").Append((cause.ENCONOMY_EFFECT.StartsWith("%") || cause.ENCONOMY_EFFECT.EndsWith("%")) ? " like " : " = ").Append(" :C_ENCONOMY_EFFECT");
				param = new OracleParameter();
				param.ParameterName =":C_ENCONOMY_EFFECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.ENCONOMY_EFFECT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ENCONOMY_EFFECT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "ENCONOMY_EFFECT"));
			}
			if(!string.IsNullOrEmpty(cause.PICTURE))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PICTURE ").Append((cause.PICTURE.StartsWith("%") || cause.PICTURE.EndsWith("%")) ? " like " : " = ").Append(" :C_PICTURE");
				param = new OracleParameter();
				param.ParameterName =":C_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.PICTURE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PICTURE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PICTURE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.ASSET_NAME ").Append((cause.ASSET_NAME.StartsWith("%") || cause.ASSET_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSET_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "ASSET_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PRV_NAME ").Append((cause.PRV_NAME.StartsWith("%") || cause.PRV_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRV_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PRV_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "UNIT_ID"));
			}
			if(cause.APPLY_ESTIMATE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY = :C_APPLY_ESTIMATE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ESTIMATE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_ESTIMATE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ESTIMATE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_ESTIMATE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHASE_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID ").Append((cause.PURCHASE_TYPE_ID.StartsWith("%") || cause.PURCHASE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHASE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHASE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PURCHASE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PURCHASE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "COMMENTS"));
			}
			if(cause.MONTH_EXAMINE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE = :C_MONTH_EXAMINE");
				param = new OracleParameter();
				param.ParameterName =":C_MONTH_EXAMINE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONTH_EXAMINE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONTH_EXAMINE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "MONTH_EXAMINE"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PRV_ID ").Append((cause.PRV_ID.StartsWith("%") || cause.PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PRV_ID"));
			}
			if(cause.ASSET_HOUSE_MAP!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP = :C_ASSET_HOUSE_MAP");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_HOUSE_MAP";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ASSET_HOUSE_MAP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_HOUSE_MAP"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "ASSET_HOUSE_MAP"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "CREATE_DEPT_ID"));
			}
			if(cause.APPLY_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT = :C_APPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "APPLY_AMOUNT"));
			}
			if(cause.IS_ASSET_HOUSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE = :C_IS_ASSET_HOUSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_ASSET_HOUSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ASSET_HOUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ASSET_HOUSE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "IS_ASSET_HOUSE"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCT_AREA))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE.PRODUCT_AREA ").Append((cause.PRODUCT_AREA.StartsWith("%") || cause.PRODUCT_AREA.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCT_AREA");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCT_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.PRODUCT_AREA;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_AREA"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE", "PRODUCT_AREA"));
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
		public static DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE.CURRENCY_ID, MCE_B_ASSETS_PURCHASE.AUDIT_TIME, MCE_B_ASSETS_PURCHASE.NAME, MCE_B_ASSETS_PURCHASE.FREEUSE2, MCE_B_ASSETS_PURCHASE.FREEUSE3, MCE_B_ASSETS_PURCHASE.REF_PRD_ID, MCE_B_ASSETS_PURCHASE.MONTH_INCOME, MCE_B_ASSETS_PURCHASE.REF_PRV_ID, MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID, MCE_B_ASSETS_PURCHASE.MODIFY_TIME, MCE_B_ASSETS_PURCHASE.PRD_ID, MCE_B_ASSETS_PURCHASE.ID, MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2, MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1, MCE_B_ASSETS_PURCHASE.SPEC, MCE_B_ASSETS_PURCHASE.TYPE_ID, MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE.CODE, MCE_B_ASSETS_PURCHASE.ASSET_ID, MCE_B_ASSETS_PURCHASE.APPLY_USER_ID, MCE_B_ASSETS_PURCHASE.CREATE_TIME, MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID, MCE_B_ASSETS_PURCHASE.PRD_NAME, MCE_B_ASSETS_PURCHASE.YEAR_INCOME, MCE_B_ASSETS_PURCHASE.APPLY_PRICE, MCE_B_ASSETS_PURCHASE.APPLY_MONEY, MCE_B_ASSETS_PURCHASE.UNIT_NAME, MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID, MCE_B_ASSETS_PURCHASE.IS_REPORT, MCE_B_ASSETS_PURCHASE.FREEUSE1, MCE_B_ASSETS_PURCHASE.CONFIGURATION, MCE_B_ASSETS_PURCHASE.STATE, MCE_B_ASSETS_PURCHASE.CREATE_DATE, MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID, MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS, MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT, MCE_B_ASSETS_PURCHASE.PICTURE, MCE_B_ASSETS_PURCHASE.CREATE_USER_ID, MCE_B_ASSETS_PURCHASE.ASSET_NAME, MCE_B_ASSETS_PURCHASE.PRV_NAME, MCE_B_ASSETS_PURCHASE.UNIT_ID, MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY, MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID, MCE_B_ASSETS_PURCHASE.COMMENTS, MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE, MCE_B_ASSETS_PURCHASE.PRV_ID, MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP, MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID, MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT, MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE, MCE_B_ASSETS_PURCHASE.PRODUCT_AREA, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, (case  when MCE_B_ASSETS_PURCHASE.STATE = 0 then '默认值' when MCE_B_ASSETS_PURCHASE.STATE = 1 then '编辑中' when MCE_B_ASSETS_PURCHASE.STATE = 2 then '已提交' when MCE_B_ASSETS_PURCHASE.STATE = 3 then '已审核' when MCE_B_ASSETS_PURCHASE.STATE = 4 then '已归档' when MCE_B_ASSETS_PURCHASE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_PURCHASE_TYPE_ID.NAME as PURCHASE_TYPE_ID_NAME from MCE_B_ASSETS_PURCHASE left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_TYPE   COM_TYPE_PURCHASE_TYPE_ID on MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = COM_TYPE_PURCHASE_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE2 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE3 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MONTH_INCOME = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRD_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLY_SITUATION_3 = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_SITUATION_2 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_SITUATION_1 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SPEC = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ASSET_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PRD_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.YEAR_INCOME = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.APPLY_PRICE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.UNIT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.IS_REPORT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREEUSE1 = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONFIGURATION = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATE = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.APPLY_COMMENTS = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ENCONOMY_EFFECT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PICTURE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ASSET_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.PRV_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.UNIT_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.APPLY_ESTIMATE_MONEY = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.PURCHASE_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.COMMENTS = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MONTH_EXAMINE = sqlReader.GetDecimal(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.PRV_ID = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.ASSET_HOUSE_MAP = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.APPLY_AMOUNT = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.IS_ASSET_HOUSE = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.PRODUCT_AREA = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.STATE_NAME = sqlReader.GetString(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.PURCHASE_TYPE_ID_NAME = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_PURCHASE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.FREEUSE2 = :U_FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.FREEUSE3 = :U_FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.REF_PRD_ID = :U_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRD_ID) ? string.Empty : obj.REF_PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONTH_INCOME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.MONTH_INCOME = :U_MONTH_INCOME");
				param = new OracleParameter();
				param.ParameterName = ":U_MONTH_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONTH_INCOME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.REF_PRV_ID = :U_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRV_ID) ? string.Empty : obj.REF_PRV_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_SITUATION_3"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_3 = :U_APPLY_SITUATION_3");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_SITUATION_3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = string.IsNullOrEmpty(obj.APPLY_SITUATION_3) ? string.Empty : obj.APPLY_SITUATION_3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_SITUATION_2"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_2 = :U_APPLY_SITUATION_2");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_SITUATION_2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = string.IsNullOrEmpty(obj.APPLY_SITUATION_2) ? string.Empty : obj.APPLY_SITUATION_2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_SITUATION_1"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_SITUATION_1 = :U_APPLY_SITUATION_1");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_SITUATION_1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 400;
				param.Value = string.IsNullOrEmpty(obj.APPLY_SITUATION_1) ? string.Empty : obj.APPLY_SITUATION_1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.TYPE_ID = :U_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_USED_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.REF_USED_AMOUNT = :U_REF_USED_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_USED_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REF_USED_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.ASSET_ID = :U_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_ID) ? string.Empty : obj.ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_USER_ID = :U_APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PRD_NAME = :U_PRD_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRD_NAME) ? string.Empty : obj.PRD_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("YEAR_INCOME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.YEAR_INCOME = :U_YEAR_INCOME");
				param = new OracleParameter();
				param.ParameterName = ":U_YEAR_INCOME";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.YEAR_INCOME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_PRICE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_PRICE = :U_APPLY_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_MONEY = :U_APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.UNIT_NAME = :U_UNIT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.UNIT_NAME) ? string.Empty : obj.UNIT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_DEPT_ID = :U_APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_DEPT_ID) ? string.Empty : obj.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_REPORT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.IS_REPORT = :U_IS_REPORT");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_REPORT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_REPORT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.FREEUSE1 = :U_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONFIGURATION"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.CONFIGURATION = :U_CONFIGURATION");
				param = new OracleParameter();
				param.ParameterName = ":U_CONFIGURATION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = string.IsNullOrEmpty(obj.CONFIGURATION) ? string.Empty : obj.CONFIGURATION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_COMMENTS = :U_APPLY_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.APPLY_COMMENTS) ? string.Empty : obj.APPLY_COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENCONOMY_EFFECT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.ENCONOMY_EFFECT = :U_ENCONOMY_EFFECT");
				param = new OracleParameter();
				param.ParameterName = ":U_ENCONOMY_EFFECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.ENCONOMY_EFFECT) ? string.Empty : obj.ENCONOMY_EFFECT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PICTURE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PICTURE = :U_PICTURE");
				param = new OracleParameter();
				param.ParameterName = ":U_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.PICTURE) ? string.Empty : obj.PICTURE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.ASSET_NAME = :U_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSET_NAME) ? string.Empty : obj.ASSET_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PRV_NAME = :U_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRV_NAME) ? string.Empty : obj.PRV_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_ESTIMATE_MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_ESTIMATE_MONEY = :U_APPLY_ESTIMATE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_ESTIMATE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_ESTIMATE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PURCHASE_TYPE_ID = :U_PURCHASE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PURCHASE_TYPE_ID) ? string.Empty : obj.PURCHASE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONTH_EXAMINE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.MONTH_EXAMINE = :U_MONTH_EXAMINE");
				param = new OracleParameter();
				param.ParameterName = ":U_MONTH_EXAMINE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONTH_EXAMINE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PRV_ID = :U_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRV_ID) ? string.Empty : obj.PRV_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_HOUSE_MAP"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.ASSET_HOUSE_MAP = :U_ASSET_HOUSE_MAP");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_HOUSE_MAP";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ASSET_HOUSE_MAP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.APPLY_AMOUNT = :U_APPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_ASSET_HOUSE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.IS_ASSET_HOUSE = :U_IS_ASSET_HOUSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_ASSET_HOUSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_ASSET_HOUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCT_AREA"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE.PRODUCT_AREA = :U_PRODUCT_AREA");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCT_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.PRODUCT_AREA) ? string.Empty : obj.PRODUCT_AREA;
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
