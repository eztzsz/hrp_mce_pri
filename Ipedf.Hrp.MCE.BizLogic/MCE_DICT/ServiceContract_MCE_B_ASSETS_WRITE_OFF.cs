
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
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_WRITE_OFF))]	
	public partial interface ServiceContract_MCE_B_ASSETS_WRITE_OFF: IServiceContractLocal<EntityObject_MCE_B_ASSETS_WRITE_OFF, CauseObject_MCE_B_ASSETS_WRITE_OFF>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_WRITE_OFF Get(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF Get(DisplayObject_MCE_B_ASSETS_WRITE_OFF obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_WRITE_OFF cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_WRITE_OFF[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_WRITE_OFF[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_WRITE_OFF obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_WRITE_OFF Load(string id , out EntityObject_COM_USER identity_user_id, out EntityObject_COM_TYPE write_off_type_id, out EntityObject_COM_DEPART dept_id, out EntityObject_COM_TYPE write_off_cause_id, out EntityObject_COM_USER audit_user_id, out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF[] saveEntities, EntityObject_MCE_B_ASSETS_WRITE_OFF[] updateEntities, EntityObject_MCE_B_ASSETS_WRITE_OFF[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_WRITE_OFF saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_WRITE_OFF deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
