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
    public partial class Frm_View_gWord_lenTspace : Form
    {

        View_gWord_lenTspaceBLL Hlp = new View_gWord_lenTspaceBLL();

        public Frm_View_gWord_lenTspace()
        {
            InitializeComponent();
        }

        private void View_gWord_lenT_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            GridLoad();
        }

        public void GridLoad()
        {
            try
            {

                List<View_gWord_lenTspace> lst = Hlp.getALLData();
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch (Exception ex)
            {

            }


        }

    }
}
