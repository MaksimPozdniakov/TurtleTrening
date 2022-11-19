using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtle2
{
    internal class Program
    {
        static void WriteT(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnLeft();
            Turtle.Move(size/3);
            Turtle.Angle = 90;
            Turtle.Move(size * 2 / 3);
        }
        static void WriteO(int x, int y, int size)
        {
            
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }
        static void WriteP(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size/2);
            WriteO(x,y - size/2, size / 2);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            
            WriteT(200,200,60);

            WriteO(240,200,30);

            WriteP(300,200,30);

            WriteT(340,200,30);
        }
    }
}
