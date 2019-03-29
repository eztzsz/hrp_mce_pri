
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
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_TRANSFER))]	
	public partial interface ServiceContract_MCE_B_ASSETS_TRANSFER: IServiceContractLocal<EntityObject_MCE_B_ASSETS_TRANSFER, CauseObject_MCE_B_ASSETS_TRANSFER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_TRANSFER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_TRANSFER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_TRANSFER obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_TRANSFER Get(EntityObject_MCE_B_ASSETS_TRANSFER obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_TRANSFER Get(DisplayObject_MCE_B_ASSETS_TRANSFER obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_TRANSFER[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_TRANSFER[] Query(CauseObject_MCE_B_ASSETS_TRANSFER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_TRANSFER cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_TRANSFER[] Query(CauseObject_MCE_B_ASSETS_TRANSFER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_TRANSFER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_TRANSFER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_TRANSFER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_TRANSFER obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_TRANSFER Load(string id , out EntityObject_COM_USER transfer_user_id, out EntityObject_COM_DEPART dept_id, out EntityObject_COM_USER create_user_id, out EntityObject_COM_USER user_id, out EntityObject_COM_DEPART transfer_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_TRANSFER[] saveEntities, EntityObject_MCE_B_ASSETS_TRANSFER[] updateEntities, EntityObject_MCE_B_ASSETS_TRANSFER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_TRANSFER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_TRANSFER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_TRANSFER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
