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
            productListSource.DataSource = lagerProductList;
            productDatalistLager.DataSource = productListSource;
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

                Console.WriteLine("{0}", backend.idcheck(form.plist.id));
                if (backend.idcheck(form.plist.id) == true)
                {

                    MessageBox.Show("Varunummer är redan taget, vänligen ange korrekt varunummer!");
                }
                else {
                    productListSource.Add(form.plist);
                    backend.saveToCSV(lagerProductList);
                 }

            }
            else
            {
                MessageBox.Show("Något är fel!");

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
            var product = (ProductList)productDatalistLager.SelectedRows[0].DataBoundItem; //the item in the selected row is out in the variable product
            if(product.status != 0)
            {
                productListSource.Remove(product);
                backend.saveToCSV(lagerProductList);

            }
            else {
                DialogResult dialogResult = MessageBox.Show("vill du verkligen ta bort varan?", "vill du verkligen ta bort varan?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productListSource.Remove(product);
                    backend.saveToCSV(lagerProductList);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //gör inget
                }
            }

        }

        private void LagerFormbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productDatalistLager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
