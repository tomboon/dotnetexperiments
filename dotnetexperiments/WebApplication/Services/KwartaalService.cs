using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dotnetexperiments;

namespace WebApplication.Services
{
    public class KwartaalService
    {

        public Kwartaal Huidig()
        {
            return new Kwartaal(DateTime.Today);
        }
    }
}