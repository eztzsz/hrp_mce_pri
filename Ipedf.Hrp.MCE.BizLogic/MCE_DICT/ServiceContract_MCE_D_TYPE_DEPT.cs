
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
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_MCE_D_MCE_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_D_TYPE_DEPT))]	
	public partial interface ServiceContract_MCE_D_TYPE_DEPT: IServiceContractLocal<EntityObject_MCE_D_TYPE_DEPT, CauseObject_MCE_D_TYPE_DEPT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_D_TYPE_DEPT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_D_TYPE_DEPT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_D_TYPE_DEPT obj);
		[OperationContract]
		EntityObject_MCE_D_TYPE_DEPT Get(EntityObject_MCE_D_TYPE_DEPT obj);
		[OperationContract]
		DisplayObject_MCE_D_TYPE_DEPT Get(DisplayObject_MCE_D_TYPE_DEPT obj);
		[OperationContract]
		DisplayObject_MCE_D_TYPE_DEPT[] List();
		[OperationContract]
		DisplayObject_MCE_D_TYPE_DEPT[] Query(CauseObject_MCE_D_TYPE_DEPT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_D_TYPE_DEPT cause);
		[OperationContract]
		DisplayObject_MCE_D_TYPE_DEPT[] Query(CauseObject_MCE_D_TYPE_DEPT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_D_TYPE_DEPT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_D_TYPE_DEPT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_D_TYPE_DEPT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_D_TYPE_DEPT obj);
        [OperationContract]
        EntityObject_MCE_D_TYPE_DEPT Load(string id , out EntityObject_COM_DEPART dept_id, out EntityObject_MCE_D_MCE_TYPE mce_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_D_TYPE_DEPT[] saveEntities, EntityObject_MCE_D_TYPE_DEPT[] updateEntities, EntityObject_MCE_D_TYPE_DEPT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_D_TYPE_DEPT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_D_TYPE_DEPT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_D_TYPE_DEPT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
