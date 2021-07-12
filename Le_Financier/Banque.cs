using System;
using System.Collections.Generic;
using System.Text;


namespace Le_Financier
{
    public class Banque 
    {
        //attributs
        private int nbCompte;
        private Compte[] listComptes;
        


        private string nomBanque;
        private string ville;

        public Banque(string _nom, string _ville)
        {


            this.nomBanque = _nom;
            this.ville = _ville;
            listComptes = new Compte[50];
            this.nbCompte = 0;
        }

        private void AddComptes(Compte _unCompte)
        {

            this.listComptes[nbCompte] = _unCompte;
            nbCompte++;

        }


        public override string ToString()
        {
            string MesComptes = " Les differents comptes de la banque " + this.nomBanque + " basé à " + this.ville + " sont :\n";

            for (int i = 0; i < this.nbCompte; i++)
            {
                MesComptes += this.listComptes[i].ToString() + "\n";
                MesComptes+=("\n"+"------------------*************---------------");
            
            }



            return MesComptes;
            
        }
    }
    }


