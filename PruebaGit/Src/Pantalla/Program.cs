
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
                    switch (res)
                    {
                        case "Uno": $"Ustes eligio {res}".gotoXY(20,20); break;
                        case "Dos": $"Ustes eligio {res}".gotoXY(20, 20); break;
                        case "Tres": $"Ustes eligio {res}".gotoXY(20, 20); break;
                        case "Cuatro": $"Ustes eligio {res}".gotoXY(20, 20); break;
                        default:
                            break;
                    }

            } while (!res.Equals("Salir"));
        }
    }
}
