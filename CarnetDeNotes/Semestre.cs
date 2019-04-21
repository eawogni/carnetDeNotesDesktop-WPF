using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Semestre
{
    [DataMember]
    private List<UE> listUE;

    public Semestre()
    {   
        listUE = new List<UE>();
    }
    /// <summary>
    /// permet de créer une nouvelle unité d'enseignemet
    /// </summary>
    public void AjouterUE(UE ue)
    {
        this.listUE.Add(ue);
    }
    /// <summary>
    /// renvoie la liste de tous les modules
    /// </summary>
    public Module[] ListeModules()
    {
        List<Module> modules = new List<Module>();
        foreach (UE e in this.listUE)
        {
            foreach (Module m in e.ListeModule())
            {
                modules.Add(m);
            }

        }
        return modules.ToArray();
    }
    /// <summary>
    /// renvoie la liste de tous les UE
    /// </summary>
    public UE[] ListeDesUE()
    {
        return this.listUE.ToArray();
    }
    /// <summary>
    /// obtenir un UE à partir de son nom
    /// </summary>
    public UE GetUE(string nomEU)
    {
        
        foreach (UE e in this.listUE)
        {
            if (e.Nom == nomEU)
            {
                return e;
            }

 
        }
        Console.WriteLine("Ue non existant");
        return null;
    }
   

   

}
