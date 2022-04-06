using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public class AuthException : Exception
    {
        public AuthException (string Message) : base (Message)
        {

        }
    }
    public class InvalidUserException : AuthException
    {
        public InvalidUserException (string Message) : base (Message)
        {

        }
    }

    public class InvalidPasswordException : AuthException
    {
        public InvalidPasswordException (string Message) : base (Message)
        {
            
        }
    }

    public class Auth
    {
        public static void Login(string? login, string? password)  
        {
            if(login != "admin")
            {
                throw new InvalidUserException("Usuário inválido");
            }

            if (password != "admin")
            {
                throw new InvalidPasswordException("Senha inválida");
            }
        }
    }
}