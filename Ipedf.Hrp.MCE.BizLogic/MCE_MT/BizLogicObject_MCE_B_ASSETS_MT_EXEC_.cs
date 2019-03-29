
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
    public partial class BizLogicObject_MCE_B_ASSETS_MT_EXEC 
    {
        public BizLogicMsg Save_Ext(JsonMCE_MT_EXEC json)
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
                            EntityObject_MCE_B_ASSETS_MT_EXEC entity = new EntityObject_MCE_B_ASSETS_MT_EXEC();

                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_MT_EXEC.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }
                            else
                            {
                                throw new Exception("参数错误.");
                            }

                            if (!string.IsNullOrEmpty(json.ACTUAL_EXEC_DATE))
                            {
                                entity.ACTUAL_EXEC_DATE =DateTime.Parse( json.ACTUAL_EXEC_DATE);
                            }
                           

                            entity.COMMENTS = json.COMMENTS;

                            decimal decTotMoney = 0;
                            if (json.children != null && json.children.Count > 0)
                            {
                             
                                foreach (JsonMCE_MT_EXEC_D item in json.children)
                                {
                                    EntityObject_MCE_B_ASSETS_MT_EXEC_D entity_D = new EntityObject_MCE_B_ASSETS_MT_EXEC_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_MT_EXEC_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("获取数据出错.");
                                    }

                                    if (!string.IsNullOrEmpty(item.RESULT_ID))
                                    {
                                        entity_D.RESULT_ID = int.Parse(item.RESULT_ID);
                                    }

                                    if (!string.IsNullOrEmpty(item.MONEY))
                                    {
                                        entity_D.MONEY = decimal.Parse(item.MONEY);
                                    }

                                    decTotMoney = decTotMoney + entity_D.MONEY;

                                    entity_D.COMMENTS = item.COMMENTS;

                                    HelperObject_MCE_B_ASSETS_MT_EXEC_D.Update(entity_D, transaction);

                                }
                            }

                            entity.TOTAL_MONEY = decTotMoney;
                            int amount = HelperObject_MCE_B_ASSETS_MT_EXEC.Update(entity, transaction);


                            CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                            pCOM_FILE.REF_TAB_ID = entity.ID;
                            pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_MT_EXEC";
                            HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);

                            if (json.listAttach != null && json.listAttach.Count > 0)
                            {
                                foreach (JsonMCEMT_APPLY_MTN_ATTACH item in json.listAttach)
                                {
                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_MT_EXEC";
                                    entityPicFile.CLIENT_NAME = item.CLIENT_NAME;
                                    entityPicFile.STATE = 1;
                                    entityPicFile.CREATE_TIME = item.CREATE_TIME;
                                    entityPicFile.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    entityPicFile.REF_TAB_ID = entity.ID;
                                    entityPicFile.SERVER_NAME = item.SERVER_NAME;
                                    entityPicFile.IS_IMPORT = 0;
                                    Ipedf.Web.DataAccess.HelperObject_COM_FILE.Save(entityPicFile, transaction);


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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_MT_EXEC obj = new EntityObject_MCE_B_ASSETS_MT_EXEC();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_EXEC.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }


                                    if (obj.ACTUAL_EXEC_DATE<DateTime.Now.AddDays(-100))
                                    {
                                        throw new Exception("执行日期错误.");
                                    }



                                    DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] list_D = BizLogicObject_MCE_B_ASSETS_MT_EXEC_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_MT_EXEC_D() { BASE_ID = obj.ID });


                                    foreach (DisplayObject_MCE_B_ASSETS_MT_EXEC_D item in list_D)
                                    {
                                        if (item.RESULT_ID <= 0)
                                        {
                                            throw new Exception("请选择保养结果.");
                                        }
                                    }



                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_MT_EXEC.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_MT_EXEC obj = new EntityObject_MCE_B_ASSETS_MT_EXEC();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_EXEC.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_MT_EXEC.Update(obj, transaction);




                                    
                                    EntityObject_MCE_B_ASSETS_MT_EXEC entity = new EntityObject_MCE_B_ASSETS_MT_EXEC();

                                    entity.PLAN_ID = obj.ID;
                                    entity.CODE = obj.CODE;
                                    entity.NAME = obj.NAME;
                                    entity.MTN_TYPE_ID = obj.MTN_TYPE_ID;
                                    entity.MTN_COMPANY_ID = obj.MTN_COMPANY_ID;

                                    entity.EXECUTE_PERIOD = obj.EXECUTE_PERIOD;

                                    entity.MTN_TYPE_ID = obj.MTN_TYPE_ID;
         

                                    entity.EXECUTE_PERIOD_UNIT = obj.EXECUTE_PERIOD_UNIT;


                                    if (entity.EXECUTE_PERIOD_UNIT == 1)
                                    {
                                        entity.CREATE_DATE = obj.ACTUAL_EXEC_DATE.AddYears(int.Parse(entity.EXECUTE_PERIOD.ToString()));
                                    }
                                    else if (entity.EXECUTE_PERIOD_UNIT == 2)
                                    {
                                        entity.CREATE_DATE = obj.ACTUAL_EXEC_DATE.AddMonths(int.Parse(entity.EXECUTE_PERIOD.ToString()));
                                    }
                                    else if (entity.EXECUTE_PERIOD_UNIT == 3)
                                    {
                                        entity.CREATE_DATE = obj.ACTUAL_EXEC_DATE.AddDays(int.Parse(entity.EXECUTE_PERIOD.ToString()));
                                    }


                                    entity.APPLY_USER_ID = obj.APPLY_USER_ID;

                                    entity.COMMENTS = obj.COMMENTS;

                                    // entity.PLAN_STATE = obj.PLAN_STATE;
                                    entity.STATE = 1;

                                    entity.CREATE_TIME = DateTime.Now;
                                    entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    int amount = HelperObject_MCE_B_ASSETS_MT_EXEC.Save(entity, transaction);


                                    obj.NEXT_EXEC_DATE = entity.CREATE_DATE;
                                    HelperObject_MCE_B_ASSETS_MT_EXEC.Update(obj, transaction);

                                    if (!string.IsNullOrEmpty(obj.PLAN_ID))
                                    {
                                        EntityObject_MCE_B_ASSETS_MT_PLAN objPlan = new EntityObject_MCE_B_ASSETS_MT_PLAN();
                                        objPlan.ID = obj.PLAN_ID;

                                        objPlan = HelperObject_MCE_B_ASSETS_MT_PLAN.Get(objPlan);

                                        if (objPlan != null)
                                        {
                                            objPlan.CREATE_DATE = entity.CREATE_DATE;
                                            HelperObject_MCE_B_ASSETS_MT_PLAN.Update(objPlan, transaction);
                                        }
                                    }

                                    DisplayObject_MCE_B_ASSETS_MT_EXEC_D[] list_D = BizLogicObject_MCE_B_ASSETS_MT_EXEC_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_MT_EXEC_D() { BASE_ID = obj.ID });


                                    foreach (DisplayObject_MCE_B_ASSETS_MT_EXEC_D item in list_D)
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_EXEC>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(listID);
                }
            }
        }

    }
}
