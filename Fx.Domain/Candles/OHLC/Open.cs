﻿namespace Fx.Domain.Candles.OHLC
{
    public class Open : Price
    {
        public Open(decimal bid, decimal ask) : base(bid, ask)
        {
        }
    }
}