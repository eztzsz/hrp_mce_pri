
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
	[ServiceKnownType(typeof(EntityObject_V_MCE_ASSETS_ROLL))]	
	public partial interface ServiceContract_V_MCE_ASSETS_ROLL: IServiceContractLocal<EntityObject_V_MCE_ASSETS_ROLL, CauseObject_V_MCE_ASSETS_ROLL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_ASSETS_ROLL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_ASSETS_ROLL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_ASSETS_ROLL obj);
		[OperationContract]
		EntityObject_V_MCE_ASSETS_ROLL Get(EntityObject_V_MCE_ASSETS_ROLL obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLL Get(DisplayObject_V_MCE_ASSETS_ROLL obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLL[] List();
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_ASSETS_ROLL cause);
		[OperationContract]
		DisplayObject_V_MCE_ASSETS_ROLL[] Query(CauseObject_V_MCE_ASSETS_ROLL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_ASSETS_ROLL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_ASSETS_ROLL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_ASSETS_ROLL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_ASSETS_ROLL obj);
        [OperationContract]
        EntityObject_V_MCE_ASSETS_ROLL Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_ROLL[] saveEntities, EntityObject_V_MCE_ASSETS_ROLL[] updateEntities, EntityObject_V_MCE_ASSETS_ROLL[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_ASSETS_ROLL saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_ASSETS_ROLL deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSETS_ROLL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
