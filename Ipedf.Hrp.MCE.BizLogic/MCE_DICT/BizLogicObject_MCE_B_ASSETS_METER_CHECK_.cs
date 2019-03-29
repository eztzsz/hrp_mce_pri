
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
    
    public partial class BizLogicObject_MCE_B_ASSETS_METER_CHECK 
    {
        public BizLogicMsg Save_Ext(JsonMCE_Meter_Check json)
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
                            EntityObject_MCE_B_ASSETS_METER_CHECK entity = new EntityObject_MCE_B_ASSETS_METER_CHECK();

                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_METER_CHECK.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }
                            else
                            {
                                throw new Exception("参数错误.");
                            }

                            if (!string.IsNullOrEmpty(json.ACTUAL_IDENTIFICATION))
                            {
                                entity.ACTUAL_IDENTIFICATION = DateTime.Parse(json.ACTUAL_IDENTIFICATION);
                            }

                            if (!string.IsNullOrEmpty(json.RESULT_ID))
                            {
                                entity.RESULT_ID =decimal.Parse( json.RESULT_ID);
                            }

                            entity.CERTIFICATE_CODE = json.CERTIFICATE_CODE;

                            if (!string.IsNullOrEmpty(json.MONEY))
                            {
                                entity.MONEY = decimal.Parse( json.MONEY);
                            }

                            entity.CHECK_PERSON = json.CHECK_PERSON;


                            entity.COMMENTS = json.COMMENTS;

                            int amount = HelperObject_MCE_B_ASSETS_METER_CHECK.Update(entity, transaction);


                            CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                            pCOM_FILE.REF_TAB_ID = entity.ID;
                            pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_METER_CHECK";
                            HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);

                            
                            if (json.listAttach != null && json.listAttach.Count > 0)
                            {
                                foreach (JsonMCEMT_APPLY_MTN_ATTACH item in json.listAttach)
                                {
                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_METER_CHECK";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_METER_CHECK obj = new EntityObject_MCE_B_ASSETS_METER_CHECK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_METER_CHECK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }


                                    if (obj.ACTUAL_IDENTIFICATION < DateTime.Now.AddDays(-100))
                                    {
                                        throw new Exception("实际检测日期错误.");
                                    }

                                    if (obj.RESULT_ID <=0)
                                    {
                                        throw new Exception("检测结果不能为空.");
                                    }
                                    if (string.IsNullOrEmpty(obj.CHECK_PERSON))
                                    {
                                        throw new Exception("检测人不能为空.");
                                    }



                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_METER_CHECK.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_METER_CHECK obj = new EntityObject_MCE_B_ASSETS_METER_CHECK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_METER_CHECK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    obj.NEXT_IDENTIFICATION = obj.ACTUAL_IDENTIFICATION.AddMonths(int.Parse(obj.IDENTIFICATION_CYCLE.ToString()));
                                    HelperObject_MCE_B_ASSETS_METER_CHECK.Update(obj, transaction);



                                    EntityObject_MCE_B_ASSETS_METER_CHECK entity = new EntityObject_MCE_B_ASSETS_METER_CHECK();

                                    entity.METER_ID = obj.ID;
                                    entity.CODE = obj.CODE;

                                    entity.ASSETS_ID = obj.ASSETS_ID;
                                    entity.ASSETS_CODE = obj.ASSETS_CODE;
                                    entity.SPEC = obj.SPEC;

                                    entity.PRD_ID = obj.PRD_ID;
                                    entity.UNIT_ID = obj.UNIT_ID;
                                    entity.USING_DEPT_ID = obj.USING_DEPT_ID;
                                    entity.PRD_CODE = obj.PRD_CODE;

                                    entity.IDENTIFICATION_CYCLE = obj.IDENTIFICATION_CYCLE;

                                    entity.METER_TYPE = obj.METER_TYPE;
                                    entity.HEAD_USER_ID = obj.HEAD_USER_ID;

                                    entity.IDENTIFICATION_TYPE = obj.IDENTIFICATION_TYPE;

                                    entity.IS_FORCE_SENSE = obj.IS_FORCE_SENSE;

                                    entity.PLAN_IDENTIFICATION = obj.ACTUAL_IDENTIFICATION.AddMonths(int.Parse(obj.IDENTIFICATION_CYCLE.ToString()));

                                    entity.EARLY_WARNING_DAYS = obj.EARLY_WARNING_DAYS;

                                    entity.COMMENTS = obj.COMMENTS;


                                    entity.STATE = 1;
                                    entity.CREATE_TIME = DateTime.Now;
                                    entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    int amount = HelperObject_MCE_B_ASSETS_METER_CHECK.Save(entity, transaction);





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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER_CHECK>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(listID);
                }
            }
        }


    }
}
