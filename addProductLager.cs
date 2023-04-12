using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoppingSystem
{
    public partial class addProductLager : Form
    {
        int validator = 0;
        bool notNum;
        private ErrorProvider errorProvider1;
        internal ProductList plist { get; private set; }
        public addProductLager()
        {
            InitializeComponent();
            plist = new ProductList();
            errorProvider1 = new ErrorProvider();
            errorProvider1.ContainerControl = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //plist = new ProductList();
            try
            {
                
                plist.type = TypeTextBox.Text;
                plist.author = AuthorTextBox.Text;
                plist.genre = GenreTextBox.Text;
                plist.format = FormatTextBox.Text;
                plist.language = LanguageTextBox.Text;
                plist.platform = PlatformTextBox.Text;

                plist.id = Int32.Parse(IDTextBox.Text);
                plist.price = Int32.Parse(PriceTextBox.Text);
                
                    if (plist.price != Math.Abs(plist.price))
                    {
                    validator += 1;
                    }

                if (!String.IsNullOrEmpty(PlaytimeTextBox.Text))
                {
                    if(Int32.Parse(PlaytimeTextBox.Text) != Math.Abs(Int32.Parse(PlaytimeTextBox.Text))){
                        validator +=1;
                    }
                    else
                    {
                        plist.playtime = PlaytimeTextBox.Text;
                    }
                }

                if (string.IsNullOrEmpty(StatusTextBox.Text.ToString())) {//tostring() is crucial. program throws exception otherwise
                    plist.status = 0;

                }
                else
                {
                    plist.status = Int32.Parse(StatusTextBox.Text);
                }

                if (String.IsNullOrWhiteSpace(NameTextBox.Text.ToString()))
                {
                    validator += 1;
                }
                else
                {
                    plist.name = NameTextBox.Text;
                }

                if (validator == 0)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.No;
                }

                this.Close();


            }
            catch
            {
                DialogResult = DialogResult.No;
                Console.WriteLine("ooga booga");
                this.Close();
            }
           /* backend.addToBasket(Int32.Parse(IDTextBox.Text), NameTextBox.Text, Int32.Parse(PriceTextBox.Text), TypeTextBox.Text,
            AuthorTextBox.Text, GenreTextBox.Text, FormatTextBox.Text,
                LanguageTextBox.Text, PlatformTextBox.Text, Int32.Parse(PlaytimeTextBox.Text));*/

            
        }

        private void LagerCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = PriceTextBox.Text;
            foreach (char c in tempstring)
            {
                if (!char.IsDigit(c))
                {
                    notNum =true;
                }
            }
    
            if(notNum && !String.IsNullOrEmpty(PriceTextBox.Text.ToString())){
                
                MessageBox.Show("Inga boskstäver!");
                PriceTextBox.Text = "";
                notNum = false;
            }
        }

        private void LagerAddButton_Validating(object sender, CancelEventArgs e)
        {

        }


        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = GenreTextBox.Text;
            foreach (char c in tempstring)
            {
                if (char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(GenreTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga siffror!");
                GenreTextBox.Text = "";
                notNum = false;
            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = IDTextBox.Text;
            foreach (char c in tempstring)
            {
                if (!char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(IDTextBox.Text.ToString()))
            {

                MessageBox.Show("Endast Siffror!");
                IDTextBox.Text = "";
                notNum = false;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = NameTextBox.Text;
            foreach (char c in tempstring)
            {
                if (char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(NameTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga siffror!");
                NameTextBox.Text = "";
                notNum = false;
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = AuthorTextBox.Text;
            foreach (char c in tempstring)
            {
                if (char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(AuthorTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga siffror!");
                AuthorTextBox.Text = "";
                notNum = false;
            }
        }

        private void FormatTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = FormatTextBox.Text;
            foreach (char c in tempstring)
            {
                if (char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(FormatTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga siffror!");
                FormatTextBox.Text = "";
                notNum = false;
            }
        }

        private void PlatformTextBox_TextChanged(object sender, EventArgs e)
        {
            //lämnar tomt pga exemplevis ps4
        }

        private void PlaytimeTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = PlaytimeTextBox.Text;
            foreach (char c in tempstring)
            {
                if (!char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(PlaytimeTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga boskstäver!");
                PlaytimeTextBox.Text = "";
                notNum = false;
            }
        }

        private void StatusTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = StatusTextBox.Text;
            foreach (char c in tempstring)
            {
                if (!char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(StatusTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga boskstäver!");
                StatusTextBox.Text = "";
                notNum = false;
            }
        }

        private void LanguageTextBox_TextChanged(object sender, EventArgs e)
        {
            string tempstring = LanguageTextBox.Text;
            foreach (char c in tempstring)
            {
                if (char.IsDigit(c))
                {
                    notNum = true;
                }
            }

            if (notNum && !String.IsNullOrEmpty(LanguageTextBox.Text.ToString()))
            {

                MessageBox.Show("Inga siffror!");
                LanguageTextBox.Text = "";
                notNum = false;
            }
        }
    }
}
