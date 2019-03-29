
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

    public partial class BizLogicObject_MCE_B_ASSETS_INSURANCE 
    {


        public BizLogicMsg Save_Ext(JsonMceAssetsInsurance item)
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
                            EntityObject_MCE_B_ASSETS_INSURANCE obj = new EntityObject_MCE_B_ASSETS_INSURANCE();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_INSURANCE.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.ASSETS_ID = item.assets_id;
                           // obj.CODE = item.code;
                            obj.NAME = item.name;
                            obj.MATER = item.mater;
                          
                            if (!string.IsNullOrEmpty(item.insurance_money))
                            {
                                obj.INSURANCE_MONEY = decimal.Parse(item.insurance_money);
                            }

                            if (!string.IsNullOrEmpty(item.fee_money))
                            {
                                obj.FEE_MONEY = decimal.Parse(item.fee_money);
                            }

                             obj.INSURANCE_UNIT = item.insurance_unit;

                            if (!string.IsNullOrEmpty(item.effect_date))
                            {
                                obj.EFFECT_DATE = DateTime.Parse(item.effect_date);
                            }

                            if (!string.IsNullOrEmpty(item.expire_date))
                            {
                                obj.EXPIRE_DATE = DateTime.Parse(item.expire_date);
                            }

                            obj.COMMENTS = item.comments;


                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.CODE = GetInsuranceCode();
                                obj.AUDIT_STATE = 1;
                                obj.STATE = 1;
                                HelperObject_MCE_B_ASSETS_INSURANCE.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_INSURANCE.Update(obj, transaction);
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
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_INSURANCE";
                                                pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_INSURANCE";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_INSURANCE obj = new EntityObject_MCE_B_ASSETS_INSURANCE();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_INSURANCE.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的保险信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_INSURANCE.Update(obj, transaction);


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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_INSURANCE obj = new EntityObject_MCE_B_ASSETS_INSURANCE();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_INSURANCE.Get(obj);

                            if (obj != null)
                            {

                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的保险信息不能删除.");
                                }

                                CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                                pCOM_FILE.REF_TAB_ID = obj.ID;
                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_INSURANCE";

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

                                HelperObject_MCE_B_ASSETS_INSURANCE.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(strID);
                }
            }
        }



        public BizLogicMsg Insurance_Expire(string strID)
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

                         EntityObject_MCE_B_ASSETS_INSURANCE obj = new EntityObject_MCE_B_ASSETS_INSURANCE();
                         obj.ID = strID;

                         obj = HelperObject_MCE_B_ASSETS_INSURANCE.Get(obj);

                         if (obj != null)
                         {
                             if (obj.STATE == 2)
                             {
                                 throw new Exception("该保险已经过期.");
                             }

                             obj.STATE = 2;

                             HelperObject_MCE_B_ASSETS_INSURANCE.Update(obj, transaction);
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
             using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE>(ServiceUri))
             {
                 return smgr.Service.Insurance_Expire(strID);
             }
         }
     }



        public BizLogicMsg Insurance_Continue(string strID)
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

                         EntityObject_MCE_B_ASSETS_INSURANCE obj = new EntityObject_MCE_B_ASSETS_INSURANCE();
                         obj.ID = strID;

                         obj = HelperObject_MCE_B_ASSETS_INSURANCE.Get(obj);

                         if (obj != null)
                         {
                             obj.CODE = GetInsuranceCode();
                             obj.STATE = 1;
                             obj.AUDIT_STATE = 1;

                             HelperObject_MCE_B_ASSETS_INSURANCE.Save(obj, transaction);
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
             using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSURANCE>(ServiceUri))
             {
                 return smgr.Service.Insurance_Continue(strID);
             }
         }
     }



        private string GetInsuranceCode()
        {
            string strInsuranceCode = "";

            string strCode = DateTime.Now.ToString("yyyyMMdd");


            int code = 1;

            OrderByParameter orderBy = new OrderByParameter();
            orderBy.Asc = false;
            orderBy.OrderBy = "CODE";

            var cause = new CauseObject_MCE_B_ASSETS_INSURANCE();
            cause.SetCustomCondition(" and MCE_B_ASSETS_INSURANCE.CODE like '" + strCode + "%'");
            var list = BizLogicObject_MCE_B_ASSETS_INSURANCE.Proxy.Query(cause, null, orderBy);
            if (list != null && list.Length > 0)
            {
                var s_code = list[0].CODE;
                var rightCode = s_code.Replace(strCode, "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strInsuranceCode = strCode + (code).ToString().PadLeft(3, '0');

            return strInsuranceCode;
        }


    }
}
