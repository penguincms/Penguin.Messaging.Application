using Penguin.Messaging.Abstractions.Messages;

namespace Penguin.Messaging.Application.Messages
{
    /// <summary>
    /// A setup message representing the configuration of objects matching a specified type
    /// </summary>
    /// <typeparam name="T">The type of the object being set up</typeparam>
    public class Setup<T> : Message
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Setup() : base()
        {
        }

        #endregion Constructors
    }

    /// <summary>
    /// A setup message representing the configuration of objects
    /// </summary>
    public class Setup : Message
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance
        /// </summary>
        public Setup() : base()
        {
        }

        #endregion Constructors
    }
}