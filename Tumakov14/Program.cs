using System;
using System.Reflection;

namespace Tumakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //УПРАЖНЕНИЕ 14.1
            Console.WriteLine("УПРАЖНЕНИЕ 14.1\n");

            BankAcc bankAcc = new BankAcc(AccType.Текущий_счет);

            Console.WriteLine("Код без символа условной компиляции: ");
            bankAcc.DumpToScreen();

            Console.WriteLine("\nКод с символом условной компиляции: ");
            AtributCheck.CallingMethodDumpToScreen(bankAcc);


            //УПРАЖНЕНИЕ 14.2
            Console.WriteLine("\nУПРАЖНЕНИЕ 14.2");

            MemberInfo typeInfo = typeof(RationalNum);
            object[] attributes = typeInfo.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfo1Attribut)
                {
                    DeveloperInfo1Attribut developerInfo = (DeveloperInfo1Attribut)attribute;
                    Console.WriteLine($"Разработчик: {developerInfo.DeveloperName}\t Дата создания: {developerInfo.ClassDevelopmentDate}");
                }
            }


            //ДОМАШНЕЕ ЗАДАНИЕ 14.1
            Console.WriteLine("\nДОМАШНЕЕ ЗАДАНИЕ 14.1");

            typeInfo = typeof(Building);
            attributes = typeInfo.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfo2Attribut)
                {
                    DeveloperInfo2Attribut developerInfo = (DeveloperInfo2Attribut)attribute;
                    Console.WriteLine($"Разработчик: {developerInfo.DeveloperName}\t Организация: {developerInfo.OrganizationName}");
                }
            }
        }

    }
}
