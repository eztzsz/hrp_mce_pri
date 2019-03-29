
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.ServiceContract
{
	#if NESTING
    [ServiceKnownType(typeof(EntityObject_))]
	#endif
	
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_MCE_QUERY_CONTRACT_PAY))]	
	public partial interface ServiceContract_V_MCE_QUERY_CONTRACT_PAY: IServiceContractLocal<EntityObject_V_MCE_QUERY_CONTRACT_PAY, CauseObject_V_MCE_QUERY_CONTRACT_PAY>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
		[OperationContract]
		EntityObject_V_MCE_QUERY_CONTRACT_PAY Get(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
		[OperationContract]
		DisplayObject_V_MCE_QUERY_CONTRACT_PAY Get(DisplayObject_V_MCE_QUERY_CONTRACT_PAY obj);
		[OperationContract]
		DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] List();
		[OperationContract]
		DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause);
		[OperationContract]
		DisplayObject_V_MCE_QUERY_CONTRACT_PAY[] Query(CauseObject_V_MCE_QUERY_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_QUERY_CONTRACT_PAY[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_QUERY_CONTRACT_PAY[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_QUERY_CONTRACT_PAY[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_QUERY_CONTRACT_PAY obj);
        [OperationContract]
        EntityObject_V_MCE_QUERY_CONTRACT_PAY Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_QUERY_CONTRACT_PAY[] saveEntities, EntityObject_V_MCE_QUERY_CONTRACT_PAY[] updateEntities, EntityObject_V_MCE_QUERY_CONTRACT_PAY[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_QUERY_CONTRACT_PAY saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_QUERY_CONTRACT_PAY deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_QUERY_CONTRACT_PAY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
