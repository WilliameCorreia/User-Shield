using System.Globalization;

namespace User_Shield.Api.Helpers
{
    public class AppException : Exception
    {
        // classe de exceção personalizada para lançar exceções específicas do aplicativo
        // que podem ser capturadas e tratadas dentro do aplicativo
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
