using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFolderHandling
{
    class DeleteFolderClass
    {
        public static void DeleteFolder(string destPath) //用來刪除指定資料夾
        {
            

            if (Directory.Exists(destPath))//確認資料夾是否存在&列舉目錄
            {
                foreach (string dest in Directory.GetFileSystemEntries(destPath))//用來傳回內容目錄名稱
                {
                    if (System.IO.File.Exists(dest))//確認子資料夾是否還有檔案，進行刪除
                    {
                        FileInfo insideFile = new FileInfo(dest);
                        if (insideFile.Attributes.ToString().IndexOf("ReadOnly") != -1)//確認是否還有檔案
                            insideFile.Attributes = FileAttributes.Normal;//使唯讀檔也可被刪除
                        System.IO.File.Delete(dest);//刪除檔案
                    }
                    else
                        DeleteFolder(dest);//刪除子資料夾
                }
                Directory.Delete(destPath);//删除空資料夾
            }
            else
            {
                Console.WriteLine($"此資料夾{destPath}不存在。");
            }
        }
        
    }
}
