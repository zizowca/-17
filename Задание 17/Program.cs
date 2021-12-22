using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> numb1 = new Account <int>("Иванов Иван Петрович", 077, 50000);
            numb1.AccountRead();
            Account<string> numb2 = new Account<string>("Сулейманов Ильдар Маратович", "RT016", 80000);
            numb2.AccountRead();
            Account<int> numb3 = new Account<int>("Васильев Юрий Николаевич", 058, 20000);
            numb3.AccountRead();
            Account<string> numb4 = new Account<string>("Сара Джесика Паркер", "USA0015", 5000000);
            numb4.AccountRead();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        T numb;
        double balance;
        string name;
        public T Numb 
        {
            set
            {
                numb = value;
            }
            get
            {
                return numb;
            }
        }
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Account(string name, T numb, double balance)
        {
            Numb = numb;
            Name = name;
            Balance = balance;
        }
        public void AccountRead()
        {
            Console.WriteLine("ФИО владеьца счета:\t{0}",Name);
            Console.WriteLine("Номер счета:\t\t{0}", numb);
            Console.WriteLine("Баланс на счету:\t{0:N2}", Balance);
            Console.WriteLine();
        }

    }
}
