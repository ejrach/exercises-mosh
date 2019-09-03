using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            //...
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());            
        }

        //This is the method we use from the outside
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
