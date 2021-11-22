using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusModels;
using BLLFactory;

namespace Focus.system
{
    public partial class FrmRoleEdit : Form
    {
        //页面需要量
        RBAC_ROLEBLL bllHelp = new RBAC_ROLEBLL();
        RBAC_ROLE model = new RBAC_ROLE();

        string strId = "";
        bool isAdd = false;//增编判断 false 新增  true 编辑

        #region  两个Form函数
        public FrmRoleEdit()
        {
            InitializeComponent();
        }

        private void FrmRoleEdit_Load(object sender, EventArgs e)
        {

        }
        #endregion
        public void setData(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                strId = "";
                
            }
            else
            {
               strId = id;
               LoadDataById(strId);
            }
        }
        #region  两个按钮：确定，取消
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.Text))
            {
                MessageBox.Show("请填写权限名称", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdd)
            {
                model = new RBAC_ROLE();
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
                txtRoleName.Text = model.ROLENAME;
                txtMemo.Text = model.Memo;
                dtCreateDate.Value = model.CREATEDATE;
                
                if (model.State == 1)
                    Btnuse.Checked = true;
                else
                    Btnuse.Checked = false;
                isAdd = false;
            }
            else
            {
                model = new RBAC_ROLE();
                model.ID = strId;
            }

        }
        #endregion

        #region Save Data 
        //
        //保存数据，将页面上的数据保存到数据库中
        private void SaveData()
        {
            model.ROLENAME = txtRoleName.Text;
            model.Memo = txtMemo.Text;
            model.CREATEDATE = dtCreateDate.Value;


            if (Btnuse.Checked)
                model.State = 1;
            else
                model.State = 0;

            model.UpdateFields.Add("Memo");
            model.UpdateFields.Add("ROLENAME");
            model.UpdateFields.Add("CREATEDATE");
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
