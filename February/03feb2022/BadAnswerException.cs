using System.Runtime.Serialization;

namespace PracticeWithHashesAndArrays
{
    [Serializable]
    internal class BadAnswerException : Exception
    {
        public BadAnswerException()
        {
        }

        public BadAnswerException(string? message) : base(message)
        {
        }

        public BadAnswerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BadAnswerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}