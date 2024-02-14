using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Act7VictorPholien_CourseDeLevriers
{
    internal class Chien
    {
        int _longueurPiste;
        int _numChien;
        Image _imageChien;
        int[] _positionCourante;
        bool _gagne;

        public int LongueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public Image ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }
        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }

        public bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }


        public Chien(int longueurPiste, int numChien, Image imageChien, int[] positionCourante, bool gagne)
        {
            _longueurPiste = longueurPiste;
            _numChien = numChien;
            _imageChien = imageChien;
            _positionCourante = positionCourante;
            _gagne = gagne;
        }

        public void Court()
        {

        }
    }
}
