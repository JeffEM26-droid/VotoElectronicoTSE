using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VotoElectronicoTSE
{
    internal class Seguridad
    {
        public static bool ValidarPassword(string password)
        {
            if (password.Length < 8 || password.Length > 15)
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

            return true;
        }

    }
}
