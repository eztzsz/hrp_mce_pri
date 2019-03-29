
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
[ServiceKnownType(typeof(EntityObject_MDM_D_STOCK))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_OUTSTOCK))]	
	public partial interface ServiceContract_MCE_B_ASSETS_OUTSTOCK: IServiceContractLocal<EntityObject_MCE_B_ASSETS_OUTSTOCK, CauseObject_MCE_B_ASSETS_OUTSTOCK>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_OUTSTOCK Get(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK Get(DisplayObject_MCE_B_ASSETS_OUTSTOCK obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_OUTSTOCK cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_OUTSTOCK[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_OUTSTOCK Load(string id , out EntityObject_COM_USER create_user_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_USER user_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_DEPART dept_id, out EntityObject_MDM_D_STOCK stock_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK[] saveEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK[] updateEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_OUTSTOCK saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
