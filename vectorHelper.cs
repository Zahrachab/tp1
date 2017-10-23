using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPigl
{
    /// <summary>
    /// La classe vectorHelper qui permet 5 opérations
    /// </summary>
    public static class vectorHelper
    {
 
        
        /// <summary>
        /// la méthode tri permet de trier le vecteur par ordre croissant
        /// </summary>
        /// <param name="tab"> le vecteur pour lequel on effectue le tri</param>
        public static void tri(int[] tab)

        {
            int i, j, x;
            for (i = 0; i < tab.Length; i++)
            {
                j = i;
                x = tab[i];
                while ((j > 0) && (tab[j - 1] > x))
                {
                    tab[j] = tab[j - 1];
                    j--;
                }
                tab[j] = x;
            }
        }

        
            /// <summary>
            /// la méthode somme permet de sommer deux vecteurs
            /// </summary>
            /// <param name="tab1"> le 1èr vecteur</param>
            /// /// <param name="tab1"> le 2ème vecteur</param>
        public static void somme(int[] tab1, int[] tab2)
        {

                if(tab1.Length==tab2.Length) //la taille des deux vecteurs doit etre la meme
                {
                    for(int i=0;i<tab1.Length;i++)
                    {
                        tab1[i] = (tab1[i] +tab2[i]);
                    }
                }
                

        }


        /// <summary>
        /// la méthode inverser permet d'inverser le vecteur 
        /// </summary>
        /// <param name="tab"> le vecteur sur lequel on applique la méthode </param>
        public static void inverser(int[] tab)
        {
            int sauv = 0;
            int taille = tab.Length;
            for (int i = 0; i < (taille / 2); i++)
            {
                sauv = tab[i];
                tab[i] = tab[taille-i-1];
                tab[taille-i-1] = sauv;

            }

        }

        /// <summary>
        /// la méthode min_max permet d'obtenir simulatnément le min et le max d'un vecteur
        /// </summary>
        /// <param name="tab"> le vecteur pour lequel le min et le max simultanément</param>
        /// <returns>retourne un tableau à 2 cases la première c'est le min et la deuxième c'est le max</returns>
        public static int[] min_max(int[] tab)
        {
            int max,min; 
            int[] min_max = new int[2];
            min=max=tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min) min = tab[i];
                if (tab[i] > max) max = tab[i];
            }
            min_max[0] = min; // la case qui contient le min
            min_max[1] = max; // la case qui contient le max

            return min_max;
        }

        /// <summary>
        /// La méthode applique_div applique à tous les éléments d'un vecteur la fonction reste de la division par 3
        /// </summary>
        /// <param name="tab"> le paramètre tab est un vecteur auquel on applique la fonction reste de la division par 3</param>
        public static void applique_div(int[] tab)
        {
            for (int i = 0; i <tab.Length; i++)
            {
                tab[i] = tab[i] % 2;
            }
        }

        
    }
}
