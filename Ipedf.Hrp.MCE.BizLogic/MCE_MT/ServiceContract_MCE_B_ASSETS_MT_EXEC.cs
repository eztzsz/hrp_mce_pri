
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
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_EXEC))]	
	public partial interface ServiceContract_MCE_B_ASSETS_MT_EXEC: IServiceContractLocal<EntityObject_MCE_B_ASSETS_MT_EXEC, CauseObject_MCE_B_ASSETS_MT_EXEC>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_MT_EXEC Get(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC Get(DisplayObject_MCE_B_ASSETS_MT_EXEC obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_EXEC cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_EXEC[] Query(CauseObject_MCE_B_ASSETS_MT_EXEC cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_EXEC[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_EXEC[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_EXEC obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_MT_EXEC Load(string id , out EntityObject_COM_USER apply_user_id, out EntityObject_MDM_D_DEPT mtn_company_id, out EntityObject_COM_TYPE mtn_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC[] saveEntities, EntityObject_MCE_B_ASSETS_MT_EXEC[] updateEntities, EntityObject_MCE_B_ASSETS_MT_EXEC[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_EXEC saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_EXEC deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_EXEC updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
