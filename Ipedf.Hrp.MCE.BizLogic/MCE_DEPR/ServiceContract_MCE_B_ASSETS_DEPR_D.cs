
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_DEPR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_DEPR_D))]	
	public partial interface ServiceContract_MCE_B_ASSETS_DEPR_D: IServiceContractLocal<EntityObject_MCE_B_ASSETS_DEPR_D, CauseObject_MCE_B_ASSETS_DEPR_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_DEPR_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_DEPR_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_DEPR_D obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_DEPR_D Get(EntityObject_MCE_B_ASSETS_DEPR_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR_D Get(DisplayObject_MCE_B_ASSETS_DEPR_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR_D[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_DEPR_D cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR_D[] Query(CauseObject_MCE_B_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_DEPR_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_DEPR_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_DEPR_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_DEPR_D obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_DEPR_D Load(string id , out EntityObject_MCE_B_ASSETS_DEPR base_id, out EntityObject_COM_TYPE currency_id, out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_DEPR_D[] saveEntities, EntityObject_MCE_B_ASSETS_DEPR_D[] updateEntities, EntityObject_MCE_B_ASSETS_DEPR_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_DEPR_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_DEPR_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_DEPR_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
