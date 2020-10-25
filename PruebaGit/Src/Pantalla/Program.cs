
using Pantalla.Core;
using System;
using System.Collections.Generic;

namespace Pantalla
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Cadenas = new List<string>() { "Uno", "Dos", "Tres", "Cuatro" };
            string res = "";
            do
            {
             res = Menu.Menus(Cadenas,0,0);
                if(!res.Equals("Salir"))
                    "                                       ".gotoXY(20, 20);
                switch (res)
                    {
                        case "Uno": $"Usted eligio {res}".gotoXY(20,20); break;
                        case "Dos": $"Usted eligio {res}".gotoXY(20, 20); break;
                        case "Tres": $"Usted eligio {res}".gotoXY(20, 20); break;
                        case "Cuatro": $"Usted eligio {res}".gotoXY(20, 20); break;
                        default:
                            break;
                    }

            } while (!res.Equals("Salir"));
        }
    }
}
