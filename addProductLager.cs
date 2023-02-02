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
            try
            {
                plist.name = NameTextBox.Text;
                plist.type = TypeTextBox.Text;
                plist.author = AuthorTextBox.Text;
                plist.genre = GenreTextBox.Text;
                plist.format = FormatTextBox.Text;
                plist.language = LanguageTextBox.Text;
                plist.platform = PlatformTextBox.Text;

                plist.id = Int32.Parse(IDTextBox.Text);
                plist.price = Int32.Parse(PriceTextBox.Text);
                plist.playtime = Int32.Parse(PlaytimeTextBox.Text);
                plist.status = Int32.Parse(StatusTextBox.Text);
                if (plist.id != Math.Abs(plist.id) || plist.price != Math.Abs(plist.price) 
                    || plist.playtime != Math.Abs(plist.price) || plist.status != Math.Abs(plist.price)) //jämför värden med dess absolut värde för att avgöra om talen innehåller negativa tal
                {
                    DialogResult = DialogResult.No;
                }
                else if (plist.type.Any(char.IsDigit) || plist.name.Any(char.IsDigit)
                        || plist.author.Any(char.IsDigit) || plist.genre.Any(char.IsDigit)
                        || plist.format.Any(char.IsDigit) || plist.language.Any(char.IsDigit) || plist.platform.Any(char.IsDigit)) //kollar ifall någon av string variabeln innehåller tal
                {
                    DialogResult = DialogResult.No;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
                    
            }
            catch
            {
                DialogResult = DialogResult.Cancel;

            }
            


            
           /* backend.addToBasket(Int32.Parse(IDTextBox.Text), NameTextBox.Text, Int32.Parse(PriceTextBox.Text), TypeTextBox.Text,
            AuthorTextBox.Text, GenreTextBox.Text, FormatTextBox.Text,
                LanguageTextBox.Text, PlatformTextBox.Text, Int32.Parse(PlaytimeTextBox.Text));*/

            
            Close();
        }

        private void LagerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
