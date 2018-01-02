using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetexperiments
{
    class AndereKlasse
    {
        public void Method()
        {
            var x = new Kwartaal(2018, 1);

            Console.WriteLine(x.Jaar);
            x.Jaar = 3;
        }
        


    }
}
