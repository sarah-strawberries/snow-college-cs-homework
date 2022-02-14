using System.Runtime.Serialization;

[Serializable]
internal class BadPhoneNumberException : Exception
{
    public BadPhoneNumberException()
    {
    }

    public BadPhoneNumberException(string? message) : base(message)
    {
    }

    public BadPhoneNumberException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected BadPhoneNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}