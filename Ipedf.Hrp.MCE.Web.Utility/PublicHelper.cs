using Ipedf.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Ipedf.Hrp.PRV.Web.Utility
{
    public static class PublicHelper
    {
        //默认排序
        public static OrderByParameter GetOrder(string order, string sort)
        {
            OrderByParameter orders = new OrderByParameter();

            if (string.IsNullOrEmpty(order))
            {
                order = "0";
            }

            //QUOTED_PRICE_MIN desc,QUOTED_PRICE desc,PRICE
            if (string.IsNullOrEmpty(sort))
            {
                sort = "ID";
            }

            orders.Asc = order == "1" ? true : false;
            orders.OrderBy = sort;

            return orders;
        }
        public static void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
            {
                if (Directory.GetFileSystemEntries(path).Length > 0)
                {
                    //遍历文件夹中所有文件
                    foreach (string file in Directory.GetFiles(path))
                    {
                        DeleteFile(file);
                    }
                    //删除文件夹
                    Directory.Delete(path);

                }
            }
        }

        public static void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                FileInfo fi = new FileInfo(file);
                //判断当前文件属性是否是只读
                if (fi.Attributes.ToString().IndexOf("ReadyOnly") >= 0)
                {
                    fi.Attributes = FileAttributes.Normal;
                }
                //删除文件
                File.Delete(file);
            }
        }

        #region 图片切割
        /// <summary>
        ///  图片切割(用来做缩略图)
        /// </summary>
        /// <param name="fileImg">源图地址</param>
        /// <param name="fileImg">缩略图存储地址</param>
        /// <param name="qieWidth">切割宽度</param>
        /// <param name="qieHeight">切割高度</param>
        /// <param name="suffix">图片后缀名,默认为jpg(一般不改)</param>
        /// <param name="thumbFile">图片保存路径,默认为image(一般不改)</param>
        /// <returns></returns>
        public static string NewsPic(string fileImg,string saveThumbPath, int qieWidth, int qieHeight, string suffix, string thumbFile)
        {

            System.Drawing.Image image = System.Drawing.Image.FromFile(fileImg);
            //判断切割的宽或高是否为空和大于源图宽高
            if (qieWidth == 0 || qieWidth > image.Width)
            {
                qieWidth = image.Width / 2;
            }
            if (qieHeight == 0 || qieHeight > image.Height)
            {
                qieHeight = image.Height / 2;
            }
            //Format24bppRgb指定像素每个为24位,清晰效果好
            Bitmap bitmap = new Bitmap(qieWidth, qieHeight, PixelFormat.Format24bppRgb);
            //设置图片的分辩率
            bitmap.SetResolution(80, 80);
            //从指定的图片创建新的图片(画图)
            Graphics g = Graphics.FromImage(bitmap);
            /*---------------------------------------------------------*/
            /* 
             * 消除齿巨的呈现
             * AntiAlias 指定消除锯齿的呈现。 
             * Default 指定默认模式。
             * HighQuality 指定高质量、低速度呈现。
             * HighSpeed 指定高速度、低质量呈现。 
             * Invalid 指定一个无效模式。
             * None 指定不消除锯齿。 
             */
            g.SmoothingMode = SmoothingMode.AntiAlias;
            /*---------------------------------------------------------*/
            //插补模式确定如何计算两个终结点之间的中间值
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //取得或設定值，指定在這個 Graphics 的呈現期間如何位移像素,高
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            /*---------------------------------------------------------*/
            /*
             * 开始绘图,使用Rectangle函数绘图
             * 在指定位置并且按指定大小绘制指定的 Image 的指定部分
             * image.Width取源图宽,在源图整体上缩小图
             * image.Height取源图高,在源图整体上缩小图
             */
            g.DrawImage(image, new Rectangle(0, 0, qieWidth, qieHeight), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            /*---------------------------------------------------------*/
            string fName = string.Empty;//路径
            string picName = string.Empty;//图片名
            if (suffix != "")
            {
                picName = Guid.NewGuid().ToString() + "." + suffix;
                fName = saveThumbPath + picName;
            }
            else
            {
                picName = Guid.NewGuid().ToString() + ".jpg";
                fName = saveThumbPath + picName;
            }
            try
            {
                switch (suffix)
                {
                    case "jpg":
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "png":
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "jpeg":
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "bmp":
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        bitmap.Save(fName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                //绘完之后清除
                image.Dispose();
                g.Dispose();
                bitmap.Dispose();
                return picName;
            }
            catch
            {
                return "";
            }
        }

        #endregion
    }
}
