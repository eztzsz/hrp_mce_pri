
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
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT))]	
	public partial interface ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT: IServiceContractLocal<EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT, CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT Get(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT Get(DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CAPITAL_ALLOT[] Query(CauseObject_MCE_B_ASSETS_CAPITAL_ALLOT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT Load(string id , out EntityObject_COM_TYPE capital_source_type_id, out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] saveEntities, EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] updateEntities, EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
