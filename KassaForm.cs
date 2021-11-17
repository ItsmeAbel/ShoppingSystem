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
    public partial class KassaForm : Form
    {
        BackendPart backend = new BackendPart();
        public KassaForm()
        {
            InitializeComponent();
            productDatalistKassa.DataSource = backend.loadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KundVagn form = new KundVagn();
            form.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            

        }
    }
}
