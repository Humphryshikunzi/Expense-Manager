using System;
using System.IO;

namespace Expense_Manager
{
    public class Expenditure
    {
        
        public Expenditure()
        {
            Console.WriteLine(
                "1.Breakfast ,Ksh 30 \n2.Lunch, Ksh 80 \n3.Supper, Ksh 60 \n4.Credit, Ksh 40 \n5.Miscelleneous");

        }

        public static float Amount = DailyStartAmount();
        public static float Balance { get; set; }
        public static void NumberofItems()
        {
            Console.WriteLine("How many Items did you spend on Today ?");
            int items = int.Parse(Console.ReadLine());
            for (int i = 1; i < items; i++)
            {
                Expenses();
            }
        }

        public static float  Expenses()
        {
            Console.WriteLine("Which among the following did you have today  ?");
            Expenditure E = new Expenditure();
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Amount -= 30;
                    break;
                case 2:
                    Amount -= 80;
                    break;
                case 3:
                    Amount -= 60;
                    break;
                case 4:
                    Amount -= 40;
                    break;
                case 5:
                    float m;
                    Console.WriteLine("How much did you spend on miscelleneous");
                    m = float.Parse(Console.ReadLine());
                    Amount -= m;
                    break;
                              
            }
            Console.WriteLine(Amount);
            return Amount;
            
          
        }
        public static float DailyStartAmount()
        {

                    StreamReader readamount = new StreamReader(@"C:\Users\user\Desktop\Programming\C#\ExpenseManagerAmountMonitor.txt");
                    string line = readamount.ReadLine();
               float     n= float.Parse(line);
                    readamount.Close();
                    
        
            return n;
        }
        public static float valuetobewrittenondatabase()
        {
            Program p = new Program();
          float value=  p.remainigbalance();
            StreamWriter writebalance = File.CreateText(@"C:\Users\user\Desktop\Programming\C#\ExpenseManagerAmountMonitor.txt");
            writebalance.WriteLine(value);
            writebalance.Close();
            return value;
        }

        public static void Records()
        {
            Program p = new Program();
            float value = p.remainigbalance();
            string Code = IDGenerator.Id();
            StreamWriter writebalance = new StreamWriter(@"C:\Users\user\Desktop\Programming\C#\Testfor open and close.Json");
            writebalance.WriteLine(value);
            writebalance.WriteLine(Code);
            writebalance.WriteLine("Date and Time:" + DateTime.Now);
            writebalance.Close();
            
        }

    }
}