
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
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;


namespace Ipedf.Web.BizLogic
{
   
    public partial class BizLogicObject_MCE_D_MCE_TYPE 
    {

        public BizLogicMsg Save_Ext(JsonMceType jsonMceType)
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
                            EntityObject_MCE_D_MCE_TYPE obj = new EntityObject_MCE_D_MCE_TYPE();

                            obj.CODE = jsonMceType.code;
                            obj.NAME = jsonMceType.name;
                            obj.PARENT_ID = jsonMceType.parent_id;
                            obj.STATE = jsonMceType.state;

                            if(string.IsNullOrEmpty( jsonMceType.id))
                            {
                                obj.CREATE_TIME = DateTime.Now;
                                obj.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_D_MCE_TYPE.Save(obj, transaction);
                            }
                            else
                            {
                                obj.ID = jsonMceType.id;
                                int amount = HelperObject_MCE_D_MCE_TYPE.Update(obj, transaction);

                                /*
                                CauseObject_MCE_D_TYPE_DEPT cause = new CauseObject_MCE_D_TYPE_DEPT();
                                cause.MCE_TYPE_ID = jsonMceType.id;
                                int amount1 = HelperObject_MCE_D_TYPE_DEPT.Delete(cause, transaction);
                                */
                            }

                            /*
                            if (jsonMceType.listDeptID != null && jsonMceType.listDeptID.Count>0)
                            {
                                foreach (string strDeptID in jsonMceType.listDeptID)
                                {
                                    EntityObject_MCE_D_TYPE_DEPT item = new EntityObject_MCE_D_TYPE_DEPT();
                                    item.MCE_TYPE_ID =  obj.ID;
                                    item.DEPT_ID = strDeptID;
                                    HelperObject_MCE_D_TYPE_DEPT.Save(item, transaction);
                                }
                                
                            }
                            */

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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Save_Ext( jsonMceType);
                }
            }
        }



        public BizLogicMsg Save_TypeDept(JsonMceType jsonMceType)
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
                            if (jsonMceType.listDeptID != null && jsonMceType.listDeptID.Count>0)
                            {
                                foreach (string strDeptID in jsonMceType.listDeptID)
                                {

                                    CauseObject_MCE_D_TYPE_DEPT p_Type = new CauseObject_MCE_D_TYPE_DEPT();

                                    p_Type.MCE_TYPE_ID = jsonMceType.id;
                                     p_Type.DEPT_ID = strDeptID;

                                    DisplayObject_MCE_D_TYPE_DEPT[] list = BizLogicObject_MCE_D_TYPE_DEPT.Proxy.Query(p_Type);

                                    if (list == null || list.Length == 0)
                                    {
                                        EntityObject_MCE_D_TYPE_DEPT item = new EntityObject_MCE_D_TYPE_DEPT();
                                        item.MCE_TYPE_ID = jsonMceType.id;
                                        item.DEPT_ID = strDeptID;
                                        HelperObject_MCE_D_TYPE_DEPT.Save(item, transaction);
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Save_TypeDept(jsonMceType);
                }
            }
        }


        public BizLogicMsg Delete_TypeDept_Ext(JsonMceType jsonMceType)
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
                            if (jsonMceType.listDeptID != null && jsonMceType.listDeptID.Count > 0)
                            {
                                foreach (string strDeptID in jsonMceType.listDeptID)
                                {
                                    CauseObject_MCE_D_TYPE_DEPT p_Type = new CauseObject_MCE_D_TYPE_DEPT();

                                    p_Type.MCE_TYPE_ID = jsonMceType.id;
                                    p_Type.DEPT_ID = strDeptID;
                                    HelperObject_MCE_D_TYPE_DEPT.Delete(p_Type, transaction);
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Delete_TypeDept_Ext(jsonMceType);
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

                            if (listID != null && listID.Count > 0)
                            {
                                foreach (string strID in listID)
                                {
                                    CauseObject_MCE_D_MCE_TYPE p_Type = new CauseObject_MCE_D_MCE_TYPE();

                                    p_Type.PARENT_ID = strID;

                                    DisplayObject_MCE_D_MCE_TYPE[] listMCE_D_MCE_TYPE = BizLogicObject_MCE_D_MCE_TYPE.Proxy.Query(p_Type);

                                    if (listMCE_D_MCE_TYPE != null && listMCE_D_MCE_TYPE.Length > 0)
                                    {
                                        throw new Exception("该资产分类下存在子分类，不能删除.");
                                    }


                                    CauseObject_MCE_B_ASSETS p = new CauseObject_MCE_B_ASSETS();

                                    p.MACHINE_TYPE_ID = strID;

                                    DisplayObject_MCE_B_ASSETS[] list = BizLogicObject_MCE_B_ASSETS.Proxy.Query(p);

                                    if (list != null && list.Length > 0)
                                    {
                                        throw new Exception("在资产卡片中已经使用的资产分类不能删除.");
                                    }



                                    EntityObject_MCE_D_MCE_TYPE obj = new EntityObject_MCE_D_MCE_TYPE();
                                    obj.ID = strID;

                                    if (obj.STATE == 1)
                                    {
                                        throw new Exception("状态为[正常]的资产分类不能删除.");
                                    }

                                    obj = HelperObject_MCE_D_MCE_TYPE.Get(obj);

                                    if (obj != null)
                                    {
                                        HelperObject_MCE_D_MCE_TYPE.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }


        public List<JsonMceTypeTree> getMceTypeTree()
        {
            if (LocalMode)
            {
                List<JsonMceTypeTree> nodes = new List<JsonMceTypeTree>();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            OrderByParameter orderBy = new OrderByParameter();
                            orderBy.Asc = true;
                            orderBy.OrderBy = "CODE";
                            CauseObject_MCE_D_MCE_TYPE pType = new CauseObject_MCE_D_MCE_TYPE();
                            pType.SetCustomCondition(" and MCE_D_MCE_TYPE.PARENT_ID is null ");
                            EntityObject_MCE_D_MCE_TYPE[] types = HelperObject_MCE_D_MCE_TYPE.Query(pType, null, orderBy, transaction);
                            foreach (EntityObject_MCE_D_MCE_TYPE type in types)
                            {
                                JsonMceTypeTree tmp = new JsonMceTypeTree();
                                tmp.id = type.ID.Trim();
                                tmp.text = type.NAME;
                                tmp.state = "open";
                                tmp.children = new List<JsonMceTypeTree>();
                                nodes.Add(tmp);
                            }

                            int count = 0;
                            CauseObject_MCE_D_MCE_TYPE pChild = new CauseObject_MCE_D_MCE_TYPE();
                            foreach (JsonMceTypeTree node in nodes)
                            {
                                addTreeNode(node, count, pChild, orderBy, transaction);
                            }

                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            nodes = null;
                            transaction.Rollback();
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return nodes;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.getMceTypeTree();
                }
            }
        }

        private void addTreeNode(JsonMceTypeTree node, int count, CauseObject_MCE_D_MCE_TYPE pChild, OrderByParameter orderBy, IDbTransaction transaction)
        {
            if (count > 5)
                return;
            pChild.PARENT_ID = node.id;
            EntityObject_MCE_D_MCE_TYPE[] typeChildren = HelperObject_MCE_D_MCE_TYPE.Query(pChild, null, orderBy, transaction);
            if (typeChildren == null || typeChildren.Length == 0)
            {
                node.state = "";
                return;
            }
            foreach (EntityObject_MCE_D_MCE_TYPE typeChild in typeChildren)
            {
                JsonMceTypeTree tmp = new JsonMceTypeTree();
                tmp.id = typeChild.ID.Trim();
                tmp.text = typeChild.NAME;
                tmp.state = "closed";
                tmp.children = new List<JsonMceTypeTree>();
                node.children.Add(tmp);
                addTreeNode(tmp, count + 1, pChild, orderBy, transaction);
            }
        }

        public BizLogicMsg Save_Dept_Ext(List<string> idList)
        {
            if (LocalMode)
            {
                string strUserID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                string strUserName = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;

                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            DateTime dtCur = DateTime.Now;

                            Ipedf.Hrp.BizLogic.PRV_MCE_Web_Service.PRV_Web_Service service = new Ipedf.Hrp.BizLogic.PRV_MCE_Web_Service.PRV_Web_Service();
                            if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                            {
                                string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                                service.Url = strServiceURL;
                            }

                            foreach (string strID in idList)
                            {

                                string strRegionAccount = service.GetAccountInfo(strID);
                                JsonRegionAccount regionAccount = (JsonConvert.DeserializeObject<JsonRegionAccount>(strRegionAccount));



                                CauseObject_MDM_D_DEPT pMDM_D_DEPT = new CauseObject_MDM_D_DEPT();
                                pMDM_D_DEPT.CODE = regionAccount.code;
                                pMDM_D_DEPT.AUDIT_STATE = "COM_1002_01";

                                DisplayObject_MDM_D_DEPT[] listMDM_D_DEPT = BizLogicObject_MDM_D_DEPT.Proxy.Query(pMDM_D_DEPT);

                                if (listMDM_D_DEPT != null && listMDM_D_DEPT.Length > 0)
                                {
                                    throw new Exception("企业代码" + pMDM_D_DEPT.CODE + "已经存在.");
                                }

                                string strEnterPriseInfo = service.GetEnterPriseInfo(strID);
                                JsonRegionEnterPrise regionEnterPrise = (JsonConvert.DeserializeObject<JsonRegionEnterPrise>(strEnterPriseInfo));

                                string strPrvCertList = service.GetPrvCertList(strID);
                                List<DisplayObject_V_PRV_PRVCERT_INFO> listRegionCert = JsonConvert.DeserializeObject<List<DisplayObject_V_PRV_PRVCERT_INFO>>(strPrvCertList);


                                EntityObject_MDM_D_DEPT entityObject_PRV_D_DEPT = new Entity.EntityObject_MDM_D_DEPT();

                                entityObject_PRV_D_DEPT.CODE = regionAccount.code;
                                entityObject_PRV_D_DEPT.NAME = regionEnterPrise.name;
                                entityObject_PRV_D_DEPT.SHORT_NAME = Ipedf.Core.ChineseHelper.GetChineseSpell(regionEnterPrise.name);
                                entityObject_PRV_D_DEPT.BALANCE_TYPE_ID = regionEnterPrise.balance_type_id;
                                entityObject_PRV_D_DEPT.ADDRESS = regionEnterPrise.address;
                                entityObject_PRV_D_DEPT.LINK_PERSON = regionEnterPrise.link_Person;

                                entityObject_PRV_D_DEPT.LAW_PERSON = regionEnterPrise.law_Person;
                                entityObject_PRV_D_DEPT.SERVICES = regionEnterPrise.services;

                                entityObject_PRV_D_DEPT.PHONE = regionAccount.phone;
                                entityObject_PRV_D_DEPT.EMAIL = regionAccount.email;

                                entityObject_PRV_D_DEPT.REGISTER_FUND = regionEnterPrise.register_fund;

                                entityObject_PRV_D_DEPT.CREATE_USER_ID = strUserID;
                                entityObject_PRV_D_DEPT.CREATE_TIME = dtCur;
                                entityObject_PRV_D_DEPT.STATE = 1;
                                entityObject_PRV_D_DEPT.DEPT_TYPE_ID = "00340005";
                                entityObject_PRV_D_DEPT.AUDIT_STATE = "COM_1002_01";
                                entityObject_PRV_D_DEPT.AUDIT_USER_ID = strUserID;
                                entityObject_PRV_D_DEPT.AUDIT_TIME = dtCur;

                                entityObject_PRV_D_DEPT.REF_ID = strID;

                                HelperObject_MDM_D_DEPT.Save(entityObject_PRV_D_DEPT, transaction);

                                if (listRegionCert != null && listRegionCert.Count > 0)
                                {
                                    foreach (DisplayObject_V_PRV_PRVCERT_INFO regionCert in listRegionCert)
                                    {
                                        if (!string.IsNullOrEmpty(regionCert.SAVE_NAME))
                                        {
                                            EntityObject_MTR_B_PRV_CERT pRV_B_PRV_CERT = new EntityObject_MTR_B_PRV_CERT();
                                            pRV_B_PRV_CERT.NATURE_ID = "MTR_20010001";
                                            pRV_B_PRV_CERT.TYPE_ID = regionCert.TYPE_ID;
                                            pRV_B_PRV_CERT.NAME = regionCert.NAME;
                                            pRV_B_PRV_CERT.BEGIN_DATE = regionCert.BEGIN_DATE;
                                            pRV_B_PRV_CERT.END_DATE = regionCert.END_DATE;
                                            pRV_B_PRV_CERT.USER_ID = strUserID;
                                            pRV_B_PRV_CERT.CREATE_DATE = dtCur;
                                            pRV_B_PRV_CERT.PRV_ID = entityObject_PRV_D_DEPT.ID;
                                            pRV_B_PRV_CERT.REF_ID = regionCert.ID;
                                            HelperObject_MTR_B_PRV_CERT.Save(pRV_B_PRV_CERT, transaction);

                                            if (!string.IsNullOrEmpty(regionCert.SAVE_NAME))
                                            {
                                                string aLastName = System.IO.Path.GetExtension(regionCert.SAVE_NAME).ToLower();

                                                try
                                                {
                                                    WebClient client = new WebClient();
                                                 
                                                    string strNetaddress = regionCert.SAVE_NAME;
                                                    byte[] bytes = client.DownloadData(new Uri(strNetaddress));
                                                    MemoryStream ms = new MemoryStream(bytes);
                                                    ms.Seek(0, SeekOrigin.Begin);

                                                    //  string strFileExt = c.PICFILENAME.Substring(1 + c.PICFILENAME.LastIndexOf("."));
                                                    string strPicName = Guid.NewGuid().ToString() + aLastName;

                                                    string folder = "mce\\";

                                                    string uploadPath = HttpRuntime.AppDomainAppPath.ToString();

                                                    if (uploadPath.EndsWith("\\"))
                                                        uploadPath = uploadPath + "upload\\" + folder;
                                                    else
                                                        uploadPath = uploadPath + "\\upload\\" + folder;


                                                    uploadPath = uploadPath + strPicName;



                                                    FileStream fs = new FileStream(uploadPath, FileMode.Create);

                                                    //将byte数组写入文件中
                                                    fs.Write(bytes, 0, bytes.Length);
                                                    //所有流类型都要关闭流，否则会出现内存泄露问题
                                                    fs.Close();


                                                    byte[] photo = new byte[] { };//原图
                                                    byte[] thumbPhoto = new byte[] { };//缩略图

                                                    EntityObject_MTR_FILE prv_File = new EntityObject_MTR_FILE();
                                                    prv_File.SAVE_NAME = strPicName;
                                                    prv_File.FILE_NAME = strPicName;
                                                    prv_File.REF_TAB_NAME = "MTR_B_PRV_CERT";
                                                    prv_File.REF_TAB_ID = pRV_B_PRV_CERT.ID;
                                                    prv_File.SUFFIX = aLastName;

                                                    prv_File.THUMB_BINARY = thumbPhoto;
                                                    prv_File.FILE_BINARY = photo;


                                                    HelperObject_MTR_FILE.Save(prv_File, transaction);

                                                }
                                                catch
                                                {
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            string strJson = JsonConvert.SerializeObject(idList);
                            int intRet = service.SetPrvAuditStatus(strJson, "COM_1002_01", strUserID, strUserName);

                            if (intRet == 0)
                            {
                                throw new Exception("更新供应商端状态错误.");
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Save_Dept_Ext(idList);
                }
            }
        }

         
        public BizLogicMsg CancelPrvAudit(List<string> idList)
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
                            string strUserID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                            string strUserName = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;


                            foreach (string strID in idList)
                            {
                                CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                                p.REF_ID = strID;


                                DisplayObject_MDM_D_DEPT[] list_MDM_D_DEPT = BizLogicObject_MDM_D_DEPT.Proxy.Query(p);
                                if (list_MDM_D_DEPT != null && list_MDM_D_DEPT.Length > 0)
                                {
                                    string strPrvID = list_MDM_D_DEPT[0].ID;

                                    EntityObject_MDM_D_DEPT entity = new EntityObject_MDM_D_DEPT();
                                    entity.ID = strPrvID;

                                    entity = BizLogicObject_MDM_D_DEPT.Proxy.Get(entity);

                                    if (entity != null)
                                    {
                                        entity.AUDIT_STATE = "COM_1002_02";
                                        entity.AUDIT_TIME = DateTime.Now;
                                        entity.AUDIT_USER_ID = strUserID;


                                        BizLogicObject_MDM_D_DEPT.Proxy.Update(entity);
                                    }
                                }

                                if (!msg.Succeed)
                                    throw new Exception(msg.Message);

                            }


                            transaction.Commit();


                            string strJson = JsonConvert.SerializeObject(idList);

                            Ipedf.Hrp.BizLogic.PRV_MCE_Web_Service.PRV_Web_Service service = new Ipedf.Hrp.BizLogic.PRV_MCE_Web_Service.PRV_Web_Service();
                            if (System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"] != null)
                            {
                                string strServiceURL = System.Configuration.ConfigurationManager.AppSettings["PrvMceWebServiceAddress"];
                                service.Url = strServiceURL;
                            }
                            service.SetPrvAuditStatus(strJson, "COM_1002_02", strUserID, strUserName);
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.CancelPrvAudit(idList);
                }
            }
        }




        public BizLogicMsg Save_Prd_Ext(string strJson)
        {
            if (LocalMode)
            {
                string strUserID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                string strUserName = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;

                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            DateTime dtCur = DateTime.Now;

                            List<EntityObject_PRV_D_DEPT> listPrd = JsonConvert.DeserializeObject<List<EntityObject_PRV_D_DEPT>>(strJson);

                            List<string> listPrdId = new List<string>();
                            foreach (EntityObject_PRV_D_DEPT entityObject_PRV_D_DEPT in listPrd)
                            {

                                CauseObject_MDM_D_DEPT pMDM_D_DEPT = new CauseObject_MDM_D_DEPT();
                                pMDM_D_DEPT.CODE = entityObject_PRV_D_DEPT.CODE;
                                pMDM_D_DEPT.AUDIT_STATE = "COM_1002_01";
                                pMDM_D_DEPT.DEPT_TYPE_ID = "00340003";
                                
                                DisplayObject_MDM_D_DEPT[] listMDM_D_DEPT = BizLogicObject_MDM_D_DEPT.Proxy.Query(pMDM_D_DEPT);

                                if (listMDM_D_DEPT != null && listMDM_D_DEPT.Length > 0)
                                {
                                    continue;
                                }

                                if(!listPrdId.Contains(entityObject_PRV_D_DEPT.ID))
                                {
                                    listPrdId.Add(entityObject_PRV_D_DEPT.ID);
                                }
                                else
                                {
                                    continue;
                                }

                                EntityObject_MDM_D_DEPT entityPrd = new Entity.EntityObject_MDM_D_DEPT();

                                entityPrd.CODE = entityObject_PRV_D_DEPT.CODE;
                                entityPrd.NAME = entityObject_PRV_D_DEPT.NAME;
                                entityPrd.SHORT_NAME = Ipedf.Core.ChineseHelper.GetChineseSpell(entityObject_PRV_D_DEPT.NAME);
                                entityPrd.BALANCE_TYPE_ID = entityObject_PRV_D_DEPT.BALANCE_TYPE_ID;
                                entityPrd.ADDRESS = entityObject_PRV_D_DEPT.ADDRESS;
                                entityPrd.LINK_PERSON = entityObject_PRV_D_DEPT.LINK_PERSON;

                                entityPrd.LAW_PERSON = entityObject_PRV_D_DEPT.LAW_PERSON;
                                entityPrd.SERVICES = entityObject_PRV_D_DEPT.SERVICES;

                                entityPrd.PHONE = entityObject_PRV_D_DEPT.PHONE;
                                entityPrd.EMAIL = entityObject_PRV_D_DEPT.EMAIL;

                                entityPrd.REGISTER_FUND = entityObject_PRV_D_DEPT.REGISTER_FUND;

                                entityPrd.CREATE_USER_ID = strUserID;
                                entityPrd.CREATE_TIME = dtCur;
                                entityPrd.STATE = 1;
                                entityPrd.DEPT_TYPE_ID = "00340003";
                                entityPrd.AUDIT_STATE = "COM_1002_01";
                                entityPrd.AUDIT_USER_ID = strUserID;
                                entityPrd.AUDIT_TIME = dtCur;

                                entityPrd.REF_ID = entityObject_PRV_D_DEPT.ID;

                                HelperObject_MDM_D_DEPT.Save(entityPrd, transaction);
                                
                           
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
                using (ServiceManager<ServiceContract_MCE_D_MCE_TYPE> smgr = new ServiceManager<ServiceContract_MCE_D_MCE_TYPE>(ServiceUri))
                {
                    return smgr.Service.Save_Prd_Ext(strJson);
                }
            }
        }


    }
}
