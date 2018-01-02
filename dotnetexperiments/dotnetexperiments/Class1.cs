using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetexperiments
{
    class Class1
    {

        public void Bla()
        {
            IEnumerable<string> nummers = new List<string> { "1", "2" };
        }
    }

    public class Drank
    {
        public Drank(params string[] ingredienten)
        {
            Ingredienten = ingredienten.ToList();

            
        }

        public List<string> Ingredienten { get; private set; }
    }
}
