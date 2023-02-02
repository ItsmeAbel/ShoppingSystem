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
        //private int returncheck = 0;

        List<ProductList> vagnlist;
        BackendPart backend = new BackendPart();
        BindingList<ProductList> kassaProductList;
        BindingSource productListSource;

        public KassaForm()
        {
            InitializeComponent();
            vagnlist = new List<ProductList>();
            try
            {
                kassaProductList = new BindingList<ProductList>(backend.loadList());


            }
            catch
            {


            }
            productListSource = new BindingSource();
            productListSource.DataSource = kassaProductList;
            productDatalistKassa.DataSource = productListSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            KundVagn vagnform = new KundVagn(vagnlist); //sends the new list to the form as a parameter
            vagnform.StartPosition = FormStartPosition.CenterParent;
            //vagnform.Show();
            if (vagnform.ShowDialog() == DialogResult.OK)
            {

                backend.saveToCSV(kassaProductList);
            }
            else
            {
                //returncheck = 1;
                productListSource.Clear();
                kassaProductList = new BindingList<ProductList>(backend.loadList());
                productListSource.DataSource = kassaProductList;
                productDatalistKassa.DataSource = productListSource;
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (productDatalistKassa.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistKassa.SelectedRows[0].DataBoundItem;
            using (AmountForm antal = new AmountForm())
            {
                if (antal.ShowDialog() == DialogResult.OK)
                {
                    if(int.Parse(antal.amount2) > product.status)
                    {
                        MessageBox.Show("Ogiltig mängd vald!");
                    }
                    else
                    {
                        productListSource.Clear();
                        kassaProductList = new BindingList<ProductList>(backend.loadList());
                        productListSource.DataSource = kassaProductList;
                        productDatalistKassa.DataSource = productListSource;
                        product.status = product.status - int.Parse(antal.amount2); //updates the product status
                       
                        //adds the product to the basket
                        List<ProductList> newlist;
                        newlist = new List<ProductList>
                        {
                       new ProductList {id = product.id, name = product.name,
                        price= product.price,type=product.type,author=product.author, genre = product.genre,
                        format= product.format, language= product.language, platform= product.platform, playtime= product.playtime, status = int.Parse(antal.amount2)}
                        }; 
                        vagnlist.AddRange(newlist);
                    }
                }

            }
        }
    }
}
