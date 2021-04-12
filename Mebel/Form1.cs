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
        List<Furniture> furnitureList = new List<Furniture>();
        List<TumboRak> complectList = new List<TumboRak>();

        public Form1()
        {
            InitializeComponent();

            Rakovina rak1 = new Rakovina { Name = "Раковина белая 50см", Price = 1000, Color = "Белый", Width = 50 };
            Tumba tum1 = new Tumba { Name = "Тумба белая 50см", Price = 1000, Color = "Белый", Width = 50 };
            complectList.Add(new TumboRak { rakovina = rak1, tumba = tum1 });

            furnitureList.Add(new Sofa { Name = "Лучший диван", Price = 20000, Mass = 30, CanRazdvigatsya = true });
            furnitureList.Add(new Chair { Name = "Лучший стул", Price = 3000, Mass = 4 });
            furnitureList.Add(new Chair { Name = "Нелучший стул", Price = 1000, Mass = 4 });
            furnitureList.Add(new Chair { Name = "Стул с торчащими гвоздями", Price = 300, Mass = 4 });
            furnitureList.Add(new Rakovina { Name = "Раковина белая 50см", Price = 1000, Color = "Белый", Width=50 });
            furnitureList.Add(new Tumba { Name = "Тумба красная 50см", Price = 1000, Color = "Красный", CountBoxes = 4, Width = 50 });
            furnitureList.Add(new Tumba { Name = "Тумба белая 70см", Price = 1000, Color = "Белый", CountBoxes = 2, Width = 70 });

            int sum = 0;
            foreach (Furniture sofa1 in furnitureList)
            {
                textBox1.AppendText(sofa1.Name + " " + sofa1.Price.ToString() + Environment.NewLine);
                sum = sum + sofa1.Price;

                if (sofa1 is Rakovina)
                    rakovinaComboBox.Items.Add(sofa1.Name);
                else if (sofa1 is Tumba)
                    tumbaComboBox.Items.Add(sofa1.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Furniture rak = new Furniture();
            Furniture tumba = new Furniture();

            foreach (Furniture sofa1 in furnitureList)
            {
                if (sofa1.Name == rakovinaComboBox.Text)
                {
                    rak = sofa1;
                }
                else if (sofa1.Name == tumbaComboBox.Text)
                {
                    tumba = sofa1;
                }
            }

            if (rak.Width == tumba.Width)
                MessageBox.Show("Совместимы");
            else
                MessageBox.Show("Несовместимы");
        }
    }
}
