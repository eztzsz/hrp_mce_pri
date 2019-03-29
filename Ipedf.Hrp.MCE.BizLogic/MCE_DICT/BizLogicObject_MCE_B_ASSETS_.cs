
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
using System.Collections.Generic;
using System.Text;

namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_MCE_B_ASSETS 
    {
        private Object lockObj = new Object();
        public DisplayObject_MCE_B_ASSETS GetTotalRecord(CauseObject_MCE_B_ASSETS cause)
		{
            if (LocalMode)
            {
                DisplayObject_MCE_B_ASSETS[] list = HelperObject_MCE_B_ASSETS.Query(cause);


                object objORIGINAL_VALUE = list.Sum(l => l.ORIGINAL_VALUE);
                object objNET_VALUE = list.Sum(l => l.NET_VALUE);


                DisplayObject_MCE_B_ASSETS item = new DisplayObject_MCE_B_ASSETS();
                item.ASSETS_CODE = "总计";
                if (!string.IsNullOrEmpty(objORIGINAL_VALUE.ToString()))
                {
                    item.ORIGINAL_VALUE = decimal.Parse(objORIGINAL_VALUE.ToString());
                }

                if (!string.IsNullOrEmpty(objNET_VALUE.ToString()))
                {
                    item.NET_VALUE = decimal.Parse(objNET_VALUE.ToString());
                }

                //平台自动生成代码
                return item;
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.GetTotalRecord(cause);
                }
            }
		}




        public BizLogicMsg Save_Ext(JsonMceAssets jsonMceAssets)
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
                            EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();

                            if (!string.IsNullOrEmpty(jsonMceAssets.id))
                            {
                                obj.ID = jsonMceAssets.id;

                                obj = HelperObject_MCE_B_ASSETS.Get(obj);

                                if (obj == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }

                            obj.ASSETS_NAME = jsonMceAssets.assets_name;
                         //   obj.ASSETS_CODE = jsonMceAssets.assets_code;
                            obj.SEQ_NUMBER = jsonMceAssets.seq_number;
                            obj.MACHINE_TYPE_ID = jsonMceAssets.machine_type_id;
                            if (!string.IsNullOrEmpty(jsonMceAssets.purchase_date))
                            {
                                obj.PURCHASE_DATE =DateTime.Parse( jsonMceAssets.purchase_date);
                            }

                            obj.EN_NAME = jsonMceAssets.en_name;
                            obj.CARD_CODE = jsonMceAssets.card_code;
                            obj.CARD_TYPE_ID = jsonMceAssets.card_type_id;

                            obj.SPEC = jsonMceAssets.spec;
                            obj.UNIT_ID = jsonMceAssets.unit_id;
                            obj.ASSETS_STATE = jsonMceAssets.assets_state;

                            /*
                            if (!string.IsNullOrEmpty(jsonMceAssets.enable_date))
                            {
                                obj.ENABLE_DATE = DateTime.Parse( jsonMceAssets.enable_date);
                            }
                            */

                            if (!string.IsNullOrEmpty(jsonMceAssets.service_life))
                            {
                                obj.SERVICE_LIFE =decimal.Parse( jsonMceAssets.service_life);
                            }

                            obj.DEPR_TYPE_ID = jsonMceAssets.depr_type_id;
                            if (!string.IsNullOrEmpty(jsonMceAssets.depr_year_amount))
                            {
                                obj.DEPR_YEAR_AMOUNT = decimal.Parse(jsonMceAssets.depr_year_amount);
                            }

                            obj.IS_IN_ACCOUNT = jsonMceAssets.is_in_account;

                            /*
                            if (!string.IsNullOrEmpty(jsonMceAssets.in_account_date))
                            {
                                obj.IN_ACCOUNT_DATE =DateTime.Parse( jsonMceAssets.in_account_date);
                            }

                            if (!string.IsNullOrEmpty(jsonMceAssets.out_account_date))
                            {
                                obj.OUT_ACCOUNT_DATE = DateTime.Parse( jsonMceAssets.out_account_date);
                            }
                            */

                            obj.STORE_ADDRESS = jsonMceAssets.store_address;
                            if (!string.IsNullOrEmpty(jsonMceAssets.maintain_period))
                            {
                                obj.MAINTAIN_PERIOD =decimal.Parse( jsonMceAssets.maintain_period);
                            }

                            obj.IS_ASSETS = jsonMceAssets.is_assets;
                            obj.IS_DEPR = jsonMceAssets.is_depr;
                            obj.IS_LARGE_ME = jsonMceAssets.is_large_me;
                            obj.IS_AFFIX = jsonMceAssets.is_affix;
                            obj.IS_METERING = jsonMceAssets.is_metering;
                            obj.IS_SELF_RESTRAINT = jsonMceAssets.is_self_restraint;
                            obj.OWNERSHIP_TYPE_ID = jsonMceAssets.ownership_type_id;
                            obj.SUBJECTION_DEPT_ID = jsonMceAssets.subjection_dept_id;
                        //    obj.CUSTODY_DEPT_ID = jsonMceAssets.custody_dept_id;
                         //   obj.CUSTODY_USER_ID = jsonMceAssets.custody_user_id;
                            obj.CUSTODY_LEVEL_ID = jsonMceAssets.custody_level_id;
                          //  obj.USING_DEPT_ID = jsonMceAssets.using_dept_id;
                           // obj.USING_USER_ID = jsonMceAssets.using_user_id;
                          
                            obj.BIZ_TYPE_ID = jsonMceAssets.biz_type_id;
                            obj.OPERATING_MACHINE_TYPE_ID = jsonMceAssets.operating_machine_type_id;
                            obj.MACHINE_MANAGE_TYPE_ID = jsonMceAssets.machine_manage_type_id;
                            obj.SPELL_CODE = jsonMceAssets.spell_code;
                            obj.FIVE_STROKE_CODE = jsonMceAssets.five_stroke_code;
                            obj.INTERNATIONAL_CODE = jsonMceAssets.international_code;
                            obj.CUSTOM_CODE = jsonMceAssets.custom_code;
                            obj.CALL_CODE = jsonMceAssets.call_code;
                           // obj.FILE_CODE = jsonMceAssets.file_code;
                           // obj.CONTRACT_CODE = jsonMceAssets.contract_code;
                            obj.LICENCE_CODE = jsonMceAssets.licence_code;
                            obj.MAINTAIN_CONTACT = jsonMceAssets.maintain_contact;

                            /*
                            if (!string.IsNullOrEmpty(jsonMceAssets.original_value))
                            {
                                obj.ORIGINAL_VALUE =decimal.Parse( jsonMceAssets.original_value);
                            }

                            if (!string.IsNullOrEmpty(jsonMceAssets.net_value))
                            {
                                obj.NET_VALUE = decimal.Parse(jsonMceAssets.net_value);
                            }
                               */
                            if (!string.IsNullOrEmpty(jsonMceAssets.net_amount))
                            {
                                obj.NET_AMOUNT = decimal.Parse(jsonMceAssets.net_amount);
                            }
                         

                            if (!string.IsNullOrEmpty(jsonMceAssets.rudimental_value_ratio))
                            {
                                obj.RUDIMENTAL_VALUE_RATIO = decimal.Parse(jsonMceAssets.rudimental_value_ratio);
                            }

                            if (!string.IsNullOrEmpty(jsonMceAssets.predict_net_rudimental_value))
                            {
                                obj.PREDICT_NET_RUDIMENTAL_VALUE = decimal.Parse(jsonMceAssets.predict_net_rudimental_value);
                            }

                            if (!string.IsNullOrEmpty(jsonMceAssets.add_value))
                            {
                                obj.ADD_VALUE = decimal.Parse(jsonMceAssets.add_value);
                            }

                            obj.ACQUIRE_OWNERSHIP_TYPE_ID = jsonMceAssets.acquire_ownership_type_id;
                            obj.ACQUIRE_USE_TYPE_ID = jsonMceAssets.acquire_use_type_id;
                            obj.VALUE_TYPE_ID = jsonMceAssets.value_type_id;
                            obj.FINANCE_TYPE_ID = jsonMceAssets.finance_type_id;
                            obj.REF_DEPT_ID = jsonMceAssets.ref_dept_id;

                            if (!string.IsNullOrEmpty(jsonMceAssets.ref_price))
                            {
                                obj.REF_PRICE =decimal.Parse( jsonMceAssets.ref_price);
                            }

                            obj.ECONOMIC_USE_TYPE_ID = jsonMceAssets.economic_use_type_id;
                            obj.PURCHASE_TYPE_ID = jsonMceAssets.purchase_type_id;
                            obj.CAPITAL_SOURCE_TYPE_ID = jsonMceAssets.capital_source_type_id;
                            if (!string.IsNullOrEmpty(jsonMceAssets.prd_date))
                            {
                                obj.PRD_DATE =DateTime.Parse( jsonMceAssets.prd_date);
                            }
                            if (!string.IsNullOrEmpty(jsonMceAssets.maintenance_period_date))
                            {
                                obj.MAINTENANCE_PERIOD_DATE =DateTime.Parse( jsonMceAssets.maintenance_period_date);
                            }
                            obj.VEHICLE_CODE = jsonMceAssets.vehicle_code;
                            obj.VEHICLE_USE_TYPE_ID = jsonMceAssets.vehicle_use_type_id;
                            obj.ENERGY_TYPE_ID = jsonMceAssets.energy_type_id;
                            obj.BRAND_NAME = jsonMceAssets.brand_name;
                            obj.PRD_ID = jsonMceAssets.prd_id;
                            obj.PRD_CODE = jsonMceAssets.prd_code;
                            obj.PROVIDER_ID = jsonMceAssets.provider_id;
                            obj.PRD_PLACE_TYPE_ID = jsonMceAssets.prd_place_type_id;
                            obj.NATIONALITY_ID = jsonMceAssets.nationality_id;
                            obj.PICTURE = jsonMceAssets.picture;

                            if (string.IsNullOrEmpty(jsonMceAssets.id))
                            {
                                obj.STATE = 1;
                                obj.ASSETS_CODE = GectAssetsCode();
                                int amount = HelperObject_MCE_B_ASSETS.Save(obj, transaction);
                            }
                            else
                            {

                                obj.ID = jsonMceAssets.id;
                                int amount = HelperObject_MCE_B_ASSETS.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMceAssets);
                }
            }
        }


        public string GectAssetsCode()
        {
            string strCode = "";


            var year = DateTime.Now.Year.ToString().Remove(0, 2);
            int code = 1;
            var cause_year = new CauseObject_MCE_B_ASSETS();
            cause_year.SetCustomCondition(" and MCE_B_ASSETS.ASSETS_CODE like '" + year + "%'");
            var list = BizLogicObject_MCE_B_ASSETS.Proxy.Query(cause_year);
            if (list != null && list.Length > 0)
            {
                var s_code = list.Max(p => p.ASSETS_CODE);
                var rightCode = s_code.Replace(year + "000026", "").TrimStart('0');
                code = int.Parse(rightCode) + 1;
            }

            strCode = year + "000026" + (code ).ToString().PadLeft(4, '0');

            return strCode;
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
                            if (listID != null && listID.Count > 0)
                            {
                                foreach (string strID in listID)
                                {
                                    EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();
                                    obj.ID = strID;

                                    obj = HelperObject_MCE_B_ASSETS.Get(obj);

                                    if (obj != null)
                                    {

                                        if (obj.STATE==3 || obj.STATE==4)
                                        {
                                            throw new Exception("已经审核的资产卡片不能再审核.");
                                        }

                                        obj.STATE = 3;
                                        obj.AUDIT_TIME = DateTime.Now;
                                        obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                        HelperObject_MCE_B_ASSETS.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
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
                            if (listID != null && listID.Count > 0)
                            {
                                foreach (string strID in listID)
                                {
                                    EntityObject_MCE_B_ASSETS obj = new EntityObject_MCE_B_ASSETS();
                                    obj.ID = strID;

                                    obj = HelperObject_MCE_B_ASSETS.Get(obj);

                                    if (obj != null)
                                    {

                                        if (obj.STATE == 3 || obj.STATE == 4)
                                        {
                                            throw new Exception("已经审核的资产卡片不能删除.");
                                        }

                                        HelperObject_MCE_B_ASSETS.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Audit_Ext(listID);
                }
            }
        }



        public string Generate_Bill_Code(string strType)
        {
            if (LocalMode)
            {
                StringBuilder strCode = new StringBuilder();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {

                            lock (lockObj)
                            {

                                CauseObject_MTR_CODE pCode = new CauseObject_MTR_CODE();
                                pCode.CODE = strType;
                                EntityObject_MTR_CODE[] codes = HelperObject_MTR_CODE.Query(pCode, transaction);
                                if (codes == null || codes.Length == 0)
                                    throw new Exception("获取编码失败, 请重试.");
                                EntityObject_MTR_CODE codeObj = codes[0];
                                codeObj.ClearUpdate();
                                if (codeObj.FLOW_DATE.ToString("yyyyMMdd") != DateTime.Today.ToString("yyyyMMdd"))
                                {
                                    codeObj.FLOW_DATE = DateTime.Today;
                                    codeObj.SetUpdate("FLOW_DATE", "FLOW_NUM");
                                    codeObj.FLOW_NUM = 1;
                                }
                                else
                                    codeObj.SetUpdate("FLOW_NUM");
                                strCode.Append(string.Concat(codeObj.PREFIX, "-", codeObj.FLOW_DATE.ToString("yyyyMMdd"), "-", ((int)codeObj.FLOW_NUM).ToString("D4")));
                                int tmpNum = (int)codeObj.FLOW_NUM;
                                codeObj.FLOW_NUM = ++tmpNum;
                                HelperObject_MTR_CODE.Update(codeObj, transaction);
                                transaction.Commit();
                                codeObj.ClearUpdate();

                            }

                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();

                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return strCode.ToString();
            }
            else
            {
                using (ServiceManager<ServiceContract_MCE_B_ASSETS> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS>(ServiceUri))
                {
                    return smgr.Service.Generate_Bill_Code(strType);
                }
            }

        }

    }
}
