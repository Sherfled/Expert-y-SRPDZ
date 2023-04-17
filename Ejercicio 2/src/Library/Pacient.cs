using System;
using System.Text;

namespace Library
{
    public class Pacient
    {
        string Name;
        string IdNumber;
        int Age;
        string PhoneNumber;
        
        public Pacient(string name, string idnumber, int age, string phonenumber)
        {
            this.Name = name;
            this.IdNumber = idnumber;
            this.Age = age;
            this.PhoneNumber = phonenumber;
        }

        public string AddPacient()
        {
            if ((string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(IdNumber)) || ((18 < Age) || string.IsNullOrEmpty(PhoneNumber))) // No se por que me da "false" en (Age > 18)
            {
                return "Falta algun dato.";
            } 
            else
            {
                return "Trámite satisfactorio.";
            }
        }
    }

}