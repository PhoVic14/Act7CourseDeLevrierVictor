using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Act7VictorPholien_CourseDeLevriers
{
    internal class Pari
    {
        int _montant;
        int _numChien;
        Parieur _joueur;



        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public Parieur Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }


        public Pari(int montant, int numChien, Parieur joueur)
        {
            _montant = montant;
            _numChien = numChien;
            _joueur = joueur;
        }

        public void GetDescription(TextBlock txtInfos)
        {

        }
        public void PrixFinal(int numGagnant)
        {

        }

    }
}
