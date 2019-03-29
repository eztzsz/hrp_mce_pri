using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Ipedf.Hrp.Web.service
{
    /// <summary>
    /// Srv_MCE_FileUpload 的摘要说明
    /// </summary>
    public class Srv_MCE_FileUpload : IHttpHandler
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

                // bool isPhoto = listSuffix.Contains(aLastName.ToLower());

                /*
                if (isPhoto)
                {
                    //生成缩略图
                    string thumbName = PublicHelper.NewsPic(uploadPath + uploadName, uploadPath, 150, 110, "", "");
                    //生成缩略图流
                    if (!string.IsNullOrEmpty(thumbName))
                    {
                        FileStream fs = new FileStream(uploadPath + thumbName, FileMode.Open, FileAccess.Read);//读取文件 
                        BinaryReader br = new BinaryReader(fs);
                        thumbPhoto = br.ReadBytes((int)fs.Length);
                    }
                }
                string ID = request["ID"].ToString();
                */

                /*
                EntityObject_MTR_FILE entity = new EntityObject_MTR_FILE();
                entity.FILE_NAME = file.FileName;
                entity.SAVE_NAME = uploadName;
                //entity.TYPE = "";
                entity.SUFFIX = aLastName;
                entity.REF_TAB_ID = ID;
                entity.REF_TAB_NAME = request["tabName"].ToString();
                entity.THUMB_BINARY = thumbPhoto;
                entity.FILE_BINARY = photo;
                BizLogicMsg msg = BizLogicObject_MTR_FILE.Proxy.Save(entity, guid);
                */


                JsonMtrFileEntity fileEntity = new JsonMtrFileEntity();
                //fileEntity.fileId = entity.ID;
                //fileEntity.fileName = entity.FILE_NAME;
                fileEntity.saveName = uploadName;
                fileEntity.fileName = file.FileName; 
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