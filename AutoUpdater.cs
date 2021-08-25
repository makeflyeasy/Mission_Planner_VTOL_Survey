using FtpTest1;

using MissionPlanner.Utilities;
using System;

using System.IO;

using System.Windows.Forms;

using ICSharpCode.SharpZipLib.GZip;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;

namespace MissionPlanner
{
    public partial  class AutoUpdater
    {

        /// <summary>  

        /// 功能：解压zip格式的文件。  

        /// </summary>  

        /// <param name="zipFilePath">压缩文件路径</param>  

        /// <param name="unZipDir">解压文件存放路径,为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹</param>  

        /// <returns>解压是否成功</returns>  
        public void UnZip(string zipFilePath, string unZipDir)

        {

            if (zipFilePath == string.Empty)

            {

                throw new Exception("压缩文件不能为空！");

            }

            if (!File.Exists(zipFilePath))

            {

                throw new FileNotFoundException("压缩文件不存在！");

            }

            //解压文件夹为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹  

            if (unZipDir == string.Empty)

                unZipDir = zipFilePath.Replace(Path.GetFileName(zipFilePath), Path.GetFileNameWithoutExtension(zipFilePath));

            if (!unZipDir.EndsWith("/"))

                unZipDir += "/";

            if (!Directory.Exists(unZipDir))

                Directory.CreateDirectory(unZipDir);



            using (var s = new ZipInputStream(File.OpenRead(zipFilePath)))

            {



                ZipEntry theEntry;

                while ((theEntry = s.GetNextEntry()) != null)

                {

                    string directoryName = Path.GetDirectoryName(theEntry.Name);

                    string fileName = Path.GetFileName(theEntry.Name);

                    if (!string.IsNullOrEmpty(directoryName))

                    {

                        Directory.CreateDirectory(unZipDir + directoryName);

                    }

                    if (directoryName != null && !directoryName.EndsWith("/"))

                    {

                    }

                    if (fileName != String.Empty)

                    {

                        using (FileStream streamWriter = File.Create(unZipDir + theEntry.Name))

                        {



                            int size;

                            byte[] data = new byte[2048];

                            while (true)

                            {

                                size = s.Read(data, 0, data.Length);

                                if (size > 0)

                                {

                                    streamWriter.Write(data, 0, size);

                                }

                                else

                                {

                                    break;

                                }

                            }

                        }

                    }

                }

            }

        }
        public void Update ()
        {
            try
            {
               
                FtpWeb fw = new FtpWeb("47.108.137.134", "MissionPlannerVtolSurvey", "doc", "bfxKe68Erv4qB");
                string filepath = Settings.GetRunningDirectory() + "ver0.txt";
                StreamReader oldsr = new StreamReader(filepath);
                string oldstr = oldsr.ReadLine();
                oldsr.Close();
                string status = fw.Download(Settings.GetRunningDirectory(), "ver.txt");
                StreamReader newsr = new StreamReader(Settings.GetRunningDirectory()+"ver.txt");
                string newstr = newsr.ReadLine();
                newsr.Close();
                if (oldstr != newstr)
                {
                    if ((int)DialogResult.Yes == CustomMessageBox.Show("检测到有新版本，是否更新", "提示", MessageBoxButtons.YesNo))
                    {
                        status=  fw.Download1(Settings.GetRunningDirectory(), "Mission Planner Vtol Survey.msi");

                        
                       
                        string sourceArchiveFileName = Settings.GetRunningDirectory() + "Mission Planner Vtol Survey.msi";

                        /*DirectoryInfo info = new DirectoryInfo(Application.StartupPath);
                        string destinationDirectoryName = info.Parent.FullName;
                        
                        UnZip(sourceArchiveFileName, destinationDirectoryName);*/
                        Process.Start(sourceArchiveFileName);
                        Process.GetCurrentProcess().Kill();
                        StreamWriter wr = new StreamWriter(filepath);//更新版本号
                        wr.WriteLine(newstr);//更新版本号
                        wr.Close();


                    }
                }
            }
            catch { }

        }
        
    }
}
