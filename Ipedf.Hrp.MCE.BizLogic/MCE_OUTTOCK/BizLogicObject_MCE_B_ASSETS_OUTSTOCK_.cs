
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
  
    public partial class BizLogicObject_MCE_B_ASSETS_OUTSTOCK 
    {



        public BizLogicMsg Save_Ext(JsonMCE_OUTSTOCK jsonMCE_OUTSTOCK)
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

                            EntityObject_MCE_B_ASSETS_OUTSTOCK entity = new EntityObject_MCE_B_ASSETS_OUTSTOCK();


                            if (!string.IsNullOrEmpty(jsonMCE_OUTSTOCK.ID))
                            {
                                entity.ID = jsonMCE_OUTSTOCK.ID;

                                entity = HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonMCE_OUTSTOCK.CODE;
                            entity.STOCK_ID = jsonMCE_OUTSTOCK.WAREHOUSE_ID;

                            if (!string.IsNullOrEmpty(jsonMCE_OUTSTOCK.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonMCE_OUTSTOCK.CREATE_DATE);
                            }
                            entity.USING_DEPT_ID = jsonMCE_OUTSTOCK.USING_DEPT_ID;
                            entity.USING_USER_ID = jsonMCE_OUTSTOCK.USING_USER_ID;

                            entity.COMMENTS = jsonMCE_OUTSTOCK.COMMENTS;
                          
                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonMCE_OUTSTOCK.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(entity, transaction);
                            }


                            if (jsonMCE_OUTSTOCK.DELETEIDS != null && jsonMCE_OUTSTOCK.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in jsonMCE_OUTSTOCK.DELETEIDS)
                                {
                                    EntityObject_MCE_B_ASSETS_OUTSTOCK_D entity_D = new EntityObject_MCE_B_ASSETS_OUTSTOCK_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_ASSETS_OUTSTOCK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_ASSETS_OUTSTOCK_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (jsonMCE_OUTSTOCK.children != null && jsonMCE_OUTSTOCK.children.Count > 0)
                            {

                                decimal decTotMoney = 0;
                                foreach (JsonMCE_OUTSTOCK_D item in jsonMCE_OUTSTOCK.children)
                                {
                                    EntityObject_MCE_B_ASSETS_OUTSTOCK_D entity_D = new EntityObject_MCE_B_ASSETS_OUTSTOCK_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_OUTSTOCK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;

                                    entity_D.ASSET_TYPE_ID = item.ASSET_TYPE_ID;
                                    entity_D.ASSETS_ID = item.ASSETS_ID;
                                    entity_D.ASSETS_NAME = item.ASSETS_NAME;
                                    entity_D.ASSETS_CODE = item.ASSETS_CODE;
                                    entity_D.SPEC = item.SPEC;
                                    entity_D.PRD_ID = item.PRD_ID;
                                    entity_D.PRICE = item.PRICE;
                                    entity_D.AMOUNT = item.AMOUNT;
                                    entity_D.UNIT_ID = item.UNIT_ID;
                                    entity_D.COUNTRY = item.COUNTRY;

                                    if (!string.IsNullOrEmpty(item.USE_DATE))
                                    {
                                        entity_D.USE_DATE =DateTime.Parse(item.USE_DATE);
                                    }

                                    entity_D.ECONOMIC_USE_TYPE_ID = item.ECONOMIC_USE_TYPE_ID;

                                    entity_D.REF_TAB_ID = item.REF_TAB_ID;
                                    entity_D.REF_TAB_NAME = item.REF_TAB_NAME;

                                    entity_D.MONEY = item.AMOUNT * item.PRICE;
                                    decTotMoney = decTotMoney + entity_D.MONEY;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_ASSETS_OUTSTOCK_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_ASSETS_OUTSTOCK_D.Update(entity_D, transaction);
                                    }


                                }
                                entity.TOTAL_MONEY = decTotMoney;

                                HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(entity, transaction);

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMCE_OUTSTOCK);
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
                                EntityObject_MCE_B_ASSETS_OUTSTOCK obj = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }


                                    if (string.IsNullOrEmpty(obj.CODE))
                                    {
                                        throw new Exception("单号不能为空.");
                                    }

                                    if (string.IsNullOrEmpty(obj.USING_DEPT_ID))
                                    {
                                        throw new Exception("领用科室不能为空.");
                                    }

                                    if (string.IsNullOrEmpty(obj.USING_USER_ID))
                                    {
                                        throw new Exception("领用人不能为空.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_OUTSTOCK obj = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_OUTSTOCK.Update(obj, transaction);


                                    #region 资产卡片更新
                                    DisplayObject_MCE_B_ASSETS_OUTSTOCK_D[] disOutstock = BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_OUTSTOCK_D() { BASE_ID = obj.ID });
                                    if (disOutstock.Length > 0 )
                                    {
                                        for (int i = 0; i < disOutstock.Length; i++)
                                        {
                                            if (string.IsNullOrEmpty(disOutstock[i].REF_TAB_ID) || string.IsNullOrEmpty(disOutstock[i].REF_TAB_NAME))
                                            {
                                                continue;
                                            }

                                            if (disOutstock[i].REF_TAB_NAME == "MCE_B_ASSETS")
                                            {
                                                EntityObject_MCE_B_ASSETS entAssets = BizLogicObject_MCE_B_ASSETS.Proxy.Get(new EntityObject_MCE_B_ASSETS() { ID = disOutstock[i].REF_TAB_ID });

                                                if (entAssets != null)
                                                {
                                                    entAssets.CUSTODY_DEPT_ID = obj.USING_DEPT_ID;
                                                    entAssets.CUSTODY_USER_ID = obj.USING_USER_ID;
                                                    entAssets.SUBJECTION_DEPT_ID = obj.USING_DEPT_ID;
                                                    entAssets.USING_DEPT_ID = obj.USING_DEPT_ID;
                                                    entAssets.USING_USER_ID = obj.USING_USER_ID;
                                                    entAssets.CUSTODY_DEPT_ID = obj.USING_DEPT_ID;
                                                    entAssets.ENABLE_DATE = obj.CREATE_DATE;
                                                    entAssets.USE_STATE = "00540001";            //在用
                                                    entAssets.ASSETS_STATE = "00530002";        //资产状态(启用).
                                                    entAssets.CARD_TYPE_ID = "00680002";
                                                    entAssets.ECONOMIC_USE_TYPE_ID = disOutstock[0].ECONOMIC_USE_TYPE_ID;//hsc 如果出库是多个设备  则会出错 
                                                    BizLogicObject_MCE_B_ASSETS.Proxy.UpdateByTrans(entAssets, transaction);
                                                }
                                            }
                                            else
                                            {
                                                //因为这个方法取出的值只有ID跟状态.所以必须重新取值.
                                                DisplayObject_MCE_B_ASSETS[] disAssets = HelperObject_MCE_B_ASSETS.QueryIdState(disOutstock[i].REF_TAB_ID, disOutstock[i].REF_TAB_NAME);
                                                foreach (DisplayObject_MCE_B_ASSETS item in disAssets)
                                                {
                                                    EntityObject_MCE_B_ASSETS entAssets = BizLogicObject_MCE_B_ASSETS.Proxy.Get(new EntityObject_MCE_B_ASSETS() { ID = item.ID });
                                                    if (entAssets != null)
                                                    {
                                                        entAssets.CUSTODY_DEPT_ID = obj.USING_DEPT_ID;
                                                        entAssets.CUSTODY_USER_ID = obj.USING_USER_ID;
                                                        entAssets.SUBJECTION_DEPT_ID = obj.USING_DEPT_ID;
                                                        entAssets.USING_DEPT_ID = obj.USING_DEPT_ID;
                                                        entAssets.USING_USER_ID = obj.USING_USER_ID;
                                                        entAssets.CUSTODY_DEPT_ID = obj.USING_DEPT_ID;
                                                        entAssets.ENABLE_DATE = obj.CREATE_DATE;
                                                        entAssets.USE_STATE = "00540001";            //在用
                                                        entAssets.ASSETS_STATE = "00530002";        //资产状态(启用).
                                                        entAssets.CARD_TYPE_ID = "00680002";
                                                        entAssets.ECONOMIC_USE_TYPE_ID = disOutstock[0].ECONOMIC_USE_TYPE_ID;//hsc 如果出库是多个设备  则会出错 
                                                        BizLogicObject_MCE_B_ASSETS.Proxy.UpdateByTrans(entAssets, transaction);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    #endregion


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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_OUTSTOCK obj = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_OUTSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_OUTSTOCK.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_OUTSTOCK>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
