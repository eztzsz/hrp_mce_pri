using System;

using System.Collections.Generic;
using System.Text;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using System.IO;

namespace Ipedf.Hrp.PRV.Web.Utility
{
    public class ZipFileClass
    {
        /// <summary>
        /// 压缩率：0-9
        /// </summary> 
        private int compressionLevel = 6;
        //private byte[] buffer = new byte[2048];

        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="folderToZip">源目录</param>
        /// <param name="zipedFile">目标名（全路径）</param>
        /// <param name="msg"></param>
        /// <returns>成功true</returns>
        public  bool ZipFolder(string folderToZip, string zipedFile,out string msg)
        {
            bool bl = false;
            try
            {             
                if (!Directory.Exists(folderToZip))
                {
                    msg = "不存在" + folderToZip + "压缩文件夹！";
                    bl=false;
                }
                else
                {
                    using (ZipOutputStream zipStream = new ZipOutputStream(File.Create(zipedFile)))
                    {
                        zipStream.SetLevel(compressionLevel);
                        Compress(folderToZip, zipStream);
                        zipStream.Finish();
                        zipStream.Close();
                    }
                    bl=true;
                    msg = "压缩成功！";
                }
            }
            catch (Exception ex)
            {
                msg = "压缩异常："+ex.Message;
                bl=false;
            }
            return bl;
        }


        public bool ZipFile(string FileToZip, string ZipedFile, int CompressionLevel, int BlockSize, string Pwd)
        {
            bool bl = false;
            try
            {
                if (!File.Exists(FileToZip))
                {
                   // msg = "不存在" + folderToZip + "压缩文件夹！";
                    bl = false;
                }
                FileStream stream = new FileStream(FileToZip, FileMode.Open, FileAccess.Read);
                ZipOutputStream stream3 = new ZipOutputStream(File.Create(ZipedFile));
                if (!string.IsNullOrEmpty(Pwd))
                {
                    stream3.Password = Pwd;
                }
                ZipEntry entry = new ZipEntry(FileToZip);
                stream3.PutNextEntry(entry);
                stream3.SetLevel(CompressionLevel);
                byte[] buffer = new byte[BlockSize];
                int count = stream.Read(buffer, 0, buffer.Length);
                stream3.Write(buffer, 0, count);
                try
                {
                    while (count < stream.Length)
                    {
                        int num2 = stream.Read(buffer, 0, buffer.Length);
                        stream3.Write(buffer, 0, num2);
                        count += num2;
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
                stream3.Finish();
                stream3.Close();
                stream.Close();
                bl = true;
            }
            catch (Exception ex)
            {
               // msg = "压缩异常：" + ex.Message;
                bl = false;
            }
            return bl;
        }
        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="source">源目录</param>
        /// <param name="s">ZipOutputStream对象</param>
        public static void Compress(string source, ZipOutputStream s)
        {
            string[] filenames = Directory.GetFileSystemEntries(source);
            foreach (string file in filenames)
            {
                if (Directory.Exists(file))
                {
                    Compress(file, s);  //递归压缩子文件夹
                }
                else
                {
                    using (FileStream fs = File.OpenRead(file))
                    {
                        byte[] buffer = new byte[4 * 1024];
                        //ZipEntry entry = new ZipEntry(file.Replace(Path.GetPathRoot(file), ""));     //此处去掉盘符，如D:\123\1.txt 去掉D:
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);

                        int sourceBytes;
                        do
                        {
                            sourceBytes = fs.Read(buffer, 0, buffer.Length);
                            s.Write(buffer, 0, sourceBytes);
                        } while (sourceBytes > 0);
                    }
                }
            }
        }
    }
}
