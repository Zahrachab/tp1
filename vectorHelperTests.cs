using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace TPigl
{
    public class vectorHelperTests
    {
        [Fact]
        public void min_max_1()
        {
            int[] val = new int[] { 1, 6, 8 };
            int[] attendu = new int[] { 1, 8 };
            int[] resultat = TPigl.vectorHelper.min_max(val);
            Assert.Equal(attendu,resultat);
        }

        [Fact]
        public void min_max_2()
        {
            int[] val = new int[] { 10 };
            int[] attendu = new int[] { 10, 10 };
            int[] resultat = TPigl.vectorHelper.min_max(val);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void min_max_3()
        {
            int[] val = new int[] { 5, 8, 0, 1, 6, 6 };
            int[] attendu = new int[] { 0, 8 };
            int[] resultat = TPigl.vectorHelper.min_max(val);
            Assert.Equal(attendu, resultat);
        }
    }
}
