
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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_MT_APPLY))]
	public partial class BizLogicObject_MCE_B_ASSETS_MT_APPLY: BizLogicBase<EntityObject_MCE_B_ASSETS_MT_APPLY>,ServiceContract_MCE_B_ASSETS_MT_APPLY
	{	
		#region Proxy 
		public BizLogicObject_MCE_B_ASSETS_MT_APPLY() { }
        private static ServiceContract_MCE_B_ASSETS_MT_APPLY singleton;
        public static ServiceContract_MCE_B_ASSETS_MT_APPLY Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_MCE_B_ASSETS_MT_APPLY();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_MT_APPLY Get(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_MT_APPLY Get(DisplayObject_MCE_B_ASSETS_MT_APPLY obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_MT_APPLY[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_MT_APPLY.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_MT_APPLY.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_MT_APPLY cause)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_MT_APPLY[] Query(CauseObject_MCE_B_ASSETS_MT_APPLY cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_MT_APPLY.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_MT_APPLY obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_MT_APPLY.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_MT_APPLY obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_MT_APPLY[] objs)
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
					foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_MT_APPLY obj)
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
							int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_MCE_B_ASSETS_MT_APPLY obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_MCE_B_ASSETS_MT_APPLY obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_MCE_B_ASSETS_MT_APPLY obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_MCE_B_ASSETS_MT_APPLY cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_MCE_B_ASSETS_MT_APPLY Load(string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_COM_USER apply_user_id, out EntityObject_COM_TYPE mtn_type_id, out EntityObject_COM_DEPART apply_dept_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE repair_result, out EntityObject_MCE_D_MCE_TYPE assets_type_id, out EntityObject_COM_TYPE emergency_degree, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_TYPE fault_type, out EntityObject_MCE_B_ASSETS assets_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_MT_APPLY obj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
				
			//平台自动生成代码
			prd_id = new EntityObject_MDM_D_DEPT() ; 
			apply_user_id = new EntityObject_COM_USER() ; 
			mtn_type_id = new EntityObject_COM_TYPE() ; 
			apply_dept_id = new EntityObject_COM_DEPART() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			repair_result = new EntityObject_COM_TYPE() ; 
			assets_type_id = new EntityObject_MCE_D_MCE_TYPE() ; 
			emergency_degree = new EntityObject_COM_TYPE() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			fault_type = new EntityObject_COM_TYPE() ; 
			assets_id = new EntityObject_MCE_B_ASSETS() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  prd_id, out  apply_user_id, out  mtn_type_id, out  apply_dept_id, out  using_user_id, out  repair_result, out  assets_type_id, out  emergency_degree, out  using_dept_id, out  fault_type, out  assets_id);                
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Load(id , out prd_id, out apply_user_id, out mtn_type_id, out apply_dept_id, out using_user_id, out repair_result, out assets_type_id, out emergency_degree, out using_dept_id, out fault_type, out assets_id);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_MT_APPLY Load(IDbTransaction transaction,string id , out EntityObject_MDM_D_DEPT prd_id, out EntityObject_COM_USER apply_user_id, out EntityObject_COM_TYPE mtn_type_id, out EntityObject_COM_DEPART apply_dept_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_TYPE repair_result, out EntityObject_MCE_D_MCE_TYPE assets_type_id, out EntityObject_COM_TYPE emergency_degree, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_TYPE fault_type, out EntityObject_MCE_B_ASSETS assets_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_MT_APPLY obj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
				
			//平台自动生成代码
			prd_id = new EntityObject_MDM_D_DEPT() ; 
			apply_user_id = new EntityObject_COM_USER() ; 
			mtn_type_id = new EntityObject_COM_TYPE() ; 
			apply_dept_id = new EntityObject_COM_DEPART() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			repair_result = new EntityObject_COM_TYPE() ; 
			assets_type_id = new EntityObject_MCE_D_MCE_TYPE() ; 
			emergency_degree = new EntityObject_COM_TYPE() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			fault_type = new EntityObject_COM_TYPE() ; 
			assets_id = new EntityObject_MCE_B_ASSETS() ; 
     
				
						obj.ID= id;
						obj = HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.PRD_ID))
						{
							prd_id.ID = obj.PRD_ID;
							prd_id = HelperObject_MDM_D_DEPT.Get(prd_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.APPLY_USER_ID))
						{
							apply_user_id.ID = obj.APPLY_USER_ID;
							apply_user_id = HelperObject_COM_USER.Get(apply_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.MTN_TYPE_ID))
						{
							mtn_type_id.ID = obj.MTN_TYPE_ID;
							mtn_type_id = HelperObject_COM_TYPE.Get(mtn_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.APPLY_DEPT_ID))
						{
							apply_dept_id.ID = obj.APPLY_DEPT_ID;
							apply_dept_id = HelperObject_COM_DEPART.Get(apply_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_USER_ID))
						{
							using_user_id.ID = obj.USING_USER_ID;
							using_user_id = HelperObject_COM_USER.Get(using_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.REPAIR_RESULT))
						{
							repair_result.ID = obj.REPAIR_RESULT;
							repair_result = HelperObject_COM_TYPE.Get(repair_result, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ASSETS_TYPE_ID))
						{
							assets_type_id.ID = obj.ASSETS_TYPE_ID;
							assets_type_id = HelperObject_MCE_D_MCE_TYPE.Get(assets_type_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.EMERGENCY_DEGREE))
						{
							emergency_degree.ID = obj.EMERGENCY_DEGREE;
							emergency_degree = HelperObject_COM_TYPE.Get(emergency_degree, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_DEPT_ID))
						{
							using_dept_id.ID = obj.USING_DEPT_ID;
							using_dept_id = HelperObject_COM_DEPART.Get(using_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.FAULT_TYPE))
						{
							fault_type.ID = obj.FAULT_TYPE;
							fault_type = HelperObject_COM_TYPE.Get(fault_type, transaction);
						}
						if (!string.IsNullOrEmpty(obj.ASSETS_ID))
						{
							assets_id.ID = obj.ASSETS_ID;
							assets_id = HelperObject_MCE_B_ASSETS.Get(assets_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY[] saveEntities, EntityObject_MCE_B_ASSETS_MT_APPLY[] updateEntities, EntityObject_MCE_B_ASSETS_MT_APPLY[] deleteEntities)
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
                            foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS_MT_APPLY.Save(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_MT_APPLY obj in deleteEntities)
                            {
                                HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_MT_APPLY saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_MT_APPLY.Save(saveBaseEntity, transaction);
							
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_MT_APPLY deleteBaseEntity)
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
                            HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_MT_APPLY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_MT_APPLY.Update(updateBaseEntity, transaction);
							
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
