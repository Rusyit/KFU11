using System;

namespace Tumakov13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //УПРАЖНЕНИЕ 13.1 И 13.2
            Console.WriteLine("УПРАЖНЕНИЕ 13.1 И 13.2.\n");

            BankAcc bankAcc = new BankAcc(AccType.Текущий_счет);

            Console.WriteLine($"{bankAcc.BankAccType} под номером {bankAcc.AccNum:D16}: {bankAcc.AccBalance} рублей. Владелец: {bankAcc.AccHolder}");
            
            Console.WriteLine("\nВведите сумму, которую хотите внести:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите сумму, которую хотите снять: ");
            decimal b = decimal.Parse(Console.ReadLine());

            bankAcc.PutMoney(a);
            bankAcc.MoreMoney(b);

            Console.WriteLine("\nТранзакции:");
            for (int i = 0; i < bankAcc.TransactionList.Count; i++)
            {
                Console.WriteLine($"{bankAcc[i].AmountChange}, {bankAcc[i].TransactionDate}");
            }


            // ДОМАШНЕЕ ЗАДАНИЕ 13.1 И 13.2
            Console.WriteLine("\nДОМАШНЕЕ ЗАДАНИЕ 13.1 И 13.2.\n");

            DifferentBuildings differentBuildings = new DifferentBuildings();

            differentBuildings.AddingBuildingToArray(new Building(10, 9, 8, 7));
            differentBuildings.AddingBuildingToArray(new Building(6, 5, 4, 3));
            differentBuildings.AddingBuildingToArray(new Building(2, 1, 0, 1));
            differentBuildings.AddingBuildingToArray(new Building(2, 3, 4, 5));
            differentBuildings.AddingBuildingToArray(new Building(6, 7, 8, 9));
            differentBuildings.AddingBuildingToArray(new Building(10, 4, 3, 2));
            differentBuildings.AddingBuildingToArray(new Building(11, 5, 78, 3));
            differentBuildings.AddingBuildingToArray(new Building(12, 4, 45, 4));
            differentBuildings.AddingBuildingToArray(new Building(13, 3, 10, 4));
            differentBuildings.AddingBuildingToArray(new Building(4, 2, 29, 7));

            for (int i = 0; i < differentBuildings.BuildingsArray.Length; i++)
            {
                Console.WriteLine($"Высота: {differentBuildings[i].BuildingHeight}, количество квартир {differentBuildings[i].NumOfAparts}, номер дома: " +
                                  $"{differentBuildings[i].BuildingNum:D3}");
            }
        }
    }
}
