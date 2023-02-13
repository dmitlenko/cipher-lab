using System;

namespace CipherLabs.Core
{
    public class CipherException : Exception
    {
        public CipherException()
        { }

        public CipherException(string message) : base(message)
        {
        }
    }
}