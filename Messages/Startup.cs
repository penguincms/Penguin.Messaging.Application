using Penguin.Messaging.Abstractions.Messages;

namespace Penguin.Messaging.Application.Messages
{
    /// <summary>
    /// A message intended to be sent at the beginning of the application lifecycle
    /// </summary>
    public class Startup : Message
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Startup() : base()
        {
        }

        #endregion Constructors
    }
}