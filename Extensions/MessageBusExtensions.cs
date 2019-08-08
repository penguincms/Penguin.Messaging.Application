using Penguin.Messaging.Core;

namespace Penguin.Messaging.Application.Extensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public static class MessageBusExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        /// <summary>
        /// Sends a Startup message over the message bus
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        public static void Startup(this MessageBus messageBus) => messageBus.Send(new Penguin.Messaging.Application.Messages.Startup());

        /// <summary>
        /// Sends a Setup message over the message bus
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        public static void Setup(this MessageBus messageBus) => messageBus.Send(new Penguin.Messaging.Application.Messages.Setup());

        /// <summary>
        /// Sends a Shutdown message over the message bus
        /// </summary>
        /// <param name="messageBus">The message bus to use</param>
        public static void Shutdown(this MessageBus messageBus) => messageBus.Send(new Penguin.Messaging.Application.Messages.Shutdown());

        /// <summary>
        /// Sends a Setup message over the message bus
        /// </summary>
        /// <typeparam name="T">The type of the object being set up</typeparam>
        /// <param name="messageBus">The message bus to use</param>
        public static void Setup<T>(this MessageBus messageBus) => messageBus.Send(new Penguin.Messaging.Application.Messages.Setup<T>());
    }
}