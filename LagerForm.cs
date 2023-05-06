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
using System.Threading;

namespace ShoppingSystem
{
    public partial class LagerForm : Form
    {
        BackendPart backend = new BackendPart();

        BindingList<ProductList> lagerProductList;
        BindingSource productListSource;

        //temprary variables for stoing elements from the xml data
        int tempId;
        int tempPrice;
        int tempStock;
        string tempName;
        string tempType;
        string tempAuthor;
        string tempPlatform;
        string tempGenre;
        string tempFormat;
        string tempLanguage;
        string tempPlaytime;

        List<ProductList> centralagerList;
        List<log> lagerlog; //list to store the log data

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

            lagerlog = new List<log>(backend.returnLog()); //initalize the log list

            centralagerList = new List<ProductList>();
            updateTimer.Start(); //starts timer
      
            // Console.ReadKey();
        }

        //"stäng" button
        private void ContinueButtton_Click(object sender, EventArgs e)
        {
            backend.saveToCSV(lagerProductList); //sends list to backend to be saved
            updateTimer.Stop(); //stops timer
            this.Close();
        }

        //"Grossit" knappen som används för att fylla på ett produkt
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

        //används för att lägga till nytt produkt
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

        //"ta bort" knappen som används för att tar bort produkt
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

        //"Hämta data" button used for downloading data from central stock
        private void updateButton_Click(object sender, EventArgs e)
        {
            httpgetz();
            saveLog();
        }

        //"Synkronisera" button to update the central stock
        private void uploadButton_Click(object sender, EventArgs e)
        {
            _ = httpput();
        }


        //gets API data from the central and updates the local stock
        private void httpgetz()
        {
            WebClient client = new WebClient();
            string text;
            try
            {
                text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api"); //downloads data from the api into a string
            }
            catch
            {
                text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/?action=error"); //downloads error data instead
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text); //loads the string into an xml doc

            int numChildElements = doc.ChildNodes
                            .OfType<XmlElement>()
                            .Count();
            Console.WriteLine(numChildElements);

            foreach (XmlElement elem in doc.FirstChild.ChildNodes) //goes through each father node
            {
                //triggers if the contents of the string are from the error api
                if (elem.Name == "error") //if the node has the name "error"
                {
                    MessageBox.Show(this, elem.InnerText, "Error"); //display it's contentns
                }
                //triggers if the actual api has been downloaded without issues
                else if (elem.Name == "metadata") // if the node has the name "metadata"
                {
                    foreach (XmlElement mdata in elem.ChildNodes) //loops through each child node of metadata
                    {

                        if (mdata.Name == "lastseed")
                        {
                            //does something
                        }
                        else if (mdata.Name == "lastupdate") //if child node name is lastupdate
                        {
                            lastUpdateLabel.Text = mdata.InnerText; //get update time
                            //SetText(mdata.InnerText.ToString());
                            Console.WriteLine(mdata.InnerText);
                        }


                    }
                }
                else if (elem.Name == "products") //if the node is products
                {
                    foreach (XmlElement prod in elem.ChildNodes) //loops throught each child node in "products"
                    {
                        //resets the variables
                        tempPrice = 0;
                        tempStock = 0;
                        tempName = "";
                        tempType = "";
                        tempAuthor = "";
                        tempPlatform = "";
                        tempGenre = "";
                        tempFormat = "";
                        tempLanguage = "";
                        tempPlaytime = "";

                        foreach (XmlElement belem in prod.ChildNodes) //loops through each child node in "book"
                        {

                            if (belem.Name == "id") //if child name is "id"
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
                            else if (belem.Name == "name")
                            {
                                tempName = belem.InnerText;
                            }
                            else if (belem.Name == "type")
                            {
                                tempType = belem.InnerText;
                            }
                            else if (belem.Name == "author")
                            {
                                tempAuthor = belem.InnerText;

                            }
                            else if (belem.Name == "genre")
                            {
                                tempGenre = belem.InnerText;
                            }
                            else if (belem.Name == "format")
                            {
                                tempFormat = belem.InnerText;
                            }
                            else if (belem.Name == "language")
                            {
                                tempLanguage = belem.InnerText;
                            }
                            else if (belem.Name == "platform")
                            {
                                tempPlatform = belem.InnerText;
                            }
                            else if (belem.Name == "playtime")
                            {
                                tempPlaytime = belem.InnerText;
                            }

                            if (backend.idcheck(tempId) == true) //checks if the product with the id already exists in the local stock
                            {
                                //updates the attributes of the product in the local stock 
                                int indexx = lagerProductList.IndexOf(lagerProductList.FirstOrDefault(item => item.id == tempId));
                                lagerProductList[indexx].price = tempPrice;
                                lagerProductList[indexx].status = tempStock;
                                lagerProductList[indexx].name = tempName;
                                lagerProductList[indexx].type = tempType;
                                lagerProductList[indexx].author = tempAuthor;
                                lagerProductList[indexx].platform = tempPlatform;
                                lagerProductList[indexx].playtime = tempPlaytime;
                                lagerProductList[indexx].language = tempLanguage;
                                lagerProductList[indexx].genre = tempGenre;
                                lagerProductList[indexx].format = tempFormat;

                                

                                productListSource.ResetBindings(false); //refreshes the data grid
                                backend.saveToCSV(lagerProductList); //saves the new list as a csv file


                            }
                            else if (backend.idcheck(tempId) == false) // if a product with the id doesn't exist
                            {
                                //gets item id
                                int indexx = lagerProductList.IndexOf(lagerProductList.FirstOrDefault(item => item.id == tempId)); 
                                //adds a new item to the list
                                lagerProductList.Add(new ProductList()
                                {
                                    id = tempId,
                                    name = tempName,
                                    price = tempPrice,
                                    type = tempType,
                                    author = tempAuthor,
                                    genre = tempGenre,
                                    format = tempFormat,
                                    language = tempLanguage,
                                    platform = tempPlatform,
                                    playtime = tempPlaytime,
                                    status = tempStock
                                });
                                productListSource.ResetBindings(false); //refreshes the data grid
                                backend.saveToCSV(lagerProductList); //saves the new list as a csv file

                            }
                        }
                    }
                }
            }
        }
        
