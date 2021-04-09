using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Furniture> furnitureList = new List<Furniture>();
            furnitureList.Add(new Sofa("Лучший диван"));
            //furnitureList.Add(new Sofa { Name = "Лучший диван", Price = 20000, Mass = 30, CanRazdvigatsya = true });
            furnitureList.Add(new Chair { Name = "Лучший стул", Price = 3000, Mass = 4 });
            furnitureList.Add(new Chair { Name = "Нелучший стул", Price = 1000, Mass = 4 });
            furnitureList.Add(new Chair { Name = "Стул с торчащими гвоздями", Price = 300, Mass = 4 });

            int sum = 0;
            foreach (Furniture sofa1 in furnitureList)
            {
                textBox1.AppendText(sofa1.Name + " " + sofa1.Price.ToString() + Environment.NewLine);
                sum = sum + sofa1.Price;
            }

            MessageBox.Show(sum.ToString());
        }
    }
}
