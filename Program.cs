
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGP_game
{
    class Program
    {
        public class Person
        {
            public string nick;
            public string type;
            public int health;
            public int damage;
            public Person(string nick)
            {
                this.nick = nick;
            }
            public void fight()
            {
                Console.WriteLine("Нажмите клавишу 'я' для наступления (русский яз.)" );
                Console.WriteLine("Нажмите клавишу 'ч' для бегства (русский яз.)");
                char but;
                int monster;
                but = char.Parse(Console.ReadLine());
                if (but == 'ч') { health -= 100; Console.WriteLine("Беги, трус! Позор тебе!"); }
                if (but == 'я')
                {
                    Random random = new Random();
                    monster = random.Next(1, 60);
                    while ((health > 0) && (monster > 0))
                    {
                        int next = random.Next(1, 10);
                        if (next % 2 == 0) { health -= 6; Console.WriteLine($"Здоровье:{health}"); }
                        if (next % 2 != 0) { monster -= 12; Console.WriteLine($"Здоровье врага:{monster}"); }
                    }
                    if (health <= 0) { Console.WriteLine("Game over"); }
                    else if (monster <= 0) { Console.WriteLine("Win!"); }
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ghost of Tsusima");
            Console.WriteLine("Имя воина:");
            Person gg = new Person(Console.ReadLine());
            Console.WriteLine("Стиль борьбы воина:");
            Console.WriteLine("Самурай или Шиноби");
            gg.type = Console.ReadLine();
            if (gg.type == "Самурай") { gg.health = 60; gg.damage = 55; }
            else if (gg.type == "Шиноби") { gg.health = 48; gg.damage = 40; }

            Console.WriteLine($"Имя: {gg.nick}, класс: {gg.type}");
            Console.WriteLine($"Здорорвье: {gg.health}, Урон: {gg.damage}");
            gg.fight();
            Console.ReadKey(); 
        }
    }
}