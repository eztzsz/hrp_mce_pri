
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
namespace Ipedf.Web.BizLogic
{
 
    public partial class BizLogicObject_MCE_B_ASSETS_CAPITAL_ALLOT 
    {

        public BizLogicMsg Save_Ext(JsonMceAssetsCapitalAllot item)
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
                            EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.CAPITAL_SOURCE_TYPE_ID = item.capital_source_type_id;
                            obj.ASSETS_ID = item.assets_id;
                            if (!string.IsNullOrEmpty(item.ratio))
                            {
                                obj.RATIO = decimal.Parse(item.ratio);
                            }

                            if (!string.IsNullOrEmpty(item.allot_money))
                            {
                                obj.ALLOT_MONEY = decimal.Parse(item.allot_money);
                            }

                            obj.COMMENTS = item.comments;
                        

                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.AUDIT_STATE = 1;
                                obj.CREATE_TIME = DateTime.Now;
                                HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Update(obj, transaction);
                            }

                            if (item.listFileName != null && (item.listFileName.Count > 0))
                            {
                                foreach (JsonMceAssetsFileInfo objFullName in item.listFileName)
                                {
                                 
                                        try
                                        {
                                            if (!string.IsNullOrEmpty(objFullName.saveName))
                                            {
                                                string strFileURL = System.Web.HttpContext.Current.Server.MapPath("~/upload/mce/" + objFullName.saveName);//路径
                                                if (File.Exists(strFileURL))
                                                {
                                                    CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                                    pCOM_FILE.REF_TAB_ID = obj.ID;
                                                    pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CAPITAL_ALLOT";
                                                    pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                    DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                    if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                    {
                                                        Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                        entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_CAPITAL_ALLOT";
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
                                        }
                                        catch { }

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的资金信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT obj = new EntityObject_MCE_B_ASSETS_CAPITAL_ALLOT();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的资金信息不能删除.");
                                }

                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CAPITAL_ALLOT";

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

                                HelperObject_MCE_B_ASSETS_CAPITAL_ALLOT.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CAPITAL_ALLOT>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(strID);
                }
            }
        }



    }
}
