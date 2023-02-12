using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherLabs.Core
{
    public class CipherException : Exception
    {
        public CipherException() { }

        public CipherException(string message) : base(message) { }
    }
}
