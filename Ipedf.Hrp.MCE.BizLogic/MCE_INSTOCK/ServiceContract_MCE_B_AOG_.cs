﻿using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using System.Collections.Generic;

namespace Ipedf.Web.ServiceContract
{
    public partial interface ServiceContract_MCE_B_AOG
    {
 
        [OperationContract]
        BizLogicMsg Save_Ext(JsonMCE_AOG jsonMCE_AOG);


        [OperationContract]
        BizLogicMsg Submit_Ext(List<string> listID);


        [OperationContract]
        BizLogicMsg Audit_Ext(List<string> listID);


        [OperationContract]
        BizLogicMsg Delete_Ext(List<string> listID);

    }
}
