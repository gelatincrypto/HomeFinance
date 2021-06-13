using System;

namespace HomeFinance.Services.Business.Exceptions
{
    [Serializable]
    public class CategoryAlreadyExistException : Exception
    {
        public CategoryAlreadyExistException()
        { }

        public CategoryAlreadyExistException(string message)
            : base(message)
        { }

        public CategoryAlreadyExistException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}