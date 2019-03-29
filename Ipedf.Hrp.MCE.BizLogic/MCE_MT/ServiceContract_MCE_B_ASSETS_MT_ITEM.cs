
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
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_ITEM))]	
	public partial interface ServiceContract_MCE_B_ASSETS_MT_ITEM: IServiceContractLocal<EntityObject_MCE_B_ASSETS_MT_ITEM, CauseObject_MCE_B_ASSETS_MT_ITEM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_MT_ITEM Get(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_ITEM Get(DisplayObject_MCE_B_ASSETS_MT_ITEM obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_ITEM[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_ITEM cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_ITEM[] Query(CauseObject_MCE_B_ASSETS_MT_ITEM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_ITEM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_ITEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_ITEM obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_MT_ITEM Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_ITEM[] saveEntities, EntityObject_MCE_B_ASSETS_MT_ITEM[] updateEntities, EntityObject_MCE_B_ASSETS_MT_ITEM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_ITEM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
