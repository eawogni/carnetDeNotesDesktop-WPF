using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes
{
    public class CollectionDataXml : ISauvableCollectionCarnets
    {
        private Stream flux;  //indique le flux qui va servir dans le traitement
        private DataContractSerializer ser = new DataContractSerializer(typeof(CollectionCarnet));
        public CollectionDataXml(string flux)
        {
            this.flux = new FileStream(flux, FileMode.OpenOrCreate);
        }
        public CollectionCarnet Charger()
        {
            CollectionCarnet list = null;
            if (flux.Length != 0)
            {
                list = ser.ReadObject(flux) as CollectionCarnet;
                flux.Close();

            }

            return list;

        }

        public void Sauver(CollectionCarnet c)
        {
            ser.WriteObject(flux, c);
            flux.Close();
        }
    }
}
