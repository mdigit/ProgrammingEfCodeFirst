using ProgrammingEfCodeFirst.Bll;

namespace ProgrammingEfCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PatientService();
            test.CreateNewPatient();
        }
    }
}
