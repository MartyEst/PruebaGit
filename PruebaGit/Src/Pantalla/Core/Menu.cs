using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla.Core
{
    public static class Menu
    {
        private static string salir = "Salir";
        private static int max = 5;


        public static string Menus(List<string> Cadenas, int x, int y)
        {
            Cadenas = Cadenas.Igualar();
            int index = 0;
            Console.CursorVisible = false;
            DrawMarco(x, y, x + max + 1, y + Cadenas.Count + 2);
            string ret = salir.Trim();

            while (true)
            {
                Cadenas.DrawTextos( 1, 1, index);
                ConsoleKey opc = Console.ReadKey(true).Key;
                if (opc == ConsoleKey.DownArrow)
                {
                    if (index < Cadenas.Count)
                        index++;
                    else
                        index = 0;
                }
                if (opc == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                    else
                        index = Cadenas.Count;
                }
                if (opc == ConsoleKey.Enter)
                {
                    if (index == Cadenas.Count)
                        break;
                    else
                    {
                        ret = Cadenas[index].Trim();
                        break;
                    }
                }

            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = true;
            return ret;
        }

        private static List<string> Igualar(this List<string> cadenas)
        {
            int  maxc = cadenas.Max(x => x.Length);
            if (maxc > max)
                max = maxc;
            for (int i = 0; i < cadenas.Count; i++)
                cadenas[i] = cadenas[i].AddSpace(max);
            salir = salir.AddSpace(max);
            return cadenas;
        }

        private static string AddSpace(this string cadena, int max)
        {
            for (int i = cadena.Length; i < max; i++)            
                cadena += " ";
            return cadena;
        }



        private static void DrawTextos(this List<string> cadenas, int x, int y, int index)
        {
            cadenas.Add(salir);

            for (int i = 0; i < cadenas.Count; i++)
            {
                Console.BackgroundColor = i == index ? ConsoleColor.Blue : ConsoleColor.Black;
                Console.ForegroundColor = i == index ? ConsoleColor.Yellow : ConsoleColor.White;
                cadenas[i].gotoXY(x, y + i);                
            }
            cadenas.Remove(salir);
        }



        private static void DrawMarco(int v1, int v2, int v3, int v4)
        {
            "╔".gotoXY(v1, v2 );
            "╚".gotoXY(v1, v4 );
            "╗".gotoXY(v3, v2 );
            "╝".gotoXY(v3, v4 );

            for (int i = v1 + 1; i < v3; i++)
            {
               "═".gotoXY(i, v2 );
               "═".gotoXY(i, v4 );
            }
            for (int i = v2 + 1; i < v4; i++)
            {
                 "║".gotoXY(v1, i);
                 "║".gotoXY(v3, i);
            }  
        }

        public static void gotoXY(this string cadena,int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(cadena);
        }

    }
}
