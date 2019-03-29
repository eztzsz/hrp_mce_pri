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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_INSTOCK_D))]
	public partial class HelperObject_MCE_B_ASSETS_INSTOCK_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_INSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_INSTOCK_D( CURRENCY_ID, COUNTRY, PRD_DATE, ASSETS_CODE, NAME, PRD_ID, ID, AMOUNT, PRD_CODE, BRAND, REF_TAB_NAME, REF_TAB_ID, ASSET_ID, BASE_ID, ASSETS_NAME, AOG_DATE, ASSET_TYPE_ID, ACCOUNT, SPEC, MONEY, SOURCES_FUNDS, DEPR_YEAR_AMOUNT, DEPR_TYPE_ID, CARD_CODE, MAINTENANCE_PERIOD_DATE, UNIT_ID, COMMENTS_D, PURCHARSE_PERSON, REF_PRD_ID, USING_DEPT_ID, PURCHARSE_DATE, ARRIVAL_DATE, PRICE) values ( :CURRENCY_ID, :COUNTRY, :PRD_DATE, :ASSETS_CODE, :NAME, :PRD_ID, :ID, :AMOUNT, :PRD_CODE, :BRAND, :REF_TAB_NAME, :REF_TAB_ID, :ASSET_ID, :BASE_ID, :ASSETS_NAME, :AOG_DATE, :ASSET_TYPE_ID, :ACCOUNT, :SPEC, :MONEY, :SOURCES_FUNDS, :DEPR_YEAR_AMOUNT, :DEPR_TYPE_ID, :CARD_CODE, :MAINTENANCE_PERIOD_DATE, :UNIT_ID, :COMMENTS_D, :PURCHARSE_PERSON, :REF_PRD_ID, :USING_DEPT_ID, :PURCHARSE_DATE, :ARRIVAL_DATE, :PRICE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[33];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CURRENCY_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COUNTRY";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.COUNTRY == null ? String.Empty:obj.COUNTRY;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PRD_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.PRD_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ASSETS_CODE";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PRD_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":AMOUNT";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.AMOUNT;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PRD_CODE";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.PRD_CODE == null ? String.Empty:obj.PRD_CODE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BRAND";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.BRAND == null ? String.Empty:obj.BRAND;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":REF_TAB_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":REF_TAB_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ASSET_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.ASSET_ID == null ? String.Empty:obj.ASSET_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":BASE_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":ASSETS_NAME";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":AOG_DATE";
			parameters[15].Size = 7;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[15].Value = obj.AOG_DATE;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":ASSET_TYPE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.ASSET_TYPE_ID == null ? String.Empty:obj.ASSET_TYPE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":ACCOUNT";
			parameters[17].Size = 50;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.ACCOUNT == null ? String.Empty:obj.ACCOUNT;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":SPEC";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":MONEY";
			parameters[19].Size = 22;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[19].Value = obj.MONEY;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":SOURCES_FUNDS";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.SOURCES_FUNDS == null ? String.Empty:obj.SOURCES_FUNDS;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":DEPR_YEAR_AMOUNT";
			parameters[21].Size = 22;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[21].Value = obj.DEPR_YEAR_AMOUNT;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":DEPR_TYPE_ID";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.DEPR_TYPE_ID == null ? String.Empty:obj.DEPR_TYPE_ID;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":CARD_CODE";
			parameters[23].Size = 50;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.CARD_CODE == null ? String.Empty:obj.CARD_CODE;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":MAINTENANCE_PERIOD_DATE";
			parameters[24].Size = 7;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[24].Value = obj.MAINTENANCE_PERIOD_DATE;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":UNIT_ID";
			parameters[25].Size = 36;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[25].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":COMMENTS_D";
			parameters[26].Size = 200;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.COMMENTS_D == null ? String.Empty:obj.COMMENTS_D;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":PURCHARSE_PERSON";
			parameters[27].Size = 50;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[27].Value = obj.PURCHARSE_PERSON == null ? String.Empty:obj.PURCHARSE_PERSON;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":REF_PRD_ID";
			parameters[28].Size = 36;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[28].Value = obj.REF_PRD_ID == null ? String.Empty:obj.REF_PRD_ID;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":USING_DEPT_ID";
			parameters[29].Size = 36;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[29].Value = obj.USING_DEPT_ID == null ? String.Empty:obj.USING_DEPT_ID;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":PURCHARSE_DATE";
			parameters[30].Size = 7;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[30].Value = obj.PURCHARSE_DATE;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":ARRIVAL_DATE";
			parameters[31].Size = 7;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[31].Value = obj.ARRIVAL_DATE;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":PRICE";
			parameters[32].Size = 22;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[32].Value = obj.PRICE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSTOCK_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_INSTOCK_D obj,CauseObject_MCE_B_ASSETS_INSTOCK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_INSTOCK_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_INSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_INSTOCK_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_INSTOCK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_INSTOCK_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_INSTOCK_D Get(EntityObject_MCE_B_ASSETS_INSTOCK_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CURRENCY_ID, COUNTRY, PRD_DATE, ASSETS_CODE, NAME, PRD_ID, ID, AMOUNT, PRD_CODE, BRAND, REF_TAB_NAME, REF_TAB_ID, ASSET_ID, BASE_ID, ASSETS_NAME, AOG_DATE, ASSET_TYPE_ID, ACCOUNT, SPEC, MONEY, SOURCES_FUNDS, DEPR_YEAR_AMOUNT, DEPR_TYPE_ID, CARD_CODE, MAINTENANCE_PERIOD_DATE, UNIT_ID, COMMENTS_D, PURCHARSE_PERSON, REF_PRD_ID, USING_DEPT_ID, PURCHARSE_DATE, ARRIVAL_DATE, PRICE from MCE_B_ASSETS_INSTOCK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_INSTOCK_D[] objs = new EntityObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D Get(DisplayObject_MCE_B_ASSETS_INSTOCK_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1) and MCE_B_ASSETS_INSTOCK_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_INSTOCK_D Get(EntityObject_MCE_B_ASSETS_INSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CURRENCY_ID, COUNTRY, PRD_DATE, ASSETS_CODE, NAME, PRD_ID, ID, AMOUNT, PRD_CODE, BRAND, REF_TAB_NAME, REF_TAB_ID, ASSET_ID, BASE_ID, ASSETS_NAME, AOG_DATE, ASSET_TYPE_ID, ACCOUNT, SPEC, MONEY, SOURCES_FUNDS, DEPR_YEAR_AMOUNT, DEPR_TYPE_ID, CARD_CODE, MAINTENANCE_PERIOD_DATE, UNIT_ID, COMMENTS_D, PURCHARSE_PERSON, REF_PRD_ID, USING_DEPT_ID, PURCHARSE_DATE, ARRIVAL_DATE, PRICE from MCE_B_ASSETS_INSTOCK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_INSTOCK_D[] objs = new EntityObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_INSTOCK_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "CURRENCY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COUNTRY))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.COUNTRY ").Append((cause.COUNTRY.StartsWith("%") || cause.COUNTRY.EndsWith("%")) ? " like " : " = ").Append(" :C_COUNTRY");
				param = new OracleParameter();
				param.ParameterName =":C_COUNTRY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.COUNTRY;
				paramList.Add(param);
			}
			if (cause.HasINValue("COUNTRY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "COUNTRY"));
			}
			if(cause.PRD_DATE!= null)
			{
				if (cause.PRD_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PRD_DATE >= :C_PRD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PRD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PRD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PRD_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PRD_DATE < :C_PRD_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PRD_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ID"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.AMOUNT = :C_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PRD_CODE ").Append((cause.PRD_CODE.StartsWith("%") || cause.PRD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PRD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BRAND))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.BRAND ").Append((cause.BRAND.StartsWith("%") || cause.BRAND.EndsWith("%")) ? " like " : " = ").Append(" :C_BRAND");
				param = new OracleParameter();
				param.ParameterName =":C_BRAND";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BRAND;
				paramList.Add(param);
			}
			if (cause.HasINValue("BRAND"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "BRAND"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "REF_TAB_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ASSET_ID ").Append((cause.ASSET_ID.StartsWith("%") || cause.ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ASSET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ASSETS_NAME"));
			}
			if(cause.AOG_DATE!= null)
			{
				if (cause.AOG_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.AOG_DATE >= :C_AOG_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AOG_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AOG_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.AOG_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.AOG_DATE < :C_AOG_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_AOG_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AOG_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("AOG_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "AOG_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID ").Append((cause.ASSET_TYPE_ID.StartsWith("%") || cause.ASSET_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ASSET_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "SPEC"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.SOURCES_FUNDS))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS ").Append((cause.SOURCES_FUNDS.StartsWith("%") || cause.SOURCES_FUNDS.EndsWith("%")) ? " like " : " = ").Append(" :C_SOURCES_FUNDS");
				param = new OracleParameter();
				param.ParameterName =":C_SOURCES_FUNDS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SOURCES_FUNDS;
				paramList.Add(param);
			}
			if (cause.HasINValue("SOURCES_FUNDS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "SOURCES_FUNDS"));
			}
			if(cause.DEPR_YEAR_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT = :C_DEPR_YEAR_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_YEAR_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPR_YEAR_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_YEAR_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "DEPR_YEAR_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.DEPR_TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID ").Append((cause.DEPR_TYPE_ID.StartsWith("%") || cause.DEPR_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPR_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPR_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPR_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPR_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "DEPR_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.CARD_CODE ").Append((cause.CARD_CODE.StartsWith("%") || cause.CARD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CARD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "CARD_CODE"));
			}
			if(cause.MAINTENANCE_PERIOD_DATE!= null)
			{
				if (cause.MAINTENANCE_PERIOD_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE >= :C_MAINTENANCE_PERIOD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MAINTENANCE_PERIOD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MAINTENANCE_PERIOD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.MAINTENANCE_PERIOD_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE < :C_MAINTENANCE_PERIOD_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "MAINTENANCE_PERIOD_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "UNIT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS_D))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.COMMENTS_D ").Append((cause.COMMENTS_D.StartsWith("%") || cause.COMMENTS_D.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS_D;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS_D"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "COMMENTS_D"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHARSE_PERSON))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON ").Append((cause.PURCHARSE_PERSON.StartsWith("%") || cause.PURCHARSE_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHARSE_PERSON");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHARSE_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PURCHARSE_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHARSE_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PURCHARSE_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID ").Append((cause.REF_PRD_ID.StartsWith("%") || cause.REF_PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "REF_PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID ").Append((cause.USING_DEPT_ID.StartsWith("%") || cause.USING_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "USING_DEPT_ID"));
			}
			if(cause.PURCHARSE_DATE!= null)
			{
				if (cause.PURCHARSE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE >= :C_PURCHARSE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PURCHARSE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PURCHARSE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PURCHARSE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE < :C_PURCHARSE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PURCHARSE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PURCHARSE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PURCHARSE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PURCHARSE_DATE"));
			}
			if(cause.ARRIVAL_DATE!= null)
			{
				if (cause.ARRIVAL_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE >= :C_ARRIVAL_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ARRIVAL_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ARRIVAL_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ARRIVAL_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE < :C_ARRIVAL_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ARRIVAL_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ARRIVAL_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ARRIVAL_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "ARRIVAL_DATE"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_INSTOCK_D.PRICE = :C_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_INSTOCK_D", "PRICE"));
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
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_INSTOCK_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_INSTOCK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_INSTOCK_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSTOCK_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_INSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_INSTOCK_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID, MCE_B_ASSETS_INSTOCK_D.COUNTRY, MCE_B_ASSETS_INSTOCK_D.PRD_DATE, MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE, MCE_B_ASSETS_INSTOCK_D.NAME, MCE_B_ASSETS_INSTOCK_D.PRD_ID, MCE_B_ASSETS_INSTOCK_D.ID, MCE_B_ASSETS_INSTOCK_D.AMOUNT, MCE_B_ASSETS_INSTOCK_D.PRD_CODE, MCE_B_ASSETS_INSTOCK_D.BRAND, MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME, MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID, MCE_B_ASSETS_INSTOCK_D.ASSET_ID, MCE_B_ASSETS_INSTOCK_D.BASE_ID, MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME, MCE_B_ASSETS_INSTOCK_D.AOG_DATE, MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.ACCOUNT, MCE_B_ASSETS_INSTOCK_D.SPEC, MCE_B_ASSETS_INSTOCK_D.MONEY, MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS, MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT, MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID, MCE_B_ASSETS_INSTOCK_D.CARD_CODE, MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE, MCE_B_ASSETS_INSTOCK_D.UNIT_ID, MCE_B_ASSETS_INSTOCK_D.COMMENTS_D, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON, MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID, MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID, MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE, MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE, MCE_B_ASSETS_INSTOCK_D.PRICE, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_COUNTRY.NAME as COUNTRY_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME, MCE_B_ASSETS_INSTOCK_BASE_ID.CODE as BASE_ID_NAME, MCE_D_MCE_TYPE_ASSET_TYPE_ID.NAME as ASSET_TYPE_ID_NAME, MCE_D_DEPR_TYPE_DEPR_TYPE_ID.NAME as DEPR_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_DEPART_USING_DEPT_ID.NAME as USING_DEPT_ID_NAME from MCE_B_ASSETS_INSTOCK_D left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_COUNTRY on MCE_B_ASSETS_INSTOCK_D.COUNTRY = COM_TYPE_COUNTRY.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MCE_B_ASSETS_INSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID left join MCE_B_ASSETS_INSTOCK   MCE_B_ASSETS_INSTOCK_BASE_ID on MCE_B_ASSETS_INSTOCK_D.BASE_ID = MCE_B_ASSETS_INSTOCK_BASE_ID.ID left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_ASSET_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = MCE_D_MCE_TYPE_ASSET_TYPE_ID.ID left join MCE_D_DEPR_TYPE   MCE_D_DEPR_TYPE_DEPR_TYPE_ID on MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = MCE_D_DEPR_TYPE_DEPR_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_INSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_DEPART   COM_DEPART_USING_DEPT_ID on MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = COM_DEPART_USING_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_INSTOCK_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_INSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_INSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COUNTRY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRD_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BRAND = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ASSET_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BASE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.AOG_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ASSET_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ACCOUNT = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SPEC = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SOURCES_FUNDS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.DEPR_YEAR_AMOUNT = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.DEPR_TYPE_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CARD_CODE = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MAINTENANCE_PERIOD_DATE = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.COMMENTS_D = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PURCHARSE_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ARRIVAL_DATE = sqlReader.GetDateTime(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PRICE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.COUNTRY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ASSET_TYPE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.DEPR_TYPE_ID_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_INSTOCK_D[] objs = new DisplayObject_MCE_B_ASSETS_INSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_INSTOCK_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COUNTRY"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.COUNTRY = :U_COUNTRY");
				param = new OracleParameter();
				param.ParameterName = ":U_COUNTRY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.COUNTRY) ? string.Empty : obj.COUNTRY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PRD_DATE = :U_PRD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PRD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.AMOUNT = :U_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PRD_CODE = :U_PRD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PRD_CODE) ? string.Empty : obj.PRD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BRAND"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.BRAND = :U_BRAND");
				param = new OracleParameter();
				param.ParameterName = ":U_BRAND";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BRAND) ? string.Empty : obj.BRAND;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.REF_TAB_NAME = :U_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.REF_TAB_ID = :U_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ASSET_ID = :U_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_ID) ? string.Empty : obj.ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AOG_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.AOG_DATE = :U_AOG_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AOG_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AOG_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ASSET_TYPE_ID = :U_ASSET_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_TYPE_ID) ? string.Empty : obj.ASSET_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ACCOUNT = :U_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT) ? string.Empty : obj.ACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SOURCES_FUNDS"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.SOURCES_FUNDS = :U_SOURCES_FUNDS");
				param = new OracleParameter();
				param.ParameterName = ":U_SOURCES_FUNDS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SOURCES_FUNDS) ? string.Empty : obj.SOURCES_FUNDS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_YEAR_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.DEPR_YEAR_AMOUNT = :U_DEPR_YEAR_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_YEAR_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DEPR_YEAR_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPR_TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.DEPR_TYPE_ID = :U_DEPR_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPR_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPR_TYPE_ID) ? string.Empty : obj.DEPR_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.CARD_CODE = :U_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CARD_CODE) ? string.Empty : obj.CARD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAINTENANCE_PERIOD_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.MAINTENANCE_PERIOD_DATE = :U_MAINTENANCE_PERIOD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_MAINTENANCE_PERIOD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MAINTENANCE_PERIOD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS_D"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.COMMENTS_D = :U_COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS_D) ? string.Empty : obj.COMMENTS_D;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHARSE_PERSON"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PURCHARSE_PERSON = :U_PURCHARSE_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHARSE_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PURCHARSE_PERSON) ? string.Empty : obj.PURCHARSE_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.REF_PRD_ID = :U_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRD_ID) ? string.Empty : obj.REF_PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.USING_DEPT_ID = :U_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID) ? string.Empty : obj.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHARSE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PURCHARSE_DATE = :U_PURCHARSE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHARSE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PURCHARSE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ARRIVAL_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.ARRIVAL_DATE = :U_ARRIVAL_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ARRIVAL_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ARRIVAL_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  MCE_B_ASSETS_INSTOCK_D.PRICE = :U_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
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
