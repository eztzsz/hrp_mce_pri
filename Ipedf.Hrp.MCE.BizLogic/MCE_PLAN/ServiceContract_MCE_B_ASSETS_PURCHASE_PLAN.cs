#define NESTING
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
    [ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN))]	
	public partial interface ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN: IServiceContractLocal<EntityObject_MCE_B_ASSETS_PURCHASE_PLAN, CauseObject_MCE_B_ASSETS_PURCHASE_PLAN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN Get(DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Load(string id , out EntityObject_COM_USER apply_user_id, out EntityObject_COM_DEPART purchase_dept_id, out EntityObject_COM_TYPE currency_id, out EntityObject_COM_DEPART apply_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] saveEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] updateEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN saveBaseEntity, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN updateBaseEntity, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] saveDetailEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] updateDetailEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
