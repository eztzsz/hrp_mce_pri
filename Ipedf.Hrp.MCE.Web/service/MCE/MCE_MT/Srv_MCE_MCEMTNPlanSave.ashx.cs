using System.Web;
using Ipedf.Core;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Web.Services;
using System.Reflection;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Web.SessionState;
using System;
using System.Collections.Generic;
using Ipedf.Hrp.Entity;
using System.Text.RegularExpressions;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_MCEMTNPlanSave 的摘要说明
    /// </summary>
    public class Srv_MCE_MCEMTNPlanSave : IHttpHandler, System.Web.SessionState.IRequiresSessionState
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

                StringBuilder rsb = new StringBuilder();
                int bytelengg = (int)request.InputStream.Length;
                using (var reader = new StreamReader(request.InputStream, Encoding.UTF8))
                {
                    var read = new Char[bytelengg];
                    var count = reader.Read(read, 0, bytelengg);
                    while (count > 0)
                    {
                        var str = new string(read, 0, count);
                        rsb.Append(str);
                        count = reader.Read(read, 0, bytelengg);
                    }
                    reader.Close();
                    reader.Dispose();
                    request.InputStream.Close();
                    request.InputStream.Dispose();
                }

                if (string.IsNullOrEmpty(rsb.ToString()))
                {
                    throw new Exception("参数错误.");
                }

                JsonMCE_MT_PLAN entity = JsonConvert.DeserializeObject<JsonMCE_MT_PLAN>(rsb.ToString());


                if (string.IsNullOrEmpty(entity.CODE))
                {
                    throw new Exception("参数错误,计划编号不能为空.");
                }

                if (string.IsNullOrEmpty(entity.NAME))
                {
                    throw new Exception("参数错误,计划名称不能为空.");
                }

                if (string.IsNullOrEmpty(entity.MTN_TYPE_ID))
                {
                    throw new Exception("参数错误,保养类别不能为空.");
                }

                if (string.IsNullOrEmpty(entity.APPLY_USER_ID))
                {
                    throw new Exception("参数错误,负责人不能为空.");
                }

                if (string.IsNullOrEmpty(entity.EXECUTE_PERIOD_UNIT))
                {
                    throw new Exception("参数错误,周期类别不能为空.");
                }
                if (string.IsNullOrEmpty(entity.EXECUTE_PERIOD))
                {
                    throw new Exception("参数错误,执行周期不能为空.");
                }


                string pattern = @"^[0-9]*[1-9][0-9]*$";
                if(! Regex.IsMatch(entity.EXECUTE_PERIOD, pattern))
                {
                    throw new Exception("参数错误,执行周期必须为正整数.");
                }

                if (string.IsNullOrEmpty(entity.CREATE_DATE))
                {
                    throw new Exception("参数错误,下次执行日期不能为空.");
                }


                if (entity.children != null && entity.children.Count > 0)
                {
                    foreach (JsonMCE_MT_PLAN_D item in entity.children)
                    {

                        if (string.IsNullOrEmpty(item.ASSETS_ID))
                        {
                            throw new Exception("参数错误,设备名称不能为空.");
                        }
                        if (string.IsNullOrEmpty(item.ITEM_ID))
                        {
                            throw new Exception("参数错误,项目名称不能为空.");
                        }
                       
                    }
                }
                else
                {
                    throw new Exception("没有明细数据");
                }


                BizLogicMsg msg = BizLogicObject_MCE_B_ASSETS_MT_PLAN.Proxy.Save_Ext(entity);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);

                jsonMsg.Succeed = 1;
                jsonMsg.Message = msg.Message;
                //jsonMsg.Message = "提交成功.";

            }
            catch (Exception ex)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = ex.Message;
            }
            finally
            {
                context.Response.Write(JsonConvert.SerializeObject(jsonMsg));
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