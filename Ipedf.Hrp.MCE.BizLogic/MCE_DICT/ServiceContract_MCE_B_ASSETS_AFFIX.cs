
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
		
[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_AFFIX))]	
	public partial interface ServiceContract_MCE_B_ASSETS_AFFIX: IServiceContractLocal<EntityObject_MCE_B_ASSETS_AFFIX, CauseObject_MCE_B_ASSETS_AFFIX>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_AFFIX obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_AFFIX obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_AFFIX obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_AFFIX Get(EntityObject_MCE_B_ASSETS_AFFIX obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_AFFIX Get(DisplayObject_MCE_B_ASSETS_AFFIX obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_AFFIX[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_AFFIX cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_AFFIX[] Query(CauseObject_MCE_B_ASSETS_AFFIX cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_AFFIX[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_AFFIX[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_AFFIX[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_AFFIX obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_AFFIX Load(string id , out EntityObject_MCE_B_ASSETS assets_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_AFFIX[] saveEntities, EntityObject_MCE_B_ASSETS_AFFIX[] updateEntities, EntityObject_MCE_B_ASSETS_AFFIX[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_AFFIX saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_AFFIX deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_AFFIX updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
