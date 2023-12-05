using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 14.1 : Использование предопределенного условного атрибута для условного выполнения кода");

            Bank2 account = new Bank2();

            Console.WriteLine("Результат выполнения кода без символа условной компиляции: ");
            account.DumpToScreen();

            Console.WriteLine("Результат выполнения кода с символом условной компиляции: ");
            Attributecheck.DumpToScreen(account);


            Console.WriteLine("Упр. 14.2 : Создать пользовательский атрибут DeveloperInfoAttribute.");
            
            Type type = typeof(RationalNumber);
            DeveloperInfo1Attribute attribute = (DeveloperInfo1Attribute)Attribute.GetCustomAttribute(type, typeof(DeveloperInfo1Attribute));

            if (attribute != null)
            {
                Console.WriteLine("Сотрудник: " + attribute.Name);
                Console.WriteLine("Дата: " + attribute.Date);
            }

            Console.WriteLine("Д/З 14.1 : Создать пользовательский атрибут DeveloperInfoAttribute.");
            Type type1 = typeof(Builder);
            DeveloperInfo2Attribute attribute1 = (DeveloperInfo2Attribute)Attribute.GetCustomAttribute(type, typeof(DeveloperInfo2Attribute));
            if (attribute != null)
            {
                Console.WriteLine("Сотрудник: " + attribute1.DName);
                Console.WriteLine("Организация: " + attribute1.OName);
            }


        }
    }
}
