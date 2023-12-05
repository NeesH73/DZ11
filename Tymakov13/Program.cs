using System;

namespace Tymakov13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 13.1 и 13.2: в классы добавлены свойства и индексаторы");
            Bank2 account = new Bank2(Type.savings);

            Console.WriteLine($"{account.AccountType} под номером {account.AccountNumber}: {account.AccountBalance} рублей. Владелец: {account.Holder}");

            account.DepositMoney(1000);
            account.WithdrawMoney(578);

            Console.WriteLine("Транзакции:");
            for (int i = 0; i < account.Transactions.Count; i++)
            {
                Console.WriteLine($"{account[i].AmountChange}, {account[i].TransactionDate}");
            }


            Console.WriteLine("Д/З 13.1 и 13.2: в класс добавлены свойства, создан класс с индексатором");

            Somebuilds Builds = new Somebuilds();

            Builds.AddBuild(new Builder(3, 3, 65, 3));
            Builds.AddBuild(new Builder(2, 2, 52, 2));
            Builds.AddBuild(new Builder(5, 4, 54, 3));
            Builds.AddBuild(new Builder(3, 6, 45, 2));
            Builds.AddBuild(new Builder(4, 2, 24, 3));
            Builds.AddBuild(new Builder(6, 3, 65, 1));
            Builds.AddBuild(new Builder(9, 4, 21, 4));
            Builds.AddBuild(new Builder(10, 3, 64, 2));
            Builds.AddBuild(new Builder(7, 2, 23, 2));
            Builds.AddBuild(new Builder(13, 6, 21, 3));

            for (int i = 0; i < Builds.Builds.Length; i++)
            {
                Console.WriteLine($"Высота: {Builds[i].Height}, количество квартир {Builds[i].CountFlats}, количетсво этажей {Builds[i].Countfloors}, количество подъездов {Builds[i].CountEntrance} номер дома: {Builds[i].IdBuilding} ");
                                  
            }




        }
    }
}
