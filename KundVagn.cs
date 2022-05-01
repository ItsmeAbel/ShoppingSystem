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
    public partial class KundVagn : Form
    {
        //List<ProductList> productlist;

        BindingList<ProductList> vagnProductList;
        BindingSource vagnproductListSource;
        public KundVagn(List<ProductList> plist)
        {
            InitializeComponent();
            vagnProductList = new BindingList<ProductList>(plist);
            vagnproductListSource = new BindingSource();
            vagnproductListSource.DataSource = vagnProductList;
            kundvagndataGridView.DataSource = vagnproductListSource;
        }

        private void ProduktLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KVRemoveButton_Click(object sender, EventArgs e)
        {
            vagnProductList.Clear();
            this.Close();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            vagnProductList.Clear();
            DialogResult = DialogResult.OK;
        }
    }
}
