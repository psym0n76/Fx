using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fx.Repository.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandleController : ControllerBase
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public CandleController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}


        // GET: api/Candle
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var unitOfWork = new UnitOfWork(new FxContext());
            unitOfWork.Candle.GetCandles(100, 100);

            return new string[] { "value1", "value2" };
        }

        // GET: api/Candle/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var unitOfWork = new UnitOfWork(new FxContext());
            unitOfWork.Candle.GetCandles(100, 100);


            return "";
            //return new string[] { "value1", "value2" };

        }

        // POST: api/Candle
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Candle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
