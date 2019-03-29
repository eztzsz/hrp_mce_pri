
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
namespace Ipedf.Web.BizLogic
{
  
    public partial class BizLogicObject_MCE_B_ASSETS_INSTOCK 
    {


        public BizLogicMsg Save_Ext(JsonMCE_INSTOCK jsonMCE_INSTOCK)
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

                            EntityObject_MCE_B_ASSETS_INSTOCK entity = new EntityObject_MCE_B_ASSETS_INSTOCK();


                            if (!string.IsNullOrEmpty(jsonMCE_INSTOCK.ID))
                            {
                                entity.ID = jsonMCE_INSTOCK.ID;

                                entity = HelperObject_MCE_B_ASSETS_INSTOCK.Get(entity);

                                if (entity == null)
                                {
                                    throw new Exception("获取数据出错.");
                                }
                            }


                            entity.CODE = jsonMCE_INSTOCK.CODE;
                            entity.WAREHOUSE_ID = jsonMCE_INSTOCK.WAREHOUSE_ID;
                            entity.PROVIDER_ID = jsonMCE_INSTOCK.PROVIDER_ID;

                            if (!string.IsNullOrEmpty(jsonMCE_INSTOCK.CREATE_DATE))
                            {
                                entity.CREATE_DATE = DateTime.Parse(jsonMCE_INSTOCK.CREATE_DATE);
                            }
                            entity.USER_ID = jsonMCE_INSTOCK.USER_ID;
                         
                            entity.COMMENTS = jsonMCE_INSTOCK.COMMENTS;
                            entity.INVOICE_CODE = jsonMCE_INSTOCK.INVOICE_CODE;
                            entity.STATE = 1;

                            if (string.IsNullOrEmpty(jsonMCE_INSTOCK.ID))
                            {
                                entity.CREATE_TIME = DateTime.Now;
                                entity.CREATE_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                int amount = HelperObject_MCE_B_ASSETS_INSTOCK.Save(entity, transaction);
                            }
                            else
                            {
                                int amount = HelperObject_MCE_B_ASSETS_INSTOCK.Update(entity, transaction);
                            }


                            if (jsonMCE_INSTOCK.DELETEIDS != null && jsonMCE_INSTOCK.DELETEIDS.Count > 0)
                            {
                                foreach (string strID in jsonMCE_INSTOCK.DELETEIDS)
                                {
                                    EntityObject_MCE_B_ASSETS_INSTOCK_D entity_D = new EntityObject_MCE_B_ASSETS_INSTOCK_D();

                                    if (!string.IsNullOrEmpty(strID))
                                    {
                                        entity_D.ID = strID;

                                        entity_D = HelperObject_MCE_B_ASSETS_INSTOCK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                        else
                                        {
                                            HelperObject_MCE_B_ASSETS_INSTOCK_D.Delete(entity_D, transaction);
                                        }
                                    }
                                }
                            }

