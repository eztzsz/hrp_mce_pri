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
	[CauseObject(typeof(CauseObject_MCE_B_AOG))]
	public partial class HelperObject_MCE_B_AOG
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_AOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_AOG( AUDIT_TIME, USE_DEPT_ID, INVOICE_CODE, NAME, ID, USE_USER_ID, DATA_ORGANISE_ID, CODE, IS_INSTOCK, CREATE_TIME, PROVIDER_ID, STATE, CREATE_DATE, AUDIT_USER_ID, PURCHARSE_HT_NUM, INSTALL_USER_ID, CREATE_USER_ID, COMMENTS, CREATE_DEPART_ID, PURCHARSE_PERSON, DEALER_ID, PURCHARSE_PERSON_ID, TOTAL_MONEY) values ( :AUDIT_TIME, :USE_DEPT_ID, :INVOICE_CODE, :NAME, :ID, :USE_USER_ID, :DATA_ORGANISE_ID, :CODE, :IS_INSTOCK, :CREATE_TIME, :PROVIDER_ID, :STATE, :CREATE_DATE, :AUDIT_USER_ID, :PURCHARSE_HT_NUM, :INSTALL_USER_ID, :CREATE_USER_ID, :COMMENTS, :CREATE_DEPART_ID, :PURCHARSE_PERSON, :DEALER_ID, :PURCHARSE_PERSON_ID, :TOTAL_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[23];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":AUDIT_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.AUDIT_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":USE_DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.USE_DEPT_ID == null ? String.Empty:obj.USE_DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":INVOICE_CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.INVOICE_CODE == null ? String.Empty:obj.INVOICE_CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":USE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.USE_USER_ID == null ? String.Empty:obj.USE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DATA_ORGANISE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":IS_INSTOCK";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.IS_INSTOCK;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.CREATE_TIME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PROVIDER_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.PROVIDER_ID == null ? String.Empty:obj.PROVIDER_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":STATE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.STATE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_DATE";
			parameters[12].Size = 7;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[12].Value = obj.CREATE_DATE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":AUDIT_USER_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":PURCHARSE_HT_NUM";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.PURCHARSE_HT_NUM == null ? String.Empty:obj.PURCHARSE_HT_NUM;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":INSTALL_USER_ID";
			parameters[15].Size = 50;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.INSTALL_USER_ID == null ? String.Empty:obj.INSTALL_USER_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CREATE_USER_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":COMMENTS";
			parameters[17].Size = 200;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":CREATE_DEPART_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":PURCHARSE_PERSON";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.PURCHARSE_PERSON == null ? String.Empty:obj.PURCHARSE_PERSON;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":DEALER_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.DEALER_ID == null ? String.Empty:obj.DEALER_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":PURCHARSE_PERSON_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.PURCHARSE_PERSON_ID == null ? String.Empty:obj.PURCHARSE_PERSON_ID;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":TOTAL_MONEY";
			parameters[22].Size = 22;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[22].Value = obj.TOTAL_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_AOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_AOG set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_AOG obj,CauseObject_MCE_B_AOG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_AOG set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_AOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_AOG where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_AOG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_AOG where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_AOG Get(EntityObject_MCE_B_AOG obj)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, USE_DEPT_ID, INVOICE_CODE, MODIFY_DEPART_ID, NAME, ID, USE_USER_ID, DATA_ORGANISE_ID, CODE, IS_INSTOCK, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, PROVIDER_ID, STATE, CREATE_DATE, AUDIT_USER_ID, PURCHARSE_HT_NUM, INSTALL_USER_ID, CREATE_USER_ID, COMMENTS, CREATE_DEPART_ID, PURCHARSE_PERSON, DEALER_ID, PURCHARSE_PERSON_ID, TOTAL_MONEY from MCE_B_AOG where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_AOG[] objs = new EntityObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_AOG Get(DisplayObject_MCE_B_AOG obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1) and MCE_B_AOG.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_AOG Get(EntityObject_MCE_B_AOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  AUDIT_TIME, USE_DEPT_ID, INVOICE_CODE, MODIFY_DEPART_ID, NAME, ID, USE_USER_ID, DATA_ORGANISE_ID, CODE, IS_INSTOCK, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, PROVIDER_ID, STATE, CREATE_DATE, AUDIT_USER_ID, PURCHARSE_HT_NUM, INSTALL_USER_ID, CREATE_USER_ID, COMMENTS, CREATE_DEPART_ID, PURCHARSE_PERSON, DEALER_ID, PURCHARSE_PERSON_ID, TOTAL_MONEY from MCE_B_AOG where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_AOG[] objs = new EntityObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_AOG[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_AOG cause,out OracleParameter[] parameters )
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
					strBuf.Append(" And MCE_B_AOG.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_AOG.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "AUDIT_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.USE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_AOG.USE_DEPT_ID ").Append((cause.USE_DEPT_ID.StartsWith("%") || cause.USE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "USE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.INVOICE_CODE))
			{
				strBuf.Append(" And MCE_B_AOG.INVOICE_CODE ").Append((cause.INVOICE_CODE.StartsWith("%") || cause.INVOICE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INVOICE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INVOICE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "INVOICE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_AOG.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_AOG.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_AOG.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.USE_USER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.USE_USER_ID ").Append((cause.USE_USER_ID.StartsWith("%") || cause.USE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "USE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_B_AOG.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_AOG.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "CODE"));
			}
			if(cause.IS_INSTOCK!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_AOG.IS_INSTOCK = :C_IS_INSTOCK");
				param = new OracleParameter();
				param.ParameterName =":C_IS_INSTOCK";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_INSTOCK;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_INSTOCK"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "IS_INSTOCK"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_AOG.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_AOG.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "MODIFY_TIME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_AOG.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_AOG.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PROVIDER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.PROVIDER_ID ").Append((cause.PROVIDER_ID.StartsWith("%") || cause.PROVIDER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROVIDER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROVIDER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "PROVIDER_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_AOG.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "STATE"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_AOG.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_AOG.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHARSE_HT_NUM))
			{
				strBuf.Append(" And MCE_B_AOG.PURCHARSE_HT_NUM ").Append((cause.PURCHARSE_HT_NUM.StartsWith("%") || cause.PURCHARSE_HT_NUM.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHARSE_HT_NUM");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHARSE_HT_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PURCHARSE_HT_NUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHARSE_HT_NUM"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "PURCHARSE_HT_NUM"));
			}
			if(!string.IsNullOrEmpty(cause.INSTALL_USER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.INSTALL_USER_ID ").Append((cause.INSTALL_USER_ID.StartsWith("%") || cause.INSTALL_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_INSTALL_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_INSTALL_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INSTALL_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTALL_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "INSTALL_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_AOG.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And MCE_B_AOG.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHARSE_PERSON))
			{
				strBuf.Append(" And MCE_B_AOG.PURCHARSE_PERSON ").Append((cause.PURCHARSE_PERSON.StartsWith("%") || cause.PURCHARSE_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHARSE_PERSON");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHARSE_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PURCHARSE_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHARSE_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "PURCHARSE_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.DEALER_ID))
			{
				strBuf.Append(" And MCE_B_AOG.DEALER_ID ").Append((cause.DEALER_ID.StartsWith("%") || cause.DEALER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEALER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEALER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEALER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEALER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "DEALER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PURCHARSE_PERSON_ID))
			{
				strBuf.Append(" And MCE_B_AOG.PURCHARSE_PERSON_ID ").Append((cause.PURCHARSE_PERSON_ID.StartsWith("%") || cause.PURCHARSE_PERSON_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PURCHARSE_PERSON_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PURCHARSE_PERSON_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PURCHARSE_PERSON_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHARSE_PERSON_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "PURCHARSE_PERSON_ID"));
			}
			if(cause.TOTAL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_AOG.TOTAL_MONEY = :C_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.TOTAL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("TOTAL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_AOG", "TOTAL_MONEY"));
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
		public static DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_AOG",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_AOG.AUDIT_TIME, MCE_B_AOG.USE_DEPT_ID, MCE_B_AOG.INVOICE_CODE, MCE_B_AOG.MODIFY_DEPART_ID, MCE_B_AOG.NAME, MCE_B_AOG.ID, MCE_B_AOG.USE_USER_ID, MCE_B_AOG.DATA_ORGANISE_ID, MCE_B_AOG.CODE, MCE_B_AOG.IS_INSTOCK, MCE_B_AOG.MODIFY_TIME, MCE_B_AOG.CREATE_TIME, MCE_B_AOG.MODIFY_USER_ID, MCE_B_AOG.PROVIDER_ID, MCE_B_AOG.STATE, MCE_B_AOG.CREATE_DATE, MCE_B_AOG.AUDIT_USER_ID, MCE_B_AOG.PURCHARSE_HT_NUM, MCE_B_AOG.INSTALL_USER_ID, MCE_B_AOG.CREATE_USER_ID, MCE_B_AOG.COMMENTS, MCE_B_AOG.CREATE_DEPART_ID, MCE_B_AOG.PURCHARSE_PERSON, MCE_B_AOG.DEALER_ID, MCE_B_AOG.PURCHARSE_PERSON_ID, MCE_B_AOG.TOTAL_MONEY, COM_DEPART_USE_DEPT_ID.NAME as USE_DEPT_ID_NAME, COM_USER_USE_USER_ID.NAME as USE_USER_ID_NAME, (case  when MCE_B_AOG.IS_INSTOCK = 1 then '是' when MCE_B_AOG.IS_INSTOCK = 2 then '否' else '' end ) as IS_INSTOCK_NAME, MDM_D_DEPT_PROVIDER_ID.NAME as PROVIDER_ID_NAME, (case  when MCE_B_AOG.STATE = 0 then '默认值' when MCE_B_AOG.STATE = 1 then '编辑中' when MCE_B_AOG.STATE = 2 then '已提交' when MCE_B_AOG.STATE = 3 then '已审核' when MCE_B_AOG.STATE = 4 then '已归档' when MCE_B_AOG.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_INSTALL_USER_ID.NAME as INSTALL_USER_ID_NAME, MDM_D_DEPT_DEALER_ID.NAME as DEALER_ID_NAME, COM_USER_PURCHARSE_PERSON_ID.NAME as PURCHARSE_PERSON_ID_NAME from MCE_B_AOG left join COM_DEPART   COM_DEPART_USE_DEPT_ID on MCE_B_AOG.USE_DEPT_ID = COM_DEPART_USE_DEPT_ID.ID left join COM_USER   COM_USER_USE_USER_ID on MCE_B_AOG.USE_USER_ID = COM_USER_USE_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PROVIDER_ID on MCE_B_AOG.PROVIDER_ID = MDM_D_DEPT_PROVIDER_ID.ID left join COM_USER   COM_USER_INSTALL_USER_ID on MCE_B_AOG.INSTALL_USER_ID = COM_USER_INSTALL_USER_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_DEALER_ID on MCE_B_AOG.DEALER_ID = MDM_D_DEPT_DEALER_ID.ID left join COM_USER   COM_USER_PURCHARSE_PERSON_ID on MCE_B_AOG.PURCHARSE_PERSON_ID = COM_USER_PURCHARSE_PERSON_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_AOG",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_AOG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_AOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_INSTOCK = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PROVIDER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PURCHARSE_HT_NUM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.INSTALL_USER_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.COMMENTS = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.PURCHARSE_PERSON = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DEALER_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURCHARSE_PERSON_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TOTAL_MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.USE_DEPT_ID_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.USE_USER_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_INSTOCK_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PROVIDER_ID_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.STATE_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.INSTALL_USER_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.DEALER_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PURCHARSE_PERSON_ID_NAME = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_AOG[] objs = new DisplayObject_MCE_B_AOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_AOG obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_AOG.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_AOG.USE_DEPT_ID = :U_USE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USE_DEPT_ID) ? string.Empty : obj.USE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVOICE_CODE"))
			{
				strBuf.Add("  MCE_B_AOG.INVOICE_CODE = :U_INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INVOICE_CODE) ? string.Empty : obj.INVOICE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  MCE_B_AOG.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_AOG.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USE_USER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.USE_USER_ID = :U_USE_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USE_USER_ID) ? string.Empty : obj.USE_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_B_AOG.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_AOG.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_INSTOCK"))
			{
				strBuf.Add("  MCE_B_AOG.IS_INSTOCK = :U_IS_INSTOCK");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_INSTOCK";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_INSTOCK;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_AOG.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PROVIDER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.PROVIDER_ID = :U_PROVIDER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PROVIDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROVIDER_ID) ? string.Empty : obj.PROVIDER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_AOG.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_AOG.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHARSE_HT_NUM"))
			{
				strBuf.Add("  MCE_B_AOG.PURCHARSE_HT_NUM = :U_PURCHARSE_HT_NUM");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHARSE_HT_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PURCHARSE_HT_NUM) ? string.Empty : obj.PURCHARSE_HT_NUM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSTALL_USER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.INSTALL_USER_ID = :U_INSTALL_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_INSTALL_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INSTALL_USER_ID) ? string.Empty : obj.INSTALL_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_AOG.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHARSE_PERSON"))
			{
				strBuf.Add("  MCE_B_AOG.PURCHARSE_PERSON = :U_PURCHARSE_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHARSE_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PURCHARSE_PERSON) ? string.Empty : obj.PURCHARSE_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEALER_ID"))
			{
				strBuf.Add("  MCE_B_AOG.DEALER_ID = :U_DEALER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEALER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEALER_ID) ? string.Empty : obj.DEALER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHARSE_PERSON_ID"))
			{
				strBuf.Add("  MCE_B_AOG.PURCHARSE_PERSON_ID = :U_PURCHARSE_PERSON_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHARSE_PERSON_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PURCHARSE_PERSON_ID) ? string.Empty : obj.PURCHARSE_PERSON_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TOTAL_MONEY"))
			{
				strBuf.Add("  MCE_B_AOG.TOTAL_MONEY = :U_TOTAL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_TOTAL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.TOTAL_MONEY;
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
