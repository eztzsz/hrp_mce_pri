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
    public partial class HelperObject_MCE_B_ASSETS
    {


        public static DisplayObject_MCE_B_ASSETS[] QueryIdState(string REF_TAB_ID, string REF_TAB_NAME)
        {

            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":REF_TAB_ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = REF_TAB_ID;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":REF_TAB_NAME";
            parameters[1].Size = 50;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = REF_TAB_NAME;
            #endregion
            string sSql = "select ID,USE_STATE from MCE_B_ASSETS where REF_TAB_ID = :REF_TAB_ID and REF_TAB_NAME = :REF_TAB_NAME";

            #region Push Block
            DisplayObject_MCE_B_ASSETS dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_MCE_B_ASSETS();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.USE_STATE = sqlReader.GetString(1);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_MCE_B_ASSETS[] objs = new DisplayObject_MCE_B_ASSETS[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }

    }
}
