using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThoughtWorks.QRCode.Codec;

namespace Ipedf.Hrp.Web.Code
{
    public class BarCodeHelper
    {

        public static string GenerateBarCode(string id)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
           // qrCodeEncoder.QRCodeVersion = 4;
            qrCodeEncoder.QRCodeVersion = 0;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //System.Drawing.Image image = qrCodeEncoder.Encode("4408810820 深圳－广州 小江");
            global::System.Drawing.Image image = qrCodeEncoder.Encode(id);
            string filename = Guid.NewGuid().ToString() + ".jpg";

            string fileMonthPath = System.Web.HttpContext.Current.Server.MapPath(@"~\UploadFile") + "\\" + DateTime.Now.ToString("yyyyMM");

            if (!System.IO.Directory.Exists(fileMonthPath))
            {
                System.IO.Directory.CreateDirectory(fileMonthPath);
            }

            string filepath = fileMonthPath + "\\" + filename;
            global::System.IO.FileStream fs = new global::System.IO.FileStream(filepath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write);
            image.Save(fs, global::System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();
            return @"../../UploadFile/" + DateTime.Now.ToString("yyyyMM") + "/" + filename;
        }

    }
}