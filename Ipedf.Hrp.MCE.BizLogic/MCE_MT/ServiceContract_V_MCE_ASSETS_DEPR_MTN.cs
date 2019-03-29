
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
	[ServiceKnownType(typeof(EntityObject_V_MCE_ASSETS_DEPR_MTN))]	
	public partial interface ServiceContract_V_MCE_ASSETS_DEPR_MTN: IServiceContractLocal<EntityObject_V_MCE_ASSETS_DEPR_MTN, CauseObject_V_MCE_ASSETS_DEPR_MTN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
		[OperationContract]
		EntityObject_V_MCE_ASSETS_DEPR_MTN Get(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_MTN Get(DisplayObject_V_MCE_ASSETS_DEPR_MTN obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_MTN[] List();
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_MTN[] Query(CauseObject_V_MCE_ASSETS_DEPR_MTN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_ASSETS_DEPR_MTN cause);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_DEPR_MTN[] Query(CauseObject_V_MCE_ASSETS_DEPR_MTN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_ASSETS_DEPR_MTN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_ASSETS_DEPR_MTN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_ASSETS_DEPR_MTN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_ASSETS_DEPR_MTN obj);
        [OperationContract]
        EntityObject_V_MCE_ASSETS_DEPR_MTN Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_DEPR_MTN[] saveEntities, EntityObject_V_MCE_ASSETS_DEPR_MTN[] updateEntities, EntityObject_V_MCE_ASSETS_DEPR_MTN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_ASSETS_DEPR_MTN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_ASSETS_DEPR_MTN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_DEPR_MTN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
