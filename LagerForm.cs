using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem
{
    public partial class LagerForm : Form
    {
        BackendPart backend = new BackendPart();
        public LagerForm()
        {
            InitializeComponent();
            productDatalistLager.DataSource = backend.loadList();
        }

        private void ContinueButtton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addToLagerButton_Click(object sender, EventArgs e)
        {
            addProductWindow form = new addProductWindow();
            form.Show();
        }
    }
}
