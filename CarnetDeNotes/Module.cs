using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Module : Enseignement  {
    [DataMember]
    private List<Examen> listExamen;
    [DataMember]
    private float coefficient;
	public float Coefficient {
		get {
			return coefficient;
		}
		set {
			coefficient = value;
		}
	}
    /// <summary>
	/// il s'agit du code du module , une sorte de matricule de ce module. saisit une seule fois à la création du module et accessible après en lecture seule uniquement.
	/// </summary>
    [DataMember]
    private string idModule;
    public string IdModule
    {
        get
        {
            return idModule;
        }
        set
        {
            this.idModule = value; 
        }
    }

    public Module(string idModule, string nom, float coeff) : base(nom) {
        this.coefficient = coeff;
        this.idModule = idModule;
        this.listExamen = new List<Examen>();
    }
    /// <summary>
    /// permet d'ajouter un examen à ce module
    /// </summary>
    public void AjouterExamen(string date, string nomProf, float ponderation, Note note)
    {
        
        Examen ex = new Examen(date, nomProf, ponderation,note);
        this.listExamen.Add(ex);
    }
    /// <summary>
    /// renvoie la liste de tous les examens de ce module
    /// </summary>
    public Examen[] ListeExamen()
    {
        return this.listExamen.ToArray();
    }

    public Note[] ListeNotes()
    {
        List<Note> Notes = new List<Note>() ;
        foreach (Examen e in this.listExamen)
        {
            Notes.Add(e.GetNote());
        }
        return Notes.ToArray();
    }

    //permet de calculer la moyenne du module 
    //return un float 
    public float Moyenne()
    {

        float sommeNotes = 0;
        float sommePonderation = 0;

        foreach (Examen ex in this.ListeExamen())
        {
            //somme des notes avec pondération et somme des pondération
            sommeNotes += ex.GetNote().Valeur * ex.Ponderation;
            sommePonderation += ex.Ponderation;
        }
 
        return sommeNotes / sommePonderation;
    }
    public override string ToString()
    {
        return this.Nom + " (" + this.Coefficient + ")";
    }
    






}
