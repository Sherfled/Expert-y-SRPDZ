using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }*/ 

        /* Creo que esta forma de hacerlo funcionaria, pero en nuestro caso, necesitamos saber mas informacion de la persona y del 
        Doctor para que sea mas facil identificarlos. Ademas de que podemos crear clases para el paciente y doctor y
        verificar en dichas clases si la informacion ingresada es correcta o no. */


        Pacient Person;
        string Appointment; 
        Doctor TheDoctor;
        public AppointmentService(Pacient Persona, DateTime date, string appoinmentPlace, Doctor ElDcotor)
        {
            this.Person = Persona;
            this.Appointment = appoinmentPlace;
            this.TheDoctor = ElDcotor;
        }


        public string CreateAppointment()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool isValid = true;

            if (Person.AddPacient() != "Trámite satisfactorio.")
            {
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(Appointment))
            {
                isValid = false;
            }

            if (TheDoctor.AddDoctor() != "El doctor se ha añadido.")
            {
                isValid = false;
            }

            if (isValid == true)
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            else
            {
                stringBuilder.Append("Unable to schedule appointment");
            }
            return stringBuilder.ToString();
        }
    }
}
