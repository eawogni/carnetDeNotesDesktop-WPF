using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class UE : Enseignement  {
    [DataMember]
    private List<Module> listModule;
    /// il s'agit d'une propriété en lecture uniquement car le coefficient d'un Ue dépend des modules (leur coefficients)qui le contiennent
    public float Coefficient {
		get {

            //calcul du coef de cette UE
            float coefficient = 0;
            foreach (Module m in this.listModule)
            {
                coefficient += m.Coefficient;
            }
            return coefficient;
		}
	}

    public UE(string nom) : base(nom)
    {
        this.listModule = new List<Module>();

    }
    public void AjouterModule(string idModule, string nom, float coef)
    {
        Module m = new Module(idModule,nom, coef);
        this.listModule.Add(m);
       
    }
    /// <summary>
    /// renvoie la liste de tous les modules de l'UE en question
    /// </summary>
    public Module[] ListeModule()
    {
        return this.listModule.ToArray();
    }
    public override String ToString()
    {
       
        return (this.Nom + " (" + this.Coefficient + ")");
    }
   public float Moyenne()
    {
        
        float sommeMoyennesModules=0;
        foreach (Module m in this.ListeModule())
        {
 
            //calcul moyenne du module
             sommeMoyennesModules += m.Moyenne() * m.Coefficient;
        }
        return sommeMoyennesModules / this.Coefficient ;
        
    }
    




}


