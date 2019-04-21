using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes
{

    /**
    * permet de sérialiser et de désérialiser un carnet sous format Xml
    */
    public class SemestreDataXml : ISauvableSemestre
    {
        private Stream flux;  //indique le flux qui va servir dans le traitement
        private DataContractSerializer ser = new DataContractSerializer(typeof(Semestre));
        
        public SemestreDataXml(string fichier)
        {
            this.flux = new FileStream(fichier, FileMode.OpenOrCreate);
            
           
        }
        public SemestreDataXml(Stream flux)
        {
            this.flux = flux;
        }

        /**
         * permet de sauver un carnet sous format xml
         */
        public void Sauver(Semestre c)
        {

            ser.WriteObject(flux, c);
            flux.Close();
        }

        /**
         * permet de charger un carnet sotocké sous format xml
         */
        public Semestre Charger()
        {
            Semestre c = null;
            if (flux.Length != 0)
            {
                c = ser.ReadObject(flux) as Semestre;
                flux.Close();

            }

            return c;
        }

       

    }
}
