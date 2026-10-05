using System.Transactions;

namespace ClassLibrary1
{
    public class Bilgisayar:ElektronikCihaz
    {
      
        public Bilgisayar() 
        { 
        
        
        
        }
        public Bilgisayar(string marka, string model, string serino, string tur) :base(marka,model,serino,tur)
        {
        
           
            

        
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
            get { return serino; }
            set { serino = value; }
        }
        private string tur;

        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }


        public override string CihazGetir()
        {
            return "cihaz bilgileri:" + base.CihazGetir();
        }

    }
}
