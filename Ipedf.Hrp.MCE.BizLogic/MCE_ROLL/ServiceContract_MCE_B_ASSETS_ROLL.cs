
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_ROLL))]	
	public partial interface ServiceContract_MCE_B_ASSETS_ROLL: IServiceContractLocal<EntityObject_MCE_B_ASSETS_ROLL, CauseObject_MCE_B_ASSETS_ROLL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_ROLL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_ROLL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_ROLL obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_ROLL Get(EntityObject_MCE_B_ASSETS_ROLL obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLL Get(DisplayObject_MCE_B_ASSETS_ROLL obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLL[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLL[] Query(CauseObject_MCE_B_ASSETS_ROLL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_ROLL cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_ROLL[] Query(CauseObject_MCE_B_ASSETS_ROLL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_ROLL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_ROLL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_ROLL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_ROLL obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_ROLL Load(string id , out EntityObject_COM_TYPE roll_property, out EntityObject_COM_USER create_user_id, out EntityObject_COM_TYPE savelimit, out EntityObject_COM_TYPE roll_type, out EntityObject_COM_TYPE plan_type);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLL[] saveEntities, EntityObject_MCE_B_ASSETS_ROLL[] updateEntities, EntityObject_MCE_B_ASSETS_ROLL[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_ROLL saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_ROLL deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_ROLL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
