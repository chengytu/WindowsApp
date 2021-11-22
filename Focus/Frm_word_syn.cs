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


namespace Focus
{
    public partial class Frm_word_syn : Form
    {

        word_page_synBLL Hlp = new word_page_synBLL();

        public Frm_word_syn()
        {
            InitializeComponent();
        }

        private void Frm_word_syn_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            getWordLenTree();
            GridLoad("词组短语");
        }

        public void GridLoad(string str)
        {

            try
            {

                List<word_page_syn> lst = Hlp.getDataByType(str);
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }

            catch (Exception ex)
            {

            }

        }


        //导航树初始化
        public void getWordLenTree()
        {

            var lst = new view_word_page_syn_typeBLL().getAllData();
            listFile.Nodes.Clear();
            TreeNode zNode = new TreeNode();
            foreach (view_word_page_syn_type tType in lst)
            {
                zNode = new TreeNode();
                zNode.Name = tType.type.ToString();
                zNode.Text = tType.type.ToString() + "[" + tType.num.ToString() + "]"; ;
                zNode.Tag = tType.type.ToString();
                listFile.Nodes.Add(zNode);
            }
            listFile.Refresh();
        }

        //坐标树点击，选中一个相对应数据等
        private void listFile_DoubleClick(object sender, EventArgs e)
        {
            string str = listFile.SelectedNode.Tag.ToString();
            if (str.Length <= 0) return;
            GridLoad(str);
        }

        private void listFile_AfterSelect(object sender, TreeViewEventArgs e)
        {
                                                              
        }
    }
}
