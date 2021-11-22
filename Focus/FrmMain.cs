using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace Focus
{
    public partial class FrmMain : MetroForm
    {

        Form actFrm = null;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenFrm("About");
        }

        #region  窗口顶部一级菜单
        //系统管理
        private void Btnsysterm_Click(object sender, EventArgs e)
        {
            showPnl("system");
        }

        //项目管理
        private void Btnproject_Click(object sender, EventArgs e)
        {
            showPnl("project");
        }




        private void BtnTest_Click(object sender, EventArgs e)
        {
            showPnl("test");
        }

        private void Btnservice_Click(object sender, EventArgs e)
        {
            showPnl("wordlen");
        }

        private void Btnsample_Click(object sender, EventArgs e)
        {
            showPnl("Sample");
        }

        private void Btnresult_Click(object sender, EventArgs e)
        {
            showPnl("result");
        }
        

        private void Btnoperate_Click(object sender, EventArgs e)
        {
            showPnl("publicDict");
        }

        private void Btnreagent_Click(object sender, EventArgs e)
        {
            showPnl("Reagent");
        }

        private void Btnhome_Click(object sender, EventArgs e)
        {
            showPnl("home");
        }

        #endregion

        #region   统一设置左边菜单     点击顶部菜单对左边菜单得布局
        // 统一设置左边菜单    
        void showPnl(string tags)
        {
            int xx = 28, yy = 40;
            Point tmp = new Point();
            tmp.X = xx;
            foreach (Control cnl in this.pnlLeft.Controls)
            {
                if (cnl.Tag != null && cnl.Tag.ToString() == tags)
                {
                    tmp.Y = yy;
                    cnl.Location = tmp;
                    cnl.Visible = true;
                    yy += 20 + cnl.Height;
                }
                else
                {
                    cnl.Visible = false;
                }
            }
            panel1.Visible = true;
            pnlLeft.Width = 200;
            pnlLeft.Visible = true;
        }
        #endregion


        #region  子菜单执行函数
        //子菜单--液体类别
        private void btnLiquid_Click(object sender, EventArgs e)
        {
            OpenFrm("TypeStatis");
        }

        //子菜单--洗板类别
        private void btnWash_Click(object sender, EventArgs e)
        {
            OpenFrm("PartType");
        }


        private void btnFactory_Click(object sender, EventArgs e)
        {
            OpenFrm("Factory");
        }
        #endregion



        #region 项目子菜单执行函数

      

        //子菜单--项目内容
         private void btnSubjectDetail_Click(object sender, EventArgs e)
        {
            OpenFrm("Student");
        }


        // 项目与试剂
        private void btnSubjectReg_Click(object sender, EventArgs e)
        {
            OpenFrm("SubjectReg");
        }

        // 项目步骤
        private void btnSubjectStep_Click(object sender, EventArgs e)
        {
            OpenFrm("SubjectOperate");
        }

        private void btnSubjectStep_Click_1(object sender, EventArgs e)
        {
            OpenFrm("SubjectStep");
        }

        #endregion


        #region  子菜单执行函数

        //子菜单--吸头类型
        private void btndict_SuctionHead(object sender, EventArgs e)
        {
            OpenFrm("dict_SuctionHead");
        }
        //子菜单--试剂仓位置
        private void btnReagentBin_Click(object sender, EventArgs e)
        {
            OpenFrm("dict_ReagentBin");
        }
        //子菜单--角色维护
        private void btnRole_Click(object sender, EventArgs e)
        {
            OpenFrm("Role");
        }
        //子菜单--用户管理
        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenFrm("User");
        }
        //子菜单--梯度稀释类别
        private void btnDilution_Click(object sender, EventArgs e)
        {
            OpenFrm("Dilution");
        }


        //子菜单-- 定量类别
        private void btnQuantity_Click(object sender, EventArgs e)
        {
            OpenFrm("Quantity");
        }

        //子菜单--单词首字符长度统计
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFrm("View_Word_lenT");
        }

        //子菜单-- 部件参数分类
        private void btnParaType_Click(object sender, EventArgs e)
        {
            OpenFrm("wordlensearch");
        }

        //子菜单--试管载架内容维护
        private void btncarrier_Click(object sender, EventArgs e)
        {
            OpenFrm("View_graduword_len");
        }

        //子菜单--单词首字符长度统计
        private void btnCharlenT_Click(object sender, EventArgs e)
        {
            OpenFrm("View_Word_lenSearch");
        }

        //子菜单--单词长度统计-字符
        private void btnSubject_Click(object sender, EventArgs e)
        {
            OpenFrm("View_Word_lenTspace");

        }
        #endregion



        #region  OpenFrm 统一处理函数


        // 窗体打开统一处理函数
        public void OpenFrm(string frmName)
        {

            //关闭当前显示的窗体
            if (actFrm != null)
            {
                actFrm.Close();
            }

            //根据给定的标识符打开相对应的窗体
            switch (frmName)
            {
                case "About":
                    actFrm = new FrmAbout();
                    break;
                case "wordlensearch":
                    actFrm = new Word.WordListByLen();
                    break;
                case "View_graduword_len":
                    actFrm = new Word.WordLenList();
                    break;
                case "View_Word_lenT":
                    actFrm = new Word.Frm_View_gWord_lenT();
                    break;
                case "View_Word_lenSearch":
                    actFrm = new Word.Frm_WordListByLen();
                    break;
                case "View_Word_lenTspace":
                    actFrm = new Word.Frm_View_gWord_lenTspace();
                    break;
                case "TypeStatis":
                    actFrm = new Word.Frm_View_WordPart();
                    break;
                case "PartType":
                    actFrm = new Word.Frm_GraduatePart();
                    break;
                case "Student":
                    actFrm = new Frm_Student();
                    break;
                default:
                    return;
            }

            //设置窗体属性
            actFrm.TopLevel = false;
            actFrm.FormBorderStyle = FormBorderStyle.None;
            this.pnlCenter.Controls.Add(actFrm);
            actFrm.Parent = pnlCenter;
            actFrm.Dock = DockStyle.Fill;
            actFrm.Show();
        }



        #endregion

        private void btnCheckbyChinese_Click(object sender, EventArgs e)
        {

        }
    }
}
