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
	[CauseObject(typeof(CauseObject_MCE_D_MCE_TYPE))]
	public partial class HelperObject_MCE_D_MCE_TYPE
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_D_MCE_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_D_MCE_TYPE( IS_END, CREATE_DEPT_ID, DATA_ORGANISE_ID, STATUS, ID, CREATE_USER_ID, FINANCE_CODE, UNIT_ID, STATE, FINANCE_NAME, PARENT_ID, CUSTOM_CODE, MODIFY_DEPT_ID, CODE, FIVE_STROKE_CODE, COMMENTS, CREATE_TIME, SPELL_CODE, INTERNATIONAL_CODE, NAME, IDIENTY_TYPE, ORDER_INDEX) values ( :IS_END, :CREATE_DEPT_ID, :DATA_ORGANISE_ID, :STATUS, :ID, :CREATE_USER_ID, :FINANCE_CODE, :UNIT_ID, :STATE, :FINANCE_NAME, :PARENT_ID, :CUSTOM_CODE, :MODIFY_DEPT_ID, :CODE, :FIVE_STROKE_CODE, :COMMENTS, :CREATE_TIME, :SPELL_CODE, :INTERNATIONAL_CODE, :NAME, :IDIENTY_TYPE, :ORDER_INDEX)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[22];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":IS_END";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.IS_END;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CREATE_DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DATA_ORGANISE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STATUS";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.STATUS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CREATE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":FINANCE_CODE";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.FINANCE_CODE == null ? String.Empty:obj.FINANCE_CODE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":UNIT_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":STATE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.STATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":FINANCE_NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.FINANCE_NAME == null ? String.Empty:obj.FINANCE_NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PARENT_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.PARENT_ID == null ? String.Empty:obj.PARENT_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CUSTOM_CODE";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.CUSTOM_CODE == null ? String.Empty:obj.CUSTOM_CODE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MODIFY_DEPT_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CODE";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":FIVE_STROKE_CODE";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.FIVE_STROKE_CODE == null ? String.Empty:obj.FIVE_STROKE_CODE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":COMMENTS";
			parameters[15].Size = 200;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CREATE_TIME";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.CREATE_TIME;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":SPELL_CODE";
			parameters[17].Size = 50;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":INTERNATIONAL_CODE";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.INTERNATIONAL_CODE == null ? String.Empty:obj.INTERNATIONAL_CODE;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":NAME";
			parameters[19].Size = 80;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":IDIENTY_TYPE";
			parameters[20].Size = 2;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.IDIENTY_TYPE == null ? String.Empty:obj.IDIENTY_TYPE;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":ORDER_INDEX";
			parameters[21].Size = 22;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[21].Value = obj.ORDER_INDEX;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_D_MCE_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_D_MCE_TYPE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_D_MCE_TYPE obj,CauseObject_MCE_D_MCE_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_D_MCE_TYPE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_D_MCE_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_D_MCE_TYPE where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_D_MCE_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_D_MCE_TYPE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_D_MCE_TYPE Get(EntityObject_MCE_D_MCE_TYPE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  IS_END, CREATE_DEPT_ID, MODIFY_TIME, DATA_ORGANISE_ID, STATUS, ID, CREATE_USER_ID, MODIFY_USER_ID, FINANCE_CODE, UNIT_ID, STATE, FINANCE_NAME, PARENT_ID, CUSTOM_CODE, MODIFY_DEPT_ID, CODE, FIVE_STROKE_CODE, COMMENTS, CREATE_TIME, SPELL_CODE, INTERNATIONAL_CODE, NAME, IDIENTY_TYPE, ORDER_INDEX from MCE_D_MCE_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_D_MCE_TYPE[] objs = new EntityObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_D_MCE_TYPE Get(DisplayObject_MCE_D_MCE_TYPE obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1) and MCE_D_MCE_TYPE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_D_MCE_TYPE Get(EntityObject_MCE_D_MCE_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  IS_END, CREATE_DEPT_ID, MODIFY_TIME, DATA_ORGANISE_ID, STATUS, ID, CREATE_USER_ID, MODIFY_USER_ID, FINANCE_CODE, UNIT_ID, STATE, FINANCE_NAME, PARENT_ID, CUSTOM_CODE, MODIFY_DEPT_ID, CODE, FIVE_STROKE_CODE, COMMENTS, CREATE_TIME, SPELL_CODE, INTERNATIONAL_CODE, NAME, IDIENTY_TYPE, ORDER_INDEX from MCE_D_MCE_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_D_MCE_TYPE[] objs = new EntityObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_D_MCE_TYPE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_D_MCE_TYPE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.IS_END!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.IS_END = :C_IS_END");
				param = new OracleParameter();
				param.ParameterName =":C_IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_END;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_END"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "IS_END"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "CREATE_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_D_MCE_TYPE.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MCE_D_MCE_TYPE.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "DATA_ORGANISE_ID"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.FINANCE_CODE ").Append((cause.FINANCE_CODE.StartsWith("%") || cause.FINANCE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "FINANCE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "UNIT_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_NAME))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.FINANCE_NAME ").Append((cause.FINANCE_NAME.StartsWith("%") || cause.FINANCE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "FINANCE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PARENT_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PARENT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARENT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "PARENT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CUSTOM_CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.CUSTOM_CODE ").Append((cause.CUSTOM_CODE.StartsWith("%") || cause.CUSTOM_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CUSTOM_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CUSTOM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CUSTOM_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CUSTOM_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "CUSTOM_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.FIVE_STROKE_CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.FIVE_STROKE_CODE ").Append((cause.FIVE_STROKE_CODE.StartsWith("%") || cause.FIVE_STROKE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIVE_STROKE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "FIVE_STROKE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "COMMENTS"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_D_MCE_TYPE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_D_MCE_TYPE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.INTERNATIONAL_CODE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.INTERNATIONAL_CODE ").Append((cause.INTERNATIONAL_CODE.StartsWith("%") || cause.INTERNATIONAL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_INTERNATIONAL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_INTERNATIONAL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INTERNATIONAL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INTERNATIONAL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "INTERNATIONAL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 80;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.IDIENTY_TYPE))
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.IDIENTY_TYPE ").Append((cause.IDIENTY_TYPE.StartsWith("%") || cause.IDIENTY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_IDIENTY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_IDIENTY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IDIENTY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDIENTY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "IDIENTY_TYPE"));
			}
			if(cause.ORDER_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_D_MCE_TYPE.ORDER_INDEX = :C_ORDER_INDEX");
				param = new OracleParameter();
				param.ParameterName =":C_ORDER_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORDER_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("MCE_D_MCE_TYPE", "ORDER_INDEX"));
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
		public static DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_D_MCE_TYPE",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_D_MCE_TYPE.IS_END, MCE_D_MCE_TYPE.CREATE_DEPT_ID, MCE_D_MCE_TYPE.MODIFY_TIME, MCE_D_MCE_TYPE.DATA_ORGANISE_ID, MCE_D_MCE_TYPE.STATUS, MCE_D_MCE_TYPE.ID, MCE_D_MCE_TYPE.CREATE_USER_ID, MCE_D_MCE_TYPE.MODIFY_USER_ID, MCE_D_MCE_TYPE.FINANCE_CODE, MCE_D_MCE_TYPE.UNIT_ID, MCE_D_MCE_TYPE.STATE, MCE_D_MCE_TYPE.FINANCE_NAME, MCE_D_MCE_TYPE.PARENT_ID, MCE_D_MCE_TYPE.CUSTOM_CODE, MCE_D_MCE_TYPE.MODIFY_DEPT_ID, MCE_D_MCE_TYPE.CODE, MCE_D_MCE_TYPE.FIVE_STROKE_CODE, MCE_D_MCE_TYPE.COMMENTS, MCE_D_MCE_TYPE.CREATE_TIME, MCE_D_MCE_TYPE.SPELL_CODE, MCE_D_MCE_TYPE.INTERNATIONAL_CODE, MCE_D_MCE_TYPE.NAME, MCE_D_MCE_TYPE.IDIENTY_TYPE, MCE_D_MCE_TYPE.ORDER_INDEX, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, (case  when MCE_D_MCE_TYPE.STATE = 1 then '正常' when MCE_D_MCE_TYPE.STATE = 2 then '禁用' else '' end ) as STATE_NAME, SELF_T.NAME as PARENT_ID_NAME from MCE_D_MCE_TYPE left join COM_TYPE   COM_TYPE_UNIT_ID on MCE_D_MCE_TYPE.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MCE_D_MCE_TYPE   SELF_T on MCE_D_MCE_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_D_MCE_TYPE",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_D_MCE_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_D_MCE_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_END = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.UNIT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.STATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FINANCE_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PARENT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CUSTOM_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COMMENTS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SPELL_CODE = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.INTERNATIONAL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IDIENTY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ORDER_INDEX = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_D_MCE_TYPE[] objs = new DisplayObject_MCE_D_MCE_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_D_MCE_TYPE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("IS_END"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.IS_END = :U_IS_END");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_END;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.FINANCE_CODE = :U_FINANCE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_CODE) ? string.Empty : obj.FINANCE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.UNIT_ID = :U_UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_NAME"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.FINANCE_NAME = :U_FINANCE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_NAME) ? string.Empty : obj.FINANCE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.PARENT_ID = :U_PARENT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CUSTOM_CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.CUSTOM_CODE = :U_CUSTOM_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CUSTOM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CUSTOM_CODE) ? string.Empty : obj.CUSTOM_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FIVE_STROKE_CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.FIVE_STROKE_CODE = :U_FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FIVE_STROKE_CODE) ? string.Empty : obj.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.SPELL_CODE = :U_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INTERNATIONAL_CODE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.INTERNATIONAL_CODE = :U_INTERNATIONAL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_INTERNATIONAL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INTERNATIONAL_CODE) ? string.Empty : obj.INTERNATIONAL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 80;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDIENTY_TYPE"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.IDIENTY_TYPE = :U_IDIENTY_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_IDIENTY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.IDIENTY_TYPE) ? string.Empty : obj.IDIENTY_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_INDEX"))
			{
				strBuf.Add("  MCE_D_MCE_TYPE.ORDER_INDEX = :U_ORDER_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":U_ORDER_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORDER_INDEX;
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
