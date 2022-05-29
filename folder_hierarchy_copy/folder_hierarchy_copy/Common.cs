using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Folder_hierarchy_copy
{
    public static class Common
    {
        /// <summary>
        /// サブフォルダを含むフォルダのコピー
        /// </summary>
        /// <param name="CopyFldName">コピーするフォルダパス</param>
        /// <param name="PasteFldName">コピー先のフォルダパス</param>
        public static void Set_CopyDirectory(string CopyFldName, string PasteFldName, bool CheckBoxState)
        {
            //コピー先のディレクトリがないときは作成
            if (!Directory.Exists(PasteFldName))
            {
                Directory.CreateDirectory(PasteFldName);
                File.SetAttributes(PasteFldName, File.GetAttributes(CopyFldName));
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (PasteFldName[PasteFldName.Length - 1] != Path.DirectorySeparatorChar)
            {
                PasteFldName = PasteFldName + Path.DirectorySeparatorChar;
            }

            //コピー元のディレクトリにあるファイルをコピー　※ここで並列処理
            if (CheckBoxState)
            {
                string[] files = Directory.GetFiles(CopyFldName);
                Parallel.ForEach(files, (file) =>
                {
                    File.Copy(file, PasteFldName + Path.GetFileName(file), true);
                });
            }
            
            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(CopyFldName);
            foreach (string dir in dirs)
            {
                Set_CopyDirectory(dir, PasteFldName + Path.GetFileName(dir), CheckBoxState);
            }
        }
    }
}
