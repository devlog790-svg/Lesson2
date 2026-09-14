using System;
using System.Collections.Generic;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> EnemyHp = new Dictionary<string, int>();
            EnemyHp.Add("Zombie!", 100);
            EnemyHp.Add("Boss!", 200);
            EnemyHp.Add("Player!", 50);
            EnemyHp["Boss!"] = 350;
            Console.WriteLine(EnemyHp["Boss!"]);
            
        }

           
        
    }
}
