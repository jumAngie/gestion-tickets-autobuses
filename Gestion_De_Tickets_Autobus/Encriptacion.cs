using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus
{
    public class Encriptacion
    {
        public static byte[] Encrip(string contrasenia)
        {
            if (string.IsNullOrEmpty(contrasenia))
            {
                throw new ArgumentException("La contraseña no puede ser nula o vacía");
            }

            using (SHA512 sha512 = SHA512.Create())
            {

                byte[] bytesContrasenia = Encoding.Unicode.GetBytes(contrasenia);

                return sha512.ComputeHash(bytesContrasenia);
            }
        }
    }
}
