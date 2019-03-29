
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
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_AOG))]	
	public partial interface ServiceContract_MCE_B_AOG: IServiceContractLocal<EntityObject_MCE_B_AOG, CauseObject_MCE_B_AOG>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_AOG obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_AOG obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_AOG obj);
		[OperationContract]
		EntityObject_MCE_B_AOG Get(EntityObject_MCE_B_AOG obj);
		[OperationContract]
		DisplayObject_MCE_B_AOG Get(DisplayObject_MCE_B_AOG obj);
		[OperationContract]
		DisplayObject_MCE_B_AOG[] List();
		[OperationContract]
		DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_AOG cause);
		[OperationContract]
		DisplayObject_MCE_B_AOG[] Query(CauseObject_MCE_B_AOG cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_AOG[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_AOG[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_AOG[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_AOG obj);
        [OperationContract]
        EntityObject_MCE_B_AOG Load(string id , out EntityObject_COM_DEPART use_dept_id, out EntityObject_COM_USER use_user_id, out EntityObject_MDM_D_DEPT provider_id, out EntityObject_COM_USER install_user_id, out EntityObject_MDM_D_DEPT dealer_id, out EntityObject_COM_USER purcharse_person_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_AOG[] saveEntities, EntityObject_MCE_B_AOG[] updateEntities, EntityObject_MCE_B_AOG[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_AOG saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_AOG deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_AOG updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
