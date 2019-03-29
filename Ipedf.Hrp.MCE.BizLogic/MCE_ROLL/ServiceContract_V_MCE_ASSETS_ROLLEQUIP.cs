
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
	
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_MCE_ASSETS_ROLLEQUIP))]	
	public partial interface ServiceContract_V_MCE_ASSETS_ROLLEQUIP: IServiceContractLocal<EntityObject_V_MCE_ASSETS_ROLLEQUIP, CauseObject_V_MCE_ASSETS_ROLLEQUIP>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		EntityObject_V_MCE_ASSETS_ROLLEQUIP Get(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLLEQUIP Get(DisplayObject_V_MCE_ASSETS_ROLLEQUIP obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] List();
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLLEQUIP[] Query(CauseObject_V_MCE_ASSETS_ROLLEQUIP cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_ASSETS_ROLLEQUIP[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_ASSETS_ROLLEQUIP[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_ASSETS_ROLLEQUIP[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_ASSETS_ROLLEQUIP obj);
        [OperationContract]
        EntityObject_V_MCE_ASSETS_ROLLEQUIP Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_ROLLEQUIP[] saveEntities, EntityObject_V_MCE_ASSETS_ROLLEQUIP[] updateEntities, EntityObject_V_MCE_ASSETS_ROLLEQUIP[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_ASSETS_ROLLEQUIP saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_ASSETS_ROLLEQUIP deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_ROLLEQUIP updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
