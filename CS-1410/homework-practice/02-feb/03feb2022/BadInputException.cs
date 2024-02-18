using System.Runtime.Serialization;

namespace PracticeWithHashesAndArrays
{
    [Serializable]
    internal class BadInputException : Exception
    {
        public BadInputException()
        {
        }

        public BadInputException(string? message) : base(message)
        {
        }

        public BadInputException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BadInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}