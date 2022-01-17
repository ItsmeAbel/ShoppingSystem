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

        
       
        BindingList<ProductList> lagerProductList;
        BindingSource productListSource;
        public LagerForm()
        {
            InitializeComponent();
            //List<ProductList> locallist = backend.loadList();
            lagerProductList = new BindingList<ProductList>(backend.loadList());
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
            form.StartPosition = FormStartPosition.CenterParent;
            //form.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                productListSource.Add(form.plist);
                backend.saveToCSV(lagerProductList);
            }
            else
            {


            }
            
            //updateList();
        }

        public void updateList()
        {
            productListSource.DataSource = lagerProductList;
            productDatalistLager.DataSource = productListSource;
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (productDatalistLager.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistLager.SelectedRows[0].DataBoundItem;
            productListSource.Remove(product);
            backend.saveToCSV(lagerProductList);

        }
    }
}
