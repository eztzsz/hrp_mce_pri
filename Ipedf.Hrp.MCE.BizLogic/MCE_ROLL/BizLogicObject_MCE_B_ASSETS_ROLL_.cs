
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
using System.IO;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_MCE_B_ASSETS_ROLL
    {

        public BizLogicMsg Save_Ext(JsonMceAssetsRoll item)
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
                            EntityObject_MCE_B_ASSETS_ROLL obj = new EntityObject_MCE_B_ASSETS_ROLL();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_ROLL.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                         //   obj.ASSETS_ID = item.assets_id;
                           // obj.CODE = item.code;
                            obj.NAME = item.name;
                            obj.SAVELIMIT = item.savelimit;
                            obj.CREATE_USER_ID = item.create_user_id;

                            if (!string.IsNullOrEmpty(item.create_time))
                            {
                                obj.CREATE_TIME = DateTime.Parse(item.create_time);
                            }

                            obj.PLAN_TYPE = item.plan_type;
                            obj.ROLL_TYPE = item.roll_type;
                            obj.ROLL_PROPERTY = item.roll_property;

                            obj.COMMENTS = item.comments;

                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.CODE = GetRollCode();
                                obj.AUDIT_STATE = 1;
                                obj.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;

                                HelperObject_MCE_B_ASSETS_ROLL.Save(obj, transaction);

                                EntityObject_MCE_B_ASSETS_ROLLEQUIP objEquip = new EntityObject_MCE_B_ASSETS_ROLLEQUIP();
                                objEquip.ASSETS_ID = item.assets_id;
                                objEquip.ROLL_ID = obj.ID;
                                HelperObject_MCE_B_ASSETS_ROLLEQUIP.Save(objEquip, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_ROLL.Update(obj, transaction);

                                CauseObject_MCE_B_ASSETS_ROLLEQUIP pMCE_B_ASSETS_ROLLEQUIP = new CauseObject_MCE_B_ASSETS_ROLLEQUIP();
                                pMCE_B_ASSETS_ROLLEQUIP.ROLL_ID = obj.ID;
                                pMCE_B_ASSETS_ROLLEQUIP.ASSETS_ID = item.assets_id;

                                DisplayObject_MCE_B_ASSETS_ROLLEQUIP[] listMCE_B_ASSETS_ROLLEQUIP = BizLogicObject_MCE_B_ASSETS_ROLLEQUIP.Proxy.Query(pMCE_B_ASSETS_ROLLEQUIP);

                                if (listMCE_B_ASSETS_ROLLEQUIP == null || listMCE_B_ASSETS_ROLLEQUIP.Length== 0)
                                {
                                    EntityObject_MCE_B_ASSETS_ROLLEQUIP objEquip = new EntityObject_MCE_B_ASSETS_ROLLEQUIP();
                                    objEquip.ASSETS_ID = item.assets_id;
                                    objEquip.ROLL_ID = obj.ID;
                                    HelperObject_MCE_B_ASSETS_ROLLEQUIP.Save(objEquip, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(item);
                }
            }
        }


        public BizLogicMsg Audit_Ext(JsonMceAssetsRoll item)
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

                            EntityObject_MCE_B_ASSETS_ROLL obj = new EntityObject_MCE_B_ASSETS_ROLL();
                            obj.ID = item.id;

                            obj = HelperObject_MCE_B_ASSETS_ROLL.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的案卷信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_ROLL.Update(obj, transaction);


                                EntityObject_MCE_B_ASSETS objMCE_B_ASSETS = new EntityObject_MCE_B_ASSETS();
                                objMCE_B_ASSETS.ID = item.assets_id;

                                objMCE_B_ASSETS = HelperObject_MCE_B_ASSETS.Get(objMCE_B_ASSETS);

                                if (obj != null)
                                {
                                    objMCE_B_ASSETS.FILE_CODE = obj.CODE;
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(item);
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

                            EntityObject_MCE_B_ASSETS_ROLL obj = new EntityObject_MCE_B_ASSETS_ROLL();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_ROLL.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的案卷信息不能删除.");
                                }


                                CauseObject_MCE_B_ASSETS_ROLLFILE pMCE_B_ASSETS_ROLLFILE = new CauseObject_MCE_B_ASSETS_ROLLFILE();
                                pMCE_B_ASSETS_ROLLFILE.BASE_ID = obj.ID;
                              
                                DisplayObject_MCE_B_ASSETS_ROLLFILE[] listMCE_B_ASSETS_ROLLFILE = BizLogicObject_MCE_B_ASSETS_ROLLFILE.Proxy.Query(pMCE_B_ASSETS_ROLLFILE);

                                if (listMCE_B_ASSETS_ROLLFILE != null && listMCE_B_ASSETS_ROLLFILE.Length > 0)
                                {

                                    foreach (DisplayObject_MCE_B_ASSETS_ROLLFILE displayObject_MCE_B_ASSETS_ROLLFILE in listMCE_B_ASSETS_ROLLFILE)
                                    {
                                        CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                        pCOM_FILE.REF_TAB_ID = displayObject_MCE_B_ASSETS_ROLLFILE.ID;
                                        pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_ROLLFILE";

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

                                        HelperObject_MCE_B_ASSETS_ROLLFILE.Delete(displayObject_MCE_B_ASSETS_ROLLFILE, transaction);
                                    }
                                }


                                CauseObject_MCE_B_ASSETS_ROLLEQUIP pMCE_B_ASSETS_ROLLEQUIP = new CauseObject_MCE_B_ASSETS_ROLLEQUIP();
                                pMCE_B_ASSETS_ROLLEQUIP.ROLL_ID = obj.ID;
                                HelperObject_MCE_B_ASSETS_ROLLEQUIP.Delete(pMCE_B_ASSETS_ROLLEQUIP, transaction);


                                HelperObject_MCE_B_ASSETS_ROLL.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(strID);
                }
            }
        }
        


        public BizLogicMsg Save_RollFiles(List<JsonMceAssetsRollFile> listItem)
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
                            if (listItem != null && listItem.Count>0)
                            {
                                EntityObject_MCE_B_ASSETS_ROLL objRoll = new EntityObject_MCE_B_ASSETS_ROLL();

                                objRoll.ID = listItem[0].base_id;

                                objRoll = HelperObject_MCE_B_ASSETS_ROLL.Get(objRoll);

                                if (objRoll == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }

                                if (objRoll.AUDIT_STATE == 3 || objRoll.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的案卷信息文件不能保存.");
                                }

                                foreach(JsonMceAssetsRollFile item in listItem)
                                {

                                    EntityObject_MCE_B_ASSETS_ROLLFILE obj = new EntityObject_MCE_B_ASSETS_ROLLFILE();

                                    if (!string.IsNullOrEmpty(item.id))
                                    {
                                        obj.ID = item.id;

                                        obj = HelperObject_MCE_B_ASSETS_ROLLFILE.Get(obj);

                                        if (obj == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }
         
                                    obj.BASE_ID = item.base_id;
                                    obj.CODE = item.code;
                                    obj.NAME = item.name;

                                    if (!string.IsNullOrEmpty(item.create_date))
                                    {
                                        obj.CREATE_DATE = DateTime.Parse(item.create_date);
                                    }

                                    if (!string.IsNullOrEmpty(item.page_num))
                                    {
                                        obj.PAGE_NUM = decimal.Parse(item.page_num);
                                    }

                                    obj.SUMMARYS = item.summarys;

                                    obj.COMMENTS = item.comments;

                                    if(string.IsNullOrEmpty(item.id))
                                    {
                                        HelperObject_MCE_B_ASSETS_ROLLFILE.Save(obj, transaction);
                                    }
                                    else
                                    {
                                        obj.ID = item.id;
                                        HelperObject_MCE_B_ASSETS_ROLLFILE.Update(obj, transaction);
                                    }

                                    if (!string.IsNullOrEmpty(item.filename))
                                    {
                                        try
                                        {
                                            string strFileURL = System.Web.HttpContext.Current.Server.MapPath("~/upload/mce/" + item.filename);//路径
                                            if (File.Exists(strFileURL))
                                            {
                                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_ROLLFILE";
                                                pCOM_FILE.SERVER_NAME = item.filename;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_ROLLFILE";
                                                    entityPicFile.CLIENT_NAME = item.filename;
                                                    entityPicFile.STATE = 1;
                                                    entityPicFile.CREATE_TIME = DateTime.Now;
                                                    entityPicFile.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                                    entityPicFile.REF_TAB_ID = obj.ID;
                                                    entityPicFile.SERVER_NAME = item.filename;
                                                    entityPicFile.IS_IMPORT = 0;
                                                    Ipedf.Web.DataAccess.HelperObject_COM_FILE.Save(entityPicFile, transaction);
                                                }
                                            }
                                        }
                                        catch { }


                                    }


                                }

                            }
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Save_RollFiles(listItem);
                }
            }
        }



        public BizLogicMsg Delete_RollFiles(List<string> listID)
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
                            if (listID != null && listID.Count > 0)
                            {
                                foreach (string strID in listID)
                                {
                                    if(string.IsNullOrEmpty(strID))
                                    {
                                        continue;
                                    }
                                    EntityObject_MCE_B_ASSETS_ROLLFILE obj = new EntityObject_MCE_B_ASSETS_ROLLFILE();
                                    obj.ID = strID;

                                    obj = HelperObject_MCE_B_ASSETS_ROLLFILE.Get(obj);

                                    if (obj != null)
                                    {

                                        EntityObject_MCE_B_ASSETS_ROLL objRoll = new EntityObject_MCE_B_ASSETS_ROLL();

                                        objRoll.ID = obj.BASE_ID;

                                        objRoll = HelperObject_MCE_B_ASSETS_ROLL.Get(objRoll);

                                        if (objRoll == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }

                                        if (objRoll.AUDIT_STATE == 3 || objRoll.AUDIT_STATE == 4)
                                        {
                                            throw new Exception("已经审核的案卷信息文件不能删除.");
                                        }

                                        CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                        pCOM_FILE.REF_TAB_ID = obj.ID;
                                        pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_ROLLFILE";

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

                                        HelperObject_MCE_B_ASSETS_ROLLFILE.Delete(obj, transaction);
                                    }
                                }
                            }
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Delete_RollFiles(listID);
                }
            }
        }


        public BizLogicMsg Save_RollFileAsTemplate(JsonMceAssetsRollFileTemplate item)
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
                            CauseObject_MCE_B_ASSETS_ROLLFILE pMCE_B_ASSETS_ROLLFILE = new CauseObject_MCE_B_ASSETS_ROLLFILE();
                            pMCE_B_ASSETS_ROLLFILE.BASE_ID = item.rollid;
                           
                            DisplayObject_MCE_B_ASSETS_ROLLFILE[] listMCE_B_ASSETS_ROLLFILE = BizLogicObject_MCE_B_ASSETS_ROLLFILE.Proxy.Query(pMCE_B_ASSETS_ROLLFILE);

                            if (listMCE_B_ASSETS_ROLLFILE != null && listMCE_B_ASSETS_ROLLFILE.Length > 0)
                            {
                                EntityObject_MCE_B_ASSETS_FILETEMPLATE objTemplate = new EntityObject_MCE_B_ASSETS_FILETEMPLATE();
                                objTemplate.NAME = item.name;
                                objTemplate.COMMENTS = item.comments;
                                HelperObject_MCE_B_ASSETS_FILETEMPLATE.Save(objTemplate, transaction);
                                foreach (DisplayObject_MCE_B_ASSETS_ROLLFILE displayObject_MCE_B_ASSETS_ROLLFILE in listMCE_B_ASSETS_ROLLFILE)
                                {

                                    EntityObject_MCE_B_ASSETS_FILETEMPLATE_D objTemplate_D = new EntityObject_MCE_B_ASSETS_FILETEMPLATE_D();
                                    objTemplate_D.CODE = displayObject_MCE_B_ASSETS_ROLLFILE.CODE;
                                    objTemplate_D.NAME = displayObject_MCE_B_ASSETS_ROLLFILE.NAME;
                                    objTemplate_D.BASE_ID = objTemplate.ID;
                                    HelperObject_MCE_B_ASSETS_FILETEMPLATE_D.Save(objTemplate_D, transaction);

                                }
                            }
                            else
                            {
                                throw new Exception("另存为文件数不能为0.");
                            }
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Save_RollFileAsTemplate(item);
                }
            }
        }


        public BizLogicMsg Save_RollEquip(JsonMceAssetsRollEquip item)
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

                            EntityObject_MCE_B_ASSETS_ROLL objRoll = new EntityObject_MCE_B_ASSETS_ROLL();

                            objRoll.ID = item.rollid;

                            objRoll = HelperObject_MCE_B_ASSETS_ROLL.Get(objRoll);

                            if (objRoll == null)
                            {
                                throw new Exception("获取数据出错.");
                            }

                            if (objRoll.AUDIT_STATE == 3 || objRoll.AUDIT_STATE == 4)
                            {
                                throw new Exception("已经审核的案卷信息不能再添加关联设备.");
                            }

                            CauseObject_MCE_B_ASSETS_ROLLEQUIP pMCE_B_ASSETS_ROLLEQUIP = new CauseObject_MCE_B_ASSETS_ROLLEQUIP();
                            pMCE_B_ASSETS_ROLLEQUIP.ROLL_ID = item.rollid;
                            pMCE_B_ASSETS_ROLLEQUIP.ASSETS_ID = item.assetsid;

                            DisplayObject_MCE_B_ASSETS_ROLLEQUIP[] listMCE_B_ASSETS_ROLLEQUIP = BizLogicObject_MCE_B_ASSETS_ROLLEQUIP.Proxy.Query(pMCE_B_ASSETS_ROLLEQUIP);

                            if (listMCE_B_ASSETS_ROLLEQUIP == null || listMCE_B_ASSETS_ROLLEQUIP.Length == 0)
                            {
                                EntityObject_MCE_B_ASSETS_ROLLEQUIP objEquip = new EntityObject_MCE_B_ASSETS_ROLLEQUIP();
                                objEquip.ASSETS_ID = item.assetsid;
                                objEquip.ROLL_ID = item.rollid;
                                HelperObject_MCE_B_ASSETS_ROLLEQUIP.Save(objEquip, transaction);
                            }
                            else
                            {
                                throw new Exception("该案卷信息中已经添加了此设备.");
                            }

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Save_RollEquip(item);
                }
            }
        }




        public BizLogicMsg Delete_RollEquip(string strID)
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
                            EntityObject_MCE_B_ASSETS_ROLLEQUIP objMCE_B_ASSETS_ROLLEQUIP = new EntityObject_MCE_B_ASSETS_ROLLEQUIP();

                            objMCE_B_ASSETS_ROLLEQUIP.ID = strID;

                            objMCE_B_ASSETS_ROLLEQUIP = HelperObject_MCE_B_ASSETS_ROLLEQUIP.Get(objMCE_B_ASSETS_ROLLEQUIP);

                            if (objMCE_B_ASSETS_ROLLEQUIP == null)
                            {
                                throw new Exception("获取数据出错.");
                            }


                            EntityObject_MCE_B_ASSETS_ROLL objRoll = new EntityObject_MCE_B_ASSETS_ROLL();

                            objRoll.ID = objMCE_B_ASSETS_ROLLEQUIP.ROLL_ID;

                            objRoll = HelperObject_MCE_B_ASSETS_ROLL.Get(objRoll);

                            if (objRoll == null)
                            {
                                throw new Exception("获取数据出错.");
                            }

                            if (objRoll.AUDIT_STATE == 3 || objRoll.AUDIT_STATE == 4)
                            {
                                throw new Exception("已经审核的案卷信息不能再删除关联设备.");
                            }


                            HelperObject_MCE_B_ASSETS_ROLLEQUIP.Delete(objMCE_B_ASSETS_ROLLEQUIP, transaction);
                           
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_ROLL>(ServiceUri))
                {
                    return smgr.Service.Delete_RollEquip(strID);
                }
            }
        }



        private string GetRollCode()
        {
            string strRollCode = "";

            string strCode = DateTime.Now.ToString("yyyyMMdd");


            int code = 1;

            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = false;
            orderBy.OrderBy = "CODE";

            var cause = new CauseObject_MCE_B_ASSETS_ROLL();
            cause.SetCustomCondition(" and MCE_B_ASSETS_ROLL.CODE like '" + strCode + "%'");
            var list = BizLogicObject_MCE_B_ASSETS_ROLL.Proxy.Query(cause, null, orderBy);
            if (list != null && list.Length > 0)
            {
                var s_code = list[0].CODE;
                var rightCode = s_code.Replace(strCode, "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strRollCode = strCode + (code).ToString().PadLeft(3, '0');

            return strRollCode;
        }


    }
}
