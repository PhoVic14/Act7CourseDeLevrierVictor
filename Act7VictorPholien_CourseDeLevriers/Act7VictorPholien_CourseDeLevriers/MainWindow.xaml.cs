using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Act7VictorPholien_CourseDeLevriers
{
    public partial class MainWindow : Window
    {
        Chien[] chien;
        Parieur[] parieur;
        Pari[] parie;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            game.Jeu(out chien, out parieur, out parie);
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            CreationJeu();
        }

        public void CreationJeu()
        {
            RdnBttnjoe.Content = "Joe possède " + parieur[0].Cash + " écus";
            RdnBttnBob.Content = "Bob possède " + parieur[1].Cash + " écus";
            RdnBttnBill.Content = "Bill possède " + parieur[2].Cash + " écus";

            Txtblckjoe.Text = "Joe n'a pas encore parié";
            TxtblckBob.Text = "Bob n'a pas encore parié";
            TxtblckBill.Text = "Bill n'a pas encore parié";
        }

        private void Parie_Click(object sender, RoutedEventArgs e)
        {
            int nbr;
            int nchien;

            if (int.TryParse(nbrparie.Text, out nbr) && int.TryParse(nbrchien.Text, out nchien))
            {
                int indexParieur = Array.FindIndex(parieur, p => p.Nom == TxtblckParieur.Text);
                if (indexParieur != -1)
                {
                    parieur[indexParieur].Parie(nbr, nchien);
                    parieur[indexParieur].MajInfos();

                    switch (TxtblckParieur.Text)
                    {
                        case "Joe":
                            Txtblckjoe.Text = parieur[indexParieur].TextBlockEtatPari.Text;
                            RdnBttnjoe.Content = "Joe possède " + parieur[indexParieur].Cash + " écus";
                            break;
                        case "Bob":
                            TxtblckBob.Text = parieur[indexParieur].TextBlockEtatPari.Text;
                            RdnBttnBob.Content = "Bob possède " + parieur[indexParieur].Cash + " écus";
                            break;
                        case "Bill":
                            TxtblckBill.Text = parieur[indexParieur].TextBlockEtatPari.Text;
                            RdnBttnBill.Content = "Bill possède " + parieur[indexParieur].Cash + " écus";
                            break;
                    }
                }
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtblckParieur.Text = "";
            nbrparie.Text = "";

            parieur[0].Cash = 50;
            parieur[1].Cash = 75;
            parieur[2].Cash = 45;

            foreach (Parieur p in parieur)
            {
                p.ResetPari();
            }

            CreationJeu();
        }

        private void RdnBttn_Checked(object sender, RoutedEventArgs e)
        {
            if (RdnBttnjoe.IsChecked == true)
            {
                TxtblckParieur.Text = "Joe";
            }
            else if (RdnBttnBob.IsChecked == true)
            {
                TxtblckParieur.Text = "Bob";
            }
            else
            {
                TxtblckParieur.Text = "Bill";
            }

            nbrparie.Text = "";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Chien chi in chien)
            {
                if (chi.MoovChien())
                {
                    timer.Stop();
                    for (int chiengagnant = 0; chiengagnant < 4; chiengagnant++)
                    {
                        if (chien[chiengagnant].IsWin())
                        {
                            int chienGagnantNum = chiengagnant + 1;
                            MessageBox.Show("Le gagnant est le chien n° " + chienGagnantNum);

                            foreach (Parieur p in parieur)
                            {
                                if (p.MonPari.NumberChien == chienGagnantNum)
                                {
                                    p.Cash += p.MonPari.Montant * 2;
                                }
                            }

                            // Reset
                            foreach (Parieur p in parieur)
                            {
                                p.ResetPari();
                            }

                            CreationJeu();
                        }
                    }
                }
            }
        }
    }
}
