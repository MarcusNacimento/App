using System.Runtime.Serialization;

namespace App.Persistence.Repositories
{
    [Serializable]
    internal class DbUpdateConcurrencyExcetion : Exception
    {
        public DbUpdateConcurrencyExcetion()
        {
        }

        public DbUpdateConcurrencyExcetion(string? message) : base(message)
        {
        }

        public DbUpdateConcurrencyExcetion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DbUpdateConcurrencyExcetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}