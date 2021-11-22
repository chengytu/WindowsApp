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
using System.Web.UI.WebControls;


namespace Focus.system
{
    public partial class FrmUser : Form
    {
        SYS_USERBLL userHlp = new SYS_USERBLL();

        public string curName = "";

        #region 两个Form函数

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            GridLoad();
        }
        #endregion
        public void GridLoad()
        {
            try
            {
                List<SYS_USER> lst = userHlp.Fetch().ToList();
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch(Exception ex)
            {

            }
        

        }


        #region 六个按钮
        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserEdit efrm = new FrmUserEdit();
            efrm.FormBorderStyle = FormBorderStyle.FixedDialog;
            efrm.setData("");
            var t = efrm.ShowDialog();
            if (t == DialogResult.OK)
            {
                GridLoad();
            }
            if (t == DialogResult.Cancel)
            {
                GridLoad();
            }
        }
        //修改按钮
        private void btnAmend_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count > 0)
            {
                string id = DataGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                FrmUserEdit efrm = new FrmUserEdit();
                efrm.setData(id);
                efrm.FormBorderStyle = FormBorderStyle.FixedDialog;
                var t = efrm.ShowDialog();
                if (t == DialogResult.OK)
                {
                    GridLoad();
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的行", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //删除按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确定要删除该信息！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                var id = DataGrid.SelectedRows[0].Cells["ID"].Value.ToString();
                if (userHlp.Delete(id))
                {
                    MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridLoad();
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
