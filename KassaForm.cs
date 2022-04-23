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
    public partial class KassaForm : Form
    {
        BackendPart backend = new BackendPart();
        BindingList<ProductList> kassaProductList;
        BindingSource productListSource;

        public KassaForm()
        {
            InitializeComponent();
            kassaProductList = new BindingList<ProductList>(backend.loadList());
            productListSource = new BindingSource();
            productListSource.DataSource = kassaProductList;
            productDatalistKassa.DataSource = productListSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KundVagn form = new KundVagn();
            form.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (productDatalistKassa.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistKassa.SelectedRows[0].DataBoundItem;

        }
    }
}
