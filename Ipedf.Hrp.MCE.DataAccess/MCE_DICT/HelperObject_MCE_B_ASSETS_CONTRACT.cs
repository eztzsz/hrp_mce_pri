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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_CONTRACT))]
	public partial class HelperObject_MCE_B_ASSETS_CONTRACT
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_CONTRACT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_CONTRACT( INPUT_PERSON, ASSETS_ID, NAME, ID, TYPE_ID, MODIFY_DEPT_ID, CONTRACT_CONTENT, CODE, EXPIRE_DATE, CREATE_TIME, AUDIT_TIME, AUDIT_STATE, SECOND_PARTY, FIRST_PARTY, CONTRACT_STATE, ARCHIVE_NO, MONEY, SIGN_DATE, AUDIT_USER_ID, SECOND_LINK_PERSON, CREATE_USER_ID, CHECK_DATE, STATE, SECOND_LINK_PHONE, ARCHIVIST, BACKUP1, CREATE_DEPT_ID, COMMENTS) values ( :INPUT_PERSON, :ASSETS_ID, :NAME, :ID, :TYPE_ID, :MODIFY_DEPT_ID, :CONTRACT_CONTENT, :CODE, :EXPIRE_DATE, :CREATE_TIME, :AUDIT_TIME, :AUDIT_STATE, :SECOND_PARTY, :FIRST_PARTY, :CONTRACT_STATE, :ARCHIVE_NO, :MONEY, :SIGN_DATE, :AUDIT_USER_ID, :SECOND_LINK_PERSON, :CREATE_USER_ID, :CHECK_DATE, :STATE, :SECOND_LINK_PHONE, :ARCHIVIST, :BACKUP1, :CREATE_DEPT_ID, :COMMENTS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[28];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":INPUT_PERSON";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.INPUT_PERSON == null ? String.Empty:obj.INPUT_PERSON;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ASSETS_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":NAME";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":TYPE_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MODIFY_DEPT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CONTRACT_CONTENT";
			parameters[6].Size = 3000;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.CONTRACT_CONTENT == null ? String.Empty:obj.CONTRACT_CONTENT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CODE";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":EXPIRE_DATE";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.EXPIRE_DATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.CREATE_TIME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":AUDIT_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.AUDIT_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":AUDIT_STATE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.AUDIT_STATE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":SECOND_PARTY";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.SECOND_PARTY == null ? String.Empty:obj.SECOND_PARTY;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":FIRST_PARTY";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.FIRST_PARTY == null ? String.Empty:obj.FIRST_PARTY;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CONTRACT_STATE";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.CONTRACT_STATE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":ARCHIVE_NO";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.ARCHIVE_NO == null ? String.Empty:obj.ARCHIVE_NO;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":MONEY";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.MONEY;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":SIGN_DATE";
			parameters[17].Size = 7;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[17].Value = obj.SIGN_DATE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":AUDIT_USER_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.AUDIT_USER_ID == null ? String.Empty:obj.AUDIT_USER_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":SECOND_LINK_PERSON";
			parameters[19].Size = 100;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.SECOND_LINK_PERSON == null ? String.Empty:obj.SECOND_LINK_PERSON;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":CREATE_USER_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":CHECK_DATE";
			parameters[21].Size = 7;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[21].Value = obj.CHECK_DATE;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":STATE";
			parameters[22].Size = 22;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[22].Value = obj.STATE;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":SECOND_LINK_PHONE";
			parameters[23].Size = 100;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.SECOND_LINK_PHONE == null ? String.Empty:obj.SECOND_LINK_PHONE;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":ARCHIVIST";
			parameters[24].Size = 36;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[24].Value = obj.ARCHIVIST == null ? String.Empty:obj.ARCHIVIST;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":BACKUP1";
			parameters[25].Size = 1000;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":CREATE_DEPT_ID";
			parameters[26].Size = 36;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":COMMENTS";
			parameters[27].Size = 200;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[27].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CONTRACT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CONTRACT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_CONTRACT obj,CauseObject_MCE_B_ASSETS_CONTRACT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_CONTRACT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_CONTRACT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_CONTRACT where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_CONTRACT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_CONTRACT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_CONTRACT Get(EntityObject_MCE_B_ASSETS_CONTRACT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  INPUT_PERSON, ASSETS_ID, NAME, ID, TYPE_ID, MODIFY_DEPT_ID, CONTRACT_CONTENT, CODE, EXPIRE_DATE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, AUDIT_TIME, AUDIT_STATE, SECOND_PARTY, FIRST_PARTY, CONTRACT_STATE, ARCHIVE_NO, MONEY, SIGN_DATE, AUDIT_USER_ID, SECOND_LINK_PERSON, CREATE_USER_ID, CHECK_DATE, STATE, SECOND_LINK_PHONE, ARCHIVIST, BACKUP1, CREATE_DEPT_ID, COMMENTS from MCE_B_ASSETS_CONTRACT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_CONTRACT[] objs = new EntityObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT Get(DisplayObject_MCE_B_ASSETS_CONTRACT obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1) and MCE_B_ASSETS_CONTRACT.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_CONTRACT Get(EntityObject_MCE_B_ASSETS_CONTRACT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  INPUT_PERSON, ASSETS_ID, NAME, ID, TYPE_ID, MODIFY_DEPT_ID, CONTRACT_CONTENT, CODE, EXPIRE_DATE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, AUDIT_TIME, AUDIT_STATE, SECOND_PARTY, FIRST_PARTY, CONTRACT_STATE, ARCHIVE_NO, MONEY, SIGN_DATE, AUDIT_USER_ID, SECOND_LINK_PERSON, CREATE_USER_ID, CHECK_DATE, STATE, SECOND_LINK_PHONE, ARCHIVIST, BACKUP1, CREATE_DEPT_ID, COMMENTS from MCE_B_ASSETS_CONTRACT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_CONTRACT[] objs = new EntityObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_CONTRACT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.INPUT_PERSON))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.INPUT_PERSON ").Append((cause.INPUT_PERSON.StartsWith("%") || cause.INPUT_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :C_INPUT_PERSON");
				param = new OracleParameter();
				param.ParameterName =":C_INPUT_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.INPUT_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("INPUT_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "INPUT_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CONTRACT_CONTENT))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT ").Append((cause.CONTRACT_CONTENT.StartsWith("%") || cause.CONTRACT_CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTRACT_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTRACT_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 3000;
				param.Value = cause.CONTRACT_CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTRACT_CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CONTRACT_CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CODE"));
			}
			if(cause.EXPIRE_DATE!= null)
			{
				if (cause.EXPIRE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.EXPIRE_DATE >= :C_EXPIRE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_EXPIRE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXPIRE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.EXPIRE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.EXPIRE_DATE < :C_EXPIRE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_EXPIRE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXPIRE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("EXPIRE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "EXPIRE_DATE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "MODIFY_TIME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "MODIFY_USER_ID"));
			}
			if(cause.AUDIT_TIME!= null)
			{
				if (cause.AUDIT_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.AUDIT_TIME >= :C_AUDIT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_AUDIT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.AUDIT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.AUDIT_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.AUDIT_TIME < :C_AUDIT_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "AUDIT_TIME"));
			}
			if(cause.AUDIT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.AUDIT_STATE = :C_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AUDIT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "AUDIT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SECOND_PARTY))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.SECOND_PARTY ").Append((cause.SECOND_PARTY.StartsWith("%") || cause.SECOND_PARTY.EndsWith("%")) ? " like " : " = ").Append(" :C_SECOND_PARTY");
				param = new OracleParameter();
				param.ParameterName =":C_SECOND_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SECOND_PARTY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECOND_PARTY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "SECOND_PARTY"));
			}
			if(!string.IsNullOrEmpty(cause.FIRST_PARTY))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.FIRST_PARTY ").Append((cause.FIRST_PARTY.StartsWith("%") || cause.FIRST_PARTY.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRST_PARTY");
				param = new OracleParameter();
				param.ParameterName =":C_FIRST_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FIRST_PARTY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRST_PARTY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "FIRST_PARTY"));
			}
			if(cause.CONTRACT_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = :C_CONTRACT_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_CONTRACT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTRACT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTRACT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CONTRACT_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.ARCHIVE_NO))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.ARCHIVE_NO ").Append((cause.ARCHIVE_NO.StartsWith("%") || cause.ARCHIVE_NO.EndsWith("%")) ? " like " : " = ").Append(" :C_ARCHIVE_NO");
				param = new OracleParameter();
				param.ParameterName =":C_ARCHIVE_NO";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ARCHIVE_NO;
				paramList.Add(param);
			}
			if (cause.HasINValue("ARCHIVE_NO"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "ARCHIVE_NO"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "MONEY"));
			}
			if(cause.SIGN_DATE!= null)
			{
				if (cause.SIGN_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.SIGN_DATE >= :C_SIGN_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_SIGN_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SIGN_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.SIGN_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.SIGN_DATE < :C_SIGN_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_SIGN_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SIGN_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("SIGN_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "SIGN_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.AUDIT_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID ").Append((cause.AUDIT_USER_ID.StartsWith("%") || cause.AUDIT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("AUDIT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "AUDIT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SECOND_LINK_PERSON))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON ").Append((cause.SECOND_LINK_PERSON.StartsWith("%") || cause.SECOND_LINK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :C_SECOND_LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":C_SECOND_LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SECOND_LINK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECOND_LINK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "SECOND_LINK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CREATE_USER_ID"));
			}
			if(cause.CHECK_DATE!= null)
			{
				if (cause.CHECK_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CHECK_DATE >= :C_CHECK_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CHECK_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CHECK_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CHECK_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CHECK_DATE < :C_CHECK_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CHECK_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CHECK_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CHECK_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CHECK_DATE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SECOND_LINK_PHONE))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE ").Append((cause.SECOND_LINK_PHONE.StartsWith("%") || cause.SECOND_LINK_PHONE.EndsWith("%")) ? " like " : " = ").Append(" :C_SECOND_LINK_PHONE");
				param = new OracleParameter();
				param.ParameterName =":C_SECOND_LINK_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SECOND_LINK_PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECOND_LINK_PHONE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "SECOND_LINK_PHONE"));
			}
			if(!string.IsNullOrEmpty(cause.ARCHIVIST))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.ARCHIVIST ").Append((cause.ARCHIVIST.StartsWith("%") || cause.ARCHIVIST.EndsWith("%")) ? " like " : " = ").Append(" :C_ARCHIVIST");
				param = new OracleParameter();
				param.ParameterName =":C_ARCHIVIST";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ARCHIVIST;
				paramList.Add(param);
			}
			if (cause.HasINValue("ARCHIVIST"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "ARCHIVIST"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_CONTRACT.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_CONTRACT", "COMMENTS"));
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
		public static DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CONTRACT",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_CONTRACT.INPUT_PERSON, MCE_B_ASSETS_CONTRACT.ASSETS_ID, MCE_B_ASSETS_CONTRACT.NAME, MCE_B_ASSETS_CONTRACT.ID, MCE_B_ASSETS_CONTRACT.TYPE_ID, MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID, MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT, MCE_B_ASSETS_CONTRACT.CODE, MCE_B_ASSETS_CONTRACT.EXPIRE_DATE, MCE_B_ASSETS_CONTRACT.MODIFY_TIME, MCE_B_ASSETS_CONTRACT.CREATE_TIME, MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID, MCE_B_ASSETS_CONTRACT.AUDIT_TIME, MCE_B_ASSETS_CONTRACT.AUDIT_STATE, MCE_B_ASSETS_CONTRACT.SECOND_PARTY, MCE_B_ASSETS_CONTRACT.FIRST_PARTY, MCE_B_ASSETS_CONTRACT.CONTRACT_STATE, MCE_B_ASSETS_CONTRACT.ARCHIVE_NO, MCE_B_ASSETS_CONTRACT.MONEY, MCE_B_ASSETS_CONTRACT.SIGN_DATE, MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON, MCE_B_ASSETS_CONTRACT.CREATE_USER_ID, MCE_B_ASSETS_CONTRACT.CHECK_DATE, MCE_B_ASSETS_CONTRACT.STATE, MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE, MCE_B_ASSETS_CONTRACT.ARCHIVIST, MCE_B_ASSETS_CONTRACT.BACKUP1, MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID, MCE_B_ASSETS_CONTRACT.COMMENTS, COM_USER_INPUT_PERSON.NAME as INPUT_PERSON_NAME, MCE_B_ASSETS_ASSETS_ID.ASSETS_NAME as ASSETS_ID_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, (case  when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.AUDIT_STATE = 9 then '已作废' else '' end ) as AUDIT_STATE_NAME, MDM_D_DEPT_SECOND_PARTY.NAME as SECOND_PARTY_NAME, COM_DEPART_FIRST_PARTY.NAME as FIRST_PARTY_NAME, (case  when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 1 then '正常' when MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = 2 then '终止' else '' end ) as CONTRACT_STATE_NAME, (case  when MCE_B_ASSETS_CONTRACT.STATE = 0 then '默认值' when MCE_B_ASSETS_CONTRACT.STATE = 1 then '编辑中' when MCE_B_ASSETS_CONTRACT.STATE = 2 then '已提交' when MCE_B_ASSETS_CONTRACT.STATE = 3 then '已审核' when MCE_B_ASSETS_CONTRACT.STATE = 4 then '已归档' when MCE_B_ASSETS_CONTRACT.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_USER_ARCHIVIST.NAME as ARCHIVIST_NAME from MCE_B_ASSETS_CONTRACT left join COM_USER   COM_USER_INPUT_PERSON on MCE_B_ASSETS_CONTRACT.INPUT_PERSON = COM_USER_INPUT_PERSON.ID left join MCE_B_ASSETS   MCE_B_ASSETS_ASSETS_ID on MCE_B_ASSETS_CONTRACT.ASSETS_ID = MCE_B_ASSETS_ASSETS_ID.ID left join COM_TYPE   COM_TYPE_TYPE_ID on MCE_B_ASSETS_CONTRACT.TYPE_ID = COM_TYPE_TYPE_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_SECOND_PARTY on MCE_B_ASSETS_CONTRACT.SECOND_PARTY = MDM_D_DEPT_SECOND_PARTY.ID left join COM_DEPART   COM_DEPART_FIRST_PARTY on MCE_B_ASSETS_CONTRACT.FIRST_PARTY = COM_DEPART_FIRST_PARTY.ID left join COM_USER   COM_USER_ARCHIVIST on MCE_B_ASSETS_CONTRACT.ARCHIVIST = COM_USER_ARCHIVIST.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_CONTRACT",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_CONTRACT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_CONTRACT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.INPUT_PERSON = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ASSETS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTRACT_CONTENT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXPIRE_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.AUDIT_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AUDIT_STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SECOND_PARTY = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FIRST_PARTY = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CONTRACT_STATE = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ARCHIVE_NO = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MONEY = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SIGN_DATE = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AUDIT_USER_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.SECOND_LINK_PERSON = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.CHECK_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SECOND_LINK_PHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ARCHIVIST = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BACKUP1 = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.COMMENTS = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.INPUT_PERSON_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ASSETS_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.AUDIT_STATE_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.SECOND_PARTY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FIRST_PARTY_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CONTRACT_STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.STATE_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ARCHIVIST_NAME = sqlReader.GetString(38);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_CONTRACT[] objs = new DisplayObject_MCE_B_ASSETS_CONTRACT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_CONTRACT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("INPUT_PERSON"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.INPUT_PERSON = :U_INPUT_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":U_INPUT_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.INPUT_PERSON) ? string.Empty : obj.INPUT_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.TYPE_ID = :U_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTRACT_CONTENT"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.CONTRACT_CONTENT = :U_CONTRACT_CONTENT");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTRACT_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 3000;
				param.Value = string.IsNullOrEmpty(obj.CONTRACT_CONTENT) ? string.Empty : obj.CONTRACT_CONTENT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXPIRE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.EXPIRE_DATE = :U_EXPIRE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_EXPIRE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.EXPIRE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_TIME"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.AUDIT_TIME = :U_AUDIT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.AUDIT_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.AUDIT_STATE = :U_AUDIT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AUDIT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECOND_PARTY"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.SECOND_PARTY = :U_SECOND_PARTY");
				param = new OracleParameter();
				param.ParameterName = ":U_SECOND_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SECOND_PARTY) ? string.Empty : obj.SECOND_PARTY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FIRST_PARTY"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.FIRST_PARTY = :U_FIRST_PARTY");
				param = new OracleParameter();
				param.ParameterName = ":U_FIRST_PARTY";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FIRST_PARTY) ? string.Empty : obj.FIRST_PARTY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTRACT_STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.CONTRACT_STATE = :U_CONTRACT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTRACT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTRACT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ARCHIVE_NO"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.ARCHIVE_NO = :U_ARCHIVE_NO");
				param = new OracleParameter();
				param.ParameterName = ":U_ARCHIVE_NO";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ARCHIVE_NO) ? string.Empty : obj.ARCHIVE_NO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SIGN_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.SIGN_DATE = :U_SIGN_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_SIGN_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.SIGN_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AUDIT_USER_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.AUDIT_USER_ID = :U_AUDIT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_AUDIT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.AUDIT_USER_ID) ? string.Empty : obj.AUDIT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECOND_LINK_PERSON"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.SECOND_LINK_PERSON = :U_SECOND_LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":U_SECOND_LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SECOND_LINK_PERSON) ? string.Empty : obj.SECOND_LINK_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHECK_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.CHECK_DATE = :U_CHECK_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CHECK_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CHECK_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECOND_LINK_PHONE"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.SECOND_LINK_PHONE = :U_SECOND_LINK_PHONE");
				param = new OracleParameter();
				param.ParameterName = ":U_SECOND_LINK_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SECOND_LINK_PHONE) ? string.Empty : obj.SECOND_LINK_PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ARCHIVIST"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.ARCHIVIST = :U_ARCHIVIST");
				param = new OracleParameter();
				param.ParameterName = ":U_ARCHIVIST";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ARCHIVIST) ? string.Empty : obj.ARCHIVIST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_CONTRACT.COMMENTS = :U_COMMENTS");
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
