using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebel
{
    abstract class Complect
    {
        public string Name;
        public List<Furniture> furnitures;
        public int GetSumma()
        {
            int summa = 0;
            foreach (Furniture f in furnitures)
                if (f != null) summa = summa + f.Price;

            return summa;
        }
        public abstract bool IsComplectFull();
        public abstract bool IsComplectCompatible();
    }

    class BathComplect : Complect
    {
        public Rakovina rakovina;
        public Tumba tumba;
        public Kran kran;

        public override bool IsComplectFull()
        {
            return (rakovina != null && tumba != null && kran != null);
        }
        public override bool IsComplectCompatible()
        {
            return (rakovina != null && tumba != null && 
                rakovina.Width == tumba.Width);
        }
    }

    class KitchenComplect : Complect
    {
        public string CollectionName;
        public Shkaf shkaf;
        public Plita plita;
        public Vutyazhka vutyazhka;

        public override bool IsComplectFull()
        {
            return (shkaf != null && plita != null && vutyazhka != null);
        }
        public override bool IsComplectCompatible()
        {
            return (shkaf != null && plita != null && vutyazhka != null &&
                shkaf.CollectionName == plita.CollectionName &&
                vutyazhka.CollectionName == plita.CollectionName);
        }
    }
}
