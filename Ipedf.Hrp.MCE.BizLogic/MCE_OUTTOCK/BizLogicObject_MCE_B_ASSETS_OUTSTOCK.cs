
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
	[CauseObject(typeof(CauseObject_MCE_B_ASSETS_OUTSTOCK))]
	public partial class BizLogicObject_MCE_B_ASSETS_OUTSTOCK: BizLogicBase<EntityObject_MCE_B_ASSETS_OUTSTOCK>,ServiceContract_MCE_B_ASSETS_OUTSTOCK
	{	
		#region Proxy 
		public BizLogicObject_MCE_B_ASSETS_OUTSTOCK() { }
        private static ServiceContract_MCE_B_ASSETS_OUTSTOCK singleton;
        public static ServiceContract_MCE_B_ASSETS_OUTSTOCK Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_MCE_B_ASSETS_OUTSTOCK();
                    return singleton;
            }
        }
        #endregion	
		#region Method Blok
		public BizLogicMsg Save(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(obj, transaction);
					//ƽ̨�Զ����ɴ���
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Save(obj);
                }
            }
		}
		public BizLogicMsg Update(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Update(obj);
                }
			}
		}
		public BizLogicMsg Delete(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(obj, transaction);
					//ƽ̨�Զ����ɴ���
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Delete(obj);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_OUTSTOCK Get(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_OUTSTOCK Get(DisplayObject_MCE_B_ASSETS_OUTSTOCK obj)
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Get(obj);
                }
			}
		}
		public DisplayObject_MCE_B_ASSETS_OUTSTOCK[] List()
		{
			if (LocalMode)
			{
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_MCE_B_ASSETS_OUTSTOCK.List();
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.List();
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_OUTSTOCK[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK cause)
		{			
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_MCE_B_ASSETS_OUTSTOCK.Query(cause);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Query(cause);
                }
			}
		}
		public BizLogicMsg Delete(CauseObject_MCE_B_ASSETS_OUTSTOCK cause)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(cause, transaction);
					//ƽ̨�Զ����ɴ���
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Delete(cause);
                }
			}
		}		
		public DisplayObject_MCE_B_ASSETS_OUTSTOCK[] Query(CauseObject_MCE_B_ASSETS_OUTSTOCK cause,PagingParamter paging,OrderByParameter order)
		{
			if (LocalMode)
			{
				SystemLogic.Proxy.AuditQuery(cause);
				
			//ƽ̨�Զ����ɴ���
			return HelperObject_MCE_B_ASSETS_OUTSTOCK.Query(cause, paging, order);
			}
			else
			{
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Query(cause,paging,order);
                }
			}
		}	
		public BizLogicMsg BatchSave(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_OUTSTOCK obj in objs)
							{
							   SystemLogic.Proxy.AuditAdd(obj);
							}
							int amount = 0;
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
        public BizLogicMsg BatchUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs)
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
							foreach(EntityObject_MCE_B_ASSETS_OUTSTOCK obj in objs)
							{
							   SystemLogic.Proxy.AuditEdit(obj);
							}
							int amount = 0;                        
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.BatchUpdate(objs);
                }
            }
        }
        public BizLogicMsg BatchDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK[] objs)
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
							
			//ƽ̨�Զ����ɴ���
					foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in objs)
					{
						amount += HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(obj, transaction);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.BatchDelete(objs);
                }
            }

        }
        public BizLogicMsg Cancel(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���                       
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Cancel(obj);
                }
            }
        }
        public BizLogicMsg Audit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostAudit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.���ύ);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Audit(obj);
                }
            }
        }
        public BizLogicMsg UndoAudit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostUndoAudit(obj, transaction);
							//ִ�г��ز���
							msg = SystemLogic.Proxy.BillUndoAudit(obj, transaction);
							if (!msg.Succeed) throw new Exception(msg.Message);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�����);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.UndoAudit(obj);
                }
            }
        }
        public BizLogicMsg Archive(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostArchive(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�����);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
        public BizLogicMsg Submit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.�༭��);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Submit(obj);
                }
            }
        }
        public BizLogicMsg UndoSubmit(EntityObject_MCE_B_ASSETS_OUTSTOCK obj)
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
							int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
							PostUndoSubmit(obj, transaction);
							transaction.Commit();
						}
						catch (Exception expt)
						{
							SystemLogic.Proxy.AuditState(obj,Ipedf.Common.����״̬.���ύ);
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.UndoSubmit(obj);
                }
            }
        }
        
        public int SaveByTrans(EntityObject_MCE_B_ASSETS_OUTSTOCK obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditAdd(obj);
				int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(obj, transaction);
					//ƽ̨�Զ����ɴ���          
				return amount;
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int UpdateByTrans(EntityObject_MCE_B_ASSETS_OUTSTOCK obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				SystemLogic.Proxy.AuditEdit(obj);
				return HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans(EntityObject_MCE_B_ASSETS_OUTSTOCK obj, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(obj, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public int DeleteByTrans2(CauseObject_MCE_B_ASSETS_OUTSTOCK cause, IDbTransaction transaction)
        {
            if (LocalMode)
            {
				return HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(cause, transaction);
					//ƽ̨�Զ����ɴ���
            }
            else
            {
				throw new InvalidConstraintException();
            }
        }
        public EntityObject_MCE_B_ASSETS_OUTSTOCK Load(string id , out EntityObject_COM_USER create_user_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_USER user_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_DEPART dept_id, out EntityObject_MDM_D_STOCK stock_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_OUTSTOCK obj = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
				
			//ƽ̨�Զ����ɴ���
			create_user_id = new EntityObject_COM_USER() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			user_id = new EntityObject_COM_USER() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			dept_id = new EntityObject_COM_DEPART() ; 
			stock_id = new EntityObject_MDM_D_STOCK() ; 

				using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
				{
					using (IDbTransaction transaction = connection.BeginTransaction())
					{
						try
						{
							obj = Load(transaction,id , out  create_user_id, out  using_dept_id, out  user_id, out  using_user_id, out  dept_id, out  stock_id);                
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
				using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Load(id , out create_user_id, out using_dept_id, out user_id, out using_user_id, out dept_id, out stock_id);
                }
			}
		}
		public EntityObject_MCE_B_ASSETS_OUTSTOCK Load(IDbTransaction transaction,string id , out EntityObject_COM_USER create_user_id, out EntityObject_COM_DEPART using_dept_id, out EntityObject_COM_USER user_id, out EntityObject_COM_USER using_user_id, out EntityObject_COM_DEPART dept_id, out EntityObject_MDM_D_STOCK stock_id)
		{
			if (LocalMode)
			{
				EntityObject_MCE_B_ASSETS_OUTSTOCK obj = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
				
			//ƽ̨�Զ����ɴ���
			create_user_id = new EntityObject_COM_USER() ; 
			using_dept_id = new EntityObject_COM_DEPART() ; 
			user_id = new EntityObject_COM_USER() ; 
			using_user_id = new EntityObject_COM_USER() ; 
			dept_id = new EntityObject_COM_DEPART() ; 
			stock_id = new EntityObject_MDM_D_STOCK() ; 
     
				
						obj.ID= id;
						obj = HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj,transaction);
						if (!string.IsNullOrEmpty(obj.CREATE_USER_ID))
						{
							create_user_id.ID = obj.CREATE_USER_ID;
							create_user_id = HelperObject_COM_USER.Get(create_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_DEPT_ID))
						{
							using_dept_id.ID = obj.USING_DEPT_ID;
							using_dept_id = HelperObject_COM_DEPART.Get(using_dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USER_ID))
						{
							user_id.ID = obj.USER_ID;
							user_id = HelperObject_COM_USER.Get(user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.USING_USER_ID))
						{
							using_user_id.ID = obj.USING_USER_ID;
							using_user_id = HelperObject_COM_USER.Get(using_user_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.DEPT_ID))
						{
							dept_id.ID = obj.DEPT_ID;
							dept_id = HelperObject_COM_DEPART.Get(dept_id, transaction);
						}
						if (!string.IsNullOrEmpty(obj.STOCK_ID))
						{
							stock_id.ID = obj.STOCK_ID;
							stock_id = HelperObject_MDM_D_STOCK.Get(stock_id, transaction);
						}  
				return obj;
            }
            else
            {
				throw new InvalidConstraintException();
            }
		}
		public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK[] saveEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK[] updateEntities, EntityObject_MCE_B_ASSETS_OUTSTOCK[] deleteEntities)
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
                            //ƽ̨�Զ����ɴ���
                            foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in saveEntities)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in updateEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
                            }
                            foreach (EntityObject_MCE_B_ASSETS_OUTSTOCK obj in deleteEntities)
                            {
                                HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(saveEntities, updateEntities, deleteEntities);
                }
            }
        }
		#endregion 
		#region Relation Blok
		#if NESTING
		public BizLogicMsg CommitSave(EntityObject_MCE_B_ASSETS_OUTSTOCK saveBaseEntity, EntityObject_[] saveDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(saveBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitDelete(EntityObject_MCE_B_ASSETS_OUTSTOCK deleteBaseEntity)
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
                            //ƽ̨�Զ����ɴ���
                            CauseObject_ p = new CauseObject_();
                            p. = deleteBaseEntity.ID;
                            HelperObject_.Delete(p, transaction);
                            HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(deleteBaseEntity, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.CommitDelete(deleteBaseEntity);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_MCE_B_ASSETS_OUTSTOCK updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities)
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
                            HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(updateBaseEntity, transaction);
							
                            //ƽ̨�Զ����ɴ���
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        #endif
		#endregion 
	}
}
