
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
	[ServiceKnownType(typeof(EntityObject_V_MCE_ASSETS_DEPR_D))]	
	public partial interface ServiceContract_V_MCE_ASSETS_DEPR_D: IServiceContractLocal<EntityObject_V_MCE_ASSETS_DEPR_D, CauseObject_V_MCE_ASSETS_DEPR_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_ASSETS_DEPR_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_ASSETS_DEPR_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_ASSETS_DEPR_D obj);
		[OperationContract]
		EntityObject_V_MCE_ASSETS_DEPR_D Get(EntityObject_V_MCE_ASSETS_DEPR_D obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_D Get(DisplayObject_V_MCE_ASSETS_DEPR_D obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_D[] List();
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_ASSETS_DEPR_D cause);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_D[] Query(CauseObject_V_MCE_ASSETS_DEPR_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_ASSETS_DEPR_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_ASSETS_DEPR_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_ASSETS_DEPR_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_ASSETS_DEPR_D obj);
        [OperationContract]
        EntityObject_V_MCE_ASSETS_DEPR_D Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_DEPR_D[] saveEntities, EntityObject_V_MCE_ASSETS_DEPR_D[] updateEntities, EntityObject_V_MCE_ASSETS_DEPR_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_ASSETS_DEPR_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_ASSETS_DEPR_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_DEPR_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
