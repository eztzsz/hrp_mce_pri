
using System;
using System.Data;
using System.Collections;
using System.Linq;
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
  
    public partial class BizLogicObject_MCE_B_ASSETS_AFFIX 
    {


        public BizLogicMsg Save_Ext(JsonMceAssersFix item)
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
                            EntityObject_MCE_B_ASSETS_AFFIX obj = new EntityObject_MCE_B_ASSETS_AFFIX();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_AFFIX.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.NAME = item.name;
                            obj.ASSETS_ID = item.assets_id;
                            if (!string.IsNullOrEmpty(item.amount))
                            {
                                obj.AMOUNT =decimal.Parse( item.amount);
                            }
                            obj.NAME = item.name;
                            obj.COMMENTS = item.comments;
                            obj.SPEC = item.spec;
                            obj.NAME = item.name;

                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.AUDIT_STATE = 1;
                                obj.CODE = GectAssetsAffixCode( item.assets_id);
                                HelperObject_MCE_B_ASSETS_AFFIX.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_AFFIX.Update(obj, transaction);
                            }

                            if(item.listFileName!=null && (item.listFileName.Count>0))
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
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_AFFIX";
                                                pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_AFFIX";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(item);
                }
            }
        }



        private string GectAssetsAffixCode(string assets_id)
        {
            string strAffixCode = "";

            string strCode = "";

            EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();

            if (!string.IsNullOrEmpty(assets_id))
            {
                obj.ID = assets_id;

                obj = HelperObject_MCE_B_ASSETS.Get(obj);

                if (obj != null)
                {
                    strCode=obj.ASSETS_CODE;
                }
            }

            int code = 1;
            var cause = new CauseObject_MCE_B_ASSETS_AFFIX();
            cause.SetCustomCondition(" and MCE_B_ASSETS_AFFIX.CODE like '" + strCode + "%'");
            var list = BizLogicObject_MCE_B_ASSETS_AFFIX.Proxy.Query(cause);
            if (list != null && list.Length > 0)
            {
                var s_code = list.Max(p => p.CODE);
                var rightCode = s_code.Replace(strCode, "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strAffixCode = strCode + (code).ToString().PadLeft(3, '0');

            return strAffixCode;
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

                            EntityObject_MCE_B_ASSETS_AFFIX obj = new EntityObject_MCE_B_ASSETS_AFFIX();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_AFFIX.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的资产卡片附件不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_AFFIX.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_AFFIX obj = new EntityObject_MCE_B_ASSETS_AFFIX();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_AFFIX.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的资产卡片附件不能删除.");
                                }

                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_AFFIX";

                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                if (listCOM_FILE != null && listCOM_FILE.Length > 0)
                                {
                                    foreach(DisplayObject_COM_FILE item in listCOM_FILE)
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

                                HelperObject_MCE_B_ASSETS_AFFIX.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_AFFIX>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(strID);
                }
            }
        }


    }
}
