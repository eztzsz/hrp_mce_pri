
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_OUTSTOCK))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_OUTSTOCK_D))]	
	public partial interface ServiceContract_MCE_B_ASSETS_OUTSTOCK_D: IServiceContractLocal<EntityObject_MCE_B_ASSETS_OUTSTOCK_D, CauseObject_MCE_B_ASSETS_OUTSTOCK_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_OUTSTOCK_D Get(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK_D Get(DisplayObject_MCE_B_ASSETS_OUTSTOCK_D obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK_D[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_OUTSTOCK_D cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK_D[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_OUTSTOCK_D obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_OUTSTOCK_D Load(string id , out EntityObject_COM_TYPE unit_id, out EntityObject_MDM_D_DEPT prd_id, out EntityObject_MCE_D_MCE_TYPE asset_type_id, out EntityObject_COM_TYPE economic_use_type_id, out EntityObject_MCE_B_ASSETS_OUTSTOCK base_id, out EntityObject_COM_TYPE country);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] saveEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] updateEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_OUTSTOCK_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
