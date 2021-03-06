
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_EXEC))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_EXEC_D))]	
	public partial interface ServiceContract_MCE_B_ASSETS_MT_EXEC_D: IServiceContractLocal<EntityObject_MCE_B_ASSETS_MT_EXEC_D, CauseObject_MCE_B_ASSETS_MT_EXEC_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_MT_EXEC_D Get(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC_D Get(DisplayObject_MCE_B_ASSETS_MT_EXEC_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_EXEC_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_EXEC_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_EXEC_D obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_MT_EXEC_D Load(string id , out EntityObject_MCE_B_ASSETS_MT_EXEC base_id, out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_COM_DEPART dept_id, out EntityObject_MCE_B_ASSETS_MT_ITEM item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC_D[] saveEntities, EntityObject_MCE_B_ASSETS_MT_EXEC_D[] updateEntities, EntityObject_MCE_B_ASSETS_MT_EXEC_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_EXEC_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_EXEC_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
