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
    public partial class Grossit : Form
    {
        public Grossit()
        {
            InitializeComponent();
        }

        private void Grossit_Load(object sender, EventArgs e)
        {
            int[] range = {1,2,3};
            
            for(int i = 1; i<= 10; i++)
            {
                antalComboBox.Items.Add(i);

            }
            
        }

        private void orderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
