namespace Fx.MessageBus.Wrapper.Subscribers
{
    public interface INetQSubscriber
    {
        void SubscribeCandleMessage();
        void SubscribeTradeMessage();
    }
}