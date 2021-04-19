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

    class VintGaikaComplect : Complect, WithoutInstruction
    {
        public Furniture vint;
        public Furniture gaika;

        public string whyNoInstruction()
        {
            return "Инструкции нет, потому что так надо";
        }

        public override bool IsComplectFull()
        {
            return (vint != null && gaika != null);
        }
        public override bool IsComplectCompatible()
        {
            return (vint != null && gaika != null &&
                vint.Width == gaika.Width);
        }
    }

    class BathComplect : Complect, WithInstruction
    {
        public Rakovina rakovina;
        public Tumba tumba;
        public Kran kran;
        public string instrAddress;
        
        public string getInstrAddress()
        {
            return instrAddress;
        }
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
    class BathComplectUsherbnyi : Complect, WithoutInstruction
    {
        public Rakovina rakovina;
        public Tumba tumba;
        public Kran kran;

        public string whyNoInstruction()
        {
            return "Инструкции нет, потому что сможешь собрать сам";
        }

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
