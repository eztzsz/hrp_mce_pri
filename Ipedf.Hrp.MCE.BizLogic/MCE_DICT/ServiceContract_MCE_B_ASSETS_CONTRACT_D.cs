
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CONTRACT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CONTRACT_D))]	
	public partial interface ServiceContract_MCE_B_ASSETS_CONTRACT_D: IServiceContractLocal<EntityObject_MCE_B_ASSETS_CONTRACT_D, CauseObject_MCE_B_ASSETS_CONTRACT_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_CONTRACT_D Get(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_D Get(DisplayObject_MCE_B_ASSETS_CONTRACT_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_D[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_D[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_CONTRACT_D cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT_D[] Query(CauseObject_MCE_B_ASSETS_CONTRACT_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_CONTRACT_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_CONTRACT_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_CONTRACT_D obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_CONTRACT_D Load(string id , out EntityObject_MCE_B_ASSETS asset_id, out EntityObject_MCE_B_ASSETS_CONTRACT base_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_D[] saveEntities, EntityObject_MCE_B_ASSETS_CONTRACT_D[] updateEntities, EntityObject_MCE_B_ASSETS_CONTRACT_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_CONTRACT_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_CONTRACT_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
