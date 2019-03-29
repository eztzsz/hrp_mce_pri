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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_ROLLFILE))]
	public partial class HelperObject_MCE_B_ASSETS_ROLLFILE
	{		
		#region Method Blok
		public static int Save(EntityObject_MCE_B_ASSETS_ROLLFILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MCE_B_ASSETS_ROLLFILE( CREATE_DATE, ID, BASE_ID, SUMMARYS, COMMENTS, CODE, BACKUP1, NAME, CREATE_TIME, PAGE_NUM) values ( :CREATE_DATE, :ID, :BASE_ID, :SUMMARYS, :COMMENTS, :CODE, :BACKUP1, :NAME, :CREATE_TIME, :PAGE_NUM)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CREATE_DATE";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.CREATE_DATE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":SUMMARYS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.SUMMARYS == null ? String.Empty:obj.SUMMARYS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":COMMENTS";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CODE";
			parameters[5].Size = 100;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BACKUP1";
			parameters[6].Size = 1000;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.BACKUP1 == null ? String.Empty:obj.BACKUP1;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NAME";
			parameters[7].Size = 100;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PAGE_NUM";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.PAGE_NUM;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_ROLLFILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_ROLLFILE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MCE_B_ASSETS_ROLLFILE obj,CauseObject_MCE_B_ASSETS_ROLLFILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MCE_B_ASSETS_ROLLFILE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MCE_B_ASSETS_ROLLFILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MCE_B_ASSETS_ROLLFILE where  ID = :ID ";
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
		public static int Delete(CauseObject_MCE_B_ASSETS_ROLLFILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MCE_B_ASSETS_ROLLFILE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_MCE_B_ASSETS_ROLLFILE Get(EntityObject_MCE_B_ASSETS_ROLLFILE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DATE, ID, BASE_ID, SUMMARYS, COMMENTS, CODE, BACKUP1, NAME, CREATE_TIME, PAGE_NUM from MCE_B_ASSETS_ROLLFILE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MCE_B_ASSETS_ROLLFILE[] objs = new EntityObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE Get(DisplayObject_MCE_B_ASSETS_ROLLFILE obj)
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1) and MCE_B_ASSETS_ROLLFILE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_MCE_B_ASSETS_ROLLFILE Get(EntityObject_MCE_B_ASSETS_ROLLFILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CREATE_DATE, ID, BASE_ID, SUMMARYS, COMMENTS, CODE, BACKUP1, NAME, CREATE_TIME, PAGE_NUM from MCE_B_ASSETS_ROLLFILE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MCE_B_ASSETS_ROLLFILE[] objs = new EntityObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MCE_B_ASSETS_ROLLFILE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SUMMARYS))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.SUMMARYS ").Append((cause.SUMMARYS.StartsWith("%") || cause.SUMMARYS.EndsWith("%")) ? " like " : " = ").Append(" :C_SUMMARYS");
				param = new OracleParameter();
				param.ParameterName =":C_SUMMARYS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SUMMARYS;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMMARYS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "SUMMARYS"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BACKUP1))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.BACKUP1 ").Append((cause.BACKUP1.StartsWith("%") || cause.BACKUP1.EndsWith("%")) ? " like " : " = ").Append(" :C_BACKUP1");
				param = new OracleParameter();
				param.ParameterName =":C_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.BACKUP1;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKUP1"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "BACKUP1"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "NAME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "CREATE_TIME"));
			}
			if(cause.PAGE_NUM!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MCE_B_ASSETS_ROLLFILE.PAGE_NUM = :C_PAGE_NUM");
				param = new OracleParameter();
				param.ParameterName =":C_PAGE_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PAGE_NUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_NUM"))
			{
				strBuf.Append(cause.GetINSQL("MCE_B_ASSETS_ROLLFILE", "PAGE_NUM"));
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
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_ROLLFILE",paging, order, sSql, parameters, connection);
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
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MCE_B_ASSETS_ROLLFILE.CREATE_DATE, MCE_B_ASSETS_ROLLFILE.ID, MCE_B_ASSETS_ROLLFILE.BASE_ID, MCE_B_ASSETS_ROLLFILE.SUMMARYS, MCE_B_ASSETS_ROLLFILE.COMMENTS, MCE_B_ASSETS_ROLLFILE.CODE, MCE_B_ASSETS_ROLLFILE.BACKUP1, MCE_B_ASSETS_ROLLFILE.NAME, MCE_B_ASSETS_ROLLFILE.CREATE_TIME, MCE_B_ASSETS_ROLLFILE.PAGE_NUM, MCE_B_ASSETS_ROLL_BASE_ID.NAME as BASE_ID_NAME from MCE_B_ASSETS_ROLLFILE left join MCE_B_ASSETS_ROLL   MCE_B_ASSETS_ROLL_BASE_ID on MCE_B_ASSETS_ROLLFILE.BASE_ID = MCE_B_ASSETS_ROLL_BASE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MCE_B_ASSETS_ROLLFILE",paging, order, sSql, parameters, trans);
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
			DisplayObject_MCE_B_ASSETS_ROLLFILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MCE_B_ASSETS_ROLLFILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARYS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BACKUP1 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAGE_NUM = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MCE_B_ASSETS_ROLLFILE[] objs = new DisplayObject_MCE_B_ASSETS_ROLLFILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MCE_B_ASSETS_ROLLFILE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMMARYS"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.SUMMARYS = :U_SUMMARYS");
				param = new OracleParameter();
				param.ParameterName = ":U_SUMMARYS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SUMMARYS) ? string.Empty : obj.SUMMARYS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKUP1"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.BACKUP1 = :U_BACKUP1");
				param = new OracleParameter();
				param.ParameterName = ":U_BACKUP1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.BACKUP1) ? string.Empty : obj.BACKUP1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_NUM"))
			{
				strBuf.Add("  MCE_B_ASSETS_ROLLFILE.PAGE_NUM = :U_PAGE_NUM");
				param = new OracleParameter();
				param.ParameterName = ":U_PAGE_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PAGE_NUM;
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
