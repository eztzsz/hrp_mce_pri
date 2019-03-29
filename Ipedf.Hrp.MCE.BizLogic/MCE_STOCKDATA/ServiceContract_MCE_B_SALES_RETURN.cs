
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
		
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_STOCK))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_SALES_RETURN))]	
	public partial interface ServiceContract_MCE_B_SALES_RETURN: IServiceContractLocal<EntityObject_MCE_B_SALES_RETURN, CauseObject_MCE_B_SALES_RETURN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_SALES_RETURN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_SALES_RETURN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_SALES_RETURN obj);
		[OperationContract]
		EntityObject_MCE_B_SALES_RETURN Get(EntityObject_MCE_B_SALES_RETURN obj);
		[OperationContract]
		DisplayObject_MCE_B_SALES_RETURN Get(DisplayObject_MCE_B_SALES_RETURN obj);
		[OperationContract]
		DisplayObject_MCE_B_SALES_RETURN[] List();
		[OperationContract]
		DisplayObject_MCE_B_SALES_RETURN[] Query(CauseObject_MCE_B_SALES_RETURN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_SALES_RETURN cause);
		[OperationContract]
		DisplayObject_MCE_B_SALES_RETURN[] Query(CauseObject_MCE_B_SALES_RETURN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_SALES_RETURN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_SALES_RETURN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_SALES_RETURN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_SALES_RETURN obj);
        [OperationContract]
        EntityObject_MCE_B_SALES_RETURN Load(string id , out EntityObject_MDM_D_DEPT provider_id, out EntityObject_MDM_D_STOCK stock_id, out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_SALES_RETURN[] saveEntities, EntityObject_MCE_B_SALES_RETURN[] updateEntities, EntityObject_MCE_B_SALES_RETURN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_SALES_RETURN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_SALES_RETURN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_SALES_RETURN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
