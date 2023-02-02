using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;


namespace ShoppingSystem
{
    class BackendPart
    {

        List<ProductList> productlist;

        //string currDir = Directory.GetCurrentDirectory();
        string path = Path.Combine(Directory.GetCurrentDirectory(), @"\products.csv");
        //string relativepath = @"..\..\..\..\..\products.csv";
        public BackendPart()
        {
            
            productlist = new List<ProductList>();

        }

        public List<ProductList> loadList()
        {
            Console.WriteLine("The path is" + Directory.GetCurrentDirectory());
            using (var reader = new StreamReader(Directory.GetCurrentDirectory() + "\\products.csv")) //Easy solution for a relative path. Can't beleve i spent 2 hours on this just to find out this is the solution. smh
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    productlist = csv.GetRecords<ProductList>().ToList();

                }
                return productlist;
            

        }

        public void addToBasket(int iid, string nname, int pprice, 
            string ttype, string aauthor,string ggenre, string fformat,
            string llanguage, string pplatform, int pplaytime)
        {

            /* ProductList newlist= new ProductList(iid, nname, pprice, ttype, aauthor, 
                 ggenre, fformat, llanguage, pplatform, pplaytime);
             //we need to create a new list with the items...
             //...and append the new list to the already existing one


             productlist.Add(newlist);*/

            List<ProductList> newlist;
            newlist = new List<ProductList>
           {

               new ProductList {id= iid, name = nname,
                price= pprice,type=ttype,author=aauthor, genre = ggenre,
                format= fformat, language= llanguage, platform= pplatform, playtime= pplaytime}
           };

            productlist.AddRange(newlist);
            //saveToCSV(newlist);
            
            
            /*
            var writer = new StreamWriter("products.csv");
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(productlist);*/
        }

        public bool idcheck(int idd)  //kollar ifall varunummret redan finns
        {
            loadList();
            if(productlist.Exists((x => x.id == idd)) == true) 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        public void saveToCSV(IEnumerable<ProductList> templist)
        {
            //saves the whole list into a csv file
                //was trying to append the list before, which didn't work. Solved it by the saving the whole file into the list instead
            using (var stream = new StreamWriter("products.csv"))
            using (var csv = new CsvWriter(stream, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(templist);
            }

        }

    }
}
