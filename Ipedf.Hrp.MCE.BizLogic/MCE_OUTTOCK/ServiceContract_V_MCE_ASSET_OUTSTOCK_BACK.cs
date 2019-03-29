
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
	[ServiceKnownType(typeof(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK))]	
	public partial interface ServiceContract_V_MCE_ASSET_OUTSTOCK_BACK: IServiceContractLocal<EntityObject_V_MCE_ASSET_OUTSTOCK_BACK, CauseObject_V_MCE_ASSET_OUTSTOCK_BACK>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
		[OperationContract]
		EntityObject_V_MCE_ASSET_OUTSTOCK_BACK Get(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK Get(DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
		[OperationContract]
		DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] List();
		[OperationContract]
		DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause);
		[OperationContract]
		DisplayObject_V_MCE_ASSET_OUTSTOCK_BACK[] Query(CauseObject_V_MCE_ASSET_OUTSTOCK_BACK cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK obj);
        [OperationContract]
        EntityObject_V_MCE_ASSET_OUTSTOCK_BACK Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] saveEntities, EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] updateEntities, EntityObject_V_MCE_ASSET_OUTSTOCK_BACK[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_MCE_ASSET_OUTSTOCK_BACK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
