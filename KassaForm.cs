using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoppingSystem
{
    public partial class KassaForm : Form
    {
        //private int returncheck = 0;

        List<ProductList> vagnlist; //list for the shopping cart
        List<ProductList> returnlist;

        BackendPart backend = new BackendPart();
        BindingList<ProductList> kassaProductList;
        BindingSource productListSource;

        List<log> kassalog;
        
        public KassaForm()
        {
            InitializeComponent();
            vagnlist = new List<ProductList>();
            returnlist = new List<ProductList>();
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
            searchComboBox.SelectedItem = "id"; //default pick for the dropdown menu for the search

            kassalog = backend.returnLog();
        }


        //opens the shopping cart
        private void button2_Click(object sender, EventArgs e)
        {  
            KundVagn vagnform = new KundVagn(vagnlist); //sends the new list to form as a parameter
            vagnform.StartPosition = FormStartPosition.CenterParent;
            //vagnform.Show();
            if (vagnform.ShowDialog() == DialogResult.OK)
            {
                //backend.saveToCSV(kassaProductList);
                productListSource.ResetBindings(false); //user has purchased items, update status
            }
            else
            {
                //returncheck = 1;
                productListSource.Clear();
                kassaProductList = new BindingList<ProductList>(backend.loadList());
                productListSource.DataSource = kassaProductList;
                productDatalistKassa.DataSource = productListSource;
                productDatalistKassa.BackgroundColor = Color.Black;
            }
            productListSource.ResetBindings(false);
            
        }

        //användaren lägger ett vara in i kundkorgen
        private void Add_Click(object sender, EventArgs e)
        {

            if (productDatalistKassa.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistKassa.SelectedRows[0].DataBoundItem; //varan användaren vill köpa

            //kollar om produkten är slut
            if (product.status == 0)
            {
                MessageBox.Show("Produkt slut!");
            }
            else
            {
                AmountPicker antal = new AmountPicker(); //väljer antal
                
                antal.StartPosition = FormStartPosition.CenterParent;
                antal.ShowDialog();
                using (antal)
                {
                    if (antal.DialogResult == DialogResult.OK)
                    {
                        if (int.Parse(antal.amount2) == 0)
                        {
                            MessageBox.Show("Inga antal vald!");
                        }
                        else if (int.Parse(antal.amount2) > product.status)
                        {
                            MessageBox.Show("Ogiltig mängd vald!");
                        }
                        else
                        {
                            MessageBox.Show("Produkt lagt i korgen!");
                            product.status = product.status - int.Parse(antal.amount2); //updates the product status
                            productListSource.ResetBindings(false); //updaterar listan
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
                        productListSource.ResetBindings(false);
                    }
                }
            }

        }

        //hantering av celler
        private void productDatalistKassa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.DarkSlateBlue;
            if (e.Value != null && e.Value.ToString() == "")
            {
                e.CellStyle.BackColor = Color.Gray; //tomma celler får grå bakgrund
            }
            if (e.Value != null && e.Value.ToString() == "0")
            {
                e.Value = "Slut"; //står "slut" om status är 0
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //används för sökning av produkt
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var columnPick = searchComboBox.Text; //picked attribute
                Console.WriteLine(columnPick);
                string lowerSearch = searchTextBox.Text.ToLower(); //changes text to lowercase. Makes sure it's not case sensetive
                BindingList<ProductList> filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.id.ToString().Contains(lowerSearch)).ToList()); //creates a new temporary list that matches the search

                //sorry for nesting. couldn't finding a better way
                if (columnPick == "id")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.id.ToString().Contains(lowerSearch)).ToList());

                }
                else if (columnPick == "name")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.name.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "price")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.price.ToString().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "type")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.type.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "author")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.author.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "genre")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.genre.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "format")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.format.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "language")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.language.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "platform")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.platform.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "playtime")
                {
                    filteredList = new BindingList<ProductList>(kassaProductList.Where(obj => obj.playtime.ToString().Contains(lowerSearch)).ToList());
                }
                else
                {

                }

                //productListSource.Filter = string.Format("{0}='{1}'","name",searchTextBox.Text);

                productDatalistKassa.DataSource = filteredList;
                productListSource.ResetBindings(false);

            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (productDatalistKassa.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistKassa.SelectedRows[0].DataBoundItem; //varan användaren vill köpa

            AmountPicker returnantal = new AmountPicker(); //väljer antal

            returnantal.StartPosition = FormStartPosition.CenterParent;
            returnantal.ShowDialog();
            using (returnantal)
            {
                if (returnantal.DialogResult == DialogResult.OK)
                {
                    if (int.Parse(returnantal.amount2) == 0)
                    {
                        MessageBox.Show("Inga antal vald!");
                    }
                    else
                    {
                        MessageBox.Show("Produkt lagt i returlistan!");
                        // product.status = product.status - int.Parse(antal.amount2); //updates the product status
                        productListSource.ResetBindings(false); //updaterar listan
                                                                //adds the product to the basket
                        List<ProductList> newlist;
                        newlist = new List<ProductList>
                        {
                       new ProductList {id = product.id, name = product.name,
                        price= product.price,type=product.type,author=product.author, genre = product.genre,
                        format= product.format, language= product.language, platform= product.platform, playtime= product.playtime, status = int.Parse(returnantal.amount2)}
                        };
                        returnlist.AddRange(newlist);
                    }
                    productListSource.ResetBindings(false);
                }
            }
        }

        //used for returning items
        private void button1_Click(object sender, EventArgs e)
        {
            returnForm retrnform = new returnForm(returnlist); //sends the new list to form as a parameter
            retrnform.StartPosition = FormStartPosition.CenterParent;
            //vagnform.Show();
            if (retrnform.ShowDialog() == DialogResult.OK)
            {
                productListSource.Clear();
                kassaProductList = new BindingList<ProductList>(backend.loadList());
                productListSource.DataSource = kassaProductList;
                productDatalistKassa.DataSource = productListSource;
                productDatalistKassa.BackgroundColor = Color.Black;
            }
            else
            {
            }
            productListSource.ResetBindings(false);
        }

        private void kassaHistoryButton_Click(object sender, EventArgs e)
        {
            foreach (var item in backend.returnLog())
            {
                Console.WriteLine(item.date + item.id);
            }

            if (productDatalistKassa.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistKassa.SelectedRows[0].DataBoundItem; //den valda produkten
            historyChart histochart = new historyChart(kassalog, product);
            histochart.Show();
        }
    }
}
