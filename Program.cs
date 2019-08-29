using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Добро пожаловать в меню онлайн-ресторана Yana's" );
            Console.WriteLine( "Вас приветствует онлайн-официант 'Мартино'" );
            Console.WriteLine( "Как я могу к Вам обращаться?" );
            String name = Console.ReadLine();
            Console.WriteLine( "Здравствуйте, " + name + "!" );
            Console.WriteLine( name + "," + " какой пункт меню Вы выберите: Закуски, Основные блюда, Напитки?" );
            String menu = Console.ReadLine();
            if (menu == "закуски" )
            {
                Console.WriteLine( "В таком случае рекомендую Вам:");
                Console.WriteLine( "*Страчетти с рукколой" );
                Console.WriteLine( "*Салат с мидиями" );
                Console.WriteLine( "*Карпаччо из осьминога с поке из авокадо и томатов" );
            }
            if (menu == "основные блюда" )
            {
                Console.WriteLine( "В таком случае рекомендую Вам:" );
                Console.WriteLine( "*Суп Минестроне" );
                Console.WriteLine( "*Равиоли" );
                Console.WriteLine( "*Ризотто" );
                Console.WriteLine( "*Лазанья" );
            }
            if (menu == "напитки")
            {
                Console.WriteLine("В таком случае рекомендую Вам:");
                Console.WriteLine("*Беллини");
                Console.WriteLine("*Граппа");
                Console.WriteLine("*Женепи");
                Console.WriteLine("*Апероль");
            }

            Console.ReadLine();
        }
    }
}
