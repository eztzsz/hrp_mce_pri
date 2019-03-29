
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

    public partial interface ServiceContract_MCE_B_ASSETS_INSURANCE
    {

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssetsInsurance item);

      
        [OperationContract]
        BizLogicMsg Audit_Ext(string strID);


        [OperationContract]
        BizLogicMsg Delete_Ext(string strID);

        
      [OperationContract]
        BizLogicMsg Insurance_Expire(string strID);


      [OperationContract]
      BizLogicMsg Insurance_Continue(string strID);
      
    }
}
