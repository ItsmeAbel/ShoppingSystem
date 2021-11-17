using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;


namespace ShoppingSystem
{
    class BackendPart
    {
        public BackendPart()
        {

        }

        public List<ProductList> loadList()
        {
            List<ProductList> productlist;
            using (var reader = new StreamReader(@"C:\Users\abelg\source\repos\ShoppingSystem\products.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                productlist = csv.GetRecords<ProductList>().ToList();

            }
            return productlist;
        }
        public List<ProductList> addToBasket()
        {
            List<ProductList> productlist;
            using (var reader = new StreamReader(@"C:\Users\abelg\source\repos\ShoppingSystem\products.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                productlist = csv.GetRecords<ProductList>().ToList();

            }
            
            return productlist;
        }


    }
}
