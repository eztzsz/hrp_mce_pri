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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D))]
	public partial class HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_PURCHASE_PLAN_D( TYPE_ID, REF_USED_AMOUNT, COMMENTS, REF_TAB_NAME, SPEC, PRD_ID, ID, PRICE, CURRENCY_ID, REF_TAB_ID, ASSETS_ID, PRV_NAME, UNIT_ID, DELIVERY_DATE, ASSET_NAME, REF_PRV_ID, BASE_ID, MONEY, AMOUNT, ASSET_CODE, PRD_NAME, PRV_ID, REF_PRD_ID) values ( :TYPE_ID, :REF_USED_AMOUNT, :COMMENTS, :REF_TAB_NAME, :SPEC, :PRD_ID, :ID, :PRICE, :CURRENCY_ID, :REF_TAB_ID, :ASSETS_ID, :PRV_NAME, :UNIT_ID, :DELIVERY_DATE, :ASSET_NAME, :REF_PRV_ID, :BASE_ID, :MONEY, :AMOUNT, :ASSET_CODE, :PRD_NAME, :PRV_ID, :REF_PRD_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[23];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":TYPE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":REF_USED_AMOUNT";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.REF_USED_AMOUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":COMMENTS";
			parameters[2].Size = 200;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":REF_TAB_NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":SPEC";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
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
			parameters[7].ParameterName =":PRICE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.PRICE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CURRENCY_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CURRENCY_ID == null ? String.Empty:obj.CURRENCY_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":REF_TAB_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ASSETS_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":PRV_NAME";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.PRV_NAME == null ? String.Empty:obj.PRV_NAME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":UNIT_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":DELIVERY_DATE";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.DELIVERY_DATE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":ASSET_NAME";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.ASSET_NAME == null ? String.Empty:obj.ASSET_NAME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":REF_PRV_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.REF_PRV_ID == null ? String.Empty:obj.REF_PRV_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":BASE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":MONEY";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.MONEY;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":AMOUNT";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.AMOUNT;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":ASSET_CODE";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.ASSET_CODE == null ? String.Empty:obj.ASSET_CODE;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":PRD_NAME";
			parameters[20].Size = 100;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.PRD_NAME == null ? String.Empty:obj.PRD_NAME;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":PRV_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.PRV_ID == null ? String.Empty:obj.PRV_ID;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":REF_PRD_ID";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.REF_PRD_ID == null ? String.Empty:obj.REF_PRD_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE_PLAN_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj,CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_PURCHASE_PLAN_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_PURCHASE_PLAN_D where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_PURCHASE_PLAN_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  TYPE_ID, REF_USED_AMOUNT, COMMENTS, REF_TAB_NAME, SPEC, PRD_ID, ID, PRICE, CURRENCY_ID, REF_TAB_ID, ASSETS_ID, PRV_NAME, UNIT_ID, DELIVERY_DATE, ASSET_NAME, REF_PRV_ID, BASE_ID, MONEY, AMOUNT, ASSET_CODE, PRD_NAME, PRV_ID, REF_PRD_ID from MCE_B_ASSETS_PURCHASE_PLAN_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D Get(DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1) and MCE_B_ASSETS_PURCHASE_PLAN_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  TYPE_ID, REF_USED_AMOUNT, COMMENTS, REF_TAB_NAME, SPEC, PRD_ID, ID, PRICE, CURRENCY_ID, REF_TAB_ID, ASSETS_ID, PRV_NAME, UNIT_ID, DELIVERY_DATE, ASSET_NAME, REF_PRV_ID, BASE_ID, MONEY, AMOUNT, ASSET_CODE, PRD_NAME, PRV_ID, REF_PRD_ID from MCE_B_ASSETS_PURCHASE_PLAN_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "TYPE_ID"));
			}
			if(cause.REF_USED_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT = :C_REF_USED_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_REF_USED_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REF_USED_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_USED_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "REF_USED_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "REF_TAB_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "ID"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE = :C_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.CURRENCY_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID ").Append((cause.CURRENCY_ID.StartsWith("%") || cause.CURRENCY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CURRENCY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CURRENCY_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "CURRENCY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME ").Append((cause.PRV_NAME.StartsWith("%") || cause.PRV_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRV_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "PRV_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "UNIT_ID"));
			}
			if(cause.DELIVERY_DATE!= null)
			{
				if (cause.DELIVERY_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE >= :C_DELIVERY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_DELIVERY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DELIVERY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.DELIVERY_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE < :C_DELIVERY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_DELIVERY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DELIVERY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("DELIVERY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "DELIVERY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME ").Append((cause.ASSET_NAME.StartsWith("%") || cause.ASSET_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSET_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "ASSET_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID ").Append((cause.REF_PRV_ID.StartsWith("%") || cause.REF_PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "REF_PRV_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "BASE_ID"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "MONEY"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT = :C_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE ").Append((cause.ASSET_CODE.StartsWith("%") || cause.ASSET_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSET_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSET_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSET_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "ASSET_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME ").Append((cause.PRD_NAME.StartsWith("%") || cause.PRD_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRD_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "PRD_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PRV_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID ").Append((cause.PRV_ID.StartsWith("%") || cause.PRV_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRV_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRV_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRV_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "PRV_ID"));
			}
			if(!string.IsNullOrEmpty(cause.REF_PRD_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID ").Append((cause.REF_PRD_ID.StartsWith("%") || cause.REF_PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_PURCHASE_PLAN_D", "REF_PRD_ID"));
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
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE_PLAN_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE, MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY, MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT, MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE, MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME, MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID, MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID, MCE_D_MCE_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_TYPE_CURRENCY_ID.NAME as CURRENCY_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MCE_B_ASSETS_PURCHASE_BASE_ID.CODE as BASE_ID_NAME from MCE_B_ASSETS_PURCHASE_PLAN_D left join MCE_D_MCE_TYPE   MCE_D_MCE_TYPE_TYPE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = MCE_D_MCE_TYPE_TYPE_ID.ID left join COM_TYPE   COM_TYPE_CURRENCY_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = COM_TYPE_CURRENCY_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_B_ASSETS_PURCHASE   MCE_B_ASSETS_PURCHASE_BASE_ID on MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = MCE_B_ASSETS_PURCHASE_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_PURCHASE_PLAN_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REF_USED_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMMENTS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRD_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CURRENCY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRV_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DELIVERY_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ASSET_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.REF_PRV_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BASE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ASSET_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PRV_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.REF_PRD_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CURRENCY_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] objs = new DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.TYPE_ID = :U_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_USED_AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.REF_USED_AMOUNT = :U_REF_USED_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_USED_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REF_USED_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_NAME = :U_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.PRICE = :U_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CURRENCY_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.CURRENCY_ID = :U_CURRENCY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CURRENCY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CURRENCY_ID) ? string.Empty : obj.CURRENCY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.REF_TAB_ID = :U_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_NAME = :U_PRV_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRV_NAME) ? string.Empty : obj.PRV_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DELIVERY_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.DELIVERY_DATE = :U_DELIVERY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_DELIVERY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.DELIVERY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_NAME = :U_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSET_NAME) ? string.Empty : obj.ASSET_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRV_ID = :U_REF_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRV_ID) ? string.Empty : obj.REF_PRV_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.AMOUNT = :U_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.ASSET_CODE = :U_ASSET_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSET_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSET_CODE) ? string.Empty : obj.ASSET_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.PRD_NAME = :U_PRD_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRD_NAME) ? string.Empty : obj.PRD_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRV_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.PRV_ID = :U_PRV_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRV_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRV_ID) ? string.Empty : obj.PRV_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_PRD_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_PURCHASE_PLAN_D.REF_PRD_ID = :U_REF_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_PRD_ID) ? string.Empty : obj.REF_PRD_ID;
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
