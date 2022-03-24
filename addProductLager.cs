using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSystem
{
    public partial class addProductLager : Form
    {
        internal ProductList plist { get; private set; }
        public addProductLager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plist = new ProductList();
            plist.id = Int32.Parse(IDTextBox.Text);
            plist.name = IDTextBox.Text;
            plist.price = Int32.Parse(PriceTextBox.Text);
            plist.type = TypeTextBox.Text;
            plist.author = AuthorTextBox.Text;
            plist.genre = GenreTextBox.Text;
            plist.format = FormatTextBox.Text;
            plist.language = LanguageTextBox.Text;
            plist.platform = PlatformTextBox.Text;
            plist.playtime = Int32.Parse(PlaytimeTextBox.Text);
            plist.status = Int32.Parse(StatusTextBox.Text);

           /* backend.addToBasket(Int32.Parse(IDTextBox.Text), NameTextBox.Text, Int32.Parse(PriceTextBox.Text), TypeTextBox.Text,
            AuthorTextBox.Text, GenreTextBox.Text, FormatTextBox.Text,
                LanguageTextBox.Text, PlatformTextBox.Text, Int32.Parse(PlaytimeTextBox.Text));*/
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LagerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
