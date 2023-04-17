using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        string Name;
        string Speciality;
        public Doctor(string name, string speciality)
        {
            this.Name = name;
            this.Speciality = speciality;
        }

        public string AddDoctor(/* string Name, string Speciality*/ )
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Speciality))
            {
                return "Falta algun dato del doctor para poder agregarlo a la consulta.";
            }
            else
            {
                return "El doctor se ha añadido."; 
            }
        }
    }
}