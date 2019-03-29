
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
using System.IO;
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_MCE_B_ASSETS_METER 
    {

        public BizLogicMsg Save_Ext(JsonMceAssetsMeter item)
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
                            EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.ASSETS_ID = item.assets_id;
                          //  obj.CODE = item.code;
                            obj.ACCURACY_CLASS = item.accuracy_class;
                            obj.METER_CLASS = item.meter_class;
                            obj.METER_TYPE = item.meter_type;

                            obj.MEASURE_RANGE = item.measure_range;
                            obj.DIVID_VALUE = item.divid_value;

                            if (!string.IsNullOrEmpty(item.identification_cycle))
                            {
                                obj.IDENTIFICATION_CYCLE = decimal.Parse(item.identification_cycle);
                            }

                            if (!string.IsNullOrEmpty(item.next_identification))
                            {
                                obj.NEXT_IDENTIFICATION = DateTime.Parse(item.next_identification);
                            }

                            obj.TIME_ZONE = item.time_zone;

                            if (!string.IsNullOrEmpty(item.is_force_sense))
                            {
                                obj.IS_FORCE_SENSE = decimal.Parse(item.is_force_sense);
                            }

                            obj.COMMENTS = item.comments;

                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.CODE = GetMeterCode();
                                obj.AUDIT_STATE = 1;
                                obj.STATE = 1;
                                HelperObject_MCE_B_ASSETS_METER.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_METER.Update(obj, transaction);
                            }

                            if (item.listFileName != null && (item.listFileName.Count > 0))
                            {
                                foreach (JsonMceAssetsFileInfo objFullName in item.listFileName)
                                {
                                    if (!string.IsNullOrEmpty(objFullName.saveName))
                                    {
                                        try
                                        {
                                            string strFileURL = System.Web.HttpContext.Current.Server.MapPath("~/upload/mce/" + objFullName.saveName);//路径
                                            if (File.Exists(strFileURL))
                                            {
                                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_METER";
                                                pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_METER";
                                                    entityPicFile.CLIENT_NAME = objFullName.fileName;
                                                    entityPicFile.STATE = 1;
                                                    entityPicFile.CREATE_TIME = DateTime.Now;
                                                    entityPicFile.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                                    entityPicFile.REF_TAB_ID = obj.ID;
                                                    entityPicFile.SERVER_NAME = objFullName.saveName;
                                                    entityPicFile.IS_IMPORT = 0;
                                                    Ipedf.Web.DataAccess.HelperObject_COM_FILE.Save(entityPicFile, transaction);
                                                }
                                            }
                                        }
                                        catch { }


                                    }
                                }
                            }

                            msg.Message = obj.ID;

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(item);
                }
            }
        }


        public BizLogicMsg Audit_Ext(string strID)
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

                            EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的计量信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_METER.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(strID);
                }
            }
        }


        public BizLogicMsg Delete_Ext(string strID)
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

                            EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的计量信息不能删除.");
                                }

                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_METER";

                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                if (listCOM_FILE != null && listCOM_FILE.Length > 0)
                                {
                                    foreach (DisplayObject_COM_FILE item in listCOM_FILE)
                                    {
                                        if (!string.IsNullOrEmpty(item.SERVER_NAME))
                                        {
                                            string strFileURL = System.Web.HttpContext.Current.Server.MapPath("~/upload/mce/" + item.SERVER_NAME);//路径
                                            if (File.Exists(strFileURL))
                                            {
                                                File.Delete(strFileURL);
                                            }
                                        }
                                    }
                                }
                                HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);

                                HelperObject_MCE_B_ASSETS_METER.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(strID);
                }
            }
        }



        public BizLogicMsg Meter_Expire(string strID)
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

                            EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                            if (obj != null)
                            {
                                if (obj.STATE == 2)
                                {
                                    throw new Exception("该计量已经过期.");
                                }

                                obj.STATE = 2;

                                HelperObject_MCE_B_ASSETS_METER.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Meter_Expire(strID);
                }
            }
        }



        public BizLogicMsg Meter_Continue(string strID)
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
                            EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                            if (obj != null)
                            {
                                obj.CODE = GetMeterCode();
                                obj.STATE = 1;
                                obj.AUDIT_STATE = 1;
                                HelperObject_MCE_B_ASSETS_METER.Save(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Meter_Continue(strID);
                }
            }
        }



        private string GetMeterCode()
        {
            string strMeterCode = "";

            string strCode = DateTime.Now.ToString("yyyyMMdd");


            int code = 1;

            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = false;
            orderBy.OrderBy = "CODE";

            var cause = new CauseObject_MCE_B_ASSETS_METER();
            cause.SetCustomCondition(" and MCE_B_ASSETS_METER.CODE like '" + strCode + "%'");
            var list = BizLogicObject_MCE_B_ASSETS_METER.Proxy.Query(cause, null, orderBy);
            if (list != null && list.Length > 0)
            {
                var s_code = list[0].CODE;
                var rightCode = s_code.Replace(strCode, "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strMeterCode = strCode + (code).ToString().PadLeft(3, '0');

            return strMeterCode;
        }




        public BizLogicMsg Save_Ext2(JsonMCE_METER json)
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
                            EntityObject_MCE_B_ASSETS_METER entity = new EntityObject_MCE_B_ASSETS_METER();


                            if (!string.IsNullOrEmpty(json.ID))
                            {
                                entity.ID = json.ID;

                                entity = HelperObject_MCE_B_ASSETS_METER.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = json.CODE;

                            entity.ASSETS_ID = json.ASSETS_ID;
                            entity.ASSETS_CODE = json.ASSETS_CODE;
                            entity.SPEC = json.SPEC;

                            entity.PRD_ID = json.PRD_ID;
                            entity.UNIT_ID = json.UNIT_ID;
                            entity.USING_DEPT_ID = json.USING_DEPT_ID;
                            entity.PRD_CODE = json.PRD_CODE;

                            if (!string.IsNullOrEmpty(json.IDENTIFICATION_CYCLE))
                            {
                                entity.IDENTIFICATION_CYCLE =decimal.Parse( json.IDENTIFICATION_CYCLE);
                            }
                            entity.METER_TYPE = json.METER_TYPE;
                            entity.HEAD_USER_ID = json.HEAD_USER_ID;

                            if (!string.IsNullOrEmpty(json.IDENTIFICATION_TYPE))
                            {
                                entity.IDENTIFICATION_TYPE =decimal.Parse( json.IDENTIFICATION_TYPE);
                            }
                            if (!string.IsNullOrEmpty(json.IS_FORCE_SENSE))
                            {
                                entity.IS_FORCE_SENSE =decimal.Parse( json.IS_FORCE_SENSE);
                            }
                            if (!string.IsNullOrEmpty(json.NEXT_IDENTIFICATION))
                            {
                                entity.NEXT_IDENTIFICATION =DateTime.Parse( json.NEXT_IDENTIFICATION);
                            }
                            if (!string.IsNullOrEmpty(json.EARLY_WARNING_DAYS))
                            {
                                entity.EARLY_WARNING_DAYS =decimal.Parse( json.EARLY_WARNING_DAYS);
                            }
                            entity.COMMENTS = json.COMMENTS;


                            if (string.IsNullOrEmpty(entity.ID))
                            {
                                entity.STATE = 1;
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_METER.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_TIME = DateTime.Now;
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                                int amount = HelperObject_MCE_B_ASSETS_METER.Update(entity, transaction);


                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = entity.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_METER";
                                HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);

                            }

                            //平台自动生成代码
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Save_Ext2(json);
                }
            }
        }




        public BizLogicMsg Submit_Ext2(List<string> listID)
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
                                EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

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
                                    HelperObject_MCE_B_ASSETS_METER.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Submit_Ext2(listID);
                }
            }
        }


        public BizLogicMsg Audit_Ext2(List<string> listID)
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
                                EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_METER.Update(obj, transaction);


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
                                
                                    entity.PLAN_IDENTIFICATION = obj.NEXT_IDENTIFICATION;
                         
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext2(listID);
                }
            }
        }



        public BizLogicMsg Delete_Ext2(List<string> listID)
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
                                EntityObject_MCE_B_ASSETS_METER obj = new EntityObject_MCE_B_ASSETS_METER();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_METER.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_METER.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext2(listID);
                }
            }
        }




    }
}
