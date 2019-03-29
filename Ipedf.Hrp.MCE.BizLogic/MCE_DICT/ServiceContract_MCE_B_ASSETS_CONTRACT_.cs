
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

    public partial interface ServiceContract_MCE_B_ASSETS_CONTRACT
    {

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssetsContract item);

     
        [OperationContract]
        BizLogicMsg Audit_Ext(string strID);

        
     [OperationContract]
     BizLogicMsg Delete_Ext(string strID);


     [OperationContract]
     BizLogicMsg Contract_Stop(string strID);


     [OperationContract]
     BizLogicMsg Contract_Continue(string strID);


     [OperationContract]
     BizLogicMsg Save_Ext2(JsonMCE_Contract json);


     [OperationContract]
     BizLogicMsg Submit_Ext2(List<string> listID);


     [OperationContract]
     BizLogicMsg Audit_Ext2(List<string> listID);


     [OperationContract]
     BizLogicMsg Delete_Ext2(List<string> listID);

     [OperationContract]
     BizLogicMsg Stop_Ext2(List<string> listID);


     [OperationContract]
     BizLogicMsg Continue_Ext2(string strID);



     [OperationContract]
     BizLogicMsg Contract_Pay2(List<string> listID);

    }
}
