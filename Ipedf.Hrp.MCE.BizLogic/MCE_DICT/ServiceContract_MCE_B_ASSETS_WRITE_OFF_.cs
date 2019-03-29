﻿
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

    public partial interface ServiceContract_MCE_B_ASSETS_WRITE_OFF
    {

        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceAssetsWriteOff item);


        [OperationContract]
        BizLogicMsg Save_Ext2(JsonMCE_Write_Off item);


        [OperationContract]
        BizLogicMsg Audit_Ext(string strID);


        [OperationContract]
        BizLogicMsg Delete_Ext(string strID);




        [OperationContract]
        BizLogicMsg Submit_Ext2(List<string> listID);


        
        [OperationContract]
        BizLogicMsg Audit_Ext2(JsonWriteOffAudit item);
        

        [OperationContract]
        BizLogicMsg Delete_Ext2(List<string> listID);


        [OperationContract]
        BizLogicMsg Identity(JsonWriteOffIdentity item);

    }
}
