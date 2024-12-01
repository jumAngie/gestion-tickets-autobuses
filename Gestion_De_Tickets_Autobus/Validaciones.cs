using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public class Validaciones
    {
        public static bool soloNumeros(KeyPressEventArgs valorTecla)
        {
            if (Char.IsNumber(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else if (Char.IsControl(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else
            {
                valorTecla.Handled = true;
                return false;
            }
        }

        public static bool soloNumerosPrecio(KeyPressEventArgs valorTecla)
        {
            char valor = valorTecla.KeyChar;
            if (Char.IsNumber(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else if (Char.IsControl(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else if (valor == '.')
            {
                valorTecla.Handled = false;
                return true;
            }
            else
            {
                valorTecla.Handled = true;
                return false;
            }
        }

        public static bool validarEmail(string txtEmail)
        {
            return txtEmail != null && Regex.IsMatch(txtEmail,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
