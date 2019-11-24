
namespace Fx.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly FxContext _context;

        public UnitOfWork(FxContext context)
        {
            _context = context;
            Price = new PriceRepository(_context);
            Candle = new CandleRepository(_context);
            Trade = new TradeRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IPriceRepository Price { get; }
        public ITradeRepository Trade { get; }
        public ICandleRepository Candle { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}