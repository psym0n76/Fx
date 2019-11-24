
using Fx.Domain.Message.Response;

namespace Fx.MessageBus.Wrapper.Publishers
{
    public interface INetQPublish
    {
        void PublishMessage(string message);
        void PublishTradeMessage(ResponseTrade message);
        void PublishCandleMessage(ResponseCandle message);
    }
}