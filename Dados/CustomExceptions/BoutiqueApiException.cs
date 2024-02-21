using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.CustomExceptions
{
    public class BoutiqueApiException : Exception

    {
        public BoutiqueApiException(string? message, int statuscode) : base(message)
        {
            Statuscode = statuscode;
        }

        public int Statuscode { get; }
    }
}