                            if (jsonMCE_INSTOCK.children != null && jsonMCE_INSTOCK.children.Count > 0)
                            {

                                decimal decTotMoney = 0;
                                foreach (JsonMCE_INSTOCK_D item in jsonMCE_INSTOCK.children)
                                {
                                    EntityObject_MCE_B_ASSETS_INSTOCK_D entity_D = new EntityObject_MCE_B_ASSETS_INSTOCK_D();

                                    if (!string.IsNullOrEmpty(item.ID))
                                    {
                                        entity_D.ID = item.ID;

                                        entity_D = HelperObject_MCE_B_ASSETS_INSTOCK_D.Get(entity_D);

                                        if (entity_D == null)
                                        {
                                            throw new Exception("获取数据出错.");
                                        }
                                    }

                                    entity_D.BASE_ID = entity.ID;
                                    entity_D.ASSET_ID = item.ASSET_ID;
                                    entity_D.USING_DEPT_ID = item.USING_DEPT_ID;
                                    entity_D.ASSET_TYPE_ID = item.ASSET_TYPE_ID;
                                    entity_D.ASSETS_NAME = item.ASSETS_NAME;
                                    entity_D.SPEC = item.SPEC;


                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        if (!string.IsNullOrEmpty(item.PRD_ID))
                                        {
                                            string strPrdID = "";
                                            CauseObject_MDM_D_DEPT p = new CauseObject_MDM_D_DEPT();
                                            p.REF_ID = item.PRD_ID;

                                            DisplayObject_MDM_D_DEPT[] listPrd = HelperObject_MDM_D_DEPT.Query(p);
                                            if (listPrd != null && listPrd.Length > 0)
                                            {
                                                strPrdID = listPrd[0].ID;
                                            }

                                            entity_D.PRD_ID = strPrdID;
                                        }
                                        entity_D.REF_PRD_ID = item.PRD_ID;
                                    }

                                    entity_D.PRICE = item.PRICE;
                                    entity_D.AMOUNT = item.AMOUNT;
                                    entity_D.UNIT_ID = item.UNIT_ID;
                                    entity_D.COUNTRY = item.COUNTRY;

                                    if (!string.IsNullOrEmpty(item.DEPR_YEAR_AMOUNT))
                                    {
                                        entity_D.DEPR_YEAR_AMOUNT = decimal.Parse(item.DEPR_YEAR_AMOUNT);
                                    }

                                    entity_D.DEPR_TYPE_ID = item.DEPR_TYPE_ID;

                                    entity_D.MONEY = item.AMOUNT * item.PRICE;
                                    decTotMoney = decTotMoney + entity_D.MONEY;

                                    entity_D.REF_TAB_ID = item.REF_TAB_ID;
                                    entity_D.REF_TAB_NAME = item.REF_TAB_NAME;

                                    if (string.IsNullOrEmpty(item.ID))
                                    {
                                        HelperObject_MCE_B_ASSETS_INSTOCK_D.Save(entity_D, transaction);
                                    }
                                    else
                                    {
                                        HelperObject_MCE_B_ASSETS_INSTOCK_D.Update(entity_D, transaction);
                                    }


                                }
                                entity.TOTAL_MONEY = decTotMoney;

                                HelperObject_MCE_B_ASSETS_INSTOCK.Update(entity, transaction);

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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK>(ServiceUri))
                {
                    return smgr.Service.Save_Ext(jsonMCE_INSTOCK);
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
                                EntityObject_MCE_B_ASSETS_INSTOCK obj = new EntityObject_MCE_B_ASSETS_INSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_INSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 2 || obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经提交的数据不能再提交.");
                                    }

                                    obj.STATE = 2;
                                    HelperObject_MCE_B_ASSETS_INSTOCK.Update(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_INSTOCK obj = new EntityObject_MCE_B_ASSETS_INSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_INSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE == 3 || obj.STATE == 4)
                                    {
                                        throw new Exception("已经审核的数据不能再审核.");
                                    }



                                    obj.STATE = 3;
                                    obj.AUDIT_TIME = DateTime.Now;
                                    obj.AUDIT_USER_ID = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                                    HelperObject_MCE_B_ASSETS_INSTOCK.Update(obj, transaction);



