using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    public class Telefon : ElektronikCihaz
    {
        public Telefon()
        {
            
        }
        public Telefon(string marka, string model, string serino, string tur) :base(marka, model, serino, tur)
        {
            
        }
        public override string CihazGetir()
        {
            return "telefon bilgileri:" + base.CihazGetir();
        }
    }
}
