﻿
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

    public partial class BizLogicObject_MCE_B_ASSETS_BACK
    {


        public BizLogicMsg Save_Ext(JsonMCE_BACK jsonMCE_BACK)
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

                            EntityObject_MCE_B_ASSETS_BACK entity = new EntityObject_MCE_B_ASSETS_BACK();


                            if (!string.IsNullOrEmpty(jsonMCE_BACK.ID))
                            {
                                entity.ID = jsonMCE_BACK.ID;

                                entity = HelperObject_MCE_B_ASSETS_BACK.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonMCE_BACK.CODE;

                            if (!string.IsNullOrEmpty(jsonMCE_BACK.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonMCE_BACK.CREATE_DATE);
                            }
                            entity.RETURN_DEPT_ID = jsonMCE_BACK.RETURN_DEPT_ID;
                            entity.RETURN_USER_ID = jsonMCE_BACK.RETURN_USER_ID;
                            entity.DEPT_ID = jsonMCE_BACK.DEPT_ID;
                            entity.USER_ID = jsonMCE_BACK.USER_ID;
                            entity.STOCK_ID = jsonMCE_BACK.STOCK_ID;

                            entity.COMMENTS = jsonMCE_BACK.COMMENTS;

                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonMCE_BACK.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_BACK.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_ASSETS_BACK.Update(entity, transaction);
                            }


                            if (jsonMCE_BACK.DELETEIDS != null && jsonMCE_BACK.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in jsonMCE_BACK.DELETEIDS)
                                {
                                    EntityObject_MCE_B_ASSETS_BACK_D entity_D = new EntityObject_MCE_B_ASSETS_BACK_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_ASSETS_BACK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_ASSETS_BACK_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (jsonMCE_BACK.children != null && jsonMCE_BACK.children.Count > 0)
                            {

                                foreach (JsonMCE_BACK_D item in jsonMCE_BACK.children)
                                {
                                    EntityObject_MCE_B_ASSETS_BACK_D entity_D = new EntityObject_MCE_B_ASSETS_BACK_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_BACK_D.Get(entity_D);

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

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_ASSETS_BACK_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_ASSETS_BACK_D.Update(entity_D, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_BACK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_BACK>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMCE_BACK);
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
                                EntityObject_MCE_B_ASSETS_BACK obj = new EntityObject_MCE_B_ASSETS_BACK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_BACK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_BACK.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_BACK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_BACK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_BACK obj = new EntityObject_MCE_B_ASSETS_BACK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_BACK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_BACK.Update(obj, transaction);

                                    
                                    DisplayObject_MCE_B_ASSETS_BACK_D[] disBack = BizLogicObject_MCE_B_ASSETS_BACK_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_BACK_D() { BASE_ID = obj.ID });
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
                                                entAssets.CUSTODY_DEPT_ID = obj.DEPT_ID;
                                                entAssets.CUSTODY_USER_ID = obj.USER_ID;
                                                entAssets.SUBJECTION_DEPT_ID = obj.DEPT_ID;
                                                entAssets.USING_DEPT_ID = obj.DEPT_ID;
                                                entAssets.USING_USER_ID = obj.USER_ID;
                                                entAssets.USE_STATE = "00540002";            //闲置
                                                BizLogicObject_MCE_B_ASSETS.Proxy.UpdateByTrans(entAssets, transaction);

                                                if (!string.IsNullOrEmpty(disBack[i].REF_TAB_ID))
                                                {
                                                    EntityObject_MCE_B_ASSETS_OUTSTOCK_D oUTSTOCK_D = BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.Get(new EntityObject_MCE_B_ASSETS_OUTSTOCK_D() { ID = disBack[i].REF_TAB_ID });

                                                    if (oUTSTOCK_D != null)
                                                    {
                                                        oUTSTOCK_D.IS_RETURN = 1;
                                                    }
                                                    BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.UpdateByTrans(oUTSTOCK_D, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_BACK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_BACK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_BACK obj = new EntityObject_MCE_B_ASSETS_BACK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_BACK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_BACK.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_BACK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_BACK>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }


    }
}