                                   DisplayObject_MCE_B_ASSETS_INSTOCK_D[] disInStock_D = BizLogicObject_MCE_B_ASSETS_INSTOCK_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_INSTOCK_D() { BASE_ID = obj.ID });

                                   if (disInStock_D.Length == 0)
                                   {
                                       throw new Exception("请添加入库设备!");
                                   }
                                   foreach (DisplayObject_MCE_B_ASSETS_INSTOCK_D item in disInStock_D)
                                   {
                                       if (string.IsNullOrEmpty(item.ASSETS_NAME))
                                       {
                                           throw new Exception("请输入设备名称!");
                                       }
                                       if (string.IsNullOrEmpty(item.ASSET_TYPE_ID))
                                       {
                                           throw new Exception("请输入设备分类!");
                                       }
                                       if (string.IsNullOrEmpty(item.USING_DEPT_ID))
                                       {
                                           throw new Exception("请输入领用科室!");
                                       }
                                   }

                                    //按领用科室对入库明细进行分组
                                    Hashtable ht = Hashtable.Synchronized(new Hashtable());
                                    foreach (DisplayObject_MCE_B_ASSETS_INSTOCK_D gd in disInStock_D)
                                    {
                                        if (gd.REF_TAB_NAME == "MCE_B_AOG_D" && !string.IsNullOrEmpty(gd.REF_TAB_ID))
                                        {
                                            EntityObject_MCE_B_AOG_D obj_AOG_D = new EntityObject_MCE_B_AOG_D();
                                            obj_AOG_D.ID = gd.REF_TAB_ID;

                                            obj_AOG_D = HelperObject_MCE_B_AOG_D.Get(obj_AOG_D);
                                            if (obj_AOG_D != null)
                                            {
                                                obj_AOG_D.REF_USED_AMOUNT = obj_AOG_D.REF_USED_AMOUNT + gd.AMOUNT;
                                                HelperObject_MCE_B_AOG_D.Update(obj_AOG_D, transaction);
                                            }
                                        }


                                        List<DisplayObject_MCE_B_ASSETS_INSTOCK_D> glist = (List<DisplayObject_MCE_B_ASSETS_INSTOCK_D>)ht[gd.USING_DEPT_ID];
                                        if (glist == null) glist = new List<DisplayObject_MCE_B_ASSETS_INSTOCK_D>();
                                        glist.Add(gd);
                                        ht[gd.USING_DEPT_ID] = glist;
                                    }
                                   
                             
                          
                                    #region 出库单
                                //    EntityObject_MCE_B_ASSETS_INSTOCK entInStock = Get(new EntityObject_MCE_B_ASSETS_INSTOCK() { ID = obj.ID });

                                    //按ht中的分组来生成
                                    foreach (object key in ht.Keys)
                                    {
                                        //生成主表
                                       EntityObject_MCE_B_ASSETS_OUTSTOCK entOutStock = new EntityObject_MCE_B_ASSETS_OUTSTOCK();
                                        List<EntityObject_MCE_B_ASSETS_OUTSTOCK_D> entOutStock_D = new List<EntityObject_MCE_B_ASSETS_OUTSTOCK_D>();
                                        entOutStock.CREATE_DATE = DateTime.Now;
                                        entOutStock.STATE = 1;
                                        entOutStock.CODE = BizLogicObject_MCE_B_ASSETS.Proxy.Generate_Bill_Code("MceOutstock");
                                        //entOutStock.TOTAL_MONEY = entOutStock.TOTAL_MONEY;
                                        entOutStock.STOCK_ID = obj.WAREHOUSE_ID; //出库仓库
                                        entOutStock.DEPT_ID = obj.DEPT_ID;//出库科室
                                        //转出列表
                                        List<DisplayObject_MCE_B_ASSETS_INSTOCK_D> glist = (List<DisplayObject_MCE_B_ASSETS_INSTOCK_D>)ht[key];
                                        entOutStock.USING_DEPT_ID = glist[0].USING_DEPT_ID;//领用科室
                                        BizLogicObject_MCE_B_ASSETS_OUTSTOCK.Proxy.SaveByTrans(entOutStock, transaction);

                                        decimal decTotMoney = 0;
                                        //生成明细
                                        foreach (DisplayObject_MCE_B_ASSETS_INSTOCK_D item in glist)
                                        {
                                            EntityObject_MCE_B_ASSETS_OUTSTOCK_D p = new EntityObject_MCE_B_ASSETS_OUTSTOCK_D();
                                            p.REF_TAB_ID = item.ID;
                                            p.REF_TAB_NAME = "MCE_B_ASSETS_INSTOCK_D";
                                            p.BASE_ID = entOutStock.ID;
                                            p.ASSETS_NAME = item.ASSETS_NAME;
                                            p.ASSET_TYPE_ID = item.ASSET_TYPE_ID;
                                            p.PRD_ID = item.PRD_ID;
                                            p.SPEC = item.SPEC;
                                            p.ASSETS_CODE = item.ASSETS_CODE;
                                            p.UNIT_ID = item.UNIT_ID;
                                            p.AMOUNT = item.AMOUNT;
                                            p.PRICE = item.PRICE;
                                            p.MONEY = item.MONEY;
                                            p.COUNTRY = item.COUNTRY;
                                            decTotMoney = decTotMoney + item.MONEY;
                                            BizLogicObject_MCE_B_ASSETS_OUTSTOCK_D.Proxy.SaveByTrans(p, transaction);
                                        }

                                        entOutStock.TOTAL_MONEY = decTotMoney;
                                        BizLogicObject_MCE_B_ASSETS_OUTSTOCK.Proxy.UpdateByTrans(entOutStock, transaction);
                                    }
                                    #endregion

                                    #region 资产卡片

                                    
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
                                    
                                    #endregion
                                    DisplayObject_MCE_B_ASSETS_INSTOCK_D[] disInStock = BizLogicObject_MCE_B_ASSETS_INSTOCK_D.Proxy.Query(new CauseObject_MCE_B_ASSETS_INSTOCK_D() { BASE_ID = obj.ID });
                                    List<EntityObject_MCE_B_ASSETS> assetsList = new List<EntityObject_MCE_B_ASSETS>();
                                    var num = 0;
                                    foreach (DisplayObject_MCE_B_ASSETS_INSTOCK_D InStockitem in disInStock)
                                    {
                                        for (int i = 0; i < InStockitem.AMOUNT; i++)
                                        {
                                            //获取并重新设置最大流水号
                                            EntityObject_MCE_B_ASSETS entAssets = new EntityObject_MCE_B_ASSETS();
                                            entAssets.REF_TAB_ID = InStockitem.ID;
                                            entAssets.REF_TAB_NAME = "MCE_B_ASSETS_INSTOCK_D";
                                            entAssets.CARD_TYPE_ID = "00680001";
                                            entAssets.ASSETS_STATE = "00530001";
                                            entAssets.IS_ASSETS = (decimal)Ipedf.Common.是否状态.是;
                                            // entAssets.IS_DEPR = 2;
                                            entAssets.USE_STATE = "00540002";
                                            entAssets.PURCHASE_DATE = DateTime.Now;
                                            entAssets.CUSTODY_DEPT_ID = obj.DEPT_ID;
                                            entAssets.SUBJECTION_DEPT_ID = obj.DEPT_ID;
                                            entAssets.PROVIDER_ID = obj.PROVIDER_ID;
                                            entAssets.NAME = InStockitem.NAME;
                                            entAssets.SPEC = InStockitem.SPEC;
                                            entAssets.PRD_ID = InStockitem.PRD_ID;
                                            entAssets.PRD_CODE = InStockitem.PRD_CODE;
                                            entAssets.PRD_DATE = InStockitem.PRD_DATE;
                                            entAssets.MAINTENANCE_PERIOD_DATE = InStockitem.MAINTENANCE_PERIOD_DATE;
                                            entAssets.ASSETS_CODE = year + "000026" + (code + num).ToString().PadLeft(4, '0');
                                            entAssets.ASSETS_NAME = InStockitem.ASSETS_NAME;
                                            entAssets.UNIT_ID = InStockitem.UNIT_ID;
                                            entAssets.ORIGINAL_VALUE = InStockitem.PRICE;
                                            entAssets.NET_VALUE = InStockitem.PRICE;//净值=原值
                                            entAssets.MACHINE_TYPE_ID = InStockitem.ASSET_TYPE_ID;
                                            entAssets.CUSTOM_CODE = InStockitem.CARD_CODE;          //验收单流水号
                                            entAssets.IS_AFFIX = (decimal)Ipedf.Common.是否状态.否;                                 //是否附件
                                            entAssets.STATE = 1;
                                            entAssets.MAINTAIN_CONTACT = obj.INVOICE_CODE;//发票号
                                            entAssets.DEPR_TYPE_ID = InStockitem.DEPR_TYPE_ID;//hsc 2016 1109
                                            entAssets.DEPR_YEAR_AMOUNT = InStockitem.DEPR_YEAR_AMOUNT;//hsc 2016 1109
                                            entAssets.IS_DEPR = !string.IsNullOrEmpty(InStockitem.DEPR_TYPE_ID) ? (decimal)Ipedf.Common.是否状态.是 : (decimal)Ipedf.Common.是否状态.否;
                                            BizLogicObject_MCE_B_ASSETS.Proxy.SaveByTrans(entAssets, transaction);
                                            //assetsList.Add(entAssets);
                                            num += 1;
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK>(ServiceUri))
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
                                EntityObject_MCE_B_ASSETS_INSTOCK obj = new EntityObject_MCE_B_ASSETS_INSTOCK();
                                obj.ID = strID;

                                obj = HelperObject_MCE_B_ASSETS_INSTOCK.Get(obj);

                                if (obj != null)
                                {
                                    if (obj.STATE >= 2)
                                    {
                                        throw new Exception("已经提交的数据不能删除.");
                                    }

                                    HelperObject_MCE_B_ASSETS_INSTOCK.Delete(obj, transaction);
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
                using (ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK> smgr = new ServiceManager<ServiceContract_MCE_B_ASSETS_INSTOCK>(ServiceUri))
                {
                    return smgr.Service.Delete_Ext(listID);
                }
            }
        }



    }
}
