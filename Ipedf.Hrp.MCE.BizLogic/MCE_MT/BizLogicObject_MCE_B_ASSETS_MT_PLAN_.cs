
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
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_MCE_B_ASSETS_MT_PLAN
    {


        public BizLogicMsg Save_Ext(JsonMCE_MT_PLAN json)
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

                            EntityObject_MCE_B_ASSETS_MT_PLAN entity = new EntityObject_MCE_B_ASSETS_MT_PLAN();

                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = json.CODE;
                            entity.NAME = json.NAME;
                            entity.MTN_TYPE_ID = json.MTN_TYPE_ID;
                            entity.MTN_COMPANY_ID = json.MTN_COMPANY_ID;

                            if (!string.IsNullOrEmpty(json.EXECUTE_PERIOD))
                            {
                                entity.EXECUTE_PERIOD =int.Parse( json.EXECUTE_PERIOD);
                            }
                            entity.MTN_TYPE_ID = json.MTN_TYPE_ID;

                            if (!string.IsNullOrEmpty(json.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(json.CREATE_DATE);
                            }

                            if (!string.IsNullOrEmpty(json.CREATE_DATE))
                            {
                                entity.EXECUTE_PERIOD_UNIT = int.Parse(json.EXECUTE_PERIOD_UNIT);
                            }

                            entity.APPLY_USER_ID = json.APPLY_USER_ID;

                            entity.COMMENTS = json.COMMENTS;

                            entity.PLAN_STATE = json.PLAN_STATE;
                            entity.STATE = json.STATE;
                            if (string.IsNullOrEmpty(json.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_MT_PLAN.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_ASSETS_MT_PLAN.Update(entity, transaction);
                            }


                            if (json.DELETEIDS != null && json.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in json.DELETEIDS)
                                {
                                    EntityObject_MCE_B_ASSETS_MT_PLAN_D entity_D = new EntityObject_MCE_B_ASSETS_MT_PLAN_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_ASSETS_MT_PLAN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_ASSETS_MT_PLAN_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (json.children != null && json.children.Count > 0)
                            {
                                foreach (JsonMCE_MT_PLAN_D item in json.children)
                                {
                                    EntityObject_MCE_B_ASSETS_MT_PLAN_D entity_D = new EntityObject_MCE_B_ASSETS_MT_PLAN_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_MT_PLAN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;
                                    entity_D.ASSETS_ID = item.ASSETS_ID;
                                    entity_D.ASSET_CODE = item.ASSET_CODE;
                                    entity_D.SPEC = item.SPEC;

                                    entity_D.DEPT_ID = item.DEPT_ID;
                                    entity_D.ITEM_ID = item.ITEM_ID;
                                    entity_D.SEQ_NUMBER = item.SEQ_NUMBER;

                                    entity_D.COMMENTS = item.COMMENTS;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_ASSETS_MT_PLAN_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_ASSETS_MT_PLAN_D.Update(entity_D, transaction);
                                    }


                                }

                            }

                            msg.Message = entity.ID;

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(json);
                }
            }
        }


        public BizLogicMsg Submit_Ext(List<string> listID)
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
                            foreach (string strID in listID)
                            {
                                EntityObject_MCE_B_ASSETS_MT_PLAN obj = new EntityObject_MCE_B_ASSETS_MT_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_MT_PLAN.Update(obj, transaction);
                                }
                            }

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(listID);
                }
            }
        }


        public BizLogicMsg Audit_Ext(List<string> listID)
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
                            foreach (string strID in listID)
                            {
                                EntityObject_MCE_B_ASSETS_MT_PLAN obj = new EntityObject_MCE_B_ASSETS_MT_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_MT_PLAN.Update(obj, transaction);


                                    EntityObject_MCE_B_ASSETS_MT_EXEC entity = new EntityObject_MCE_B_ASSETS_MT_EXEC();

                                    entity.PLAN_ID = obj.ID;
                                    entity.CODE = obj.CODE;
                                    entity.NAME = obj.NAME;
                                    entity.MTN_TYPE_ID = obj.MTN_TYPE_ID;
                                    entity.MTN_COMPANY_ID = obj.MTN_COMPANY_ID;

                                    entity.EXECUTE_PERIOD = obj.EXECUTE_PERIOD;
                                    
                                    entity.MTN_TYPE_ID = obj.MTN_TYPE_ID;

                                    entity.CREATE_DATE = obj.CREATE_DATE;
                                    
                                    entity.EXECUTE_PERIOD_UNIT = obj.EXECUTE_PERIOD_UNIT;

                                    entity.APPLY_USER_ID = obj.APPLY_USER_ID;

                                    entity.COMMENTS = obj.COMMENTS;

                                   // entity.PLAN_STATE = obj.PLAN_STATE;
                                    entity.STATE = 1;
                              
                                    entity.CREATE_TIME = DateTime.Now;
                                    entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    int amount = HelperObject_MCE_B_ASSETS_MT_EXEC.Save(entity, transaction);
                                    

                                    DisplayObject_MCE_B_ASSETS_MT_PLAN_D[] list_D = BizLogicObject_MCE_B_ASSETS_MT_PLAN_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_MT_PLAN_D() { BASE_ID = obj.ID });


                                    foreach (DisplayObject_MCE_B_ASSETS_MT_PLAN_D item in list_D)
                                   {
                                       EntityObject_MCE_B_ASSETS_MT_EXEC_D entity_D = new EntityObject_MCE_B_ASSETS_MT_EXEC_D();
                                        
                                       entity_D.BASE_ID = entity.ID;
                                       entity_D.ASSETS_ID = item.ASSETS_ID;
                                       entity_D.ASSET_CODE = item.ASSET_CODE;
                                       entity_D.SPEC = item.SPEC;

                                       entity_D.DEPT_ID = item.DEPT_ID;
                                       entity_D.ITEM_ID = item.ITEM_ID;
                                       entity_D.SEQ_NUMBER = item.SEQ_NUMBER;

                                       entity_D.COMMENTS = item.COMMENTS;
                                       HelperObject_MCE_B_ASSETS_MT_EXEC_D.Save(entity_D, transaction);
                                   }


                                }
                            }

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(listID);
                }
            }
        }



        public BizLogicMsg Delete_Ext(List<string> listID)
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
                            foreach (string strID in listID)
                            {
                                EntityObject_MCE_B_ASSETS_MT_PLAN obj = new EntityObject_MCE_B_ASSETS_MT_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_MT_PLAN.Delete(obj, transaction);
                                }
                            }

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }




        public BizLogicMsg SetPlanState_Ext(List<string> listID, int intState)
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
                            foreach (string strID in listID)
                            {
                                EntityObject_MCE_B_ASSETS_MT_PLAN obj = new EntityObject_MCE_B_ASSETS_MT_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    obj.PLAN_STATE = intState;

                                    HelperObject_MCE_B_ASSETS_MT_PLAN.Update(obj, transaction);
                                }
                            }
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_PLAN>(ServiceUri))
                {
                    return smgr.Service.SetPlanState_Ext(listID, intState);
                }
            }
        }


    }
}
