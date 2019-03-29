
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

    public partial class BizLogicObject_MCE_B_ASSETS_METER_TYPE 
    {



        public BizLogicMsg Save_Ext(EntityObject_MCE_B_ASSETS_METER_TYPE item)
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

                            EntityObject_MCE_B_ASSETS_METER_TYPE obj = new EntityObject_MCE_B_ASSETS_METER_TYPE();

                            if (!string.IsNullOrEmpty(item.ID))
                            {
                                obj.ID = item.ID;

                                obj = HelperObject_MCE_B_ASSETS_METER_TYPE.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.CODE = item.CODE;
                            obj.NAME = item.NAME;
                            obj.STATE = item.STATE;
                          
                            if (string.IsNullOrEmpty(item.ID))
                            {
                                obj.CREATE_TIME = DateTime.Now;
                                obj.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_METER_TYPE.Save(obj, transaction);
                            }
                            else
                            {
                                obj.MODIFY_TIME = DateTime.Now;
                                obj.MODIFY_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID; 
                                int amount = HelperObject_MCE_B_ASSETS_METER_TYPE.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER_TYPE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER_TYPE>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(item);
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

                                    EntityObject_MCE_B_ASSETS_METER_TYPE obj = new EntityObject_MCE_B_ASSETS_METER_TYPE();
                                    obj.ID = strID;

                                    obj = HelperObject_MCE_B_ASSETS_METER_TYPE.Get(obj);

                                    if (obj != null)
                                    {
                                        HelperObject_MCE_B_ASSETS_METER_TYPE.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_METER_TYPE> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_METER_TYPE>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }

    }
}
