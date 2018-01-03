using System;
using Newtonsoft.Json;


namespace dotnetexperiments
{
    public class Kwartaal : IComparable<Kwartaal>
    {
        public int Jaar { get; set; }
        public int Nummer { get; set; }
        
        public Kwartaal() { }

        public Kwartaal(int jaar, int nummer)
        {
            if (nummer < 1 || nummer > 4) throw new ArgumentException("Invalid kwartaalnummer");
            
            Jaar = jaar;
            Nummer = nummer;
        }

        public Kwartaal(DateTime datum)
        {
            Jaar = datum.Year;
            Nummer = datum.Month % 4;
        }

        public int CompareTo(Kwartaal other)
        {
            return ToString().CompareTo(other.ToString());
        }

        public override string ToString()
        {
            return $"{Jaar}/{Nummer}";
        }

        public Kwartaal Volgende()
        {
            if (Nummer == 4) return new Kwartaal(Jaar + 1, 1);
            return new Kwartaal(Jaar, Nummer + 1);
        }

        public Kwartaal Vorige()
        {
            if (Nummer == 1) return new Kwartaal(Jaar - 1, 4);
            return new Kwartaal(Jaar, Nummer - 1);
        }

        public DateTime StartDatum()
        {
            throw new NotImplementedException();
        }

        public DateTime EindDatum()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            var other = (Kwartaal) obj;
            return ToString().Equals(other.ToString());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Kwartaal k1, Kwartaal k2)
        {
            if (ReferenceEquals(k1, null) || ReferenceEquals(k2, null)) return false;
            return k1.Equals(k2);
        }

        public static bool operator !=(Kwartaal k1, Kwartaal k2)
        {
            if (ReferenceEquals(k1, null) || ReferenceEquals(k2, null)) return true;
            return !k1.Equals(k2);
        }

        public static bool operator <(Kwartaal k1, Kwartaal k2)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(Kwartaal k1, Kwartaal k2)
        {
            throw new NotImplementedException();
        }
    }
    
}
