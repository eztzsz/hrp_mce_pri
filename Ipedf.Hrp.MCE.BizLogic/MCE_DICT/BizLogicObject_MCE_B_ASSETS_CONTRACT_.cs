
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
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{
   
    public partial class BizLogicObject_MCE_B_ASSETS_CONTRACT
    {


        public BizLogicMsg Save_Ext(JsonMceAssetsContract item)
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
                            EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();

                            if (!string.IsNullOrEmpty(item.id))
                            {
                                obj.ID = item.id;

                                obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.ASSETS_ID = item.assets_id;
                           // obj.CODE = item.code;
                            obj.NAME = item.name;
                            obj.TYPE_ID = item.type_id;
                            obj.FIRST_PARTY = item.first_party;
                            obj.SECOND_PARTY = item.second_party;

                            if (!string.IsNullOrEmpty(item.money))
                            {
                                obj.MONEY = decimal.Parse(item.money);
                            }

                            if (!string.IsNullOrEmpty(item.sign_date))
                            {
                                obj.SIGN_DATE =DateTime.Parse(item.sign_date);
                            }

                            if (!string.IsNullOrEmpty(item.expire_date))
                            {
                                obj.EXPIRE_DATE= DateTime.Parse(item.expire_date);
                            }

                            obj.COMMENTS = item.comments;


                            if (string.IsNullOrEmpty(item.id))
                            {
                                obj.CODE = GetContractCode();
                                obj.AUDIT_STATE = 1;
                                obj.STATE = 1;
                                HelperObject_MCE_B_ASSETS_CONTRACT.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = item.id;
                                HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);
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
                                                pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";
                                                pCOM_FILE.SERVER_NAME = objFullName.saveName;
                                                DisplayObject_COM_FILE[] listCOM_FILE = BizLogicObject_COM_FILE.Proxy.Query(pCOM_FILE);

                                                if (listCOM_FILE == null || listCOM_FILE.Length == 0)
                                                {
                                                    Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                                    entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
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

                            EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                            obj.ID = strID;

                            obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                            if (obj != null)
                            {
                                if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                                {
                                    throw new Exception("已经审核的合同信息不能再审核.");
                                }

                                obj.AUDIT_STATE = 3;
                                obj.AUDIT_TIME = DateTime.Now;
                                obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);


                                if (obj.STATE == 1)
                                {
                                    EntityObject_MCE_B_ASSETS objMCE_B_ASSETS = new EntityObject_MCE_B_ASSETS();
                                    objMCE_B_ASSETS.ID = obj.ASSETS_ID;

                                    objMCE_B_ASSETS = HelperObject_MCE_B_ASSETS.Get(objMCE_B_ASSETS);

                                    if (obj != null)
                                    {
                                        objMCE_B_ASSETS.CONTRACT_CODE = obj.CODE;

                                        HelperObject_MCE_B_ASSETS.Update(objMCE_B_ASSETS, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
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

                           EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                           obj.ID = strID;

                           obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                           if (obj != null)
                           {

                               if (obj.AUDIT_STATE == 3 || obj.AUDIT_STATE == 4)
                               {
                                   throw new Exception("已经审核的合同信息不能删除.");
                               }

                               CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                               pCOM_FILE.REF_TAB_ID = obj.ID;
                               pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";

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

                               HelperObject_MCE_B_ASSETS_CONTRACT.Delete(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Audit_Ext(strID);
               }
           }
       }



       public BizLogicMsg Contract_Stop(string strID)
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

                           EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                           obj.ID = strID;

                           obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                           if (obj != null)
                           {
                               if (obj.STATE == 2)
                               {
                                   throw new Exception("该合同已经终止.");
                               }

                               obj.STATE = 2;
                      
                               HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Contract_Stop(strID);
               }
           }
       }



       public BizLogicMsg Contract_Continue(string strID)
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

                           EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                           obj.ID = strID;

                           obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                           if (obj != null)
                           {
                               obj.CODE = GetContractCode();
                               obj.STATE = 1;
                               obj.AUDIT_STATE = 1;
                               HelperObject_MCE_B_ASSETS_CONTRACT.Save(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Contract_Continue(strID);
               }
           }
       }



       private string GetContractCode()
       {
           string strContractCode = "";

           string strCode = DateTime.Now.ToString("yyyyMMdd");

      
           int code = 1;

           OrderByParameter orderBy = new OrderByParameter();
           orderBy.Asc = false;
           orderBy.OrderBy = "CODE";

           var cause = new CauseObject_MCE_B_ASSETS_CONTRACT();
           cause.SetCustomCondition(" and MCE_B_ASSETS_CONTRACT.CODE like '" + strCode + "%'");
           var list = BizLogicObject_MCE_B_ASSETS_CONTRACT.Proxy.Query(cause, null, orderBy);
           if (list != null && list.Length > 0)
           {
               var s_code = list[0].CODE;
               var rightCode = s_code.Replace(strCode, "").TrimStart('0');
               code = int.Parse(rightCode) + 1;
           }

           strContractCode = strCode + (code).ToString().PadLeft(3, '0');

           return strContractCode;
       }



       public BizLogicMsg Save_Ext2(JsonMCE_Contract json)
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
                           EntityObject_MCE_B_ASSETS_CONTRACT entity = new EntityObject_MCE_B_ASSETS_CONTRACT();


                           if (!string.IsNullOrEmpty(json.ID))
                           {
                               entity.ID = json.ID;

                               entity = HelperObject_MCE_B_ASSETS_CONTRACT.Get(entity);

                               if (entity == null)
                               {
                                   throw new Exception("获取数据出错.");
                               }
                           }

                           entity.CODE = json.CODE;
                           entity.NAME = json.NAME;

                           if (!string.IsNullOrEmpty(json.SIGN_DATE))
                           {
                               entity.SIGN_DATE = DateTime.Parse(json.SIGN_DATE);
                           }
                           if (!string.IsNullOrEmpty(json.EXPIRE_DATE))
                           {
                               entity.EXPIRE_DATE = DateTime.Parse(json.EXPIRE_DATE);
                           }
                           entity.TYPE_ID = json.TYPE_ID;
                           entity.FIRST_PARTY = json.FIRST_PARTY;

                           entity.SECOND_PARTY = json.SECOND_PARTY;
                           entity.SECOND_LINK_PERSON = json.SECOND_LINK_PERSON;
                           entity.SECOND_LINK_PHONE = json.SECOND_LINK_PHONE;

                           if (!string.IsNullOrEmpty(json.MONEY))
                           {
                               entity.MONEY =decimal.Parse(json.MONEY);
                           }

                           entity.ARCHIVE_NO = json.ARCHIVE_NO;

                           if (!string.IsNullOrEmpty(json.CHECK_DATE))
                           {
                               entity.CHECK_DATE = DateTime.Parse(json.CHECK_DATE);
                           }
                           entity.ARCHIVIST = json.ARCHIVIST;
                           entity.INPUT_PERSON = json.INPUT_PERSON;
                           entity.CONTRACT_CONTENT = json.CONTRACT_CONTENT;

               
                           entity.STATE = 1;

                           if (string.IsNullOrEmpty(json.ID))
                           {
                               entity.CONTRACT_STATE = 1;
                               entity.CREATE_TIME = DateTime.Now;
                               entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                               int amount = HelperObject_MCE_B_ASSETS_CONTRACT.Save(entity, transaction);
                           }
                           else
                           {
                               entity.MODIFY_TIME = DateTime.Now;
                               entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                               int amount = HelperObject_MCE_B_ASSETS_CONTRACT.Update(entity, transaction);


                               CauseObject_MCE_B_ASSETS_CONTRACT_D pCONTRACT_D = new CauseObject_MCE_B_ASSETS_CONTRACT_D();
                               pCONTRACT_D.BASE_ID = json.ID;
                               HelperObject_MCE_B_ASSETS_CONTRACT_D.Delete(pCONTRACT_D, transaction);


                             CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                             pCOM_FILE.REF_TAB_ID = entity.ID;
                             pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";
                             HelperObject_COM_FILE.Delete(pCOM_FILE, transaction);


                             DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] list_Pay = BizLogicObject_MCE_B_ASSETS_CONTRACT_PAY.Proxy.Query(new CauseObject_MCE_B_ASSETS_CONTRACT_PAY() { BASE_ID = entity.ID });
                               if(list_Pay!=null && list_Pay.Length>0)
                               {
                                   foreach(DisplayObject_MCE_B_ASSETS_CONTRACT_PAY item_Pay in list_Pay)
                                   {
                                       var v_Pay = json.listPay.Find(l => l.ID == item_Pay.ID);
                                       if(v_Pay==null)
                                       {
                                           HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Delete(item_Pay, transaction);
                                       }

                                   }
                               }

                           }

                         
                           if (json.children != null && json.children.Count > 0)
                           {
                               foreach (JsonMCE_Contract_D item in json.children)
                               {
                                   EntityObject_MCE_B_ASSETS_CONTRACT_D entity_D = new EntityObject_MCE_B_ASSETS_CONTRACT_D();

                                   entity_D.BASE_ID = entity.ID;
                                   entity_D.ASSET_ID = item.ASSET_ID;

                                   HelperObject_MCE_B_ASSETS_CONTRACT_D.Save(entity_D, transaction);
                               }
                           }


                           if (json.listPay != null && json.listPay.Count > 0)
                           {
                               foreach (JsonMCE_Contract_Pay item in json.listPay)
                               {
                                   EntityObject_MCE_B_ASSETS_CONTRACT_PAY entity_D = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY();

                                   if (!string.IsNullOrEmpty(item.ID))
                                   {
                                       entity_D.ID = item.ID;

                                       entity_D = HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Get(entity_D);

                                       if (entity_D == null)
                                       {
                                           throw new Exception("获取数据出错.");
                                       }
                                   }

                                   entity_D.BASE_ID = entity.ID;
                                   entity_D.PERIODS = item.PERIODS;
                                   if (!string.IsNullOrEmpty(item.MONEY))
                                   {
                                       entity_D.MONEY = decimal.Parse(item.MONEY);
                                   }
                                   if (!string.IsNullOrEmpty(item.PLAN_PAY_DATE))
                                   {
                                       entity_D.PLAN_PAY_DATE = DateTime.Parse(item.PLAN_PAY_DATE);
                                   }

                                   if (string.IsNullOrEmpty(item.ID))
                                   {
                                       entity_D.STATE=2;
                                       HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Save(entity_D, transaction);
                                   }
                                   else
                                   {
                                       HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Update(entity_D, transaction);
                                   }
                               }
                           }


                           if (json.listAttach != null && json.listAttach.Count > 0)
                           {
                               foreach (JsonMCEMT_APPLY_MTN_ATTACH item in json.listAttach)
                               {
                                   Ipedf.Web.Entity.EntityObject_COM_FILE entityPicFile = new Ipedf.Web.Entity.EntityObject_COM_FILE();
                                   entityPicFile.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
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
                               EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                               obj.ID = strID;

                               obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

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
                                   HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
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
                               EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                               obj.ID = strID;

                               obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                               if (obj != null)
                               {
                                   if (obj.STATE == 3 || obj.STATE == 4)
                                   {
                                       throw new Exception("已经审核的数据不能再审核.");
                                   }

                                   obj.STATE = 3;
                                   obj.AUDIT_TIME = DateTime.Now;
                                   obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                   HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);



                                   DisplayObject_MCE_B_ASSETS_CONTRACT_D[] list_D = BizLogicObject_MCE_B_ASSETS_CONTRACT_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_CONTRACT_D() { BASE_ID = obj.ID });
                                   if (list_D != null && list_D.Length > 0)
                                   {
                                       foreach (DisplayObject_MCE_B_ASSETS_CONTRACT_D item_D in list_D)
                                       {
                                           EntityObject_MCE_B_ASSETS objMCE_B_ASSETS = new EntityObject_MCE_B_ASSETS();
                                           objMCE_B_ASSETS.ID = item_D.ASSET_ID;

                                           objMCE_B_ASSETS = HelperObject_MCE_B_ASSETS.Get(objMCE_B_ASSETS);

                                           if (obj != null)
                                           {
                                               objMCE_B_ASSETS.CONTRACT_CODE = obj.CODE;

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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Audit_Ext2(listID);
               }
           }
       }



       public BizLogicMsg Stop_Ext2(List<string> listID)
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
                               EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                               obj.ID = strID;

                               obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                               if (obj != null)
                               {
                               
                                   obj.CONTRACT_STATE = 2;
                                   HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Submit_Ext2(listID);
               }
           }
       }



       public BizLogicMsg Continue_Ext2(string strID)
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

                           EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                           obj.ID = strID;

                           obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                           if (obj != null)
                           {
                               obj.CONTRACT_STATE = 2;
                               HelperObject_MCE_B_ASSETS_CONTRACT.Update(obj, transaction);

                               string strCode = BizLogicObject_MCE_B_ASSETS.Proxy.Generate_Bill_Code("MceContract");
                               obj.CODE = strCode;
                               obj.STATE = 1;
                               obj.CONTRACT_STATE = 1;
                               HelperObject_MCE_B_ASSETS_CONTRACT.Save(obj, transaction);



                               DisplayObject_MCE_B_ASSETS_CONTRACT_D[] list_D = BizLogicObject_MCE_B_ASSETS_CONTRACT_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_CONTRACT_D() { BASE_ID = strID });
                               if (list_D != null && list_D.Length > 0)
                               {
                                   foreach (DisplayObject_MCE_B_ASSETS_CONTRACT_D item_D in list_D)
                                   {
                                       EntityObject_MCE_B_ASSETS_CONTRACT_D obj_D = new EntityObject_MCE_B_ASSETS_CONTRACT_D();
                                       obj_D.ID = item_D.ID;

                                       obj_D = HelperObject_MCE_B_ASSETS_CONTRACT_D.Get(obj_D);

                                       if (obj_D != null)
                                       {
                                           obj_D.BASE_ID = obj.ID;
                                           HelperObject_MCE_B_ASSETS_CONTRACT_D.Save(obj_D, transaction);
                                       }
                                   }
                               }


                               DisplayObject_MCE_B_ASSETS_CONTRACT_PAY[] list_P = BizLogicObject_MCE_B_ASSETS_CONTRACT_PAY.Proxy.Query(new CauseObject_MCE_B_ASSETS_CONTRACT_PAY() { BASE_ID = strID });
                               if (list_P != null && list_P.Length > 0)
                               {
                                   foreach (DisplayObject_MCE_B_ASSETS_CONTRACT_PAY item_P in list_P)
                                   {
                                       EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj_P = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY();
                                       obj_P.ID = item_P.ID;

                                       obj_P = HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Get(obj_P);

                                       if (obj_P != null)
                                       {
                                           obj_P.BASE_ID = obj.ID;
                                           HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Save(obj_P, transaction);
                                       }
                                   }
                               }

                               CauseObject_COM_FILE pCOM_FILE = new CauseObject_COM_FILE();
                               pCOM_FILE.REF_TAB_ID = strID;
                               pCOM_FILE.REF_TAB_NAME = "MCE_B_ASSETS_CONTRACT";
                               DisplayObject_COM_FILE[] list_F = HelperObject_COM_FILE.Query(pCOM_FILE);
                               if (list_F != null && list_F.Length > 0)
                               {
                                   foreach (DisplayObject_COM_FILE item_F in list_F)
                                   {
                                       EntityObject_COM_FILE obj_F = new EntityObject_COM_FILE();
                                       obj_F.ID = item_F.ID;

                                       obj_F = HelperObject_COM_FILE.Get(obj_F);

                                       if (obj_F != null)
                                       {
                                           obj_F.REF_TAB_ID = obj.ID;
                                           HelperObject_COM_FILE.Save(obj_F, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Continue_Ext2(strID);
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
                               EntityObject_MCE_B_ASSETS_CONTRACT obj = new EntityObject_MCE_B_ASSETS_CONTRACT();
                               obj.ID = strID;

                               obj = HelperObject_MCE_B_ASSETS_CONTRACT.Get(obj);

                               if (obj != null)
                               {
                                   if (obj.STATE >= 2)
                                   {
                                       throw new Exception("已经提交的数据不能删除.");
                                   }

                                   HelperObject_MCE_B_ASSETS_CONTRACT.Delete(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Delete_Ext2(listID);
               }
           }
       }



       public BizLogicMsg Contract_Pay2(List<string> listID)
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
                               EntityObject_MCE_B_ASSETS_CONTRACT_PAY obj = new EntityObject_MCE_B_ASSETS_CONTRACT_PAY();
                               obj.ID = strID;

                               obj = HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Get(obj);

                               if (obj != null)
                               {
                                   if (obj.STATE == 1)
                                   {
                                       throw new Exception("已经付款的数据不能再付款.");
                                   }

                                   obj.STATE = 1;
                                   obj.ACTUAL_PAY_DATE = DateTime.Now;
                                   HelperObject_MCE_B_ASSETS_CONTRACT_PAY.Update(obj, transaction);
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
               using (ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CONTRACT>(ServiceUri))
               {
                   return smgr.Service.Contract_Pay2(listID);
               }
           }
       }


    }
}
