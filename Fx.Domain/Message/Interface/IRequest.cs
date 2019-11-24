using System.Collections.Generic;

namespace Fx.Domain.Message.Interface
{
    public interface IRequest
    {
        string Text { get; set; }
        IList<string> Properties { get; set; }
        string Status { get; set; }
    }
}