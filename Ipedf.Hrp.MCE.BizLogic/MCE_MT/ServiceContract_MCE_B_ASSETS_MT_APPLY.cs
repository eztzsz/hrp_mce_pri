
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
		
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_MT_APPLY))]	
	public partial interface ServiceContract_MCE_B_ASSETS_MT_APPLY: IServiceContractLocal<EntityObject_MCE_B_ASSETS_MT_APPLY, CauseObject_MCE_B_ASSETS_MT_APPLY>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_MT_APPLY Get(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY Get(DisplayObject_MCE_B_ASSETS_MT_APPLY obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_APPLY cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_APPLY obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_MT_APPLY Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_COM_USER apply_user_id, out EntityObject_COM_TYPE mtn_type_id, out EntityObject_COM_DEPART apply_dept_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE repair_result, out EntityObject_MCE_D_MCE_TYPE assets_type_id, out EntityObject_COM_TYPE emergency_degree, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_TYPE fault_type, out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY[] saveEntities, EntityObject_MCE_B_ASSETS_MT_APPLY[] updateEntities, EntityObject_MCE_B_ASSETS_MT_APPLY[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_APPLY saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_APPLY deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
