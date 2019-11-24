using Fx.Domain.Message.Interface;

namespace Fx.Domain.Message.Response
{
    public class ResponsePrice : IResponse
    {
        public string Text { get; set; }
        public string Status { get; set; }
    }
}