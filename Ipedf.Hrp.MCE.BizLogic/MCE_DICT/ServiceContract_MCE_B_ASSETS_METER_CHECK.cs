
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
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_METER_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_METER_CHECK))]	
	public partial interface ServiceContract_MCE_B_ASSETS_METER_CHECK: IServiceContractLocal<EntityObject_MCE_B_ASSETS_METER_CHECK, CauseObject_MCE_B_ASSETS_METER_CHECK>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_METER_CHECK Get(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_CHECK Get(DisplayObject_MCE_B_ASSETS_METER_CHECK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_CHECK[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_METER_CHECK cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_CHECK[] Query(CauseObject_MCE_B_ASSETS_METER_CHECK cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_METER_CHECK[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_METER_CHECK[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_METER_CHECK[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_METER_CHECK obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_METER_CHECK Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_COM_TYPE unit_id, out EntityObject_MCE_B_ASSETS_METER_TYPE meter_type, out EntityObject_COM_USER head_user_id, out EntityObject_COM_USER audit_user_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER_CHECK[] saveEntities, EntityObject_MCE_B_ASSETS_METER_CHECK[] updateEntities, EntityObject_MCE_B_ASSETS_METER_CHECK[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_METER_CHECK saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_METER_CHECK deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER_CHECK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
