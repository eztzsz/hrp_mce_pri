
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_INSURANCE))]	
	public partial interface ServiceContract_MCE_B_ASSETS_INSURANCE: IServiceContractLocal<EntityObject_MCE_B_ASSETS_INSURANCE, CauseObject_MCE_B_ASSETS_INSURANCE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_INSURANCE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_INSURANCE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_INSURANCE obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_INSURANCE Get(EntityObject_MCE_B_ASSETS_INSURANCE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSURANCE Get(DisplayObject_MCE_B_ASSETS_INSURANCE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSURANCE[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_INSURANCE cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSURANCE[] Query(CauseObject_MCE_B_ASSETS_INSURANCE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_INSURANCE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_INSURANCE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_INSURANCE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_INSURANCE obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_INSURANCE Load(string id , out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_MDM_D_DEPT insurance_unit);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_INSURANCE[] saveEntities, EntityObject_MCE_B_ASSETS_INSURANCE[] updateEntities, EntityObject_MCE_B_ASSETS_INSURANCE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_INSURANCE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_INSURANCE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_INSURANCE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
