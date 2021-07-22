using System;
using System.Collections.Generic;
using System.Text;

namespace Financier
{
    class banque
    {
        //attributs
        private int nbCompte;
        private Compte[] lesComptes;

        private string nomBanque;
        private string localisation;
        //Constructeur 

        public banque(string _nom, string _loc)
        {
            this.localisation = _loc;
            this.nomBanque = _nom;
            lesComptes = new Compte[20];
            this.nbCompte = 0;

        }
        //methodes
        private void AjouterCompte(Compte _unCompte)
        {

            this.lesComptes[nbCompte] = _unCompte;
            nbCompte++;
        }
        public bool Verif(string _numeroCompte)
        {
            for (int i = 0; i < this.nbCompte - 1; i++)
            {


                if (_numeroCompte == this.listComptes[i].GetNumero)

                {

                    return false;

                }

            }

        }
    }

}
}
