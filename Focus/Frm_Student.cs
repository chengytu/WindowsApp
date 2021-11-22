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
    public partial class Frm_Student : Form
    {
        public string classname = "";
        StudentBLL Hlp = new StudentBLL();

        public Frm_Student()
        {

            InitializeComponent();

        }

        private void Frm_Student_Load(object sender, EventArgs e)
        {

            DataGrid.AutoGenerateColumns = false;
            getWordLenTree();

        }



        public void GridLoad(string str)
        {

            if (str.Length <= 0)
                return;
            try
            {

                List<StudentModel> lst = Hlp.getDataByClassName(str);
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }

            catch (Exception ex)
            {

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_StudentEdit actFrm = new Frm_StudentEdit();
            actFrm.setFrm(this);
            actFrm.Show();
            GridLoad(classname);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GridLoad(classname);
        }


        public void refreshGird()
        {
            getWordLenTree();
            GridLoad(classname);
        }


        private void btnUpdata_Click(object sender, EventArgs e)
        {
            int num = DataGrid.SelectedRows.Count;
            if (num > 0)
            {
                string ID= DataGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                Frm_StudentEdit actFrm = new Frm_StudentEdit();
                actFrm.setFrm(this);
                actFrm.setID(ID);
                actFrm.Show();
                //if (actFrm.ShowDialog()== DialogResult.OK)
                //{
                //    GridLoad("");
                //}
                GridLoad(classname);


            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            int num = DataGrid.SelectedRows.Count;
            if (num > 0)
            {
                string ID = DataGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                StudentModel model = new StudentBLL().getDataByID(ID);
                bool sign = new StudentBLL().Delete(model);
                if (sign == true)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }

                GridLoad(classname);

            }
        }


        //导航树初始化
        public void getWordLenTree()
        {
            var lst = new View_ClassBLL().getALLData();
            listFile.Nodes.Clear();
            TreeNode zNode = new TreeNode();
            foreach (View_Class tType in lst)
            {
                zNode = new TreeNode();
                zNode.Name = tType.ClassName.ToString();
                zNode.Text = tType.ClassName.ToString() + "[" + tType.num.ToString() + "]"; ;
                zNode.Tag = tType.ClassName.ToString();
                listFile.Nodes.Add(zNode);
            }

            listFile.Refresh();
        }


        //坐标树点击，选中一个相对应数据等
        private void listFile_DoubleClick(object sender, EventArgs e)
        {
            string str = listFile.SelectedNode.Tag.ToString();
            if (str.Length <= 0)
                return;
            classname = str;
            GridLoad(str);
        }
    }

}

