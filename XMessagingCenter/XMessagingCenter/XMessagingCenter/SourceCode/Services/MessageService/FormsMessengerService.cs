using System;
using Xamarin.Forms;

namespace XMessagingCenter.SourceCode.Services.MessageService
{
    /*how to use
    1. Define Your Message

        public class AlbumCreatedMessage : IMessage
        {
            public readonly Album Album;

            public AlbumCreatedMessage(Album album)
            {
                Album = album;
            }
        }
        2. Send It Around

        var album = new Album
        {
            Id = Guid.NewGuid(),
            Title = "Hello World"
        };

        // An instance of IMessenger
        Messenger.Send(new AlbumCreatedMessage(album));
        3. Subscribe To It

        // An instance of IMessenger
        Messenger.Subscribe<AlbumCreatedMessage>(this, AlbumAdded);

        private void AlbumAdded(object sender, AlbumCreatedMessage Message)
        {
            // Do something
        }
        4. When You're Done, Unsubscribe

        Messenger.Unsubscribe<AlbumCreatedMessage>(this);
        */
    public class FormsMessengerService : IMessenger
    {
        private static readonly Lazy<FormsMessengerService> Lazy =
        new Lazy<FormsMessengerService>(() => new FormsMessengerService());

        public static IMessenger Instance => Lazy.Value;

        private FormsMessengerService()
        {
        }
        public void Send<TMessage>(TMessage message, object sender = null) where TMessage : IMessage
        {
            if (sender == null)
                sender = new object();

            MessagingCenter.Send(sender, typeof(TMessage).FullName, message);
        }

        public void Subscribe<TMessage>(object subscriber, Action<object, TMessage> callback) where TMessage : IMessage
        {
            MessagingCenter.Subscribe(subscriber, typeof(TMessage).FullName, callback);
        }

        public void Unsubscribe<TMessage>(object subscriber) where TMessage : IMessage
        {
            MessagingCenter.Unsubscribe<object, TMessage>(subscriber, typeof(TMessage).FullName);
        }
    }
}
