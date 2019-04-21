using System;
using System.Runtime.Serialization;

[DataContract]
public class Examen {
    [DataMember]
    private Note note;
    [DataMember]
    private string nomProf;
	public string NomProf {
		get {
			return nomProf;
		}
		set {
			nomProf = value;
		}
	}
    [DataMember]
    private float ponderation;
	public float Ponderation {
		get {
			return ponderation;
		}
		set {
			ponderation = value;
		}
	}
    [DataMember]
    private string dateExam;
	public string DateExam {
		get {
			return dateExam;
		}
		set {
			dateExam = value;
		}
	}

	/// <summary>
	/// création d'un  examen ; par défaut la note est
	/// </summary>
	public Examen(string date, string nomProf, float pond, Note note) {
        this.dateExam = date;
        this.nomProf = nomProf;
        this.ponderation = pond;
        this.note = note;
        
    }
	/// <summary>
	/// permet d'ajouetr la note assicier à cet examen
	/// </summary>
	public void SetNote(Note note) {
        this.note = note;
    }
	public Note GetNote() {
        return this.note;
	}


	

}
