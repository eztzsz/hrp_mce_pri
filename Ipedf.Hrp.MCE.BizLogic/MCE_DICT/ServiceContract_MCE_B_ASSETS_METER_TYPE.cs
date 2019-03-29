
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
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_METER_TYPE))]	
	public partial interface ServiceContract_MCE_B_ASSETS_METER_TYPE: IServiceContractLocal<EntityObject_MCE_B_ASSETS_METER_TYPE, CauseObject_MCE_B_ASSETS_METER_TYPE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_METER_TYPE Get(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_TYPE Get(DisplayObject_MCE_B_ASSETS_METER_TYPE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_TYPE[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_TYPE[] Query(CauseObject_MCE_B_ASSETS_METER_TYPE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_METER_TYPE cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER_TYPE[] Query(CauseObject_MCE_B_ASSETS_METER_TYPE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_METER_TYPE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_METER_TYPE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_METER_TYPE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_METER_TYPE obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_METER_TYPE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER_TYPE[] saveEntities, EntityObject_MCE_B_ASSETS_METER_TYPE[] updateEntities, EntityObject_MCE_B_ASSETS_METER_TYPE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_METER_TYPE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_METER_TYPE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER_TYPE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
