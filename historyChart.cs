using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShoppingSystem
{
    public partial class historyChart : Form
    {
        public historyChart(List<log> templist, ProductList product)
        {
            InitializeComponent();

            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Price & History");

            Series price = this.chart1.Series.Add("price");
            Series stock = this.chart1.Series.Add("stock");

            price.ChartType = SeriesChartType.Spline;
            stock.ChartType = SeriesChartType.Spline;

            foreach (var item in templist)
            {
                if (item.id == product.id)
                {
                    price.Points.AddXY(item.date, item.price);
                    stock.Points.AddXY(item.date, item.status);
                }
            }
        }
    }
}
