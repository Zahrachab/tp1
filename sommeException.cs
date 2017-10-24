using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPigl
{
    /// <summary>
    /// sommeException est la classe de l'exception qui doit étre lancée quand deux vecteurs de longueur distincs sont les paramètres de somme
    /// </summary>
    public class sommeException : Exception
    { 
        /// <summary>
        /// le constructeur de la classe sommeException
        /// </summary>
        public sommeException()
        {

        }
    }
}
