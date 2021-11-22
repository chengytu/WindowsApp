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
    public partial class WordListByLen : Form
    {

        word_graduateBLL Hlp = new word_graduateBLL();

        public WordListByLen()
        {
            InitializeComponent();
        }

        private void WordListByLen_Load(object sender, EventArgs e)
        {
            DataGrid.AutoGenerateColumns = false;
            GridLoad();
        }

        public void GridLoad()
        {
            int len;
            len = Convert.ToInt16(textBox1.Text);
            try
            {

                List<word_graduate> lst = Hlp.getWordByLen(len);
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
