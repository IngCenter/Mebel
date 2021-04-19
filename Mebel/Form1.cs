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
            BathComplect complect1 = new BathComplect { instrAddress = "https://google.com", Name = "Комплект для ванной 1", rakovina = rak1, kran = kran1, tumba = tum1, furnitures = mebel1 };

            Shkaf shkaf1 = new Shkaf { Name = "Шкаф кухонный 180 см", Price = 12000, CollectionName = "Элитное" };
            Plita plita1 = new Plita { Name = "Плита электрическая дровяная", Price = 20000, CollectionName = "Элитное" };
            List<Furniture> mebel2 = new List<Furniture>() { shkaf1, plita1 };
            KitchenComplect complect2 = new KitchenComplect { Name = "Комплект для кухни 1", CollectionName = "Элитное", plita = plita1, shkaf = shkaf1, furnitures = mebel2 };

            Shkaf shkaf2 = new Shkaf { Name = "Шкаф кухонный 180 см", Price = 12000, CollectionName = "Элитное" };
            Plita plita2 = new Plita { Name = "Плита электрическая дровяная", Price = 20000, CollectionName = "Элитное" };
            Vutyazhka vutyazhka2 = new Vutyazhka { Name = "Вытяжка существует", Price = 2000, CollectionName = "Элитное" };
            List<Furniture> mebel3 = new List<Furniture>() { shkaf2, plita2, vutyazhka2 };
            KitchenComplect complect3 = new KitchenComplect { Name = "Комплект для кухни 1", CollectionName = "Элитное", plita = plita2, shkaf = shkaf2, vutyazhka = vutyazhka2, furnitures = mebel3 };
            
            Furniture vint1 = new Furniture { Name = "Винт 10 см", Price = 12, Width = 10 };
            Furniture gaika1 = new Furniture { Name = "Гайка 10см", Price = 2, Width = 10 };
            List<Furniture> vg1 = new List<Furniture>() { vint1, gaika1 };
            VintGaikaComplect complect4 = new VintGaikaComplect { Name = "Комплект для недоразвитых", vint = vint1, gaika = gaika1, furnitures = vg1 };

            List<Complect> complects = new List<Complect>() { complect1, complect2, complect3, complect4 };

            int y = 50;
            foreach (Complect comp in complects)
            {
                Label label = new Label();
                label.AutoSize = false;
                label.Size = new Size(400, 100);
                label.Location = new Point(20, y);
                label.Text  = 
                    comp.Name + Environment.NewLine +
                    "статус " + (comp.IsComplectFull() ? "полный" : "неполный") + Environment.NewLine +
                    (comp.IsComplectCompatible() ? "все совместимо" : "детали из разных комплектов") + Environment.NewLine +
                    "стоит " + comp.GetSumma().ToString() + " рублей" + Environment.NewLine + Environment.NewLine;
                Controls.Add(label);

                if (comp is WithInstruction)
                {
                    LinkLabel lb = new LinkLabel();
                    lb.Location = new Point(500, y);
                    lb.AutoSize = true;
                    lb.Text = (comp as WithInstruction).getInstrAddress();
                    Controls.Add(lb);
                }
                if (comp is WithoutInstruction)
                {
                    Label lb = new Label();
                    lb.Location = new Point(500, y);
                    lb.AutoSize = true;
                    lb.Text = (comp as WithoutInstruction).whyNoInstruction();
                    Controls.Add(lb);
                }

                y += 100;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
