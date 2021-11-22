using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Focus
{
    public class PubFun
    {

        public static string FileSavePath = ConfigurationManager.AppSettings["FilesUpLoadPath"].ToString();


        public bool ExistDir(string dirPath)
        {
            bool returnVal = false;

            if (dirPath.Length <= 0) return returnVal;
            //检测当前目录是否存在，如果不存在，则创建，创建后再次检测，如果还不存在，则返回出错，后期将文本框内容清空
            if (Directory.Exists(dirPath))
            {
                returnVal = true;
            }
            else
            {
                Directory.CreateDirectory(dirPath);
                if (Directory.Exists(dirPath)) returnVal = true;
            }
            return returnVal;
        }
    }

    public class kmItem
    {
        public string Code;
        public string Name;

        public kmItem(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }

}
