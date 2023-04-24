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
    public partial class MainShop
    {
        public MainShop()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //opens the checkout form
            //this.Hide();
            KassaForm form = new KassaForm();
            form.Show();
        }

        private void LagerButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            LagerForm form = new LagerForm();
            form.Show();

        }
    }
}