        //updates data in the api
        private async Task httpput()
        {
            foreach (var item in lagerProductList)
            {
                try
                {
                    string url = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={item.id}&stock={item.status}";
                    Console.WriteLine(url);

                    var client = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Post, url);
                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
                catch
                {
                    Console.WriteLine("Error in httpput");
                }
            }
        }

        //method for timer. ticks once every method. timer is in the designer
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                httpgetz(); //get api data
                saveLog();  //save data to log
                updateTimer.Start(); //starts the timer
            }
            catch
            {
                notificationThread.Start();
                updateTimer.Start();
            }

        }
        // Create a new thread for the notification process
        Thread notificationThread = new Thread(() =>
        {
            MessageBox.Show("Något är fel med timer, vänligen kontrollera!");
        });
        
        //saves log
        private void saveLog()
        {
            backend.saveToCSV(lagerProductList);
            lagerlog = backend.returnLog();
            DateTime now = DateTime.Now; // Get the current date and time
            string datenow = now.ToString("HH:mm:ss");
            foreach (var item in lagerProductList)
            {
                lagerlog.Add(new log { date = datenow, id = item.id, price = item.price, status = item.status });
            }

            backend.saveToLog(lagerlog);
        }

        //history button
        private void showHistory_Click(object sender, EventArgs e)
        {
            lagerlog = backend.returnLog();
            if (productDatalistLager.SelectedRows.Count < 1) 
                return;
            var product = (ProductList)productDatalistLager.SelectedRows[0].DataBoundItem; //den valda produkten
            historyChart histochart = new historyChart(lagerlog, product); //opens graph form. sends loglist and product to the form
            histochart.Show();
        }
    }
}
