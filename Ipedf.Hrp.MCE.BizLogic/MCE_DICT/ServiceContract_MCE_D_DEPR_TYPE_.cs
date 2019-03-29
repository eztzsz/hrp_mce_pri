
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

    public partial interface ServiceContract_MCE_D_DEPR_TYPE
    {
        [OperationContract]
        BizLogicMsg Save_Ext(EntityObject_MCE_D_DEPR_TYPE entity);


        [OperationContract]
        BizLogicMsg Delete_Ext(List<string> listID);
    }
}
