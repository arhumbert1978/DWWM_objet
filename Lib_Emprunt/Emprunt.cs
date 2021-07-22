using System;

namespace Lib_Emprunt
{
    public class Emprunt
    {


        double tauxInteretAnnuel;
        int nbrAnneeRbmt;
        int capitalEmprunte;
        double tauxInteretMensuel;
        
        int nbMois;
        double interetsMensuel;
        double amortissementMois;

        public int CapitalEmprunte
        {
            get
            {

                return capitalEmprunte;

            }
            set
            {

                capitalEmprunte = value;


            }

        }

        public double TauxInteretAnnuel
        {

            get
            {

                return tauxInteretAnnuel;

            }
            set
            {

                tauxInteretAnnuel = value;

            }

        }
        public int NbrAnneeRbmt
        {
            get
            {

                return nbrAnneeRbmt;

            }

            set
            {

                nbrAnneeRbmt = value;

            }

        }

        public Emprunt(double _tauxInteretAnnuel, int _nbrAnneeRbmt,int _capitalEmprunte)
        {
           
            this.tauxInteretAnnuel = _tauxInteretAnnuel;

            this.nbrAnneeRbmt = _nbrAnneeRbmt;

            this.capitalEmprunte = _capitalEmprunte;

            this.tauxInteretMensuel = this.TauxInteretAnnuel / 12;

            this.nbMois = _nbrAnneeRbmt * 12;


        }


        public double CalculerMensualite ()
        {


           double mensualite;
           mensualite = (this.capitalEmprunte * this.tauxInteretAnnuel/100) * Math.Pow((1 + this.tauxInteretAnnuel/100), (double)this.nbMois) / Math.Pow((1 + this.tauxInteretAnnuel/100), (double)this.nbMois) - 1;
           
            
           return mensualite;
        
        
        }

    }

    
}
