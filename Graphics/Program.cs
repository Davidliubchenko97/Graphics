using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

 class Square
{
    decimal x1, y1, x2, y2;
    public Square(decimal a1, decimal a2, decimal b1, decimal b2)
    {
        x1 = a1;
        x2 = a2;
        y1 = b1;
        y2 = b2;

    }
    public void Draw()
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        graphics.DrawLine(0xFF000000, (int)x1, (int)x2, (int)y1, (int)y2, 6);
       
    }
    public void Draw2()
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        graphics.DrawLine(0xFFFFFF00, (int)x1, (int)x2, (int)y1, (int)y2, 6);

    }
    public void Draw3()
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        graphics.DrawLine(0xFFFF0000, (int)x1, (int)x2, (int)y1, (int)y2, 6);

    }
    public void Draw4()
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        graphics.DrawLine(0xFF00FF00, (int)x1, (int)x2, (int)y1, (int)y2, 6);

    }
    public void Draw5()
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        graphics.DrawLine(0xFF0000FF, (int)x1, (int)x2, (int)y1, (int)y2, 6);

    }

}

class Program
{
    static void Main(string[] args)
    {
        ConsoleGraphics graphics = new ConsoleGraphics();
        Console.CursorVisible = false;
        //   graphics.DrawLine(0xFFFF0000, 100, 50, 100, 120, 5);
        //  graphics.DrawLine(0xFFFF0000, 100, 120, 180, 120, 5);
        // graphics.DrawLine(0xFFFF0000, 100, 50, 180, 50, 5);
        //  graphics.DrawLine(0xFFFF0000, 180, 50, 180, 120, 5);
        //  Console.ReadLine();
        Square[] square = new Square[360];


        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 100, 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 100);
            square[i].Draw();

        }
        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 99, 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 99);
            square[i].Draw5();

        }
        graphics.DrawLine(0xFF000000, 100, 0, (int)(100 + 50 * Math.Sqrt(3)), 150, 2);
        graphics.DrawLine(0xFF000000, (int)(100 + 50 * Math.Sqrt(3)), 150, (int)(100 - 50 * Math.Sqrt(3)), 150, 2);
        graphics.DrawLine(0xFF000000, (int)(100 - 50 * Math.Sqrt(3)), 150, 100, 0, 2);

        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 50, 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 50);
            square[i].Draw();

        }
        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 49, 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 49);
            square[i].Draw3();

        }

        //ебаная циклоида
        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(60, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 50, (315 + (decimal)Math.Cos((Math.PI / 180) + i) * 50)/ (decimal)Math.PI);
            square[i].Draw();
        }
        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(60, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 49, (315 + (decimal)Math.Cos((Math.PI / 180) + i) * 48) / (decimal)Math.PI);
            square[i].Draw2();
        }


        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 100/ (2*(decimal)Math.PI), 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 100 / (2 * (decimal)Math.PI));
            square[i].Draw();

        }
        for (int i = 0; i < 360; i++)
        {
            square[i] = new Square(100, 100, 100 + (decimal)Math.Sin((Math.PI / 180) + i) * 98 / (2 * (decimal)Math.PI), 100 + (decimal)Math.Cos((Math.PI / 180) + i) * 98 / (2 * (decimal)Math.PI));
            square[i].Draw4();

        }



        graphics.DrawLine(0xFF0000FF, 100, 93, 100, 107, 2);
        //for (int i = 0; i < 4; i++)
        //{
        //    graphics.DrawLine(0xFFFF0000, 200, 200, 180, 120, 5);



        //}


        Console.ReadLine();

    }
}

