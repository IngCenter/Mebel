using System.Drawing;

namespace Mebel
{
    class Furniture
    {
        public string Name;
        public int Mass;
        public int Length;
        public int Width;
        public int Height;
        public int Price;
        public Image Picture;
    }

    class Sofa : Furniture
    {
        /// <summary>
        /// Может ли раздвигаться
        /// </summary>
        public bool CanRazdvigatsya;
    }

    class Chair : Furniture
    {
        /// <summary>
        /// Мягкий или нет
        /// </summary>
        public bool IsSoft;
    }

    //Стол (вместимость), Шкаф (зеркальность, встраиваемый / отдельно стоящий)
}
