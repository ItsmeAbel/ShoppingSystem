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
        BindingSource productListSource;
        public LagerForm()
        {
            InitializeComponent();
            productListSource = new BindingSource();
            updateList();
        }

        private void ContinueButtton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addToLagerButton_Click(object sender, EventArgs e)
        {
            addProductLager form = new addProductLager();
            form.Show();
            
        }

        public void updateList()
        {
            productListSource.DataSource = backend.loadList();
            productDatalistLager.DataSource = productListSource;
        }
    }
}
