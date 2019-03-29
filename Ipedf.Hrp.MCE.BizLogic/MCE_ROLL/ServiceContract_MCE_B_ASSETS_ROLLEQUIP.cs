
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_ROLL))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_ROLLEQUIP))]	
	public partial interface ServiceContract_MCE_B_ASSETS_ROLLEQUIP: IServiceContractLocal<EntityObject_MCE_B_ASSETS_ROLLEQUIP, CauseObject_MCE_B_ASSETS_ROLLEQUIP>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_ROLLEQUIP Get(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLEQUIP Get(DisplayObject_MCE_B_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLEQUIP[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLEQUIP[] Query(CauseObject_MCE_B_ASSETS_ROLLEQUIP cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_ROLLEQUIP cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLEQUIP[] Query(CauseObject_MCE_B_ASSETS_ROLLEQUIP cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_ROLLEQUIP[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_ROLLEQUIP[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_ROLLEQUIP[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_ROLLEQUIP Load(string id , out EntityObject_MCE_B_ASSETS_ROLL roll_id, out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLLEQUIP[] saveEntities, EntityObject_MCE_B_ASSETS_ROLLEQUIP[] updateEntities, EntityObject_MCE_B_ASSETS_ROLLEQUIP[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_ROLLEQUIP saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_ROLLEQUIP deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLLEQUIP updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
