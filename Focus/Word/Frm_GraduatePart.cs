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

namespace Focus.Word
{
    public partial class Frm_GraduatePart : Form
    {

        graduate_partBLL Hlp = new graduate_partBLL();

        public Frm_GraduatePart()
        {
            InitializeComponent();
        }

        private void Frm_GraduatePart_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            //   GridLoad();
        }

        public void GridLoad()
        {
            string  type;
            type = textBox1.Text.Trim();
            try
            {

                List<graduate_part> lst = Hlp.getWordByType(type);
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch (Exception ex)
            {

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
