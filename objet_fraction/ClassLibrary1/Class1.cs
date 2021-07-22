using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test_Fraction
{
    public class Fraction
    {

        private int denominateur;
        private int numerateur;


        public int Numerateur
        {
            get
            {
                return numerateur;
            }
            set
            {
                numerateur = value;
            }
        }
        public int Denominateur
        {

            get
            {
                return denominateur;
            }
            set
            {
                denominateur = value;
            }

        }
        public Fraction(int _numerateur, int _denominateur)
        {
            try
            {
                this.denominateur = _denominateur;
                this.numerateur = _numerateur;
                double test = (double)_numerateur / _denominateur;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);

            }


        }

        public Fraction()
        {

            this.numerateur = 0;
            this.denominateur = 1;

        }
        public Fraction(int _numerateur, int _denominateur)
        {

            this.numerateur = _numerateur;
            this.denominateur = 1;
            double test = (double)_numerateur / _denominateur;

        }

        public override string ToString()
        {
            String affiche = "";

            if (this.denominateur == 1)
            {
                affiche += this.numerateur;
            }
            else
            {
                //if (this.denominateur < 0)
                //{
                //    if (this.numerateur > 0)
                //    {
                //        if (this.denominateur == 1)
                //        {
                //            affiche += this.numerateur;
                //        }
                //        else
                //        {
                //            if (this.denominateur < 0)
                //            {
                //                if (this.numerateur > 0)
                //                {
                //                    affiche += (-this.numerateur) + "/" + (-this.denominateur);
                //                }
                //                else
                //                {
                //                    affiche += (-this.numerateur) + "/" + (-this.denominateur);
                //                }
                //            }
                //            else
                //            {
                //                affiche += this.numerateur + "/" + this.denominateur;
                //            }
                //        }

                //    }


                return this.Numerateur + "/" + this.Denominateur;
            }

        }
        



            public Division(Fraction _newfraction)
            {
                return (new Fraction(this.numerateur * _newfraction.denominateur, this.denominateur * _newfraction.numerateur));
            }




            public Multiplication(Fraction _newfraction)
            {

                return (new Fraction(this.numerateur * _newfraction.numerateur, this.denominateur * _newfraction.denominateur));
            }


            public void Oppose()
            {
                Numerateur = (this.numerateur * (-1));
            }

            public void Inverse()
            {

                int temp;
                temp = numerateur;
                denominateur = numerateur;
                numerateur = temp;

            }

            private int pgcd()
            {

                int a = this.numerateur;
                int b = this.denominateur;
                int pgcd = -1;
                if (a == 0) pgcd = b;
                else if (b == 0) pgcd = a;
                else
                {
                    if (a < 0) a = -a;
                    if (b < 0) b = -b;
                    while (a != b)
                    {
                        if (a < b)
                            b -= a;
                        else
                            a -= b;
                    }
                    pgcd = a;
                }
                return pgcd;
            }
        }

        private void Reduire()
        {
            int div = this.pgcd();
            this.Denominateur /= div;
            if (this.numerateur < 0 && this.denominateur < 0)
            {
                this.Numerateur = -Numerateur;
                this.Denominateur = -Denominateur;
            }
            if (this.numerateur > 0 && this.denominateur < 0)
            {
                this.Numerateur = -Numerateur;
                this.Denominateur = -Denominateur;
            }
        }







        public void Puissance(double _puiss)
        {

            return ((new Fraction((int)Math.Pow((double)this.numerateur, _puiss), (int)Math.Pow(Convert.ToDouble(this.denominateur), _puiss))));
        }





        public void Addition(Fraction _autrefraction)
        {
            int numtemp = (this.numerateur * _autreFraction.denominateur) + (_autreFraction.numerateur * this.denominateur);
            int denomtemp = this.Denominateur * _autreFraction.Denominateur;
            Fraction temp3 = new Fraction(numtemp, denomtemp);

            return temp3;
        }
        public void Soustraction(Fraction _autrefraction)
        {
            return (new Fraction(this.numerateur * _autrefraction.denominateur - _autrefraction.numerateur * this.denominateur, this.denominateur * _autrefraction.Denominateur));
        }


        public bool Superieur(Fraction _newFraction)
        {

            double fractemp1;
            double fractemp2;
            fractemp1 = (double)Numerateur / Denominateur;
            fractemp2 = (double)_newFraction.Numerateur / _newFraction.Denominateur;

            if (fractemp1 > fractemp2)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Inferieur(Fraction _newFraction)
        {
            double fractemp1;
            double fractemp2;
            fractemp1 = (double)Numerateur / Denominateur;
            fractemp2 = (double)_newFraction.Numerateur / _newFraction.Denominateur;

            if (fractemp1 < fractemp2)
            {

                return true;

            }
            else
            {

                return false;

            }


        }





    }
}
