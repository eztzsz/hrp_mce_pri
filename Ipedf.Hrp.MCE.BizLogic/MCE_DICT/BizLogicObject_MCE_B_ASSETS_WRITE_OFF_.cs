
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
 
    public partial class BizLogicObject_MCE_B_ASSETS_WRITE_OFF 
    {


        public BizLogicMsg Save_Ext(JsonMceAssetsWriteOff item)
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
                            EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.ASSETS_ID = item.assets_id;
                         //   obj.CODE = item.code;
                            obj.FINANCE_CYCLE = item.finance_cycle;
                            if (!string.IsNullOrEmpty(item.create_date))
                            {
                                obj.CREATE_DATE =DateTime.Parse( item.create_date);
                            }
                            obj.WRITE_OFF_TYPE_ID = item.write_off_type_id;

                            obj.WRITE_OFF_CAUSE_ID = item.write_off_cause_id;

                            if (!string.IsNullOrEmpty(item.original_value))
                            {
                                obj.ORIGINAL_VALUE = decimal.Parse(item.original_value);
                            }
                            if (!string.IsNullOrEmpty(item.net_value))
                            {
                                obj.NET_VALUE = decimal.Parse(item.net_value);
                            }
                            if (!string.IsNullOrEmpty(item.rudimental_value))
                            {
                                obj.RUDIMENTAL_VALUE = decimal.Parse(item.rudimental_value);
                            }
                            obj.INCOME = item.income;

                       

                            obj.COMMENTS = item.comments;

                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.CODE = GetWriteOffCode();
                                obj.AUDIT_STATE = 1;
                                obj.STATE = 1;
                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(obj, transaction);
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
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_WRITE_OFF";
                                                pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_WRITE_OFF";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(item);
                }
            }
        }



        public BizLogicMsg Save_Ext2(JsonMCE_Write_Off json_Write_Off)
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
                            EntityObject_MCE_B_ASSETS_WRITE_OFF entity = new EntityObject_MCE_B_ASSETS_WRITE_OFF();


                            if (!string.IsNullOrEmpty(json_Write_Off.ID))
                            {
                                entity.ID = json_Write_Off.ID;

                                entity = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = json_Write_Off.CODE;
                          
                            if (!string.IsNullOrEmpty(json_Write_Off.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(json_Write_Off.CREATE_DATE);
                            }
                            entity.DEPT_ID = json_Write_Off.DEPT_ID;
                            entity.USER_ID = json_Write_Off.USER_ID;


                            entity.FINANCE_CYCLE = json_Write_Off.FINANCE_CYCLE;
                            entity.WRITE_OFF_TYPE_ID = json_Write_Off.WRITE_OFF_TYPE_ID;
                            entity.WRITE_OFF_CAUSE_ID = json_Write_Off.WRITE_OFF_CAUSE_ID;
                            entity.INCOME = json_Write_Off.INCOME;
                            entity.USAGE = json_Write_Off.USAGE;
                        

                            entity.COMMENTS = json_Write_Off.COMMENTS;
                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(json_Write_Off.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_WRITE_OFF.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_TIME = DateTime.Now;
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(entity, transaction);

                                CauseObject_MCE_B_ASSETS_WRITE_OFF_D pWriteOffDetail = new CauseObject_MCE_B_ASSETS_WRITE_OFF_D();
                                pWriteOffDetail.BASE_ID = json_Write_Off.ID;
                                HelperObject_MCE_B_ASSETS_WRITE_OFF_D.Delete(pWriteOffDetail, transaction);


                                CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH pWriteOffAttach = new CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();
                                pWriteOffAttach.BASE_ID = json_Write_Off.ID;
                                HelperObject_MCE_B_ASSETS_WRITE_OFF_ATTACH.Delete(pWriteOffAttach, transaction);
                            }

                            if (json_Write_Off.children != null && json_Write_Off.children.Count > 0)
                            {
                                foreach (JsonMCE_Write_Off_D item in json_Write_Off.children)
                                {
                                    EntityObject_MCE_B_ASSETS_WRITE_OFF_D entity_D = new EntityObject_MCE_B_ASSETS_WRITE_OFF_D();

                                    entity_D.BASE_ID = entity.ID;
                                    entity_D.ASSET_ID = item.ASSET_ID;
                                
                                    HelperObject_MCE_B_ASSETS_WRITE_OFF_D.Save(entity_D, transaction);
                                }                         
                            }


                            if (json_Write_Off.listAttach != null && json_Write_Off.listAttach.Count > 0)
                            {
                                foreach (JsonMCE_Write_Off__ATTACH item in json_Write_Off.listAttach)
                                {
                                    EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH entity_D = new EntityObject_MCE_B_ASSETS_WRITE_OFF_ATTACH();

                                    entity_D.BASE_ID = entity.ID;
                                    entity_D.FILE_NAME = item.FILE_NAME;
                                    entity_D.SAVENAME= item.SAVENAME;
                                    entity_D.USER_ID = item.USER_ID;
                                    entity_D.CREATE_DATE = item.CREATE_DATE;
   

                                    HelperObject_MCE_B_ASSETS_WRITE_OFF_ATTACH.Save(entity_D, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Save_Ext2(json_Write_Off);
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

                            EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的报废信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(obj, transaction);

                                EntityObject_MCE_B_ASSETS objMCE_B_ASSETS = new EntityObject_MCE_B_ASSETS();
                                objMCE_B_ASSETS.ID = obj.ASSETS_ID;

                                objMCE_B_ASSETS = HelperObject_MCE_B_ASSETS.Get(objMCE_B_ASSETS);

                                if (obj != null)
                                {
                                    objMCE_B_ASSETS.ASSETS_STATE = "00530003";
                                    objMCE_B_ASSETS.OUT_ACCOUNT_DATE = obj.CREATE_DATE;
                                    HelperObject_MCE_B_ASSETS.Update(objMCE_B_ASSETS, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的报废信息不能删除.");
                                }

                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_WRITE_OFF";

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

                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(strID);
                }
            }
        }


        private string GetWriteOffCode()
        {
            string strWriteOffCode = "";

            string strCode = DateTime.Now.ToString("yyyyMMdd");


            int code = 1;

            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = false;
            orderBy.OrderBy = "CODE";

            var cause = new CauseObject_MCE_B_ASSETS_WRITE_OFF();
            cause.SetCustomCondition(" and MCE_B_ASSETS_WRITE_OFF.CODE like '" + strCode + "%'");
            var list = BizLogicObject_MCE_B_ASSETS_WRITE_OFF.Proxy.Query(cause, null, orderBy);
            if (list != null && list.Length > 0)
            {
                var s_code = list[0].CODE;
                var rightCode = s_code.Replace(strCode, "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strWriteOffCode = strCode + (code).ToString().PadLeft(3, '0');

            return strWriteOffCode;
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
                                EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Submit_Ext2(listID);
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
                                EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }


                                    DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH[] listAttach = BizLogicObject_MCE_B_ASSETS_WRITE_OFF_ATTACH.Proxy.Query(new CauseObject_MCE_B_ASSETS_WRITE_OFF_ATTACH() { BASE_ID = obj.ID });

                                    if (listAttach != null && listAttach.Length > 0)
                                    {
                                        foreach (DisplayObject_MCE_B_ASSETS_WRITE_OFF_ATTACH item in listAttach)
                                        {
                                            if (!string.IsNullOrEmpty(item.SAVENAME))
                                            {
                                                 string strFileURL = System.Web.HttpContext.Current.Server.MapPath("~/upload/mce/" + item.SAVENAME);//路径
                                                if(File.Exists(strFileURL))
                                                {
                                                    File.Delete(strFileURL);
                                                }
                                            }
                                        }
                                    }

                                    HelperObject_MCE_B_ASSETS_WRITE_OFF.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext2(listID);
                }
            }
        }



        public BizLogicMsg Identity(JsonWriteOffIdentity item)
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
                            EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                            obj.ID = item.ID;

                            obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                            if (obj != null)
                            {
                                if (obj.STATE > 2 )
                                {
                                    throw new Exception("已经鉴定的数据不能再鉴定.");
                                }
                                obj.IDENTITY_PARAM = item.IDENTITY_PARAM;
                                obj.STATE =int.Parse( item.IDENTITY_STATE);
                                obj.IDENTITY_STATE = int.Parse(item.IDENTITY_STATE);

                                obj.IDENTITY_TIME =DateTime.Parse( item.IDENTITY_TIME);
                                obj.IDENTITY_USER_ID = item.IDENTITY_USER_ID;

                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Identity( item);
                }
            }
        }



        public BizLogicMsg Audit_Ext2(JsonWriteOffAudit item)
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
                            EntityObject_MCE_B_ASSETS_WRITE_OFF obj = new EntityObject_MCE_B_ASSETS_WRITE_OFF();
                            obj.ID = item.ID;

                            obj = HelperObject_MCE_B_ASSETS_WRITE_OFF.Get(obj);

                            if (obj != null)
                            {
                                if (obj.STATE > 4)
                                {
                                    throw new Exception("已经审核的数据不能再审核.");
                                }
                         
                                obj.STATE = int.Parse(item.AUDIT_STATE);

                                obj.AUDIT_TIME = DateTime.Parse(item.AUDIT_TIME);
                                obj.AUDIT_USER_ID = item.AUDIT_USER_ID;
                                obj.SUMARRY = item.SUMARRY;

                                HelperObject_MCE_B_ASSETS_WRITE_OFF.Update(obj, transaction);


                                if (obj.STATE == 5)
                                {
                                    DisplayObject_MCE_B_ASSETS_WRITE_OFF_D[] listD = BizLogicObject_MCE_B_ASSETS_WRITE_OFF_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_WRITE_OFF_D() { BASE_ID = obj.ID });

                                    if (listD != null && listD.Length > 0)
                                    {
                                        foreach (DisplayObject_MCE_B_ASSETS_WRITE_OFF_D item_D in listD)
                                        {
                                            EntityObject_MCE_B_ASSETS objMCE_B_ASSETS = new EntityObject_MCE_B_ASSETS();
                                            objMCE_B_ASSETS.ID = item_D.ASSET_ID;

                                            objMCE_B_ASSETS = HelperObject_MCE_B_ASSETS.Get(objMCE_B_ASSETS);

                                            if (obj != null)
                                            {
                                                objMCE_B_ASSETS.ASSETS_STATE = "00530003";
                                                objMCE_B_ASSETS.OUT_ACCOUNT_DATE = obj.AUDIT_TIME;
                                                HelperObject_MCE_B_ASSETS.Update(objMCE_B_ASSETS, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_WRITE_OFF>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext2( item);
                }
            }
        }


    }
}
