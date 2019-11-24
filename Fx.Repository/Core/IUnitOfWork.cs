using System;

namespace Fx.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        //list each tables interface
        IPriceRepository Price { get; }
        ICandleRepository Candle { get; }
        ITradeRepository Trade { get; }

        int Complete();
    }
}