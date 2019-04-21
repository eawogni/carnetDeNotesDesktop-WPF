using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes 
{
    public class CarnetDataXml : ISauvableCarnet
    {
        private Stream flux;  //indique le flux qui va servir dans le traitement
        private DataContractSerializer ser = new DataContractSerializer(typeof(Carnet));

        public CarnetDataXml(string flux)
        {
            this.flux = new FileStream(flux, FileMode.OpenOrCreate);
        }

        public CarnetDataXml(Stream flux)
        {
            this.flux = flux;
        }
        public Carnet Charger()
        {
            Carnet list = null;
            if (flux.Length != 0)
            {
                list = ser.ReadObject(flux) as Carnet;
                flux.Close();

            }

            return list;

        }

        public void Sauver(Carnet c)
        {
            ser.WriteObject(flux, c);
            flux.Close();
        }
    }
}
