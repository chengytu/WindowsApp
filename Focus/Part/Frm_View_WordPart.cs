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
    public partial class Frm_View_WordPart : Form
    {

        View_WordPartBLL Hlp = new View_WordPartBLL();

        public Frm_View_WordPart()
        {
            InitializeComponent();
        }

        private void Frm_View_WordPart_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            GridLoad();
        }

        public void GridLoad()
        {


            try
            {

                List<View_WordPart> lst = Hlp.getAllData();
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch (Exception ex)
            {

            }


        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

