using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Person Sarah = new Person("Sarah", "Croche", 21, "Femme")
        Person Marc = new Person("Marc", "Eurindelebile", 35, "Homme");
        
        string AgeDeSarah = Srah.GetInfo("Age");
        Console.WriteLine($"Sarah a {AgeDeSarah}.);
        
        Marc.Birthday();
        
        List<string> InfoDeSarah = Sarah.GetAllInfo();
        
        for (int i = 0; i < InfoDeSarah.Count; i+) {
            Console.writeLine(InfoDeSarah[i]);
        }
    }
}

public class Person {
    public static int NombreDePersonne { get; set; } = 0;
    public static List<Person> Personnes { get; } = new List<Person>();
    
    public string FirstName { get; set; 
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; };
    
    public Person(string fn, strin ln, int a, string g) {
        NombreDePersonne += 1;
        
        FirstName = fn;
        LastName = ln;
        Age = a;
        Gender = g;
        
        Personnes.Add(this);
    }
    
    public void Hello() {
        Console.WriteLine($"{this.FirstName} {this.LastName} says hello !";
    }
    
    public string GetInfo(string info) {
        if (info == "FirstName") {
            return this.FirstName;
        } else if (info == "LastName") {
            return this.LastName;
        } else if (info == "Age") {
            return this.Age.ToString();
        } else if (info = "Gender") {
            return this.Gender;
        } else {
            return $"No information named {info} !";
        }
    }
    
    public List<string> Infos;
    
    public List<string> GetAllInfo() {
        Infos = new List<string> {this.FirstName, this.LastName, this.Age.ToString(), this.Gender};
        return Infos;
    }
    
    public void Birthday() {
        this.Age += 1;
        
        print($"Bon anniversaire {this.FirstName} {this.LastName} !! Tu as maintenant {this.Age.ToString()} !!");
    }
}
