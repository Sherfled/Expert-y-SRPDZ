﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */



        

            Pacient Persona = new Pacient("Steven Jhonson", "986782342", 24, "5555-555-555");
            
            Doctor ElDoc = new Doctor("Armand", "Oculista");
          
            AppointmentService appointmentResult = new AppointmentService(Persona, DateTime.Now, "Wall Street", ElDoc);
            Console.WriteLine(appointmentResult.CreateAppointment());
        }
    }
}
