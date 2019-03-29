
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
    public partial class BizLogicObject_MCE_B_ASSETS_MT_APPLY 
    {


        public BizLogicMsg Save_Ext(JsonMCE_MT_APPLY json)
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
                            EntityObject_MCE_B_ASSETS_MT_APPLY entity = new EntityObject_MCE_B_ASSETS_MT_APPLY();


                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_MT_APPLY.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = json.CODE;
                            entity.APPLY_DEPT_ID = json.APPLY_DEPT_ID;
                            entity.APPLY_USER_ID = json.APPLY_USER_ID;
                            entity.ASSETS_ID = json.ASSETS_ID;
                            entity.ASSETS_CODE = json.ASSETS_CODE;
                            entity.SPEC = json.SPEC;

                            entity.ASSETS_TYPE_ID = json.ASSETS_TYPE_ID;
                            entity.PRD_ID = json.PRD_ID;
                            entity.MTN_TYPE_ID = json.MTN_TYPE_ID;
                            entity.FAULT_TYPE = json.FAULT_TYPE;
                            entity.EMERGENCY_DEGREE = json.EMERGENCY_DEGREE;
                            entity.REPAIR_RESULT = json.REPAIR_RESULT;

                            if (!string.IsNullOrEmpty(json.CREATE_DATE))
                            {
                                entity.CREATE_DATE =DateTime.Parse( json.CREATE_DATE);
                            }

                            entity.APPLY_USER_PHONE = json.APPLY_USER_PHONE;

                            if (!string.IsNullOrEmpty(json.COMPLETE_TIME))
                            {
                                entity.COMPLETE_TIME = DateTime.Parse( json.COMPLETE_TIME);
                            }
                         
                            entity.MTN_ENGINEER = json.MTN_ENGINEER;

                            if (!string.IsNullOrEmpty(json.MTN_TOTAL_HOURS))
                            {
                                entity.MTN_TOTAL_HOURS =decimal.Parse( json.MTN_TOTAL_HOURS);
                            }

                            if (!string.IsNullOrEmpty(json.MAINTAIN_MONEY))
                            {
                                entity.MAINTAIN_MONEY =decimal.Parse( json.MAINTAIN_MONEY);
                            }

                            entity.INVOICE_CODE = json.INVOICE_CODE;
                            entity.FAULT_DESC = json.FAULT_DESC;
                            entity.FAULT_ANALYSIS = json.FAULT_ANALYSIS;
                            entity.FAULT_SOLUTION = json.FAULT_SOLUTION;

                            if (string.IsNullOrEmpty(entity.ID))
                            {
                                entity.STATE = 1;
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_TIME = DateTime.Now;
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                                int amount = HelperObject_MCE_B_ASSETS_MT_APPLY.Update(entity, transaction);


                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = entity.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_MT_APPLY";
                                HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);

                            }


                            if (json.listAttach != null && json.listAttach.Count > 0)
                            {
                                foreach (JsonMCEMT_APPLY_MTN_ATTACH item in json.listAttach)
                                {
                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_MT_APPLY";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_MT_APPLY obj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj);

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

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_MT_APPLY obj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_MT_APPLY.Update(obj, transaction);

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_MT_APPLY obj = new EntityObject_MCE_B_ASSETS_MT_APPLY();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_MT_APPLY.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_MT_APPLY.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_MT_APPLY>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }




    }
}
