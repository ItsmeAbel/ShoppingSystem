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
        BackendPart backend = new BackendPart();
        public addProductLager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backend.addToBasket(Int32.Parse(IDTextBox.Text), NameTextBox.Text, Int32.Parse(PriceTextBox.Text), TypeTextBox.Text,
            AuthorTextBox.Text, GenreTextBox.Text, FormatTextBox.Text,
                LanguageTextBox.Text, PlatformTextBox.Text, Int32.Parse(PlaytimeTextBox.Text));
        }
    }
}
