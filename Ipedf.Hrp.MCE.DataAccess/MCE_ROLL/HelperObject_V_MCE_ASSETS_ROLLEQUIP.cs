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
	[CauseObject(typeof(CauseObject_V_MCE_ASSETS_ROLLEQUIP))]
	public partial class HelperObject_V_MCE_ASSETS_ROLLEQUIP
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_ASSETS_ROLLEQUIP( ASSETS_CODE, USING_DEPT_ID_NAME, ASSETS_STATE, PICTURE, ASSETS_STATE_NAME, USING_DEPT_ID, SPEC, ROLL_ID, ASSETS_ID, ID, ASSETS_NAME) values ( :ASSETS_CODE, :USING_DEPT_ID_NAME, :ASSETS_STATE, :PICTURE, :ASSETS_STATE_NAME, :USING_DEPT_ID, :SPEC, :ROLL_ID, :ASSETS_ID, :ID, :ASSETS_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ASSETS_CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":USING_DEPT_ID_NAME";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.USING_DEPT_ID_NAME == null ? String.Empty:obj.USING_DEPT_ID_NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ASSETS_STATE";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ASSETS_STATE == null ? String.Empty:obj.ASSETS_STATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":PICTURE";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.PICTURE == null ? String.Empty:obj.PICTURE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ASSETS_STATE_NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.ASSETS_STATE_NAME == null ? String.Empty:obj.ASSETS_STATE_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":USING_DEPT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.USING_DEPT_ID == null ? String.Empty:obj.USING_DEPT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":SPEC";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ROLL_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ROLL_ID == null ? String.Empty:obj.ROLL_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ASSETS_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ASSETS_ID == null ? String.Empty:obj.ASSETS_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ASSETS_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_ROLLEQUIP set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj,CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSETS_ROLLEQUIP set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_ASSETS_ROLLEQUIP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_ASSETS_ROLLEQUIP Get(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, USING_DEPT_ID_NAME, ASSETS_STATE, PICTURE, ASSETS_STATE_NAME, USING_DEPT_ID, SPEC, ROLL_ID, ASSETS_ID, ID, ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new EntityObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP Get(DisplayObject_V_MCE_ASSETS_ROLLEQUIP obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_ASSETS_ROLLEQUIP Get(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ASSETS_CODE, USING_DEPT_ID_NAME, ASSETS_STATE, PICTURE, ASSETS_STATE_NAME, USING_DEPT_ID, SPEC, ROLL_ID, ASSETS_ID, ID, ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new EntityObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME ").Append((cause.USING_DEPT_ID_NAME.StartsWith("%") || cause.USING_DEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.USING_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "USING_DEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_STATE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE ").Append((cause.ASSETS_STATE.StartsWith("%") || cause.ASSETS_STATE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ASSETS_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.PICTURE))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.PICTURE ").Append((cause.PICTURE.StartsWith("%") || cause.PICTURE.EndsWith("%")) ? " like " : " = ").Append(" :C_PICTURE");
				param = new OracleParameter();
				param.ParameterName =":C_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PICTURE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PICTURE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "PICTURE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_STATE_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME ").Append((cause.ASSETS_STATE_NAME.StartsWith("%") || cause.ASSETS_STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ASSETS_STATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.USING_DEPT_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID ").Append((cause.USING_DEPT_ID.StartsWith("%") || cause.USING_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USING_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "USING_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ROLL_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ROLL_ID ").Append((cause.ROLL_ID.StartsWith("%") || cause.ROLL_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ROLL_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ROLL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ROLL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLL_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ROLL_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID ").Append((cause.ASSETS_ID.StartsWith("%") || cause.ASSETS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSETS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ASSETS_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSETS_ROLLEQUIP", "ASSETS_NAME"));
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
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_ROLLEQUIP",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE, V_MCE_ASSETS_ROLLEQUIP.PICTURE, V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME, V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID, V_MCE_ASSETS_ROLLEQUIP.SPEC, V_MCE_ASSETS_ROLLEQUIP.ROLL_ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID, V_MCE_ASSETS_ROLLEQUIP.ID, V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME from V_MCE_ASSETS_ROLLEQUIP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSETS_ROLLEQUIP",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USING_DEPT_ID_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ASSETS_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PICTURE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ASSETS_STATE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USING_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ROLL_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] objs = new DisplayObject_V_MCE_ASSETS_ROLLEQUIP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID_NAME = :U_USING_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID_NAME) ? string.Empty : obj.USING_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_STATE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE = :U_ASSETS_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_STATE) ? string.Empty : obj.ASSETS_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PICTURE"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.PICTURE = :U_PICTURE");
				param = new OracleParameter();
				param.ParameterName = ":U_PICTURE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PICTURE) ? string.Empty : obj.PICTURE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_STATE_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ASSETS_STATE_NAME = :U_ASSETS_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_STATE_NAME) ? string.Empty : obj.ASSETS_STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USING_DEPT_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.USING_DEPT_ID = :U_USING_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USING_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USING_DEPT_ID) ? string.Empty : obj.USING_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLL_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ROLL_ID = :U_ROLL_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ROLL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ROLL_ID) ? string.Empty : obj.ROLL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ASSETS_ID = :U_ASSETS_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_ID) ? string.Empty : obj.ASSETS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  V_MCE_ASSETS_ROLLEQUIP.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		
		#endregion 
	}
}
