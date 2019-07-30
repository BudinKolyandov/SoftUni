using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public Smartphone()
        {

        }
            
        public string Browse(string site)
        {
            if (site.Any(c => char.IsDigit(c)))
            {
                throw new SiteException();
            }
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            if (number.Any(c => char.IsLetter(c)))
            {
                throw new NumberException();
            }
            return $"Calling... {number}";
        }
    }
}
