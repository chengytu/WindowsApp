using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusModels;
using BLLFactory;

namespace Focus.Word
{
    public partial class Frm_WordListByLen : Form
    {
        int wordlen;
        View_graduword_lenBLL Hlp = new View_graduword_lenBLL();

        public Frm_WordListByLen()
        {
            InitializeComponent();
        }

        private void Frm_WordListByLen_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            getWordLenTree();
        }


        //导航树初始化
        public void getWordLenTree()
        {

            var lst = Hlp.Fetch().OrderBy(t => t.wordlen).ToList();
            listFile.Nodes.Clear();
            TreeNode zNode = new TreeNode();
            foreach (View_graduword_len tType in lst)
            {
                zNode = new TreeNode();
                zNode.Name = tType.wordlen.ToString();
                zNode.Text = tType.wordlen.ToString() + "[" + tType.num.ToString() + "]"; ;
                zNode.Tag = tType.wordlen.ToString();
                listFile.Nodes.Add(zNode);
            }
            listFile.Refresh();
        }


        //坐标树点击，选中一个相对应数据等
        private void listFile_DoubleClick(object sender, EventArgs e)
        {
            string str = listFile.SelectedNode.Tag.ToString();
            if (str.Length <= 0) return;
            wordlen =Convert.ToInt16(str);
            GridLoad();
        }


        public void GridLoad()
        {
            word_graduateBLL tHelp = new word_graduateBLL();
           
            if (wordlen>0)
            {
                try
                {
                    List<word_graduate> lst = tHelp.getWordByLen(wordlen);
                    DataGrid.DataSource = lst;
                    DataGrid.Refresh();
                }
                catch (Exception ex)
                {

                }

            }

        }

    }
}
