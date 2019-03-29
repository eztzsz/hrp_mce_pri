#define NESTING
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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN))]
	public partial class BizLogicObject_MCE_B_ASSETS_PURCHASE_PLAN: BizLogicBase<EntityObject_MCE_B_ASSETS_PURCHASE_PLAN>,ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN
	{	
		#region Proxy 
		public BizLogicObject_MCE_B_ASSETS_PURCHASE_PLAN() { }
        private static ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN singleton;
        public static ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_MCE_B_ASSETS_PURCHASE_PLAN();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Get(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN Get(DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] List()
		{
			if (LocalMode)
			{
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(cause, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN[] Query(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//平台自动生成代码
			return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//平台自动生成代码
					foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] objs)
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
					foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj)
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
							int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(obj, transaction);
					//平台自动生成代码          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(obj, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_MCE_B_ASSETS_PURCHASE_PLAN cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(cause, transaction);
					//平台自动生成代码
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Load(string id , out EntityObject_COM_USER apply_user_id, out EntityObject_COM_DEPART purchase_dept_id, out EntityObject_COM_TYPE currency_id, out EntityObject_COM_DEPART apply_dept_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
				
			//平台自动生成代码
			apply_user_id = new EntityObject_COM_USER() ; 
			purchase_dept_id = new EntityObject_COM_DEPART() ; 
			currency_id = new EntityObject_COM_TYPE() ; 
			apply_dept_id = new EntityObject_COM_DEPART() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  apply_user_id, out  purchase_dept_id, out  currency_id, out  apply_dept_id);                
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Load(id , out apply_user_id, out purchase_dept_id, out currency_id, out apply_dept_id);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_PURCHASE_PLAN Load(IDbTransaction transaction,string id , out EntityObject_COM_USER apply_user_id, out EntityObject_COM_DEPART purchase_dept_id, out EntityObject_COM_TYPE currency_id, out EntityObject_COM_DEPART apply_dept_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
				
			//平台自动生成代码
			apply_user_id = new EntityObject_COM_USER() ; 
			purchase_dept_id = new EntityObject_COM_DEPART() ; 
			currency_id = new EntityObject_COM_TYPE() ; 
			apply_dept_id = new EntityObject_COM_DEPART() ; 
     
				
						obj.ID= id;
						obj = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.APPLY_USER_ID))
						{
							apply_user_id.ID = obj.APPLY_USER_ID;
							apply_user_id = HelperObject_COM_USER.Get(apply_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.PURCHASE_DEPT_ID))
						{
							purchase_dept_id.ID = obj.PURCHASE_DEPT_ID;
							purchase_dept_id = HelperObject_COM_DEPART.Get(purchase_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.CURRENCY_ID))
						{
							currency_id.ID = obj.CURRENCY_ID;
							currency_id = HelperObject_COM_TYPE.Get(currency_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.APPLY_DEPT_ID))
						{
							apply_dept_id.ID = obj.APPLY_DEPT_ID;
							apply_dept_id = HelperObject_COM_DEPART.Get(apply_dept_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] saveEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] updateEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN[] deleteEntities)
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
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj in deleteEntities)
                            {
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN saveBaseEntity, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] saveDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(saveBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN deleteBaseEntity)
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
                            CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D p = new CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
                            p.BASE_ID = deleteBaseEntity.ID;
                            HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Delete(p, transaction);
                            HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_PURCHASE_PLAN updateBaseEntity, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] saveDetailEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] updateDetailEntities, EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] deleteDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(updateBaseEntity, transaction);
							
                            //平台自动生成代码
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj in saveDetailEntities)
                            {
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Save(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Update(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj in deleteDetailEntities)
                            {
                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
