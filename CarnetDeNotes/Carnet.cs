using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes
{
    
    [DataContract]
    public class Carnet
    {
        
        [DataMember]
        private List<Semestre> lesSemestres;
        [DataMember]
        private Etudiant etudiant = null;
    
        public List<Semestre> LesSemestres
        {
            get { return this.lesSemestres; }
        }

        public Carnet(Etudiant etd)
        {
            this.etudiant = etd;
            lesSemestres = new List<Semestre>();

        }
        public void AjouterSemestre()
        {
            this.LesSemestres.Add( new Semestre());
        }
        public void SupprimerSemestre(Semestre s)
        {
            foreach(Semestre se  in this.lesSemestres)
            {
                if (s.Equals(se))
                {
                    this.lesSemestres.Remove(se);
                }
            }
        }

        public Etudiant Etudiant
        {
            get { return etudiant; }
        }

    }
}
