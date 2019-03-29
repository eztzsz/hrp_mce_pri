
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_WRITE_OFF))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH))]	
	public partial interface ServiceContract_MCE_B_ASSETS_WRITE_OFF_ATTACH: IServiceContractLocal<EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH, CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Get(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Get(DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] Query(CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH Load(string id , out EntityObject_MCE_B_ASSETS_WRITE_OFF base_id, out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] saveEntities, EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] updateEntities, EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
