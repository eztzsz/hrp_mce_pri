
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

    public partial interface ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT
    {

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssetsCapitalAllot item);

      
        [OperationContract]
        BizLogicMsg Audit_Ext(string strID);
        
        
      [OperationContract]
      BizLogicMsg Delete_Ext(string strID);
      
    }
}
