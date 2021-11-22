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

namespace Focus
{
    public partial class Frm_word_College : Form
    {

        word_collegeBLL Hlp = new word_collegeBLL();

        public Frm_word_College()
        {
            InitializeComponent();
        }

        private void WordLenList_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            GridLoad();
        }

        public void GridLoad()
        {


            try
            {

                List<View_word_college> lst = Hlp.getALLData();
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch (Exception ex)
            {

            }


        }
    }
}
