
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
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_ROLLFILE))]	
	public partial interface ServiceContract_MCE_B_ASSETS_ROLLFILE: IServiceContractLocal<EntityObject_MCE_B_ASSETS_ROLLFILE, CauseObject_MCE_B_ASSETS_ROLLFILE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_ROLLFILE Get(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLFILE Get(DisplayObject_MCE_B_ASSETS_ROLLFILE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLFILE[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_ROLLFILE cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLLFILE[] Query(CauseObject_MCE_B_ASSETS_ROLLFILE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_ROLLFILE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_ROLLFILE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_ROLLFILE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_ROLLFILE obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_ROLLFILE Load(string id , out EntityObject_MCE_B_ASSETS_ROLL base_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLLFILE[] saveEntities, EntityObject_MCE_B_ASSETS_ROLLFILE[] updateEntities, EntityObject_MCE_B_ASSETS_ROLLFILE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_ROLLFILE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_ROLLFILE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLLFILE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
