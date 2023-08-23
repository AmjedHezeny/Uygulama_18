using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_18
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public Kisi(string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
        }
    }
}