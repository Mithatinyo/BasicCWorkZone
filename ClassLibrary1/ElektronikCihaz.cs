using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ElektronikCihaz
    {

        public ElektronikCihaz()
        {
            
        }
        public ElektronikCihaz (string marka, string model, string serino, string tur)
        { 
            this.marka = marka;
            this.model = model;
            this.serino = serino;
            this.tur = tur;
        
        }

        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { Marka = value; }
        }
        private string Serino;

        public string serino
        {
            get { return Serino; }
            set { Serino = value; }
        }
        private string tur;

        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }

        public virtual string CihazGetir()
        {
            return this.Marka + " " + this.Model + " " + this.serino + " " + this.Tur;
        }

    }
}
