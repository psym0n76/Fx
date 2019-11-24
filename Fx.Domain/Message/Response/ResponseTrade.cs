using System.Collections.Generic;
using Fx.Domain.Message.Dto;
using Fx.Domain.Message.Interface;

namespace Fx.Domain.Message.Response
{
    public class ResponseTrade : IResponse
    {
        public string Text { get; set; }
        public string Status { get; set; }
        public List<TradeDto> Type { get; set; }
    }
}