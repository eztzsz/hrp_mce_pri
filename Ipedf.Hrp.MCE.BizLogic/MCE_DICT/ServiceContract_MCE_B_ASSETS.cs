
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
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_DEPR_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
	public partial interface ServiceContract_MCE_B_ASSETS: IServiceContractLocal<EntityObject_MCE_B_ASSETS, CauseObject_MCE_B_ASSETS>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS Get(EntityObject_MCE_B_ASSETS obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS Get(DisplayObject_MCE_B_ASSETS obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_MDM_D_DEPT ref_dept_id, out EntityObject_COM_TYPE acquire_use_type_id, out EntityObject_COM_TYPE operating_machine_type_id, out EntityObject_COM_TYPE purchase_type_id, out EntityObject_COM_TYPE finance_type_id, out EntityObject_COM_DEPART subjection_dept_id, out EntityObject_COM_TYPE prd_place_type_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE assets_state, out EntityObject_COM_TYPE capital_source_type_id, out EntityObject_COM_TYPE biz_type_id, out EntityObject_MDM_D_DEPT provider_id, out EntityObject_COM_USER custody_user_id, out EntityObject_COM_TYPE vehicle_use_type_id, out EntityObject_MCE_D_MCE_TYPE machine_type_id, out EntityObject_COM_TYPE ownership_type_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_MCE_D_MCE_TYPE name, out EntityObject_MCE_D_DEPR_TYPE depr_type_id, out EntityObject_COM_TYPE use_state, out EntityObject_COM_TYPE economic_use_type_id, out EntityObject_COM_TYPE custody_level_id, out EntityObject_COM_TYPE acquire_ownership_type_id, out EntityObject_COM_DEPART custody_dept_id, out EntityObject_COM_TYPE nationality_id, out EntityObject_COM_TYPE value_type_id, out EntityObject_COM_TYPE machine_manage_type_id, out EntityObject_COM_TYPE energy_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE card_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS[] saveEntities, EntityObject_MCE_B_ASSETS[] updateEntities, EntityObject_MCE_B_ASSETS[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
