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
    public partial class WordLenList : Form
    {

        View_graduword_lenBLL Hlp = new View_graduword_lenBLL();

        public WordLenList()
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

                List<View_graduword_len> lst = Hlp.getALLData();
                DataGrid.DataSource = lst;
                DataGrid.Refresh();

            }
            catch (Exception ex)
            {
                
            }


        }
       
    }
}
