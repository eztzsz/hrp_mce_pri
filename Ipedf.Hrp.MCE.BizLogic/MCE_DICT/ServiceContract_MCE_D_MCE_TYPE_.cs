
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

    public partial interface ServiceContract_MCE_D_MCE_TYPE
    {
        [OperationContract]
        BizLogicMsg Save_Ext(JsonMceType jsonMceType);

        [OperationContract]
        BizLogicMsg Save_TypeDept(JsonMceType jsonMceType);

        [OperationContract]
        BizLogicMsg Delete_Ext(List<string> listID);

        [OperationContract]
        List<JsonMceTypeTree> getMceTypeTree();

        [OperationContract]
        BizLogicMsg Delete_TypeDept_Ext(JsonMceType jsonMceType);


        [OperationContract]
        BizLogicMsg Save_Dept_Ext(List<string> idList);


        [OperationContract]
        BizLogicMsg CancelPrvAudit(List<string> idList);

        [OperationContract]
        BizLogicMsg Save_Prd_Ext(string strJson);

    }
}
