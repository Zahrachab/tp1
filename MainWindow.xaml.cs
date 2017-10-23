using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace TPigl
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// vec1 c'est le vecteur utilisé dans toutes les opérations et contient le résultat à la fin
        /// vec2 c'est le deuxième vecteur utilisé pour la somme
        /// vectorHelp est une instance de la classe vectorHelper
        /// action c'est une chaine qui contient l'opération qu'on veut appliquer (tri,...)
        /// </summary>
        private int[] vec1; /**<  */
        private int[] vec2;
        private string action;

        public MainWindow()
        {
            InitializeComponent();
            grid1.Visibility = Visibility.Hidden;
            valider.Visibility = Visibility.Hidden;
           // grid2.Visibility = Visibility.Hidden;

        }


        public void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Catch myTextBox's TextChanged Event
        }
        /// <summary>
        /// la méthode qui permet l'affichage de la page après le clique sur le bouton trier
        /// </summary>

        private void tri_click(object sender, RoutedEventArgs e)
        {
            txt2.Text="";
            taille.Text = "";
            valider.IsEnabled = true;
            ok.IsEnabled = true;
            valider.Visibility = Visibility.Hidden;
            wp1.Children.Clear();
            wp2.Children.Clear();
            action = "tri";
            grid1.Visibility = Visibility.Visible;

        }
        private void somme_click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// méthode executé quand on clique sur le bouton "inverser"
        /// </summary>
        private void inverse_click(object sender, RoutedEventArgs e)
        {
            valider.IsEnabled = true;
            ok.IsEnabled = true;
            taille.Text = "";
            txt2.Text = "";
            valider.Visibility = Visibility.Hidden;
            wp1.Children.Clear();
            wp2.Children.Clear();
            action = "inverse";
            grid1.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// méthode executé quand on clique sur le bouton "min et max"
        /// </summary>
        private void m_click(object sender, RoutedEventArgs e)
        {
            valider.IsEnabled = true;
            ok.IsEnabled = true;
            taille.Text = "";
            txt2.Text = "";
            valider.Visibility = Visibility.Hidden;
            wp1.Children.Clear();
            wp2.Children.Clear();
            action = "min_max";
            grid1.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// méthode executé quand on clique sur le bouton "appliquer la fonction modulo 2"
        /// </summary>
        private void fonc_click(object sender, RoutedEventArgs e)
        {
            valider.IsEnabled = true;
            ok.IsEnabled = true;
            taille.Text = "";
            txt2.Text = "";
            valider.Visibility = Visibility.Hidden;
            wp1.Children.Clear();
            wp2.Children.Clear();
            action = "fonc";
            grid1.Visibility = Visibility.Visible;
        }

        private void vector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// méthode qui permet de calculer le vecteur en sortie après une opétion (tri, inversion ...)
        /// </summary>
        public void set_result(int[] tab)
        {
            for (int i = 0; i < vec1.Length; i++)
            {
                TextBox myTextBox = new TextBox() { Text = "", Width = 30, Height = 30, FontSize = 12 };
                myTextBox.TextChanged += myTextBox_TextChanged;
                myTextBox.Text = vec1[i].ToString();
                wp2.Children.Add(myTextBox);
            }
        }

        private void taille_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /// <summary>
        /// la méthode qui déffinit l'action qui va s'éxecuter quand on clique sur le bouton ok
        /// </summary>
        
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            vec1 = new int[Int32.Parse(taille.Text)];
            for (int i = 0; i < vec1.Length; i++)
            {
                TextBox myTextBox = new TextBox() { Text = "", Width = 30, Height = 30, FontSize = 12  };
                myTextBox.TextChanged += myTextBox_TextChanged;
                wp1.Children.Add(myTextBox);
            }
            ok.IsEnabled = false;
            valider.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// la méthode qui déffinit l'action qui va s'éxecuter quand on clique sur le bouton valider
        /// </summary>
        private void valider_Click(object sender, RoutedEventArgs e)
        {
            // remplir vec à partir des entrées de l'utilisateur
            for (int i = 0; i < vec1.Length; i++)
            {
                vec1[i] = Int32.Parse(((TextBox)wp1.Children[i]).Text);
            }
            if(action=="tri")
            {
                vectorHelper.tri(vec1);
                txt2.Text = "Le vecteur trié : ";
                set_result(vec1);
            }
            else if(action=="inverse")
            {
                vectorHelper.inverser(vec1);
                txt2.Text = "Le vecteur après inveresement de tous ses élèments : ";
                set_result(vec1);
            }
            else if(action=="fonc")
            {
                vectorHelper.applique_div(vec1);
                txt2.Text = "Le vecteur après application de la fonction modulo 2 sur tous les élèments  : ";
                set_result(vec1);
            }

            else if(action=="min_max")
            {
                int[] a = new int[2];
                a= vectorHelper.min_max(vec1);
                txt2.Text = "valeur min = " + a[0] +" et la valeur max = "+a[1] ;
            }
            valider.IsEnabled = false;

        }
    }
}