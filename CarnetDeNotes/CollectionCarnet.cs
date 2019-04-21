using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes
{
    [DataContract]
   public class CollectionCarnet
    {
        [DataMember]
        private List<Carnet> Collections;
        
        public CollectionCarnet()
        {
            Collections= new List<Carnet>();
        }
        public void AjouterCarnet(Carnet c)
        {
            this.Collections.Add(c);
        }
        public Carnet GetCarnet(string nom, string prenom)
        {
            foreach(Carnet c in this.Collections)
            {
                if (c.Etudiant.Nom == nom && c.Etudiant.Prenom==prenom)

                {
                    return c;
                }
            }
            return null;
        }
    }
}
