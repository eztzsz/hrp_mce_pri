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
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_MCE_B_ASSETS_PURCHASE_PLAN 
    {


        public BizLogicMsg Save_Ext(JsonMCE_PURCHASE_PLAN json)
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

                            EntityObject_MCE_B_ASSETS_PURCHASE_PLAN entity = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();


                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = json.CODE;
                            entity.APPLY_DEPT_ID = json.APPLY_DEPT_ID;
                            entity.APPLY_USER_ID = json.APPLY_USER_ID;
                            entity.PRV_ID = json.PRV_ID;
                            entity.PRV_NAME = json.PRV_NAME;

                            if (!string.IsNullOrEmpty(json.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(json.CREATE_DATE);
                            }
                            entity.PURCHASE_DEPT_ID = json.PURCHASE_DEPT_ID;
                            entity.APPLY_USER_ID = json.APPLY_USER_ID;

                            entity.COMMENTS = json.COMMENTS;
                       
                          

                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(json.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                entity.CREATE_DEPT_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                                int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                entity.MODIFY_DEPT_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.DEPART_ID;
                                int amount = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(entity, transaction);
                            }


                            if (json.DELETEIDS != null && json.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in json.DELETEIDS)
                                {
                                    EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D entity_D = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (json.children != null && json.children.Count > 0)
                            {

                                decimal decTotMoney = 0;
                                foreach (JsonMCE_PURCHASE_PLAN_D item in json.children)
                                {
                                    EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D entity_D = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;

                                    entity_D.TYPE_ID = item.TYPE_ID;
                                    entity_D.ASSETS_ID = item.ASSETS_ID;
                                    entity_D.ASSET_NAME = item.ASSET_NAME;
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

                                 

                                    entity_D.PRD_NAME = item.PRD_NAME;
                                    entity_D.PRICE = item.PRICE;
                                    entity_D.AMOUNT = item.AMOUNT;
                                    entity_D.UNIT_ID = item.UNIT_ID;

                                    entity_D.REF_TAB_ID = item.REF_TAB_ID;
                                    entity_D.REF_TAB_NAME = item.REF_TAB_NAME;

                                    entity_D.MONEY = item.AMOUNT * item.PRICE;
                                    decTotMoney = decTotMoney + entity_D.MONEY;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Update(entity_D, transaction);
                                    }


                                }
                                entity.APPLY_MONEY = decTotMoney;

                                HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(entity, transaction);

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Update(obj, transaction);


                                    DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D[] list_D = BizLogicObject_MCE_B_ASSETS_PURCHASE_PLAN_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_PURCHASE_PLAN_D() { BASE_ID = obj.ID });
                                    if(list_D!=null && list_D.Length>0)
                                    {
                                        foreach(DisplayObject_MCE_B_ASSETS_PURCHASE_PLAN_D item in list_D)
                                        {
                                            if (item.REF_TAB_NAME == "MCE_B_ASSETS_PURCHASE" && !string.IsNullOrEmpty(item.REF_TAB_ID))
                                            {
                                                EntityObject_MCE_B_ASSETS_PURCHASE obj_Pur = new EntityObject_MCE_B_ASSETS_PURCHASE();
                                                obj_Pur.ID = item.REF_TAB_ID;

                                                obj_Pur = HelperObject_MCE_B_ASSETS_PURCHASE.Get(obj_Pur);
                                                if(obj_Pur!=null)
                                                {
                                                    obj_Pur.REF_USED_AMOUNT = obj_Pur.REF_USED_AMOUNT + item.AMOUNT;
                                                    HelperObject_MCE_B_ASSETS_PURCHASE.Update(obj_Pur, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_PURCHASE_PLAN obj = new EntityObject_MCE_B_ASSETS_PURCHASE_PLAN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_PURCHASE_PLAN.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_PURCHASE_PLAN>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
