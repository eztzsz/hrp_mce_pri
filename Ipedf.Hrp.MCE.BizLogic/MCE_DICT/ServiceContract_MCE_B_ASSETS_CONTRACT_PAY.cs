
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CONTRACT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CONTRACT_PAY))]	
	public partial interface ServiceContract_MCE_B_ASSETS_CONTRACT_PAY: IServiceContractLocal<EntityObject_MCE_B_ASSETS_CONTRACT_PAY, CauseObject_MCE_B_ASSETS_CONTRACT_PAY>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_CONTRACT_PAY Get(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_PAY Get(DisplayObject_MCE_B_ASSETS_CONTRACT_PAY obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_PAY cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_CONTRACT_PAY Load(string id , out EntityObject_MCE_B_ASSETS_CONTRACT base_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] saveEntities, EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] updateEntities, EntityObject_MCE_B_ASSETS_CONTRACT_PAY[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_CONTRACT_PAY saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_CONTRACT_PAY deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_PAY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
