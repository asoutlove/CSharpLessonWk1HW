using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class ReadFileClass
    {
        public static void ReadFile(string sourceFileName)
        {
            if (File.Exists(sourceFileName))//確認來源檔案是否存在
            {
                try
                {
                    string text = File.ReadAllText(sourceFileName);
                    Console.WriteLine($"檔案讀取內容如下:\n" );
                    Console.WriteLine($"{text}");
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
