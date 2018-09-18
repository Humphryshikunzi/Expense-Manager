using System;
using static System.Console;
namespace Expense_Manager
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
             Console.Title="Expense Manager";
         
            Program k = new Program();
            k.Details();
            Expenditure.NumberofItems();
            string IdGenerated = IDGenerator.Id();
           
           
            Expenditure.valuetobewrittenondatabase();
            Expenditure.Records();
            Console.Clear();
           Console.WriteLine("Remaining balance:"+Expenditure.Amount);
            Console.WriteLine("Transaction code :"+IdGenerated);
            Console.WriteLine("Date and Time    :" +DateTime.Now);
          
            Console.ReadKey();
        }
      public  string name;
        
        public  string Details()
        {

            Console.WriteLine(" Enter your name");
               name = Console.ReadLine();
            string name1 = "Humphry";
            Console.BackgroundColor = ConsoleColor.Blue;
            if (name == name1)
            { Person p = new Person(14); }
            else
         Console.WriteLine(" name does not exist in the system,try again or create new account");
            return name;          
        }
        
        public  float remainigbalance()
        {
            float x = Expenditure.Expenses();
            return x;

        }
        public  string AssigningNameToDetails()
        {
            string locate = Details();
            return locate;
        }
   
    }
       
        
    }
    
    