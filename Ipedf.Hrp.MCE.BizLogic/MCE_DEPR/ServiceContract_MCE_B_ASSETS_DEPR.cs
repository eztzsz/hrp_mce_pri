
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
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_DEPR))]	
	public partial interface ServiceContract_MCE_B_ASSETS_DEPR: IServiceContractLocal<EntityObject_MCE_B_ASSETS_DEPR, CauseObject_MCE_B_ASSETS_DEPR>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_DEPR obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_DEPR obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_DEPR obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_DEPR Get(EntityObject_MCE_B_ASSETS_DEPR obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR Get(DisplayObject_MCE_B_ASSETS_DEPR obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR[] Query(CauseObject_MCE_B_ASSETS_DEPR cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_DEPR cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_DEPR[] Query(CauseObject_MCE_B_ASSETS_DEPR cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_DEPR[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_DEPR[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_DEPR[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_DEPR obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_DEPR Load(string id , out EntityObject_COM_DEPART dept_id, out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_DEPR[] saveEntities, EntityObject_MCE_B_ASSETS_DEPR[] updateEntities, EntityObject_MCE_B_ASSETS_DEPR[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_DEPR saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_DEPR deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_DEPR updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
