using System;

namespace TestMedWinFormsApp.Exceptions
{
    internal class DBException : Exception
    {
        public DBException() : base()
        {
        }

        public DBException(string message) : base(message)
        {
        }
    }
}
