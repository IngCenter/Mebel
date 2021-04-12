namespace Mebel
{
    class TumboRak
    {
        public Rakovina rakovina;
        public Tumba tumba;

        public TumboRak()
        {

        }

        public TumboRak(int width)
        {
            if (width == 50)
            {
                rakovina = new Rakovina50();
                tumba = new Tumba50();
            }
            if (width == 70)
            {
                rakovina = new Rakovina70();
                tumba = new Tumba70();
            }
        }
    }
}
