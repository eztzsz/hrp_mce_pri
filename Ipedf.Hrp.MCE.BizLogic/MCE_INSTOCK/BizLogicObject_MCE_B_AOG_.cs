
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
 
    public partial class BizLogicObject_MCE_B_AOG 
    {

        public BizLogicMsg Save_Ext(JsonMCE_AOG jsonMCE_AOG)
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

                            EntityObject_MCE_B_AOG entity = new EntityObject_MCE_B_AOG();


                            if (!string.IsNullOrEmpty(jsonMCE_AOG.ID))
                            {
                                entity.ID = jsonMCE_AOG.ID;

                                entity = HelperObject_MCE_B_AOG.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonMCE_AOG.CODE;
                            entity.USE_DEPT_ID = jsonMCE_AOG.USE_DEPT_ID;
                            entity.PROVIDER_ID = jsonMCE_AOG.PROVIDER_ID;

                            if (!string.IsNullOrEmpty(jsonMCE_AOG.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonMCE_AOG.CREATE_DATE);
                            }
                            entity.USE_USER_ID = jsonMCE_AOG.USE_USER_ID;
                            entity.PURCHARSE_PERSON = jsonMCE_AOG.PURCHARSE_PERSON;
                            entity.PURCHARSE_HT_NUM = jsonMCE_AOG.PURCHARSE_HT_NUM;

                            entity.COMMENTS = jsonMCE_AOG.COMMENTS;
                            entity.INVOICE_CODE = jsonMCE_AOG.INVOICE_CODE;
                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonMCE_AOG.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_AOG.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_AOG.Update(entity, transaction);
                            }


                            if (jsonMCE_AOG.DELETEIDS != null && jsonMCE_AOG.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in jsonMCE_AOG.DELETEIDS)
                                {
                                    EntityObject_MCE_B_AOG_D entity_D = new EntityObject_MCE_B_AOG_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_AOG_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_AOG_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (jsonMCE_AOG.children != null && jsonMCE_AOG.children.Count > 0)
                            {

                                decimal decTotMoney = 0;
                                foreach (JsonMCE_AOG_D item in jsonMCE_AOG.children)
                                {
                                    EntityObject_MCE_B_AOG_D entity_D = new EntityObject_MCE_B_AOG_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_AOG_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;
                                    entity_D.ASSET_ID = item.ASSET_ID;
                                    entity_D.ASSET_TYPE_ID = item.ASSET_TYPE_ID;
                                    entity_D.ASSETS_NAME = item.ASSETS_NAME;
                                    entity_D.SPEC = item.SPEC;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        if (!string.IsNullOrEmpty(item.PRD_ID))
                                        {
                                            string strPrdID = "";
                                            CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                                            p.REF_ID = item.PRD_ID;

                                            DisplayObject_MDM_D_DEPT[] listPrd = HelperObject_MDM_D_DEPT.Query(p);
                                            if (listPrd != null && listPrd.Length > 0)
                                            {
                                                strPrdID = listPrd[0].ID;
                                            }

                                            entity_D.PRD_ID = strPrdID;
                                        }
                                        entity_D.REF_PRD_ID = item.PRD_ID;
                                    }

                              
                                    entity_D.PRICE = item.PRICE;
                                    entity_D.AMOUNT = item.AMOUNT;
                                    entity_D.UNIT_ID = item.UNIT_ID;
                                    entity_D.COUNTRY = item.COUNTRY;
                                    entity_D.REG_CODE = item.REG_CODE;
                          
                                    entity_D.MONEY = item.AMOUNT * item.PRICE;
                                    decTotMoney = decTotMoney + entity_D.MONEY;


                                    entity_D.REF_TAB_ID = item.REF_TAB_ID;
                                    entity_D.REF_TAB_NAME = item.REF_TAB_NAME;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_AOG_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_AOG_D.Update(entity_D, transaction);
                                    }

                                   
                                }
                                entity.TOTAL_MONEY = decTotMoney;

                                HelperObject_MCE_B_AOG.Update(entity, transaction);
                                
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
                using (ServiceManager<ServiceContract_MCE_B_AOG> smgr = new ServiceManager<ServiceContract_MCE_B_AOG>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMCE_AOG);
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
                                EntityObject_MCE_B_AOG obj = new EntityObject_MCE_B_AOG();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_AOG.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_AOG.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_AOG> smgr = new ServiceManager<ServiceContract_MCE_B_AOG>(ServiceUri))
                {
                    return smgr.Service.Submit_Ext(listID);
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
                                EntityObject_MCE_B_AOG obj = new EntityObject_MCE_B_AOG();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_AOG.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_AOG.Update(obj, transaction);


                                    DisplayObject_MCE_B_AOG_D[] list_D = BizLogicObject_MCE_B_AOG_D.Proxy.Query(new CauseObject_MCE_B_AOG_D() { BASE_ID = obj.ID });
                                    if (list_D != null && list_D.Length > 0)
                                    {
                                        foreach (DisplayObject_MCE_B_AOG_D item in list_D)
                                        {
                                            if (item.REF_TAB_NAME == "MCE_B_ASSETS_PURCHASE_PLAN_D" && !string.IsNullOrEmpty(item.REF_TAB_ID))
                                            {
                                                EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D obj_Pur = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D();
                                                obj_Pur.ID = item.REF_TAB_ID;

                                                obj_Pur = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Get(obj_Pur);
                                                if (obj_Pur != null)
                                                {
                                                    obj_Pur.REF_USED_AMOUNT = obj_Pur.REF_USED_AMOUNT + item.AMOUNT;
                                                    HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Update(obj_Pur, transaction);
                                                }
                                            }
                                        }
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
                using (ServiceManager<ServiceContract_MCE_B_AOG> smgr = new ServiceManager<ServiceContract_MCE_B_AOG>(ServiceUri))
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
                                EntityObject_MCE_B_AOG obj = new EntityObject_MCE_B_AOG();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_AOG.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >=2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_AOG.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_AOG> smgr = new ServiceManager<ServiceContract_MCE_B_AOG>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }


    }
}
