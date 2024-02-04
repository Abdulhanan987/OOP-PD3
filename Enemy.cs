using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.NewFolder2
{
    internal class Enemy
    {
        public Enemy(int x, int y, string l, string l2, string l3, string l4)
        {
            ex = x;
            ey = y;
            Char1 = l;
            Char2 = l2;
            Char3 = l3;
            Char4 = l4;
        }
        public int ex;
        public int ey;
        public string Char1;
        public string Char2;
        public string Char3;
        public string Char4;
        public void printEnemy(int x, int y, string l1, string l2, string l3, string l4)
        {
            Enemy enemy = new Enemy(x, y, l1, l2, l3, l4);
            Console.SetCursorPosition(enemy.ex, enemy.ey);
            Console.WriteLine(enemy.Char1);
            Console.SetCursorPosition(enemy.ex + 1, enemy.ey + 1);
            Console.WriteLine(enemy.Char2);
            Console.SetCursorPosition(enemy.ex + 2, enemy.ey + 2);
            Console.WriteLine(enemy.Char3);
            Console.SetCursorPosition(enemy.ex + 3, enemy.ey + 3);
            Console.WriteLine(enemy.Char4);
        }

        public void eraseEnemy(int x, int y, string l1, string l2, string l3, string l4)
        {
            Enemy enemy = new Enemy(x, y, l1, l2, l3, l4);
            Console.SetCursorPosition(enemy.ex, enemy.ey);
            Console.WriteLine("        ");
            Console.SetCursorPosition(enemy.ex + 1, enemy.ey + 1);
            Console.WriteLine("        ");
            Console.SetCursorPosition(enemy.ex + 2, enemy.ey + 2);
            Console.WriteLine("         ");
            Console.SetCursorPosition(enemy.ex + 3, enemy.ey + 3);
            Console.WriteLine("      ");
        }
        public void moveEnemy(int x, int y, string l1, string l2, string l3, string l4)
        {
            eraseEnemy(x, y, l1, l2, l3, l4);

            y = y + 1;
            printEnemy(x, y, l1, l2, l3, l4);
        }
    }
}
