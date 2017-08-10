using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public static class PersonHelper
    {
        public static string GetNombre(string ap_pater, string ap_mater, string pri_nom, string seg_nom, string razon_social)
        {
            string nombre = "";
            nombre = string.Format("{0} {1} {2} {3}", ap_pater, ap_mater, pri_nom, seg_nom);
            nombre.Replace("   ", " ");
            nombre.Replace("  ", " ");
            nombre = nombre.Trim();
            if (razon_social != "" && nombre != "")
                nombre += " | " + razon_social;
            else if (razon_social != "" && nombre == "")
                nombre = razon_social;

            return nombre;

        }

        public static string GetDireccion(string direc1, string direc2)
        {
            if (direc1 != "" && direc2 != "")
                return string.Format("{0} | {1}", direc1, direc2);
            else if (direc1 != "" && direc2 == "")
                return direc1;
            else if (direc1 == "" && direc2 != "")
                return direc2;
            else return "";
        }
    }
}
