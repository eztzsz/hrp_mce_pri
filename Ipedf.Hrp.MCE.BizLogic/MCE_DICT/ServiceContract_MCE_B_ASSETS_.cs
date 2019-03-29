
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.ServiceContract
{

    public partial interface ServiceContract_MCE_B_ASSETS
    {
        [OperationContract]
        DisplayObject_MCE_B_ASSETS GetTotalRecord(CauseObject_MCE_B_ASSETS p);

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssets jsonMceAssets);

        [OperationContract]
        BizLogicMsg Audit_Ext(List<string> listID);


        [OperationContract]
        BizLogicMsg Delete_Ext(List<string> listID);

        [OperationContract]
        string Generate_Bill_Code(string strType);


    }
}
