using ProgrammingEfCodeFirst.Dal;
using ProgrammingEfCodeFirst.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingEfCodeFirst.Bll
{
    class PatientService
    {
        public void CreateNewPatient()
        {
            using (var context = new VetContext())
            {
                var patient = context.Patients.Include("Visits").FirstOrDefault(x => x.Name == "Markus");
                if (patient != null)
                {
                    Console.WriteLine($"Visits[0] = {patient.Visits[0].Date}");
                }
                else
                {
                    patient = GetPatient();
                    context.Patients.Add(patient);
                    context.SaveChanges();
                }
            }
        }

        private Patient GetPatient()
        {
            var dog = new AnimalType { TypeName = "Dog" };
            var firstVisit = new DateTime(2015, 1, 1);
            var patient = new Patient
            {
                Name = "Markus",
                BirthDate = new DateTime(1988, 1, 1),
                AnimalType = dog,
                FirstVisit = firstVisit,
                Visits = new List<Visit>
                {
                    new Visit {Date=firstVisit }
                }
            };

            return patient;
        }
    }
}
