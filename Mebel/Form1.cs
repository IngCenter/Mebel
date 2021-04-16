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



            Rakovina rak1 = new Rakovina { Name = "Раковина белая 50см", Price = 1000, Color = "Белый", Width = 50 };
            Tumba tum1 = new Tumba { Name = "Тумба белая 50см", Price = 1000, Color = "Белый", Width = 50 };
            Kran kran1 = new Kran { Name = "Кран кранистый длинный с водой", Price = 2500 };
            List<Furniture> mebel1 = new List<Furniture>() { rak1, tum1, kran1 };
            BathComplect complect1 = new BathComplect { Name = "Комплект для ванной 1", rakovina = rak1, kran = kran1, tumba = tum1, furnitures = mebel1 };

            Shkaf shkaf1 = new Shkaf { Name = "Шкаф кухонный 180 см", Price = 12000, CollectionName = "Элитное" };
            Plita plita1 = new Plita { Name = "Плита электрическая дровяная", Price = 20000, CollectionName = "Элитное" };
            List<Furniture> mebel2 = new List<Furniture>() { shkaf1, plita1 };
            KitchenComplect complect2 = new KitchenComplect { Name = "Комплект для кухни 1", CollectionName = "Элитное", plita = plita1, shkaf = shkaf1, furnitures = mebel2 };

            Shkaf shkaf2 = new Shkaf { Name = "Шкаф кухонный 180 см", Price = 12000, CollectionName = "Элитное" };
            Plita plita2 = new Plita { Name = "Плита электрическая дровяная", Price = 20000, CollectionName = "Элитное" };
            Vutyazhka vutyazhka2 = new Vutyazhka { Name = "Вытяжка существует", Price = 2000, CollectionName = "Элитное" };
            List<Furniture> mebel3 = new List<Furniture>() { shkaf2, plita2, vutyazhka2 };
            KitchenComplect complect3 = new KitchenComplect { Name = "Комплект для кухни 1", CollectionName = "Элитное", plita = plita2, shkaf = shkaf2, vutyazhka = vutyazhka2, furnitures = mebel3 };

            List<Complect> complects = new List<Complect>() { complect1, complect2, complect3 };

            foreach (Complect comp in complects)
            {
                textBox1.AppendText(comp.Name + Environment.NewLine +
                    "статус " + (comp.IsComplectFull() ? "полный" : "неполный") + Environment.NewLine +
                    (comp.IsComplectCompatible() ? "все совместимо" : "детали из разных комплектов") + Environment.NewLine +
                    "стоит " + comp.GetSumma().ToString() + " рублей" + Environment.NewLine + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
