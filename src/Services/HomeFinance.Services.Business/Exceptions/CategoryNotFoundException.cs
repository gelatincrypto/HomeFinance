using System;

namespace HomeFinance.Services.Business.Exceptions
{
    [Serializable]
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException()
        { }

        public CategoryNotFoundException(string message)
            : base(message)
        { }

        public CategoryNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}