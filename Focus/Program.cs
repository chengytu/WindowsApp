using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus
{

    
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        ///



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new Word.WordListByLen());
            //Application.Run(new Frm_Student());

            Application.Run(new FrmMain());

        }

    }


    public class appPara
    {

        public string aPath;

        public appPara()
        {
            aPath = System.AppDomain.CurrentDomain.BaseDirectory;
        }


        public void savePara(string str)
        {
            string setFile = aPath + "\\app.txt";
            FileStream fS = new FileStream(setFile, FileMode.Create, FileAccess.Write, FileShare.Read);
            StreamWriter sW = new StreamWriter(fS, Encoding.UTF8);
            sW.WriteLine(str.Trim());
            sW.Close();
            sW.Dispose();
        }

        public string loadPara()
        {
            string setFile = aPath + "\\app.txt";
            if (!File.Exists(setFile)) return "";

            FileStream fS = new FileStream(setFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sR = new StreamReader(fS, Encoding.UTF8);
            string str = sR.ReadLine();
            sR.Close();
            sR.Dispose();
            return str;
        }

    }
}
