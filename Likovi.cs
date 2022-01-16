namespace OTTER
{
    class Likovi : Sprite
    {



        //konstruktor
        public Likovi(string s, int xk, int yk, int br)
            : base(s, xk, yk)
        {
            this.Brzina = br;
        }


        private int brzina;


        public int Brzina
        {
            get
            {
                return brzina;
            }

            set
            {
                brzina = value;
            }
        }



    }
    class Protivnik : Likovi
    {
        public Protivnik(string s, int xk, int yk)
           : base(s, xk, yk, 7)
        {

        }
    }
    class GlavniLik : Likovi
    {


        public GlavniLik(string s, int xk, int yk)
            : base(s, xk, yk, 5)
        {

        }
        private int brojBodova;
        public int BrojBodova
        {
            get
            {
                return brojBodova;
            }

            set
            {
                brojBodova = value;
            }
        }


    }
}
