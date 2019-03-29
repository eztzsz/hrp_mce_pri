using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Ipedf.Hrp.Web.Code;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Text;
using Ipedf.Common;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_GetMCEDeprCalc 的摘要说明
    /// </summary>
    public class Srv_MCE_GetMCEDeprCalc : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //允许跨域
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            JSON_MSG jsonMsg = new JSON_MSG();
            try
            {
                 context.Response.ContentType = "text/plain";
                 HttpRequest request = context.Request;

                if (string.IsNullOrEmpty(request["dept"]))
                {
                    throw new Exception("参数错误.");
                }


                CauseObject_MCE_B_ASSETS pAssets = new CauseObject_MCE_B_ASSETS();
                pAssets.IS_AFFIX = (decimal)是否状态.否;//是否附件
                pAssets.IS_ASSETS = (decimal)是否状态.是;//是否固定资产
                pAssets.IS_DEPR = (decimal)是否状态.是;//是否折旧
                pAssets.ASSETS_STATE = "00530002";//资产状态
                pAssets.CARD_TYPE_ID = "00680002"; //卡片类型

                pAssets.USING_DEPT_ID = request["dept"];
                EntityObject_MCE_B_ASSETS[] entities = BizLogicObject_MCE_B_ASSETS.Proxy.Query(pAssets);


                List<JsonMceDepr_D> list = new List<JsonMceDepr_D>();
                //创建记录
                foreach (EntityObject_MCE_B_ASSETS entity in entities)
                {
                    JsonMceDepr_D deprDetail = new JsonMceDepr_D();
                    //deprDetail.BASE_ID = obj.ID;//主从关联
                    deprDetail.ASSETS_ID = entity.ID;
                    deprDetail.ASSETS_NAME = entity.ASSETS_NAME;
                    deprDetail.ASSETS_CODE = entity.ASSETS_CODE;
                    deprDetail.CURRENCY_ID = "00660001";//人民币
                    deprDetail.CURRENCY_ID_NAME = "人民币";//
                    //  deprDetail.MONEY = BizLogicObject_MCE_D_DEPR_TYPE.Proxy.GetAssetsMonthDerpMoney(entity);//月折旧额
                    decimal derpMoney = 0;
                    if (entity.DEPR_YEAR_AMOUNT > 0)
                    {
                        derpMoney = entity.ORIGINAL_VALUE * ((1 - entity.PREDICT_NET_RUDIMENTAL_VALUE) / entity.DEPR_YEAR_AMOUNT) / 12;
                    }

                    deprDetail.MONEY =Math.Round( derpMoney,2);

                    deprDetail.NET_VALUE = entity.NET_VALUE;//净值
                    deprDetail.NEW_NET_VALUE = deprDetail.NET_VALUE - deprDetail.MONEY;//计提后净值
                    deprDetail.ORIGINAL_VALUE = entity.ORIGINAL_VALUE;//原值

                    list.Add(deprDetail);

                }

                jsonMsg.Message = list;
                jsonMsg.Succeed = 1;

            }
            catch (Exception ex)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = ex.Message;
            }
            finally
            {
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy'-'MM'-'dd HH':'mm" };

                string strMsg = JsonConvert.SerializeObject(jsonMsg, Formatting.Indented, timeConverter);
                strMsg = strMsg.Replace("0001-01-01 00:00", "");
                context.Response.Write(strMsg);

                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}