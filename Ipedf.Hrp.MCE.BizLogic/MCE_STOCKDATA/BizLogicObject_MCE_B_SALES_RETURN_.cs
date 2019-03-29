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

    public partial class BizLogicObject_MCE_B_SALES_RETURN 
    {


        public BizLogicMsg Save_Ext(JsonMCE_SALESRETURN jsonMCE_SALESRETURN)
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

                            EntityObject_MCE_B_SALES_RETURN entity = new EntityObject_MCE_B_SALES_RETURN();


                            if (!string.IsNullOrEmpty(jsonMCE_SALESRETURN.ID))
                            {
                                entity.ID = jsonMCE_SALESRETURN.ID;

                                entity = HelperObject_MCE_B_SALES_RETURN.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonMCE_SALESRETURN.CODE;

                            if (!string.IsNullOrEmpty(jsonMCE_SALESRETURN.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonMCE_SALESRETURN.CREATE_DATE);
                            }
                            entity.PROVIDER_ID = jsonMCE_SALESRETURN.PROVIDER_ID;
                        
                            entity.USER_ID = jsonMCE_SALESRETURN.USER_ID;
                            entity.STOCK_ID = jsonMCE_SALESRETURN.STOCK_ID;

                            entity.COMMENTS = jsonMCE_SALESRETURN.COMMENTS;

                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonMCE_SALESRETURN.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_SALES_RETURN.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_SALES_RETURN.Update(entity, transaction);
                            }


                            if (jsonMCE_SALESRETURN.DELETEIDS != null && jsonMCE_SALESRETURN.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in jsonMCE_SALESRETURN.DELETEIDS)
                                {
                                    EntityObject_MCE_B_SALES_RETURN_D entity_D = new EntityObject_MCE_B_SALES_RETURN_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_SALES_RETURN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_SALES_RETURN_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (jsonMCE_SALESRETURN.children != null && jsonMCE_SALESRETURN.children.Count > 0)
                            {
                                decimal decTotMoney = 0;
                                foreach (JsonMCE_SALESRETURN_D item in jsonMCE_SALESRETURN.children)
                                {
                                    EntityObject_MCE_B_SALES_RETURN_D entity_D = new EntityObject_MCE_B_SALES_RETURN_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_SALES_RETURN_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;

                                    entity_D.ASSETS_ID = item.ASSETS_ID;
                                    entity_D.ASSETS_NAME = item.ASSETS_NAME;
                                    entity_D.ASSETS_CODE = item.ASSETS_CODE;
                                    entity_D.REF_TAB_ID = item.REF_TAB_ID;
                                    entity_D.REF_TAB_NAME = item.REF_TAB_NAME;
                                    entity_D.SPEC = item.SPEC;
                                    entity_D.COMMENTS = item.COMMENTS;

                                    entity_D.MONEY = item.MONEY;
                                    entity_D.PRICE = item.PRICE;

                                    if (!string.IsNullOrEmpty(item.PRD_DATE))
                                    {
                                        entity_D.PRD_DATE =DateTime.Parse( item.PRD_DATE);
                                        entity_D.PRD_ID = item.PRD_ID;
                                    }

                                    decTotMoney = decTotMoney + entity_D.MONEY;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_SALES_RETURN_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_SALES_RETURN_D.Update(entity_D, transaction);
                                    }


                                }
                                entity.TOTAL_MONEY = decTotMoney;

                                HelperObject_MCE_B_SALES_RETURN.Update(entity, transaction);

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
                using (ServiceManager<ServiceContract_MCE_B_SALES_RETURN> smgr = new ServiceManager<ServiceContract_MCE_B_SALES_RETURN>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMCE_SALESRETURN);
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
                                EntityObject_MCE_B_SALES_RETURN obj = new EntityObject_MCE_B_SALES_RETURN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_SALES_RETURN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_SALES_RETURN.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_SALES_RETURN> smgr = new ServiceManager<ServiceContract_MCE_B_SALES_RETURN>(ServiceUri))
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
                                EntityObject_MCE_B_SALES_RETURN obj = new EntityObject_MCE_B_SALES_RETURN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_SALES_RETURN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_SALES_RETURN.Update(obj, transaction);

                                    
                                    DisplayObject_MCE_B_SALES_RETURN_D[] disBack = BizLogicObject_MCE_B_SALES_RETURN_D.Proxy.Query(new CauseObject_MCE_B_SALES_RETURN_D() { BASE_ID = obj.ID });
                                    if (disBack.Length > 0)
                                    {
                                        for (int i = 0; i < disBack.Length; i++)
                                        {
                                            if (string.IsNullOrEmpty(disBack[i].ASSETS_ID))
                                            {
                                                continue;
                                            }
                                            //资产卡片更新
                                            EntityObject_MCE_B_ASSETS entAssets = BizLogicObject_MCE_B_ASSETS.Proxy.Get(new EntityObject_MCE_B_ASSETS() { ID = disBack[i].ASSETS_ID });

                                            if (entAssets != null)
                                            {

                                                entAssets.ASSETS_STATE = "00530004";            //退货
                                                BizLogicObject_MCE_B_ASSETS.Proxy.UpdateByTrans(entAssets, transaction);

                                                /*
                                                if (!string.IsNullOrEmpty(disBack[i].REF_TAB_ID))
                                                {
                                                    EntityObject_MCE_B_ASSETS_OUTSTOCK_D oUTSTOCK_D = BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.Get(new EntityObject_MCE_B_ASSETS_OUTSTOCK_D() { ID = disBack[i].REF_TAB_ID });

                                                    if (oUTSTOCK_D != null)
                                                    {
                                                        oUTSTOCK_D.IS_RETURN = 1;
                                                    }
                                                    BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.UpdateByTrans(oUTSTOCK_D, transaction);
                                                }
                                                */
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
                using (ServiceManager<ServiceContract_MCE_B_SALES_RETURN> smgr = new ServiceManager<ServiceContract_MCE_B_SALES_RETURN>(ServiceUri))
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
                                EntityObject_MCE_B_SALES_RETURN obj = new EntityObject_MCE_B_SALES_RETURN();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_SALES_RETURN.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_SALES_RETURN.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_SALES_RETURN> smgr = new ServiceManager<ServiceContract_MCE_B_SALES_RETURN>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
