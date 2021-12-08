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
        public BackendPart()
        {

        }

        public List<ProductList> loadList()
        {
            
            using (var reader = new StreamReader("products.csv")) //Easy solution for a relative path. Can't beleve i spent 2 hours on this just to find out this is the solution. smh
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
            //we need to create a new list with the items...
            //...and append the new list to the already existing one

            productlist = new List<ProductList>
           {

               new ProductList {id= iid, name = nname,
                price= pprice,type=ttype,author=aauthor, genre = ggenre,
                format= fformat, language= llanguage, platform= pplatform, playtime= pplaytime}
           };

            // Append to the file.
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };

            using (var stream = File.Open("products.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(productlist);
            }
            /*
            var writer = new StreamWriter("products.csv");
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(productlist);*/
        }


    }
}
