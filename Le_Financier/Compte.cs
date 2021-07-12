using System;
using System.Collections.Generic;
using System.Text;

namespace Le_Financier
{
    class Compte
    {
        private string e = Encoding.Default.GetString(new Byte[] { 128 });



        private double decouvertAutorise;
        private string nomCompte;
        private string numeroCompte;
        private double soldeCompte;
        public Compte(double decouvertAutorise, string nomCompte, string numeroCompte, double soldeCompte)
        {

            this.decouvertAutorise = decouvertAutorise;
            this.nomCompte = nomCompte;
            this.numeroCompte = numeroCompte;
            this.soldeCompte = soldeCompte;
        }
        public Compte()
        {
        }




        public double Decouvert
        {
            get
            {
                return decouvertAutorise;
            }

            set
            {
                decouvertAutorise = value;
            }
        }

        public string GetNom
        {
            get
            {
                return nomCompte;
            }
            set { nomCompte = value; }
        }

        public string GetNumero
        {
            get
            {
                return numeroCompte;
            }
            set { this.numeroCompte = value; }
        }

        public double SoldeCompte
        {

            get
            {
                return this.soldeCompte;
            }

            set
            {
                this.soldeCompte = value;
            }

        }

        public void credit(Double _somme)
        {

            soldeCompte += _somme;
        }
        public bool debit(Double _somme)
        {

            if ((SoldeCompte - _somme) < Decouvert)
            {

                return false;
            }
            else
            {

                return true;
            }
        }
        public override string ToString()
        {


            return "Le Compte n°:" + this.GetNumero + " appartenant à : " + GetNom + "  ayant pour solde " + SoldeCompte + e + " Euros  Ayant un decouvert de:" + Decouvert + e;

        }

    }
}




