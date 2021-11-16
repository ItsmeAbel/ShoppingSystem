using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public partial class BackEnd : Component
    {
        public BackEnd()
        {
            InitializeComponent();
        }

        public BackEnd(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
