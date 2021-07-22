using System;


namespace Financier
    {
        public class Compte
        {

            private double decouvertAutorise;
            private string nomCompte;
            private string numeroCompte;
            private double soldeCompte;
        private string e = "€";
        public Compte()
            {
            }

            public Compte(double decouvertAutorise, string nomCompte, string numeroCompte, double soldeCompte)
            {

                this.decouvertAutorise = decouvertAutorise;
                this.nomCompte = nomCompte;
                this.numeroCompte = numeroCompte;
                this.soldeCompte = soldeCompte;
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

            }

            public string GetNumero
            {
                get
                {
                    return numeroCompte;
                }

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

            public void Credit(double _somme)
            {

                soldeCompte += _somme;
            }
        public bool Debit(double _somme)
        {
           

                if ((this.soldeCompte - _somme) < Decouvert)
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


                return "Le Compte n°:" + this.GetNumero + " appartenant à : " + GetNom + "  ayant pour solde " + SoldeCompte + e + " Ayant un decouvert de:" + Decouvert + e;

            }


  


            public bool Transferer(double _Montant, Compte _Bene)
            {
                bool valVir;
                if (this .Debit(_Montant)== false)
                {

                    valVir = false;

                }
                else
                {
                    this.Debit(_Montant);
                    _Bene.Credit(_Montant);
                    valVir = true;
                }

                return valVir;

            }



        }
    }




    