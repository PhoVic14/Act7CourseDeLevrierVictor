using System;
using System.Windows.Controls;

namespace Act7VictorPholien_CourseDeLevriers
{
    internal class Parieur
    {
        string _nom;
        Pari _monPari;
        int _cash;
        TextBlock _textBlockEtatPari;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }

        public Parieur(string nom, Pari monPari, int cash, TextBlock textBlockEtatPari)
        {
            _nom = nom;
            _monPari = monPari;
            _cash = cash;
            _textBlockEtatPari = textBlockEtatPari;
        }

        public void Parie(int valeurPari, int numChien)
        {
            // Implémentez la logique de pari ici
        }

        public void ResetPari()
        {
            // Implémentez la logique de réinitialisation du pari ici
        }

        public void MajInfos()
        {
            // Implémentez la logique de mise à jour des informations ici
        }
    }
}
