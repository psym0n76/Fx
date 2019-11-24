namespace Fx.Domain.Message.Interface
{
    public interface IResponse
    {
        string Text { get; set; }
        string Status { get; set; } 
    }
}