
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
using Ipedf.Common;
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_MCE_B_ASSETS_DEPR 
    {


        public BizLogicMsg Save_Ext(JsonMCE_Depr jsonEntity)
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

                            EntityObject_MCE_B_ASSETS_DEPR entity = new EntityObject_MCE_B_ASSETS_DEPR();


                            if (!string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                entity.ID = jsonEntity.ID;

                                entity = HelperObject_MCE_B_ASSETS_DEPR.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonEntity.CODE;
                            entity.DEPT_ID = jsonEntity.DEPT_ID;
                            entity.USER_ID = jsonEntity.USER_ID;

                            if (!string.IsNullOrEmpty(jsonEntity.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonEntity.CREATE_DATE);
                            }
                            entity.FINANCE_CYCLE = jsonEntity.FINANCE_CYCLE;
                         
                            entity.COMMENTS = jsonEntity.COMMENTS;
                          
                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_DEPR.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_TIME = DateTime.Now;
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_DEPR.Update(entity, transaction);
                            }

                            if (!string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                CauseObject_MCE_B_ASSETS_DEPR_D pDeprDetail = new CauseObject_MCE_B_ASSETS_DEPR_D();
                                pDeprDetail.BASE_ID = jsonEntity.ID;
                                HelperObject_MCE_B_ASSETS_DEPR_D.Delete(pDeprDetail, transaction);
                            }

                           
                            if (jsonEntity.children != null && jsonEntity.children.Count > 0)
                            {

                                foreach (JsonMceDepr_D item in jsonEntity.children)
                                {
                                    EntityObject_MCE_B_ASSETS_DEPR_D entity_D = new EntityObject_MCE_B_ASSETS_DEPR_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_DEPR_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;

                                    entity_D.ASSETS_ID = item.ASSETS_ID;
                                    entity_D.ASSETS_CODE = item.ASSETS_CODE;
                                    entity_D.CURRENCY_ID = item.CURRENCY_ID;
                                    entity_D.ORIGINAL_VALUE = item.ORIGINAL_VALUE;
                                    entity_D.NET_VALUE = item.NET_VALUE;
                                    entity_D.MONEY = item.MONEY;
                                    entity_D.NEW_NET_VALUE = item.NEW_NET_VALUE;
                                
                                    HelperObject_MCE_B_ASSETS_DEPR_D.Save(entity_D, transaction);
                           
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonEntity);
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
                                EntityObject_MCE_B_ASSETS_DEPR obj = new EntityObject_MCE_B_ASSETS_DEPR();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_DEPR.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_DEPR.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_DEPR obj = new EntityObject_MCE_B_ASSETS_DEPR();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_DEPR.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_DEPR.Update(obj, transaction);

                                    CauseObject_MCE_B_ASSETS_DEPR_D pDeprDetail = new CauseObject_MCE_B_ASSETS_DEPR_D();
                                    pDeprDetail.BASE_ID = strID;
                                    EntityObject_MCE_B_ASSETS_DEPR_D[] deprDetails = HelperObject_MCE_B_ASSETS_DEPR_D.Query(pDeprDetail, transaction);
                                    //更新资产卡片记录
                                    foreach (EntityObject_MCE_B_ASSETS_DEPR_D deprDetail in deprDetails)
                                    {
                                        EntityObject_MCE_B_ASSETS assets = new EntityObject_MCE_B_ASSETS();
                                        assets.ID = deprDetail.ASSETS_ID;
                                        assets.NET_VALUE = deprDetail.NEW_NET_VALUE;//净值
                                        assets.DEPR_MONTH_AMOUNT += 1;//累计折旧月份
                                        assets.ACCUMULATED_DEPRECIATION += deprDetail.MONEY;//累计折旧金额
                                        assets.SetUpdate("NET_VALUE", "DEPR_MONTH_AMOUNT", "ACCUMULATED_DEPRECIATION");
                                        HelperObject_MCE_B_ASSETS.Update(assets, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_DEPR obj = new EntityObject_MCE_B_ASSETS_DEPR();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_DEPR.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_DEPR.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_DEPR>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
