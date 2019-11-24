using System.Collections.Generic;
using Fx.Domain.Message.Interface;

namespace Fx.Domain.Message.Request
{
    public class RequestCandle:IRequest
    {
        public string Text { get; set; }
        public IList<string> Properties { get; set; }
        public string Status { get; set; }
    }
}