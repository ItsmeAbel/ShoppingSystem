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
    public partial class KundVagn : Form
    {
        //List<ProductList> productlist;
        BackendPart backend = new BackendPart();

        List<ProductList> biglist;
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


            biglist = backend.loadList();
        }


        private void ProduktLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KVRemoveButton_Click(object sender, EventArgs e)
        {
            vagnProductList.Clear();
            this.Close();
        }

        //vid tryck av försätt vidare knapp
        private void ContinueButton_Click(object sender, EventArgs e)
        {

            foreach (var item in vagnProductList)
            {
                var result = from r in biglist where r.id == item.id select r;
                result.First().status = result.First().status - item.status;
            }
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(document_PrintPage);
            printDocument.DocumentName = "Kvitto";
            printDocument.Print();

            backend.saveToCSV(biglist);
            vagnproductListSource.Clear();
            vagnProductList.Clear();
            DialogResult = DialogResult.OK;
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 20;
            foreach (ProductList item in biglist)
            {
                e.Graphics.DrawString(item.name, new Font("Arial", 14), Brushes.Black, 20, y);
                e.Graphics.DrawString(item.price.ToString(), new Font("Arial", 14), Brushes.Black, 250, y);
                e.Graphics.DrawString(item.type, new Font("Arial", 14), Brushes.Black, 220, y);
                e.Graphics.DrawString(item.author, new Font("Arial", 14), Brushes.Black, 320, y);
                e.Graphics.DrawString(item.genre, new Font("Arial", 14), Brushes.Black, 420, y);
                e.Graphics.DrawString(item.format, new Font("Arial", 14), Brushes.Black, 520, y);
                e.Graphics.DrawString(item.language, new Font("Arial", 14), Brushes.Black, 620, y);
                e.Graphics.DrawString(item.platform, new Font("Arial", 14), Brushes.Black, 720, y);
                y += 20;
            }
        }
    }
}
