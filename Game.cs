using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using EZInput;
using Game.NewFolder1;
using Game.NewFolder2;
namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int x = 20; int y=20;
            int ex = 2;
            int ey = 2;
            Player player = new Player(x, y, "     *", "  :::::", " :::::", ":::::");
            player.printPlayer(20,20);
            int ex1 = 70;
            int ey1 = 3;
            Enemy enemy = new Enemy(ex, ey, "     ___", "   (o o)", " /|   |\\", " |   |");
            Enemy enemy1 = new Enemy(ex1, ey1, "     ___", "   (o o)", " /|   |\\", " |   |");
            enemy.printEnemy(2, 2, "     ___", "   (o o)", " /|   |\\", " |   |");
           enemy1. printEnemy(ex1, ey1, "     ___", "   (o o)", " /|   |\\", " |   |");
            while (true)
            {   
                if(Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player.movePlayerLeft(x, y);
                    x--;
                }
                if(Keyboard.IsKeyPressed(Key.RightArrow))
                {
                   player. movePlayerRigth(x, y);
                    x++;
                }
                if(Keyboard.IsKeyPressed (Key.UpArrow))
                {
                   player. movePlayerUp(x, y);
                    y--;
                }
                if(Keyboard.IsKeyPressed(Key.DownArrow))
                {
                  player.  movePlayerDown(x, y);
                    y++;
                }

                enemy.moveEnemy(ex, ey, "     ___", "   (o o)", " /|   |\\", " |   |");
               enemy1. moveEnemy(ex1+1,ey1-1, "     ___", "   (o o)", " /|   |\\", " |   |");
                if (ex==60)
                {
                   enemy. eraseEnemy(ex + 1, ey+1, "     ___", "   (o o)", " /|   |\\", " |   |");
                    ex =2;
                   
                }
                if(ey1==25)
                { 
                    enemy1.eraseEnemy(ex1+1, ey1, "     ___", "   (o o)", " /|   |\\", " |   |");
                    ey1 = 2;
                }
                
                    ex++;
                ey1++;
               Thread.Sleep(50);
            }
            
        }
        
     
    }
}
