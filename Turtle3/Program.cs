using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown; // данная команда позволяет управлять черепашкой с клавиатуры
            Turtle.PenUp(); // не рисуем шлейф за черепашкой
            //Turtle.PenDown(); // рисуем шлейф за черепашкой
            
            GraphicsWindow.BrushColor = "Red"; // подкрашиваем еду в красный цвет.
            var eat = Shapes.AddRectangle(10,10); // создаем переменную в которую заносим команду рисующую квадратик, это наша еда.
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y); // данной командой перемещаем еду (переменная eat) в центр экрана.

            Random rand = new Random();

            while (true)
            {
                Turtle.Move(10);
                if(Turtle.X >= x && Turtle.X <= x+10 && Turtle.Y >= y && Turtle.Y >= y+10)
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = x = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                }
            }
        }

        private static void GraphicsWindow_KeyDown() // в данную команду мы записываем значения клавиш. Описание каждой клавиши ниже. ниже
        {
            if(GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
