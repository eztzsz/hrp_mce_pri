
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
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_CONTRACT))]	
	public partial interface ServiceContract_MCE_B_ASSETS_CONTRACT: IServiceContractLocal<EntityObject_MCE_B_ASSETS_CONTRACT, CauseObject_MCE_B_ASSETS_CONTRACT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_CONTRACT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_CONTRACT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_CONTRACT obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_CONTRACT Get(EntityObject_MCE_B_ASSETS_CONTRACT obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT Get(DisplayObject_MCE_B_ASSETS_CONTRACT obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_CONTRACT cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_CONTRACT[] Query(CauseObject_MCE_B_ASSETS_CONTRACT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_CONTRACT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_CONTRACT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_CONTRACT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_CONTRACT obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_CONTRACT Load(string id , out EntityObject_COM_USER input_person, out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_COM_TYPE type_id, out EntityObject_MDM_D_DEPT second_party, out EntityObject_COM_DEPART first_party, out EntityObject_COM_USER archivist);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT[] saveEntities, EntityObject_MCE_B_ASSETS_CONTRACT[] updateEntities, EntityObject_MCE_B_ASSETS_CONTRACT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_CONTRACT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_CONTRACT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_CONTRACT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
