using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Timers;

namespace ShoppingSystem
{
    public partial class LagerForm : Form
    {
        BackendPart backend = new BackendPart();

        BindingList<ProductList> lagerProductList;
        BindingSource productListSource;

        int tempId;
        int tempPrice;
        int tempStock; 
        List<ProductList> centralagerList;
        private static System.Threading.Timer aTimer;
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

            centralagerList = new List<ProductList>();
            updateTimer.Start();
      
            // Console.ReadKey();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now; // Get the current date and time
            string date = now.ToString("d");
            // Your task goes here
            Console.WriteLine("Task executed at: " + date);

        }

        private void ContinueButtton_Click(object sender, EventArgs e)
        {
            backend.saveToCSV(lagerProductList);
            updateTimer.Stop();
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            httpgetz();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            _ = httpput();
        }

        private void httpgetz()
        {
            WebClient client = new WebClient();
            string text;
            try
            {
                text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
            }
            catch
            {
                text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/?action=error");
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);

            int numChildElements = doc.ChildNodes
                            .OfType<XmlElement>()
                            .Count();
            Console.WriteLine(numChildElements);

            foreach (XmlElement elem in doc.FirstChild.ChildNodes)
            {
                //Console.WriteLine(elem.InnerXml + "\n");
                if (elem.Name == "error")
                {
                    MessageBox.Show(this, elem.InnerText, "Error");
                }
                else if (elem.Name == "metadata")
                {
                    foreach (XmlElement mdata in elem.ChildNodes)
                    {

                        if (mdata.Name == "lastseed")
                        {

                        }
                        else if (mdata.Name == "lastupdate")
                        {
                            lastUpdateLabel.Text = mdata.InnerText;
                            //SetText(mdata.InnerText.ToString());
                            Console.WriteLine(mdata.InnerText);
                        }


                    }
                }
                else if (elem.Name == "products")
                {
                    foreach (XmlElement prod in elem.ChildNodes)
                    {
                        foreach (XmlElement belem in prod.ChildNodes)
                        {

                            if (belem.Name == "id")
                            {
                                tempId = Int32.Parse(belem.InnerText);
                                Console.WriteLine(tempId);
                                //centralagerList.Add(new ProductList { });
                            }
                            else if (belem.Name == "price")
                            {

                                tempPrice = Int32.Parse(belem.InnerText);
                                Console.WriteLine(tempPrice);
                            }
                            else if (belem.Name == "stock")
                            {
                                tempStock = Int32.Parse(belem.InnerText);
                                Console.WriteLine(tempStock);
                            }

                            if (backend.idcheck(tempId) == true)
                            {
                                int indexx = lagerProductList.IndexOf(lagerProductList.FirstOrDefault(item => item.id == tempId));
                                lagerProductList[indexx].price = tempPrice;
                                lagerProductList[indexx].status = tempStock;

                                productListSource.ResetBindings(false);
                                
                            }
                            else if (backend.idcheck(tempId) == false)
                            {
                                int indexx = lagerProductList.IndexOf(lagerProductList.FirstOrDefault(item => item.id == tempId));

                                lagerProductList.Add(new ProductList()
                                {
                                    id = tempId,
                                    name = "new item",
                                    price = tempPrice,
                                    type = "new item",
                                    author = "new item ",
                                    genre = "new item",
                                    format = "new item",
                                    language = "new item",
                                    platform = "new item",
                                    playtime = "new item",
                                    status = tempStock
                                });
                                productListSource.ResetBindings(false);
                            }


                        }




                    }
                }


            }


        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lastUpdateLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lastUpdateLabel.Text = text;
            }
        }
        private async Task httpput()
        {
            foreach (var item in lagerProductList)
            {
                string url = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={item.id}&stock={item.status}";
                Console.WriteLine(url);

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            httpgetz();
            updateTimer.Start();
        }
    }
}
