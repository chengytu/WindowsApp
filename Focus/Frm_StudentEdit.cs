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
    public partial class Frm_StudentEdit : Form
    {
        Frm_Student frm = null;

        public string PID = "";
        public Frm_StudentEdit()
        {
            InitializeComponent();
        }


        public void setFrm(Frm_Student frm1)
        {
            frm = frm1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel();
            if (PID.Length > 0)
            {

                model = new StudentBLL().getDataByID(PID);

            }
            else
            {

            }
            
            
            model.StudentID = txtStudentID.Text;
            model.StudentName = txtStudentName.Text;
            model.ClassName = txtClassName.Text;
            if (rdoMale.Checked)
            { model.Gender = "男"; }
            else
            { model.Gender = "女"; }


            if (PID.Length > 0)
            {


                 model.UpdateFields.Add("ID");
                 model.UpdateFields.Add("StudentID");
                 model.UpdateFields.Add("StudentName");
                 model.UpdateFields.Add("Gender");
                 model.UpdateFields.Add("ClassName");
                 bool sign = new StudentBLL().Save(model);
                if (sign == true)
                {
                    MessageBox.Show("更新成功！");

                }
                else{
                    MessageBox.Show("更新失败！");
                }
            }
            else
            {
                bool sign = new StudentBLL().Insert(model);
                if (sign == true)
                {
                    MessageBox.Show("插入成功！");

                }
                else
                {
                    MessageBox.Show("插入失败！");
                }

            }
            
            if (frm != null)
            {
                frm.refreshGird();
            }

            this.Close();
        }

        private void Frm_StudentEdit_Load(object sender, EventArgs e)
        {

        }

        public void setID(string ID) {

            PID = ID;
            StudentModel model = new StudentBLL().getDataByID(PID);


            txtStudentID.Text = model.StudentID;
            txtStudentName.Text = model.StudentName;
            txtClassName.Text = model.ClassName;
            if (model.Gender == "男") {
                rdoMale.Checked = true;
            }
            else
                rdoMale.Checked = false;
        }
    }
}
