using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Benvindo ao Executor de Design Patterns");
            Console.WriteLine("=======================================");
            Console.WriteLine('\n');
            Console.WriteLine("=======================================");
            Console.WriteLine("Pressione : ");
            Console.WriteLine("=======================================");
            Console.WriteLine("(1) FactoryMethod ");
            Console.WriteLine("(2) AbstractFactory ");
            Console.WriteLine("(3) Singleton ");
            Console.WriteLine("(4) Adapter ");
            Console.WriteLine("(5) Facade ");
            Console.WriteLine("(6) Strategy ");
            Console.WriteLine('\n');
            Console.WriteLine("Qualquer outra tecla para sair");
            Console.WriteLine("=======================================");

            var opcao = Console.ReadKey();
            switch (opcao.KeyChar)
            {
                case '1':
                    FactoryMethodExecutor.Execute();
                    break;
                case '2':
                    AbstractFactoryExecutor.Execute();
                    break;
                case '3':
                    SingletonExecutor.Execute();
                    break;
                case '4':
                    AdapterExecutor.Execute();
                    break;
                case '5':
                    FacadeExecutor.Execute();
                    break;
                case '6':
                    StrategyExecutor.Execute();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Main(new string[] { });
        }
    }
}
