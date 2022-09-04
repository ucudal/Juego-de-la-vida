using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class BoardPrinter
    {
        public class Board
    {
        public Board Largo {get;}
        public Board Ancho {get;}
        public Board Tablero {get;}

        public Board(bool[,] tablero)
        {
            this.Largo = tablero.GetLength(1);
            this.Ancho = tablero.GetLength(0);
            this.Tablero = tablero;  
        }
    }
        public void Printer()
        {
            bool[,] b ;
            int width; 
            int height; 
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
            }
        }
    }
}