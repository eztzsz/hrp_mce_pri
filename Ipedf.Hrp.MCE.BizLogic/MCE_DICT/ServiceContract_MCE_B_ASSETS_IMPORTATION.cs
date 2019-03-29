
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
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MCE_B_ASSETS_IMPORTATION))]	
	public partial interface ServiceContract_MCE_B_ASSETS_IMPORTATION: IServiceContractLocal<EntityObject_MCE_B_ASSETS_IMPORTATION, CauseObject_MCE_B_ASSETS_IMPORTATION>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
		[OperationContract]
		EntityObject_MCE_B_ASSETS_IMPORTATION Get(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_IMPORTATION Get(DisplayObject_MCE_B_ASSETS_IMPORTATION obj);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_IMPORTATION[] List();
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_IMPORTATION cause);
		[OperationContract]
		DisplayObject_MCE_B_ASSETS_IMPORTATION[] Query(CauseObject_MCE_B_ASSETS_IMPORTATION cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_IMPORTATION[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_IMPORTATION[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_IMPORTATION[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_IMPORTATION obj);
        [OperationContract]
        EntityObject_MCE_B_ASSETS_IMPORTATION Load(string id , out EntityObject_MCE_B_ASSETS assets_id, out EntityObject_COM_TYPE currency_id, out EntityObject_COM_TYPE foreign_currency_source_id, out EntityObject_COM_TYPE country_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_IMPORTATION[] saveEntities, EntityObject_MCE_B_ASSETS_IMPORTATION[] updateEntities, EntityObject_MCE_B_ASSETS_IMPORTATION[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_IMPORTATION saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_IMPORTATION deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_IMPORTATION updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
