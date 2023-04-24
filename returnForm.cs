using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ShoppingSystem
{
    public partial class returnForm : Form
    {
        //List<ProductList> productlist;
        BackendPart backend = new BackendPart();

        List<ProductList> biglist; //used for the main list returened from the backend
        BindingList<ProductList> vagnProductList;
        BindingSource vagnproductListSource;

        private System.Drawing.Printing.PrintDocument document =
        new System.Drawing.Printing.PrintDocument();
        public returnForm(List<ProductList> plist)
        {
            InitializeComponent();
            vagnProductList = new BindingList<ProductList>(plist);
            vagnproductListSource = new BindingSource();
            vagnproductListSource.DataSource = vagnProductList;
            returnFormGridView.DataSource = vagnproductListSource;

            biglist = backend.loadList(); //loads the csv data into the list
        }


        private void ProduktLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //user cancels purchase
        private void KVRemoveButton_Click(object sender, EventArgs e)
        {
            vagnProductList.Clear();
            this.Close();
        }

        //vid tryck av "visa kvitto..." knapp
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (vagnProductList.Count != 0)
            {
                OpenFileDialog fileopener = new OpenFileDialog();
                fileopener.Filter = "Pdf kvitto (.pdf)|*.pdf";
                fileopener.Title = "Välj Kvitto...";

                if (fileopener.ShowDialog() == DialogResult.OK)
                {

                    foreach (var item in vagnProductList)
                    {
                        var result = from r in biglist where r.id == item.id select r; //find item with matching id
                        result.First().status = result.First().status + item.status; //subtract from the status
                    }

                    backend.saveToCSV(biglist); //saves new list into the csv
                    vagnproductListSource.Clear();
                    vagnProductList.Clear();
                    DialogResult = DialogResult.OK; //returns ok



                }
            }


        }


        //hantering av celler
        private void kundvagndataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value != null && e.Value.ToString() == "")
            {
                e.CellStyle.BackColor = Color.Gray;
            }
            if (e.Value != null && e.Value.ToString() == "0")
            {
                e.Value = "Slut";
            }
        }
    }
}
