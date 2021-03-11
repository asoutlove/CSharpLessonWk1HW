using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class DeleteFileClass
    {
        public static void DeleteFile(string sourceFileName)
        {
            if (File.Exists(sourceFileName))//確認要刪除的檔案是否存在
            {
                try
                {
                    string text = File.ReadAllText(sourceFileName);
                    File.Delete(sourceFileName);
                    Console.WriteLine($"檔案已刪除");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                Console.WriteLine("來源路徑無指定檔案");
            }
        }
    }
}
