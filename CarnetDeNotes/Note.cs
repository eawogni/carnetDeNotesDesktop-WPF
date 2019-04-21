using System;
using System.Runtime.Serialization;

[DataContract]
public class Note {
    [DataMember]
    private float valeur;
	public float Valeur {
		get {
			return valeur;
		}
		set {
			valeur = value;
		}
	}
    [DataMember]
    private bool absent;
	public bool Absent {
		get {
			return absent;
		}
		set {
			absent = value;
		}
	}

    public Note(float valeur, bool absent)
    {
        this.valeur = valeur;
        this.absent = absent;
    }

    public override string ToString()
    {
        if (this.absent)
        {
            return" Absent";
        }
        else
        {
            return (this.valeur + "/20");
        }
        
    }


}
