
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
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_FILETEMPLATE))]	
	public partial interface ServiceContract_MCE_B_ASSETS_FILETEMPLATE: IServiceContractLocal<EntityObject_MCE_B_ASSETS_FILETEMPLATE, CauseObject_MCE_B_ASSETS_FILETEMPLATE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_FILETEMPLATE Get(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_FILETEMPLATE Get(DisplayObject_MCE_B_ASSETS_FILETEMPLATE obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_FILETEMPLATE[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_FILETEMPLATE[] Query(CauseObject_MCE_B_ASSETS_FILETEMPLATE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_FILETEMPLATE cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_FILETEMPLATE[] Query(CauseObject_MCE_B_ASSETS_FILETEMPLATE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_FILETEMPLATE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_FILETEMPLATE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_FILETEMPLATE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_FILETEMPLATE obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_FILETEMPLATE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_FILETEMPLATE[] saveEntities, EntityObject_MCE_B_ASSETS_FILETEMPLATE[] updateEntities, EntityObject_MCE_B_ASSETS_FILETEMPLATE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_FILETEMPLATE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_FILETEMPLATE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_FILETEMPLATE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
