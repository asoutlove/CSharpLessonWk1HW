using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class CopyFileClass
    {
        public static void CopyFile(string sourceFileName, string destPath)
        {
            if (File.Exists(sourceFileName))//確認來源檔案是否存在
            {
                try
                {
                    File.Copy(sourceFileName, destPath);
                    Console.WriteLine("檔案已複製");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("來源路徑無指定檔案");
            }
        }
    }
}
