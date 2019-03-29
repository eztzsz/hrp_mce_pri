
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
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_STOCK))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_BACK))]	
	public partial interface ServiceContract_MCE_B_ASSETS_BACK: IServiceContractLocal<EntityObject_MCE_B_ASSETS_BACK, CauseObject_MCE_B_ASSETS_BACK>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_BACK obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_BACK obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_BACK obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_BACK Get(EntityObject_MCE_B_ASSETS_BACK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_BACK Get(DisplayObject_MCE_B_ASSETS_BACK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_BACK[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_BACK[] Query(CauseObject_MCE_B_ASSETS_BACK cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_BACK cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_BACK[] Query(CauseObject_MCE_B_ASSETS_BACK cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_BACK[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_BACK[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_BACK[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_BACK obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_BACK Load(string id , out EntityObject_COM_DEPART return_dept_id, out EntityObject_COM_USER user_id, out EntityObject_COM_DEPART dept_id, out EntityObject_MDM_D_STOCK stock_id, out EntityObject_COM_USER return_user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_BACK[] saveEntities, EntityObject_MCE_B_ASSETS_BACK[] updateEntities, EntityObject_MCE_B_ASSETS_BACK[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_BACK saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_BACK deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_BACK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
