using EasyNetQ;
using Fx.MessageBus.Wrapper.Publishers;
using Fx.Domain.Message.Response;

namespace Fx.MessageBus.Wrapper.Publishers
{
    public class NetQPublish : INetQPublish
    {
        private const string Host = "host=localhost";

        public void PublishMessage(string message)
        {
            using (var bus = RabbitHutch.CreateBus(Host))
            {
                bus.Publish(message);
            }
        }


        public void PublishTradeMessage(ResponseTrade message)
        {
            using (var bus = RabbitHutch.CreateBus(Host))
            {

                bus.Publish<ResponseTrade>(message);
            }
        }

        public void PublishCandleMessage(ResponseCandle message)
        {
            using (var bus = RabbitHutch.CreateBus(Host))
            {

                bus.Publish<ResponseCandle>(message);
            }
        }

    }
}