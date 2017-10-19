using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPigl
{
    class vectorHelper
    {
        // les méthodes sont à modifier  
        public void tri(int[] tab)
        {

        }
        public void somme(int[] tab1, int[] tab2)
        {

        }
        public void inverser(int[] tab)
        {

        }

        /// <summary>
        /// la méthode min_max permet d'obtenir simulatnément le min et le max d'un vecteur
        /// </summary>
        /// <param name="tab"> le vecteur pour lequel le min et le max simultanément</param>
        /// <returns>retourne un tableau à 2 cases la première c'est le min et la deuxième c'est le max</returns>
        public int[] min_max(int[] tab)
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
        public void applique_div(int[] tab)
        {
            for (int i = 0; i <tab.Length; i++)
            {
                tab[i] = tab[i] % 2;
            }
        }
    }
}
