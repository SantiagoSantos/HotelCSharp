namespace HotelCSharp.Exceptions
{
    public class DocumentosInvalidosException : Exception
    {
        public DocumentosInvalidosException(): base("Documentos inválidos, verifique.") {}
        public DocumentosInvalidosException(string message) : base(message) {}
        public DocumentosInvalidosException(string message, System.Exception inner) : base(message, inner) {}
        public DocumentosInvalidosException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) {}   
    }
}