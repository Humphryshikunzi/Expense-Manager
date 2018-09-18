using System;

namespace Expense_Manager
{
    public class Person
    {
        private static string name2;
        private static int Id;
        private static  int Phonenumber;

        public static string Name1(string name1)
        {
            Console.WriteLine("Enter your Firstname");
            name1 = Console.ReadLine();
           // Console.WriteLine(name1);
            return name1;
        }
        public static string Name2()
        {
            Console.WriteLine("Enter your secondname");
            name2 = Console.ReadLine();
            return name2;
        }
        public static  int Nummer()
        {
            Console.WriteLine("Enter your contacts");
            Phonenumber =int.Parse( Console.ReadLine());
            return Phonenumber;
        }
        public static int ID()
        {
            Console.WriteLine("Enter your National Id or PassportNumber");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public Person(float index)
        {
            float ValueCarriedhere = Expenditure.DailyStartAmount();
            Console.WriteLine("Name    :Humphry");
            Console.WriteLine("Id      :36058390");
            Console.WriteLine("Number  :0742267032");
            Console.WriteLine("Amount  :" + ValueCarriedhere);
        }
        public static void DetailGuidance ()
           {
            Console.WriteLine("Welcome to expense Manager,manage your budget and save your funds");
            Console.WriteLine("Create account ");
            Console.WriteLine("Enter your Firstname");
            Person.Name1("Me");
            Console.WriteLine("Enter your secondname");
            Person.Name2();
            Console.WriteLine("Enter your contacts");
            Person.ID();
            Console.WriteLine("Enter your National Id or PassportNumber");
            Person.Nummer();
           }


    }

    
    
        
    
}