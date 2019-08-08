using Penguin.Messaging.Abstractions.Messages;

namespace Penguin.Messaging.Application.Messages
{
    /// <summary>
    /// A message intended to be sent at the end of the application lifecycle
    /// </summary>
    public class Shutdown : Message
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Shutdown() : base()
        {
        }

        #endregion Constructors
    }
}