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
    public partial class Shwep : Form
    {
        List<log> mainLog; //used for logging
        public Shwep()
        {
            InitializeComponent();
            mainLog = new List<log>();
        }

        //loads kassaform on button click
        private void KassaButton_Click(object sender, EventArgs e)
        {
            //opens the checkout form
            //this.Hide();
            KassaForm form = new KassaForm(mainLog);
            form.Show();
        }

        //loads lagerform on button click
        private void LagerButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            LagerForm form = new LagerForm(mainLog);
            //DialogResult result = form.ShowDialog();
            form.Show();
            mainLog = form.MyList;
        }
    }


}
