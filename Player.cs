using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.NewFolder1
{
    internal class Player
    {
        public Player(int x , int y,string l,string l1,string l2, string l3) 
        {
            px = x; py = y;
            line1 = l;
            line2 = l1;
            line3 = l2;
            line4 = l3;
        }
        public int px;
        public int py;
        public string line1;
        public string line2;
        public string line3;
        public string line4;
        static void erasePlayer(int x, int y)
        {
            Player s = new Player(x, y, "     *", "  :::::", " :::::", ":::::");
            Console.SetCursorPosition(s.px, s.py);
            Console.WriteLine("      ");
            Console.SetCursorPosition(s.px + 1, s.py + 1);
            Console.WriteLine("       ");
            Console.SetCursorPosition(s.px + 2, s.py + 2);
            Console.WriteLine("      ");
            Console.SetCursorPosition(s.px + 3, s.py + 3);
            Console.WriteLine("     ");
        }
        public void movePlayerLeft(int x, int y)
        {
            erasePlayer(x, y);
            x = x - 1;
            printPlayer(x, y);

        }
        public void movePlayerRigth(int x, int y)
        {
            erasePlayer(x, y);
            x = x + 1;
            printPlayer(x, y);

        }
        public void movePlayerUp(int x, int y)
        {
            erasePlayer(x, y);
            y = y - 1;
            printPlayer(x, y);

        }
        public void movePlayerDown(int x, int y)
        {
            erasePlayer(x, y);
            y = y + 1;
            printPlayer(x, y);

        }
        public void printPlayer(int x, int y)
        {
            Player s = new Player(x, y, "     *", "  :::::", " :::::", ":::::");
            Console.SetCursorPosition(s.px, s.py);
            Console.WriteLine(s.line1);
            Console.SetCursorPosition(s.px + 1, s.py + 1);
            Console.WriteLine(s.line2);
            Console.SetCursorPosition(s.px + 2, s.py + 2);
            Console.WriteLine(s.line3);
            Console.SetCursorPosition(s.px + 3, s.py + 3);
            Console.WriteLine(s.line4);
        }
    }
}
