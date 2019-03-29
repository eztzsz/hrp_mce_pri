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
	[CauseObject(typeof(CauseObject_V_MCE_ASSET_SALERETURN_BACK))]
	public partial class HelperObject_V_MCE_ASSET_SALERETURN_BACK
	{		
		#region Method Blok
		public static int Save(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_MCE_ASSET_SALERETURN_BACK( ORIGINAL_VALUE, PURCHASE_DATE, REF_TAB_NAME, PRODUCT_NAME, UNIT_ID_NAME, ASSETS_NAME, PRICE, REF_TAB_ID, ASSETS_CODE, PRD_ID, CARD_CODE, BASE_ID, ID, SPEC, BACK_D_ID) values ( :ORIGINAL_VALUE, :PURCHASE_DATE, :REF_TAB_NAME, :PRODUCT_NAME, :UNIT_ID_NAME, :ASSETS_NAME, :PRICE, :REF_TAB_ID, :ASSETS_CODE, :PRD_ID, :CARD_CODE, :BASE_ID, :ID, :SPEC, :BACK_D_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ORIGINAL_VALUE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.ORIGINAL_VALUE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PURCHASE_DATE";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.PURCHASE_DATE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":REF_TAB_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":PRODUCT_NAME";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.PRODUCT_NAME == null ? String.Empty:obj.PRODUCT_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":UNIT_ID_NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.UNIT_ID_NAME == null ? String.Empty:obj.UNIT_ID_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ASSETS_NAME";
			parameters[5].Size = 80;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.ASSETS_NAME == null ? String.Empty:obj.ASSETS_NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PRICE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.PRICE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_TAB_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ASSETS_CODE";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.ASSETS_CODE == null ? String.Empty:obj.ASSETS_CODE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PRD_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CARD_CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.CARD_CODE == null ? String.Empty:obj.CARD_CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":BASE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":SPEC";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":BACK_D_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.BACK_D_ID == null ? String.Empty:obj.BACK_D_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSET_SALERETURN_BACK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj,CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_MCE_ASSET_SALERETURN_BACK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_MCE_ASSET_SALERETURN_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_MCE_ASSET_SALERETURN_BACK Get(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ORIGINAL_VALUE, PURCHASE_DATE, REF_TAB_NAME, PRODUCT_NAME, UNIT_ID_NAME, ASSETS_NAME, PRICE, REF_TAB_ID, ASSETS_CODE, PRD_ID, CARD_CODE, BASE_ID, ID, SPEC, BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new EntityObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK Get(DisplayObject_V_MCE_ASSET_SALERETURN_BACK obj)
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_V_MCE_ASSET_SALERETURN_BACK Get(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ORIGINAL_VALUE, PURCHASE_DATE, REF_TAB_NAME, PRODUCT_NAME, UNIT_ID_NAME, ASSETS_NAME, PRICE, REF_TAB_ID, ASSETS_CODE, PRD_ID, CARD_CODE, BASE_ID, ID, SPEC, BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new EntityObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ORIGINAL_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE = :C_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName =":C_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORIGINAL_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "ORIGINAL_VALUE"));
			}
			if(cause.PURCHASE_DATE!= null)
			{
				if (cause.PURCHASE_DATE.Begin != null)
				{
					strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE >= :C_PURCHASE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PURCHASE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PURCHASE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PURCHASE_DATE.End != null)
				{
					strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE < :C_PURCHASE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "PURCHASE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "REF_TAB_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCT_NAME))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME ").Append((cause.PRODUCT_NAME.StartsWith("%") || cause.PRODUCT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "PRODUCT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.UNIT_ID_NAME))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME ").Append((cause.UNIT_ID_NAME.StartsWith("%") || cause.UNIT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_UNIT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_UNIT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.UNIT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "UNIT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_NAME))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME ").Append((cause.ASSETS_NAME.StartsWith("%") || cause.ASSETS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 80;
				param.Value = cause.ASSETS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "ASSETS_NAME"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.PRICE = :C_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":C_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ASSETS_CODE))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE ").Append((cause.ASSETS_CODE.StartsWith("%") || cause.ASSETS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ASSETS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSETS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "ASSETS_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.PRD_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "PRD_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CARD_CODE))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.CARD_CODE ").Append((cause.CARD_CODE.StartsWith("%") || cause.CARD_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CARD_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CARD_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "CARD_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.BACK_D_ID))
			{
				strBuf.Append(" And V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID ").Append((cause.BACK_D_ID.StartsWith("%") || cause.BACK_D_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BACK_D_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BACK_D_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BACK_D_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACK_D_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_MCE_ASSET_SALERETURN_BACK", "BACK_D_ID"));
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
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] Query(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] Query(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] Query(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSET_SALERETURN_BACK",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] Query(CauseObject_V_MCE_ASSET_SALERETURN_BACK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE, V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME, V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME, V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME, V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME, V_MCE_ASSET_SALERETURN_BACK.PRICE, V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID, V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE, V_MCE_ASSET_SALERETURN_BACK.PRD_ID, V_MCE_ASSET_SALERETURN_BACK.CARD_CODE, V_MCE_ASSET_SALERETURN_BACK.BASE_ID, V_MCE_ASSET_SALERETURN_BACK.ID, V_MCE_ASSET_SALERETURN_BACK.SPEC, V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID from V_MCE_ASSET_SALERETURN_BACK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_MCE_ASSET_SALERETURN_BACK",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ORIGINAL_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PURCHASE_DATE = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ASSETS_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ASSETS_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRD_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CARD_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BASE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.SPEC = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BACK_D_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_MCE_ASSET_SALERETURN_BACK[] objs = new DisplayObject_V_MCE_ASSET_SALERETURN_BACK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_MCE_ASSET_SALERETURN_BACK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ORIGINAL_VALUE"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.ORIGINAL_VALUE = :U_ORIGINAL_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORIGINAL_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORIGINAL_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_DATE"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.PURCHASE_DATE = :U_PURCHASE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PURCHASE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PURCHASE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.REF_TAB_NAME = :U_REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCT_NAME"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.PRODUCT_NAME = :U_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PRODUCT_NAME) ? string.Empty : obj.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID_NAME"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.UNIT_ID_NAME = :U_UNIT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_UNIT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID_NAME) ? string.Empty : obj.UNIT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_NAME"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.ASSETS_NAME = :U_ASSETS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 80;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_NAME) ? string.Empty : obj.ASSETS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.PRICE = :U_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.REF_TAB_ID = :U_REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSETS_CODE"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.ASSETS_CODE = :U_ASSETS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_ASSETS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ASSETS_CODE) ? string.Empty : obj.ASSETS_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.PRD_ID = :U_PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CARD_CODE"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.CARD_CODE = :U_CARD_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CARD_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CARD_CODE) ? string.Empty : obj.CARD_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACK_D_ID"))
			{
				strBuf.Add("  V_MCE_ASSET_SALERETURN_BACK.BACK_D_ID = :U_BACK_D_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BACK_D_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BACK_D_ID) ? string.Empty : obj.BACK_D_ID;
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
