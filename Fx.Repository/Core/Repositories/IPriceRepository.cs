using System.Collections.Generic;

namespace Fx.Repository
{
    public interface IPriceRepository
    {
        Price GetPrice(int id);
        IEnumerable<Price> GetPrices(int pageIndex, int pageSize);
        void AddPrice(Price price);
        void AddPrices(IEnumerable<Price> prices);
    }
}