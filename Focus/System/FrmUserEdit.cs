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
    public partial class FrmUserEdit : Form
    {

        //页面需要量
        SYS_USERBLL bllHelp = new SYS_USERBLL();
        RBAC_ROLEBLL roleHelp = new RBAC_ROLEBLL();
        SYS_USER model = new SYS_USER();


        public string curroleid = "";
        string strId = "";
        bool isAdd = false;//增编判断 false 新增  true 编辑

        #region  两个Form函数
        public FrmUserEdit()
        {
            InitializeComponent();
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
        }
        #endregion

        public void setData(string id)
        {
            getrole();
            if (string.IsNullOrEmpty(id))
            {
                strId = "";
                //cbxIsWashboard.Visible = true;
            }
            else
            {
                strId = id;
                LoadDataById(strId);
            }
        }

        public void getrole()
        {
            List<RBAC_ROLE> lst = roleHelp.getAllRoleId();
            if (lst == null || lst.Count <= 0) return;

            cbxRoleID.Items.Clear();

            foreach (RBAC_ROLE tid in lst)
            {
                ListItem tItem = new ListItem();
             //   model.RoleID = cbxRoleID.Text;
                tItem.Text = tid.ROLENAME;
                tItem.Value = tid.ID;
                cbxRoleID.Items.Add(tItem);

            }

            cbxRoleID.Refresh();
            cbxRoleID.SelectedIndex = 0;
            curroleid = lst[0].ID;
           
        }

        #region  两个按钮：确定，取消
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("请填写登录名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("请填写用户名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("请填写密码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (isAdd)
            {
                model = new SYS_USER();
            }

            SaveData();
          
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Load Data
        //
        //根据 strId 获取数据并在页面上显示
        //
        public void LoadDataById(string strId)
        {
            isAdd = true;
            model = bllHelp.GetById(strId);
            if (model != null)
            {
                // XiangXian.Text = model.XiangXian;
                txtLogin.Text = model.Login;
                txtUserName.Text = model.UserName;
                txtPwd.Text = model.Pwd;

                string rid = model.RoleID.ToString();
                //                cbxRoleID.SelectedValue = rid;
                int idx = 0;
                foreach (ListItem tItem in cbxRoleID.Items)
                {
                    if (tItem.Value == rid) break;
                    idx++;
                }

                cbxRoleID.SelectedIndex = idx;

                dtCreateDate.Value = model.CreateDate;
                
                if (model.State == 1)
                    Btnuse.Checked = true;
                else
                    Btnuse.Checked = false;
                isAdd = false;
            }
            else
            {
                model = new SYS_USER();
                model.ID = strId;
            }

        }
        #endregion

        #region Save Data 
        //
        //保存数据，将页面上的数据保存到数据库中
        private void SaveData()
        {
            model.Login = txtLogin.Text;
            model.UserName = txtUserName.Text;
            model.Pwd = txtPwd.Text;
//            model.RoleID = cbxRoleID.Text;
            //model.RoleID = cbxRoleID.SelectedItem.
                //.Value;
           ListItem tItem =(ListItem)cbxRoleID.SelectedItem;
            model.RoleID = tItem.Value;

            model.CreateDate = dtCreateDate.Value;
;


            if (Btnuse.Checked)
                model.State = 1;
            else
                model.State = 0;


            model.UpdateFields.Add("Login");
            model.UpdateFields.Add("UserName");
            model.UpdateFields.Add("Pwd");
            model.UpdateFields.Add("RoleID");
            model.UpdateFields.Add("CreateDate");
            model.UpdateFields.Add("State");

            bool sign = bllHelp.Save(model);
            if (sign)
            {
                MessageBox.Show("保存成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("保存失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        

    }
}
