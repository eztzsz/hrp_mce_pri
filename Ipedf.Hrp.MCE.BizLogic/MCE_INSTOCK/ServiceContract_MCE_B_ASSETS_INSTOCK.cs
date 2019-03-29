
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
[ServiceKnownType(typeof(EntityObject_MDM_D_STOCK))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_INSTOCK))]	
	public partial interface ServiceContract_MCE_B_ASSETS_INSTOCK: IServiceContractLocal<EntityObject_MCE_B_ASSETS_INSTOCK, CauseObject_MCE_B_ASSETS_INSTOCK>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_INSTOCK obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_INSTOCK obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_INSTOCK obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_INSTOCK Get(EntityObject_MCE_B_ASSETS_INSTOCK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSTOCK Get(DisplayObject_MCE_B_ASSETS_INSTOCK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSTOCK[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_INSTOCK cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_INSTOCK[] Query(CauseObject_MCE_B_ASSETS_INSTOCK cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_INSTOCK[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_INSTOCK[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_INSTOCK[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_INSTOCK obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_INSTOCK Load(string id , out EntityObject_COM_DEPART dept_id, out EntityObject_MDM_D_STOCK warehouse_id, out EntityObject_COM_USER user_id, out EntityObject_MDM_D_DEPT provider_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_INSTOCK[] saveEntities, EntityObject_MCE_B_ASSETS_INSTOCK[] updateEntities, EntityObject_MCE_B_ASSETS_INSTOCK[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_INSTOCK saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_INSTOCK deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_INSTOCK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
