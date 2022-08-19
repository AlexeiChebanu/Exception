using System;

namespace Exception_
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base("This exception is mine\nYou entered wrong data.\nTry again")
        {
             
        }

        public MyOwnException(string message) : base(message)
            {

            }
    }
}
