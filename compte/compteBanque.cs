using System;
using System.Text;


namespace compte
{
    class compteBanque
    {
        private string e = Encoding.Default.GetString(new Byte[] { 128 });


        
        private double decouvertAutorise;
        private string nomCompte;
        private string numeroCompte;
        private double soldeCompte;

        public compteBanque()
        {
        }

        public compteBanque(string e, double decouvertAutorise, string nomCompte, string numeroCompte, double soldeCompte)
        {
          
            this.decouvertAutorise = decouvertAutorise;
            this.nomCompte = nomCompte;
            this.numeroCompte = numeroCompte;
            this.soldeCompte = soldeCompte;
        }
        public int Decouvert
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
            else if(SoldeCompte>=Decouvert)
            {

                return true;
            }
        }
             public override string ToString()
        {


            return "Le Compte n°:" + this.GetNumero + " appartenant à : " + GetNom + "  ayant pour solde " + SoldeCompte + e + " Ayant un decouvert de:" + Decouvert + e;
            
        }


        //pb pour faire est supérieur. Avec les trois param


        public bool virement(double _Montant, compteBanque _Bene )
        {
            bool valVir;
            if(this.debit(_Montant)==false)
            {

                valVir == false;

            }
            else
            {
                this.debit(_Montant);
                _Bene.credit(_Montant);
                valVir == true;
            }

            return valVir;

        }



    }
}

