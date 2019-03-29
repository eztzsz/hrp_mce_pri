
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
		
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_PURCHASE))]	
	public partial interface ServiceContract_MCE_B_ASSETS_PURCHASE: IServiceContractLocal<EntityObject_MCE_B_ASSETS_PURCHASE, CauseObject_MCE_B_ASSETS_PURCHASE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_PURCHASE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_PURCHASE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_PURCHASE obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_PURCHASE Get(EntityObject_MCE_B_ASSETS_PURCHASE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE Get(DisplayObject_MCE_B_ASSETS_PURCHASE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_PURCHASE cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_PURCHASE[] Query(CauseObject_MCE_B_ASSETS_PURCHASE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_PURCHASE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_PURCHASE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_PURCHASE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_PURCHASE obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_PURCHASE Load(string id , out EntityObject_MCE_D_MCE_TYPE type_id, out EntityObject_COM_USER apply_user_id, out EntityObject_COM_DEPART apply_dept_id, out EntityObject_COM_TYPE purchase_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE[] saveEntities, EntityObject_MCE_B_ASSETS_PURCHASE[] updateEntities, EntityObject_MCE_B_ASSETS_PURCHASE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_PURCHASE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_PURCHASE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
