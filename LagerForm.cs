using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            try
            {
                lagerProductList = new BindingList<ProductList>(backend.loadList());

            }
            catch
            {

            }
            productListSource = new BindingSource();
            productListSource.DataSource = lagerProductList;
            productDatalistLager.DataSource = productListSource;
            //productDatalistLager.ForeColor = System.Drawing.Color.Red;
            searchComboBox.SelectedItem = "id"; //default pick for the dropdown menu for the search
        }

        private void ContinueButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //används för att fylla på ett produkt
        private void button1_Click(object sender, EventArgs e)
        {
            if (productDatalistLager.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistLager.SelectedRows[0].DataBoundItem;
            AmountPicker grossit = new AmountPicker();
            grossit.StartPosition = FormStartPosition.CenterParent;
            //grossit.Show();
            using (AmountPicker antal = new AmountPicker())
            {
                if (grossit.ShowDialog() == DialogResult.OK)
                {
                    product.status = product.status + int.Parse(grossit.amount2);
                    backend.saveToCSV(lagerProductList);
                    productListSource.ResetBindings(false); //updates the list
                }

            }
        }

        //används för att lägga ett nytt vara
        private void addToLagerButton_Click(object sender, EventArgs e)
        {
            //ps. had a try catch here
                addProductLager form = new addProductLager();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    Console.WriteLine("{0}", backend.idcheck(form.plist.id));
                    if (backend.idcheck(form.plist.id) == true)
                    {
                        MessageBox.Show("ID redan finns, vänligen ange rätt ID nummer!");
                    }
                    else
                    {
                        productListSource.Add(form.plist);
                        backend.saveToCSV(lagerProductList);
                    }

                }
                else if (form.DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Något stämmer ej!");
                }
                else
                {
                    

                }

            form.Dispose();


            
            //updateList();
        }

        //tar bort ett vara
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (productDatalistLager.SelectedRows.Count < 1)
                return;
            var product = (ProductList)productDatalistLager.SelectedRows[0].DataBoundItem; //den valda produkten
            if(product.status == 0) //om produkten är slut
            {
                productListSource.Remove(product); //ta bort den
                backend.saveToCSV(lagerProductList);
            }
            else { //om produk ej slut
                DialogResult dialogResult = MessageBox.Show("Vill du verkligen ta bort varan?", "Varan finns i lager!", MessageBoxButtons.YesNo); //visa varning
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

        //sets empty cells to gray
        private void productDatalistLager_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.DarkSlateBlue;
            if (e.Value != null && e.Value.ToString() == "") //tomma celler får grå bakgrund
            {
                e.CellStyle.BackColor = Color.Gray;
            }
            if (e.Value != null && e.Value.ToString() == "0") //om status är 0 skriv "slut" istället
            {
                e.Value = "Slut";
            }
        }

        //används för sökning av produkt
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var columnPick = searchComboBox.Text;
                Console.WriteLine(columnPick);
                string lowerSearch = searchTextBox.Text.ToLower();
                BindingList<ProductList> filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.id.ToString().Contains(lowerSearch)).ToList());

                //sorry for nesting. couldn't finding a better way
                if (columnPick == "id")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.id.ToString().Contains(lowerSearch)).ToList());

                }
                else if (columnPick == "name")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.name.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "price")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.price.ToString().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "type")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.type.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "author")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.author.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "genre")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.genre.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "format")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.format.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "language")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.language.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "platform")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.platform.ToLower().Contains(lowerSearch)).ToList());
                }
                else if (columnPick == "playtime")
                {
                    filteredList = new BindingList<ProductList>(lagerProductList.Where(obj => obj.playtime.ToString().Contains(lowerSearch)).ToList());
                }
                else
                {

                }


                //productListSource.Filter = string.Format("{0}='{1}'","name",searchTextBox.Text);

                productDatalistLager.DataSource = filteredList;
                productListSource.ResetBindings(false);
            }
        }
    }
}
