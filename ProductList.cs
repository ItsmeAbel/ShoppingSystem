namespace ShoppingSystem
{
    public class ProductList
    {
       /* public ProductList(int iid, string nname, int pprice, string ttype, string aauthor,
            string ggenre, string fformat, string llanguage, string pplatform, int pplaytime)
        {
            id = iid;
            name = nname;
            price = pprice;
            type = ttype;
            author = aauthor;
            genre = ggenre;
            format = fformat;
            language = llanguage;
            platform = pplatform;
            playtime = pplaytime;
        }*/

        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
        public int playtime { get; set; }

    }
}