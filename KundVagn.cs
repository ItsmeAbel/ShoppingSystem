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
using System.Net.Http;

namespace ShoppingSystem
{
    public partial class KundVagn : Form
    {
        //List<ProductList> productlist;
        BackendPart backend = new BackendPart();

        List<ProductList> biglist; //used for the main list returened from the backend
        List<ProductList> printlist; //temp list used for recipt
        BindingList<ProductList> vagnProductList;
        BindingSource vagnproductListSource;

        private System.Drawing.Printing.PrintDocument document =
        new System.Drawing.Printing.PrintDocument();
        public KundVagn(List<ProductList> plist)
        {
            InitializeComponent();
            vagnProductList = new BindingList<ProductList>(plist);
            vagnproductListSource = new BindingSource();
            vagnproductListSource.DataSource = vagnProductList;
            kundvagndataGridView.DataSource = vagnproductListSource;

            biglist = backend.loadList(); //loads the csv data into the list
            printlist = plist;
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

        //vid tryck av "försätt vidare" knapp
        private void ContinueButton_Click(object sender, EventArgs e)
        {

            foreach (var item in vagnProductList)
            {
                var result = from r in biglist where r.id == item.id select r; //find item with matching id
                result.First().status = result.First().status - item.status; //subtract from the status

                _ = httpput(item.id, result.First().status); //updates the stock of the product with the id
                //_ return value is immideatly discared as it serves no other purpose
            }
            //prints out a recipt
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(document_PrintPage);
            printDocument.DocumentName = "Kvitto";
            printDocument.Print();

            backend.saveToCSV(biglist); //saves new list into the csv
            vagnproductListSource.Clear();
            vagnProductList.Clear();
            DialogResult = DialogResult.OK; //returns ok
        }

        //method to update api data
        private async Task httpput(int iid, int sstatus)
        {
            try
            {
                string url = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={iid}&stock={sstatus}";
                Console.WriteLine(url);

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                MessageBox.Show(await response.Content.ReadAsStringAsync());
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            catch
            {


            }

        }

        //prints into pdf
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 20;
            foreach (ProductList item in printlist)
            {
                e.Graphics.DrawString(item.name, new Font("Arial", 14), Brushes.Black, 20, y);
                e.Graphics.DrawString(item.price.ToString(), new Font("Arial", 14), Brushes.Black, 250, y);
                e.Graphics.DrawString(item.type, new Font("Arial", 14), Brushes.Black, 320, y);
                e.Graphics.DrawString(item.author, new Font("Arial", 14), Brushes.Black, 420, y);
                e.Graphics.DrawString(item.genre, new Font("Arial", 14), Brushes.Black, 520, y);
                y += 20;
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
