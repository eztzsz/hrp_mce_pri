
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
using System.Data.OracleClient;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_MCE_B_ASSETS_CHECK
    {



        public BizLogicMsg Save_Ext(JsonMCE_Check jsonEntity)
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

                            EntityObject_MCE_B_ASSETS_CHECK entity = new EntityObject_MCE_B_ASSETS_CHECK();


                            if (!string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                entity.ID = jsonEntity.ID;

                                entity = HelperObject_MCE_B_ASSETS_CHECK.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonEntity.CODE;
                            entity.DEPT_ID = jsonEntity.DEPT_ID;
                            entity.USER_ID = jsonEntity.USER_ID;

                            if (!string.IsNullOrEmpty(jsonEntity.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonEntity.CREATE_DATE);
                            }

                            entity.CHECK_TYPE_ID = jsonEntity.CHECK_TYPE_ID;

                            entity.COMMENTS = jsonEntity.COMMENTS;

                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_CHECK.Save(entity, transaction);
                            }
                            else
                            {
                                entity.MODIFY_TIME = DateTime.Now;
                                entity.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_CHECK.Update(entity, transaction);
                            }


                              if (!string.IsNullOrEmpty(jsonEntity.ID))
                            {
                                CauseObject_MCE_B_ASSETS_CHECK_D pDetail = new CauseObject_MCE_B_ASSETS_CHECK_D();
                                pDetail.BASE_ID = jsonEntity.ID;
                                HelperObject_MCE_B_ASSETS_CHECK_D.Delete(pDetail, transaction);
                            }

                           
                            if (jsonEntity.children != null && jsonEntity.children.Count > 0)
                            {

                                foreach (JsonMCE_Check_D item in jsonEntity.children)
                                {
                                    EntityObject_MCE_B_ASSETS_CHECK_D entity_D = new EntityObject_MCE_B_ASSETS_CHECK_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_CHECK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }


                                    entity_D.NEW_ASSETS_STATE = item.NEW_ASSETS_STATE;
                                
                                    HelperObject_MCE_B_ASSETS_CHECK_D.Save(entity_D, transaction);
                           
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonEntity);
                }
            }
        }


        public BizLogicMsg Save_CheckType_Ext(string strBaseID, List<string> listID)
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
                            CauseObject_MCE_B_ASSETS_CHECK_TYPE pDetail = new CauseObject_MCE_B_ASSETS_CHECK_TYPE();
                            pDetail.BASE_ID = strBaseID;
                            HelperObject_MCE_B_ASSETS_CHECK_TYPE.Delete(pDetail, transaction);


                            if (listID != null && listID.Count > 0)
                            {
                                
                                foreach (string strID  in listID)
                                {
                                    EntityObject_MCE_B_ASSETS_CHECK_TYPE entity_D = new EntityObject_MCE_B_ASSETS_CHECK_TYPE();
                                    entity_D.BASE_ID=strBaseID;

                                    entity_D.TYPE_ID =strID;

                                    HelperObject_MCE_B_ASSETS_CHECK_TYPE.Save(entity_D, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
                {
                    return smgr.Service.Save_CheckType_Ext( strBaseID, listID);
                }
            }
        }


        public BizLogicMsg Generate_Detail(string strBaseID)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {

                    try
                    {
                        IDbCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        OracleParameter p1 = new OracleParameter();
                        p1.ParameterName = "p_planid";
                        p1.Direction = ParameterDirection.Input;
                        p1.Size = 36;
                        p1.OracleType = OracleType.Char;
                        p1.Value = strBaseID;
                        cmd.Parameters.Add(p1);


                        OracleParameter p2 = new OracleParameter();
                        p2.ParameterName = "p_msg";
                        p2.Direction = ParameterDirection.Output;
                        p2.Size = 1024;
                        p2.OracleType = OracleType.VarChar;
                        cmd.Parameters.Add(p2);

                        OracleParameter p3 = new OracleParameter();
                        p3.ParameterName = "p_succeed";
                        p3.Direction = ParameterDirection.Output;
                        p3.OracleType = OracleType.Number;
                        cmd.Parameters.Add(p3);

                        cmd.CommandText = "SP_mce_create_stockdata_chk_d";
                        cmd.ExecuteNonQuery();
                        string  msg0 = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                        int succeed = (int)(decimal)p3.Value;
                    }
                    catch (Exception expt)
                    {
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
                {
                    return smgr.Service.Generate_Detail(strBaseID);
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
                                EntityObject_MCE_B_ASSETS_CHECK obj = new EntityObject_MCE_B_ASSETS_CHECK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_CHECK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_CHECK.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_CHECK obj = new EntityObject_MCE_B_ASSETS_CHECK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_CHECK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }

                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_CHECK.Update(obj, transaction);

                                    
                                    CauseObject_MCE_B_ASSETS_CHECK_D pDetail = new CauseObject_MCE_B_ASSETS_CHECK_D();
                                    pDetail.BASE_ID = strID;
                                    EntityObject_MCE_B_ASSETS_CHECK_D[] deprDetails = HelperObject_MCE_B_ASSETS_CHECK_D.Query(pDetail, transaction);
                                    //更新资产卡片记录
                                    foreach (EntityObject_MCE_B_ASSETS_CHECK_D dDetail in deprDetails)
                                    {
                                        string strOldState = dDetail.OLD_ASSETS_STATE ?? "";
                                        string strNewState = dDetail.NEW_ASSETS_STATE ?? "";
                                        if (strOldState != strNewState && !string.IsNullOrEmpty( strNewState))
                                        {
                                            EntityObject_MCE_B_ASSETS assets = new EntityObject_MCE_B_ASSETS();
                                            assets.ID = dDetail.ASSETS_ID;
                                            assets.ASSETS_STATE = dDetail.NEW_ASSETS_STATE;//净值

                                            assets.SetUpdate("ASSETS_STATE");
                                            HelperObject_MCE_B_ASSETS.Update(assets, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_CHECK obj = new EntityObject_MCE_B_ASSETS_CHECK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_CHECK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_CHECK.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_CHECK>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
