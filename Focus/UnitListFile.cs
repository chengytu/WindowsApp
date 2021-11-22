using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus
{
    public partial class UnitListFile : UserControl
    {

        public UnitListFile()
        {
            InitializeComponent();
        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            string dirPath = TxtDir.Text.ToString();
            //检测当前目录是否存在，如果不存在，则创建，创建后再次检测，如果还不存在，则名称出错，文本框内容清空
            PubFun pfun = new PubFun();
            bool val = pfun.ExistDir(dirPath);
            if (!val)
            {
                TxtDir.Text = "";
            }
            else
            {
                getImageFileList();
            }
        }


        // 获取当前路径中得图像文件
        public void getImageFileList()
        {
            string fstr = ".jpg,.jpeg,.png,*.bmp;";
            string dirPath = TxtDir.Text.Trim();
            if (dirPath.Length <= 0) return;

            //// 检测目录是否存在，不存在，直接返回
            //PubFun pfun = new PubFun();
            //bool val = pfun.ExistDir(dirPath);
            //if (!val) return;

            listFile.Items.Clear();

            string[] dirs = Directory.GetFiles(dirPath);

            foreach (string svar in dirs)
            {
                string houzhui = System.IO.Path.GetExtension(svar).ToLower();
                if (fstr.Contains(houzhui))
                {
                    listFile.Items.Add(svar);
                }
            }
            listFile.Refresh();
        }


        // 通过一个文件选择list
        private void setFileSelected(string fName)
        {
            int num = listFile.Items.Count;
            for (int ii = 0; ii < num; ii++)
            {
                if (listFile.Items[ii].ToString() == fName)
                {
                    listFile.SelectedIndex = ii;
                    break;
                }
            }

        }

        //坐标树点击，选中一个图像，加载，记录图像文件名称等
        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listFile.SelectedItems.Count == 1)
            {
                string tfile = listFile.SelectedItem.ToString();
                Image img = Image.FromFile(tfile);

            }
        }


        #region 控件内容
        // 设置目录参数内容
        public void setDirPath(string path)
        {
            TxtDir.Text = path;
        }

        //读取目录参数内容
        public string getDirPath()
        {
            string path = TxtDir.Text.ToString();
            return path;
        }

        #endregion

    }
}
