using System;

namespace TestMedWinFormsApp.Exceptions
{
    internal class RegistrationException : Exception
    {
        public RegistrationException():base()
        {            
        }

        public RegistrationException(string message):base(message)
        {
        }
    }
}
