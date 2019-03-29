
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_APPLY))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_APPLY_EN))]	
	public partial interface ServiceContract_MCE_B_ASSETS_MT_APPLY_EN: IServiceContractLocal<EntityObject_MCE_B_ASSETS_MT_APPLY_EN, CauseObject_MCE_B_ASSETS_MT_APPLY_EN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_MT_APPLY_EN Get(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY_EN Get(DisplayObject_MCE_B_ASSETS_MT_APPLY_EN obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY_EN[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY_EN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_APPLY_EN obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_MT_APPLY_EN Load(string id , out EntityObject_MCE_B_ASSETS_MT_APPLY base_id, out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] saveEntities, EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] updateEntities, EntityObject_MCE_B_ASSETS_MT_APPLY_EN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_APPLY_EN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_APPLY_EN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY_EN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
