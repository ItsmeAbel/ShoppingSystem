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
        public historyChart(List<log> templist, ProductList product) //takes log list and product as parameters
        {
            InitializeComponent();

            this.chart1.Series.Clear(); //clears all series
            this.chart1.Titles.Add("Price & History"); //title for graph
            this.chart1.ChartAreas[0].AxisY.Title = "Amount"; //title for Y-Axis
            this.chart1.ChartAreas[0].AxisX.Title = "Time"; //title for X-Axis

            Series price = this.chart1.Series.Add("price"); //graph line(series) to represent the price
            Series stock = this.chart1.Series.Add("stock"); //graph line(series) to represent the stock
            stock.Color = Color.Red; 

           
            price.ChartType = SeriesChartType.Spline;
            stock.ChartType = SeriesChartType.Spline;

            foreach (var item in templist)//for each item in the log list
            {
                if (item.id == product.id) //pick only the the items with matching id
                {
                    price.Points.AddXY(item.date, item.price); //add a point in the graph with date and price of the item
                    stock.Points.AddXY(item.date, item.status); //add a point to the graph with date and status
                }
            }
            //backend.saveToLog(templist);
        }
    }
}
