
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Web.BizLogic
{
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS))]
	public partial class BizLogicObject_MCE_B_ASSETS: BizLogicBase<EntityObject_MCE_B_ASSETS>,ServiceContract_MCE_B_ASSETS
	{	
		#region Proxy 
		public BizLogicObject_MCE_B_ASSETS() { }
        private static ServiceContract_MCE_B_ASSETS singleton;
        public static ServiceContract_MCE_B_ASSETS Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_MCE_B_ASSETS();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_MCE_B_ASSETS obj)
		{
			if (LocalMode)
			{
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
	                    
						try
						{
							SystemLogic.Proxy.AuditAdd(obj);
							int amount = HelperObject_MCE_B_ASSETS.Save(obj, transaction);
					//平台自动生成代码
							PostSave(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;															
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_MCE_B_ASSETS obj)
		{
			if (LocalMode)
			{
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{ 
						try
						{
							SystemLogic.Proxy.AuditEdit(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostSave(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_MCE_B_ASSETS obj)
		{
			if (LocalMode)
			{
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{ 
						try
						{
							int amount = HelperObject_MCE_B_ASSETS.Delete(obj, transaction);
					//平台自动生成代码
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS Get(EntityObject_MCE_B_ASSETS obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS Get(DisplayObject_MCE_B_ASSETS obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_MCE_B_ASSETS cause)
		{
			if (LocalMode)
			{
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
	                    
						try
						{
							int amount = HelperObject_MCE_B_ASSETS.Delete(cause, transaction);
					//平台自动生成代码
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS[] Query(CauseObject_MCE_B_ASSETS cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS[] objs)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
						try
						{
							foreach(EntityObject_MCE_B_ASSETS obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS.Save(obj, transaction);
					}
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS[] objs)
        {
			if (LocalMode)
			{
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                   
						try
						{
							foreach(EntityObject_MCE_B_ASSETS obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					}
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS[] objs)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
						try
						{
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS.Delete(obj, transaction);
					}
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							SystemLogic.Proxy.AuditCancel(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码                       
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;	
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
	                    
						try
						{
							SystemLogic.Proxy.AuditAudit(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostAudit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已提交);
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
						try
						{
	                        
							SystemLogic.Proxy.AuditUndoAudit(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostUndoAudit(obj, transaction);
							//执行撤回操作
							msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
							if (!msg.Succeed) throw new Exception(msg.Message);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已审核);
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
	                    
						try
						{
							SystemLogic.Proxy.AuditArchive(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostArchive(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已审核);
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
	                    
						try
						{
							SystemLogic.Proxy.AuditSubmit(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.编辑中);
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
            }
            else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS obj)
        {
            if (LocalMode)
            {
				BizLogicMsg msg = new BizLogicMsg();
				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{                    
						try
						{
							SystemLogic.Proxy.AuditUndoSubmit(obj);
							int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
							PostUndoSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.数据状态.已提交);
							transaction.Rollback();
							msg = new BizLogicMsg(false, expt.Message);
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return msg;
			}
			else
            {
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_MCE_B_ASSETS obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_MCE_B_ASSETS.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_MCE_B_ASSETS obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_MCE_B_ASSETS.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_MCE_B_ASSETS obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_MCE_B_ASSETS cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_MCE_B_ASSETS Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_MDM_D_DEPT ref_dept_id, out EntityObject_COM_TYPE acquire_use_type_id, out EntityObject_COM_TYPE operating_machine_type_id, out EntityObject_COM_TYPE purchase_type_id, out EntityObject_COM_TYPE finance_type_id, out EntityObject_COM_DEPART subjection_dept_id, out EntityObject_COM_TYPE prd_place_type_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE assets_state, out EntityObject_COM_TYPE capital_source_type_id, out EntityObject_COM_TYPE biz_type_id, out EntityObject_MDM_D_DEPT provider_id, out EntityObject_COM_USER custody_user_id, out EntityObject_COM_TYPE vehicle_use_type_id, out EntityObject_MCE_D_MCE_TYPE machine_type_id, out EntityObject_COM_TYPE ownership_type_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_MCE_D_MCE_TYPE name, out EntityObject_MCE_D_DEPR_TYPE depr_type_id, out EntityObject_COM_TYPE use_state, out EntityObject_COM_TYPE economic_use_type_id, out EntityObject_COM_TYPE custody_level_id, out EntityObject_COM_TYPE acquire_ownership_type_id, out EntityObject_COM_DEPART custody_dept_id, out EntityObject_COM_TYPE nationality_id, out EntityObject_COM_TYPE value_type_id, out EntityObject_COM_TYPE machine_manage_type_id, out EntityObject_COM_TYPE energy_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE card_type_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();
				
			//平台自动生成代码
			prd_id = new EntityObject_MDM_D_DEPT() ; 
			ref_dept_id = new EntityObject_MDM_D_DEPT() ; 
			acquire_use_type_id = new EntityObject_COM_TYPE() ; 
			operating_machine_type_id = new EntityObject_COM_TYPE() ; 
			purchase_type_id = new EntityObject_COM_TYPE() ; 
			finance_type_id = new EntityObject_COM_TYPE() ; 
			subjection_dept_id = new EntityObject_COM_DEPART() ; 
			prd_place_type_id = new EntityObject_COM_TYPE() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			assets_state = new EntityObject_COM_TYPE() ; 
			capital_source_type_id = new EntityObject_COM_TYPE() ; 
			biz_type_id = new EntityObject_COM_TYPE() ; 
			provider_id = new EntityObject_MDM_D_DEPT() ; 
			custody_user_id = new EntityObject_COM_USER() ; 
			vehicle_use_type_id = new EntityObject_COM_TYPE() ; 
			machine_type_id = new EntityObject_MCE_D_MCE_TYPE() ; 
			ownership_type_id = new EntityObject_COM_TYPE() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			name = new EntityObject_MCE_D_MCE_TYPE() ; 
			depr_type_id = new EntityObject_MCE_D_DEPR_TYPE() ; 
			use_state = new EntityObject_COM_TYPE() ; 
			economic_use_type_id = new EntityObject_COM_TYPE() ; 
			custody_level_id = new EntityObject_COM_TYPE() ; 
			acquire_ownership_type_id = new EntityObject_COM_TYPE() ; 
			custody_dept_id = new EntityObject_COM_DEPART() ; 
			nationality_id = new EntityObject_COM_TYPE() ; 
			value_type_id = new EntityObject_COM_TYPE() ; 
			machine_manage_type_id = new EntityObject_COM_TYPE() ; 
			energy_type_id = new EntityObject_COM_TYPE() ; 
			unit_id = new EntityObject_COM_TYPE() ; 
			card_type_id = new EntityObject_COM_TYPE() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  prd_id, out  ref_dept_id, out  acquire_use_type_id, out  operating_machine_type_id, out  purchase_type_id, out  finance_type_id, out  subjection_dept_id, out  prd_place_type_id, out  using_user_id, out  assets_state, out  capital_source_type_id, out  biz_type_id, out  provider_id, out  custody_user_id, out  vehicle_use_type_id, out  machine_type_id, out  ownership_type_id, out  using_dept_id, out  name, out  depr_type_id, out  use_state, out  economic_use_type_id, out  custody_level_id, out  acquire_ownership_type_id, out  custody_dept_id, out  nationality_id, out  value_type_id, out  machine_manage_type_id, out  energy_type_id, out  unit_id, out  card_type_id);                
							transaction.Commit();
						}
						catch (Exception expt)
						{
							transaction.Rollback();
							Error(expt);
						}
						finally
						{
							IDALProvider.IDAL.PushConnection(connection);
						}
					}
				}
				return obj;
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Load(id , out prd_id, out ref_dept_id, out acquire_use_type_id, out operating_machine_type_id, out purchase_type_id, out finance_type_id, out subjection_dept_id, out prd_place_type_id, out using_user_id, out assets_state, out capital_source_type_id, out biz_type_id, out provider_id, out custody_user_id, out vehicle_use_type_id, out machine_type_id, out ownership_type_id, out using_dept_id, out name, out depr_type_id, out use_state, out economic_use_type_id, out custody_level_id, out acquire_ownership_type_id, out custody_dept_id, out nationality_id, out value_type_id, out machine_manage_type_id, out energy_type_id, out unit_id, out card_type_id);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS Load(IDbTransaction transaction,string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_MDM_D_DEPT ref_dept_id, out EntityObject_COM_TYPE acquire_use_type_id, out EntityObject_COM_TYPE operating_machine_type_id, out EntityObject_COM_TYPE purchase_type_id, out EntityObject_COM_TYPE finance_type_id, out EntityObject_COM_DEPART subjection_dept_id, out EntityObject_COM_TYPE prd_place_type_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE assets_state, out EntityObject_COM_TYPE capital_source_type_id, out EntityObject_COM_TYPE biz_type_id, out EntityObject_MDM_D_DEPT provider_id, out EntityObject_COM_USER custody_user_id, out EntityObject_COM_TYPE vehicle_use_type_id, out EntityObject_MCE_D_MCE_TYPE machine_type_id, out EntityObject_COM_TYPE ownership_type_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_MCE_D_MCE_TYPE name, out EntityObject_MCE_D_DEPR_TYPE depr_type_id, out EntityObject_COM_TYPE use_state, out EntityObject_COM_TYPE economic_use_type_id, out EntityObject_COM_TYPE custody_level_id, out EntityObject_COM_TYPE acquire_ownership_type_id, out EntityObject_COM_DEPART custody_dept_id, out EntityObject_COM_TYPE nationality_id, out EntityObject_COM_TYPE value_type_id, out EntityObject_COM_TYPE machine_manage_type_id, out EntityObject_COM_TYPE energy_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE card_type_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();
				
			//平台自动生成代码
			prd_id = new EntityObject_MDM_D_DEPT() ; 
			ref_dept_id = new EntityObject_MDM_D_DEPT() ; 
			acquire_use_type_id = new EntityObject_COM_TYPE() ; 
			operating_machine_type_id = new EntityObject_COM_TYPE() ; 
			purchase_type_id = new EntityObject_COM_TYPE() ; 
			finance_type_id = new EntityObject_COM_TYPE() ; 
			subjection_dept_id = new EntityObject_COM_DEPART() ; 
			prd_place_type_id = new EntityObject_COM_TYPE() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			assets_state = new EntityObject_COM_TYPE() ; 
			capital_source_type_id = new EntityObject_COM_TYPE() ; 
			biz_type_id = new EntityObject_COM_TYPE() ; 
			provider_id = new EntityObject_MDM_D_DEPT() ; 
			custody_user_id = new EntityObject_COM_USER() ; 
			vehicle_use_type_id = new EntityObject_COM_TYPE() ; 
			machine_type_id = new EntityObject_MCE_D_MCE_TYPE() ; 
			ownership_type_id = new EntityObject_COM_TYPE() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			name = new EntityObject_MCE_D_MCE_TYPE() ; 
			depr_type_id = new EntityObject_MCE_D_DEPR_TYPE() ; 
			use_state = new EntityObject_COM_TYPE() ; 
			economic_use_type_id = new EntityObject_COM_TYPE() ; 
			custody_level_id = new EntityObject_COM_TYPE() ; 
			acquire_ownership_type_id = new EntityObject_COM_TYPE() ; 
			custody_dept_id = new EntityObject_COM_DEPART() ; 
			nationality_id = new EntityObject_COM_TYPE() ; 
			value_type_id = new EntityObject_COM_TYPE() ; 
			machine_manage_type_id = new EntityObject_COM_TYPE() ; 
			energy_type_id = new EntityObject_COM_TYPE() ; 
			unit_id = new EntityObject_COM_TYPE() ; 
			card_type_id = new EntityObject_COM_TYPE() ; 
     
				
						obj.ID= id;
						obj = HelperObject_MCE_B_ASSETS.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.PRD_ID))
						{
							prd_id.ID = obj.PRD_ID;
							prd_id = HelperObject_MDM_D_DEPT.Get(prd_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.REF_DEPT_ID))
						{
							ref_dept_id.ID = obj.REF_DEPT_ID;
							ref_dept_id = HelperObject_MDM_D_DEPT.Get(ref_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ACQUIRE_USE_TYPE_ID))
						{
							acquire_use_type_id.ID = obj.ACQUIRE_USE_TYPE_ID;
							acquire_use_type_id = HelperObject_COM_TYPE.Get(acquire_use_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.OPERATING_MACHINE_TYPE_ID))
						{
							operating_machine_type_id.ID = obj.OPERATING_MACHINE_TYPE_ID;
							operating_machine_type_id = HelperObject_COM_TYPE.Get(operating_machine_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.PURCHASE_TYPE_ID))
						{
							purchase_type_id.ID = obj.PURCHASE_TYPE_ID;
							purchase_type_id = HelperObject_COM_TYPE.Get(purchase_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.FINANCE_TYPE_ID))
						{
							finance_type_id.ID = obj.FINANCE_TYPE_ID;
							finance_type_id = HelperObject_COM_TYPE.Get(finance_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.SUBJECTION_DEPT_ID))
						{
							subjection_dept_id.ID = obj.SUBJECTION_DEPT_ID;
							subjection_dept_id = HelperObject_COM_DEPART.Get(subjection_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.PRD_PLACE_TYPE_ID))
						{
							prd_place_type_id.ID = obj.PRD_PLACE_TYPE_ID;
							prd_place_type_id = HelperObject_COM_TYPE.Get(prd_place_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_USER_ID))
						{
							using_user_id.ID = obj.USING_USER_ID;
							using_user_id = HelperObject_COM_USER.Get(using_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ASSETS_STATE))
						{
							assets_state.ID = obj.ASSETS_STATE;
							assets_state = HelperObject_COM_TYPE.Get(assets_state, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CAPITAL_SOURCE_TYPE_ID))
						{
							capital_source_type_id.ID = obj.CAPITAL_SOURCE_TYPE_ID;
							capital_source_type_id = HelperObject_COM_TYPE.Get(capital_source_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.BIZ_TYPE_ID))
						{
							biz_type_id.ID = obj.BIZ_TYPE_ID;
							biz_type_id = HelperObject_COM_TYPE.Get(biz_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.PROVIDER_ID))
						{
							provider_id.ID = obj.PROVIDER_ID;
							provider_id = HelperObject_MDM_D_DEPT.Get(provider_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CUSTODY_USER_ID))
						{
							custody_user_id.ID = obj.CUSTODY_USER_ID;
							custody_user_id = HelperObject_COM_USER.Get(custody_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.VEHICLE_USE_TYPE_ID))
						{
							vehicle_use_type_id.ID = obj.VEHICLE_USE_TYPE_ID;
							vehicle_use_type_id = HelperObject_COM_TYPE.Get(vehicle_use_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.MACHINE_TYPE_ID))
						{
							machine_type_id.ID = obj.MACHINE_TYPE_ID;
							machine_type_id = HelperObject_MCE_D_MCE_TYPE.Get(machine_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.OWNERSHIP_TYPE_ID))
						{
							ownership_type_id.ID = obj.OWNERSHIP_TYPE_ID;
							ownership_type_id = HelperObject_COM_TYPE.Get(ownership_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_DEPT_ID))
						{
							using_dept_id.ID = obj.USING_DEPT_ID;
							using_dept_id = HelperObject_COM_DEPART.Get(using_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.NAME))
						{
							name.ID = obj.NAME;
							name = HelperObject_MCE_D_MCE_TYPE.Get(name, transaction);
						}
						if (!string.IsNullOrEmpty(obj.DEPR_TYPE_ID))
						{
							depr_type_id.ID = obj.DEPR_TYPE_ID;
							depr_type_id = HelperObject_MCE_D_DEPR_TYPE.Get(depr_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USE_STATE))
						{
							use_state.ID = obj.USE_STATE;
							use_state = HelperObject_COM_TYPE.Get(use_state, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ECONOMIC_USE_TYPE_ID))
						{
							economic_use_type_id.ID = obj.ECONOMIC_USE_TYPE_ID;
							economic_use_type_id = HelperObject_COM_TYPE.Get(economic_use_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CUSTODY_LEVEL_ID))
						{
							custody_level_id.ID = obj.CUSTODY_LEVEL_ID;
							custody_level_id = HelperObject_COM_TYPE.Get(custody_level_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ACQUIRE_OWNERSHIP_TYPE_ID))
						{
							acquire_ownership_type_id.ID = obj.ACQUIRE_OWNERSHIP_TYPE_ID;
							acquire_ownership_type_id = HelperObject_COM_TYPE.Get(acquire_ownership_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CUSTODY_DEPT_ID))
						{
							custody_dept_id.ID = obj.CUSTODY_DEPT_ID;
							custody_dept_id = HelperObject_COM_DEPART.Get(custody_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.NATIONALITY_ID))
						{
							nationality_id.ID = obj.NATIONALITY_ID;
							nationality_id = HelperObject_COM_TYPE.Get(nationality_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.VALUE_TYPE_ID))
						{
							value_type_id.ID = obj.VALUE_TYPE_ID;
							value_type_id = HelperObject_COM_TYPE.Get(value_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.MACHINE_MANAGE_TYPE_ID))
						{
							machine_manage_type_id.ID = obj.MACHINE_MANAGE_TYPE_ID;
							machine_manage_type_id = HelperObject_COM_TYPE.Get(machine_manage_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ENERGY_TYPE_ID))
						{
							energy_type_id.ID = obj.ENERGY_TYPE_ID;
							energy_type_id = HelperObject_COM_TYPE.Get(energy_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.UNIT_ID))
						{
							unit_id.ID = obj.UNIT_ID;
							unit_id = HelperObject_COM_TYPE.Get(unit_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CARD_TYPE_ID))
						{
							card_type_id.ID = obj.CARD_TYPE_ID;
							card_type_id = HelperObject_COM_TYPE.Get(card_type_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS[] saveEntities, EntityObject_MCE_B_ASSETS[] updateEntities, EntityObject_MCE_B_ASSETS[] deleteEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //平台自动生成代码
                            foreach (EntityObject_MCE_B_ASSETS obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS.Save(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_MCE_B_ASSETS.Update(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS obj in deleteEntities)
                            {
                                HelperObject_MCE_B_ASSETS.Delete(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS saveBaseEntity, EntityObject_[] saveDetailEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditAdd(saveBaseEntity);
                            HelperObject_MCE_B_ASSETS.Save(saveBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
                            }
                            PostSave(saveBaseEntity, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS deleteBaseEntity)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //平台自动生成代码
                            CauseObject_ p = new CauseObject_();
                            p. = deleteBaseEntity.ID;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_MCE_B_ASSETS.Delete(deleteBaseEntity, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditEdit(updateBaseEntity);
                            HelperObject_MCE_B_ASSETS.Update(updateBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_ obj in saveDetailEntities)
                            {
                                obj. = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_.Save(obj, transaction);
                            }
                            foreach (EntityObject_ obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_.Update(obj, transaction);
                            }
                            foreach (EntityObject_ obj in deleteDetailEntities)
                            {
                                HelperObject_.Delete(obj, transaction);
                            }
                            PostSave(updateBaseEntity, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
