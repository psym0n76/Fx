﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Fx.Repository
{
    public class TradeRepository : Repository<Trade>,ITradeRepository
    {
        public TradeRepository(DbContext context) : base(context)
        {
        }

        public FxContext FxDatabaseContext => Context as FxContext;

        public Trade GetTrade(int id)
        {
            return FxDatabaseContext.Trades.Find(id);
        }

        public IEnumerable<Trade> GetTrades(int pageIndex, int pageSize)
        {
            return FxDatabaseContext.Trades.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public void AddTrade(Trade trade)
        {
            FxDatabaseContext.Trades.Add(trade);
        }

        public void AddTrades(IEnumerable<Trade> trades)
        {
            FxDatabaseContext.Trades.AddRange(trades);
        }
    }
}