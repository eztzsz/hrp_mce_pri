
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

    public partial interface ServiceContract_MCE_B_ASSETS_ROLL
    {

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssetsRoll item);

        [OperationContract]
        BizLogicMsg Audit_Ext(JsonMceAssetsRoll item);
        
        [OperationContract]
        BizLogicMsg Delete_Ext(string strID);



        [OperationContract]
        BizLogicMsg Save_RollFiles(List< JsonMceAssetsRollFile> listItem);


        [OperationContract]
        BizLogicMsg Delete_RollFiles(List<string> listID);


        [OperationContract]
        BizLogicMsg Save_RollFileAsTemplate(JsonMceAssetsRollFileTemplate item);


        [OperationContract]
        BizLogicMsg Save_RollEquip(JsonMceAssetsRollEquip item);


        [OperationContract]
        BizLogicMsg Delete_RollEquip(string strID);

   
        

    }
}
