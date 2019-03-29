
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
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_METER_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_METER))]	
	public partial interface ServiceContract_MCE_B_ASSETS_METER: IServiceContractLocal<EntityObject_MCE_B_ASSETS_METER, CauseObject_MCE_B_ASSETS_METER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_METER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_METER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_METER obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_METER Get(EntityObject_MCE_B_ASSETS_METER obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER Get(DisplayObject_MCE_B_ASSETS_METER obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER[] Query(CauseObject_MCE_B_ASSETS_METER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_METER cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_METER[] Query(CauseObject_MCE_B_ASSETS_METER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_METER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_METER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_METER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_METER obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_METER Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_COM_TYPE unit_id, out EntityObject_MCE_B_ASSETS_METER_TYPE meter_type, out EntityObject_COM_USER head_user_id, out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_COM_TYPE meter_class, out EntityObject_COM_DEPART using_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER[] saveEntities, EntityObject_MCE_B_ASSETS_METER[] updateEntities, EntityObject_MCE_B_ASSETS_METER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_METER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_METER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_METER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
