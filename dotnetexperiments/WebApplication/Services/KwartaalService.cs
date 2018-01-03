using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dotnetexperiments;

namespace WebApplication.Services
{
    public interface IKwartaalService
    {
        Kwartaal GetHuidigKwartaal();
        IEnumerable<Kwartaal> KwartalenVoorJaar(int jaar);
        bool IsHuidigKwartaal(Kwartaal kwartaal);
    }


    public class KwartaalService : IKwartaalService
    {

        public virtual Kwartaal GetHuidigKwartaal()
        {
            return new Kwartaal(DateTime.Today);
        }

        public virtual bool IsHuidigKwartaal(Kwartaal kwartaal)
        {
            return GetHuidigKwartaal() == kwartaal;
        }

        public virtual IEnumerable<Kwartaal> KwartalenVoorJaar(int jaar)
        {
            return new List<Kwartaal>
            {
                new Kwartaal(jaar, 1),
                new Kwartaal(jaar, 2),
                new Kwartaal(jaar, 3),
                new Kwartaal(jaar, 4)
            };
        }
    }
}