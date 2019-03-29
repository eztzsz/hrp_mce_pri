using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_WriteOffFileUpload 的摘要说明
    /// </summary>
    public class Srv_MCE_WriteOffFileUpload : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //允许跨域
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            JSON_MSG jsonMsg = new JSON_MSG();
            context.Response.ContentType = "text/json";
            try
            {
                HttpRequest request = context.Request;

                HttpPostedFile file = request.Files.Count > 0 ? request.Files[0] : null;

                string folder = "mce\\";

                string uploadPath = HttpRuntime.AppDomainAppPath.ToString();

                if (uploadPath.EndsWith("\\"))
                    uploadPath = uploadPath + "upload\\" + folder;
                else
                    uploadPath = uploadPath + "\\upload\\" + folder;

                string guid = Guid.NewGuid().ToString();
                string uploadName = guid;
                string aLastName = "";
                byte[] photo = new byte[] { };//原图
                byte[] thumbPhoto = new byte[] { };//缩略图
                if (file != null)
                {
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    aLastName = System.IO.Path.GetExtension(file.FileName).ToLower();
                    uploadName += aLastName;
                    file.SaveAs(uploadPath + uploadName);

                }
                else
                    throw new Exception("未检测到上传文件, 请重试.");

                List<string> listSuffix = new List<string>();
                listSuffix.Add(".jpg");
                listSuffix.Add(".png");
                listSuffix.Add(".jpeg");
                listSuffix.Add(".gif");
                listSuffix.Add(".bmp");


                JsonWriteOffFile fileEntity = new JsonWriteOffFile();
        
                fileEntity.saveName = uploadName;
                fileEntity.fileName = file.FileName;
                fileEntity.userid = Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.ID;
                fileEntity.username= Ipedf.Web.BizLogic.SystemLogic.Proxy.CurrentUser.NAME;
                fileEntity.createdate = DateTime.Now;

                fileEntity.fileUrl = "upload/mce";
                jsonMsg.Message = fileEntity;


                jsonMsg.Succeed = 1;

            }
            catch (Exception e)
            {
                jsonMsg.Succeed = 0;
                jsonMsg.Message = e.Message;
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