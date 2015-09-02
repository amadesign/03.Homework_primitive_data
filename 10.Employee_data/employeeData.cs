namespace _10.Employee_data
{
    using System;

    class employeeData
    {
        static void Main(string[] args)
        {
            string firstName = "First name:";
            string firstNameIs = "Amanda";
            string firstNameAnd = firstName + " " + firstNameIs;
            Console.WriteLine(firstNameAnd);
            string lastName = "Last name:";
            string lastNameIs = "Jonson";
            string lastNameAnd = lastName + " " + lastNameIs;
            Console.WriteLine(lastNameAnd);
            string age = "Äge:";
            byte ageIs = 27;
            string ageAnd = age + " " + ageIs;
            Console.WriteLine(ageAnd);
            string gender = "Gender:";
            char genderIs = 'f';
            string genderAre = gender + " " + genderIs;
            Console.WriteLine(genderAre);
            string ID = "Personal ID:";
            long idIs = 8306112507;
            string idAre = ID + " " + idIs;
            Console.WriteLine(idAre);
            string number = "Unique Employee number:";
            int numberIs = 27563571;
            string numberAre = number + " " + numberIs;
            Console.WriteLine(numberAre);
        }
    }
}
