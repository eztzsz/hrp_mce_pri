
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
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]	
	public partial interface ServiceContract_MCE_D_MCE_TYPE: IServiceContractLocal<EntityObject_MCE_D_MCE_TYPE, CauseObject_MCE_D_MCE_TYPE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_D_MCE_TYPE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_D_MCE_TYPE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_D_MCE_TYPE obj);
		[OperationContract]
		EntityObject_MCE_D_MCE_TYPE Get(EntityObject_MCE_D_MCE_TYPE obj);
		[OperationContract]
		DisplayObject_MCE_D_MCE_TYPE Get(DisplayObject_MCE_D_MCE_TYPE obj);
		[OperationContract]
		DisplayObject_MCE_D_MCE_TYPE[] List();
		[OperationContract]
		DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_D_MCE_TYPE cause);
		[OperationContract]
		DisplayObject_MCE_D_MCE_TYPE[] Query(CauseObject_MCE_D_MCE_TYPE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_D_MCE_TYPE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_D_MCE_TYPE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_D_MCE_TYPE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_D_MCE_TYPE obj);
        [OperationContract]
        EntityObject_MCE_D_MCE_TYPE Load(string id , out EntityObject_COM_TYPE unit_id, out EntityObject_MCE_D_MCE_TYPE parent_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_D_MCE_TYPE[] saveEntities, EntityObject_MCE_D_MCE_TYPE[] updateEntities, EntityObject_MCE_D_MCE_TYPE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_D_MCE_TYPE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_D_MCE_TYPE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_D_MCE_TYPE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
