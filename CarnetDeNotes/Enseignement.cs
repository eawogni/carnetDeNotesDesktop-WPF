using System;
using System.Runtime.Serialization;

[DataContract]
public class Enseignement {
    [DataMember]
    private string nom;
	public string Nom {
		get {
			return nom;
		}
		set {
			nom = value;
		}
	}

	public Enseignement(string nom) {
        this.nom = nom;
	}

}
