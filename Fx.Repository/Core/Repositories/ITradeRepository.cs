using System.Collections.Generic;

namespace Fx.Repository
{
    public interface ITradeRepository
    {
        Trade GetTrade(int id);
        IEnumerable<Trade> GetTrades(int pageIndex, int pageSize);
        void AddTrade(Trade candle);
        void AddTrades(IEnumerable<Trade> candles);
    }
}