using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarketplace.API.Data;

namespace OnlineMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var result= await _dataContext.Products.ToListAsync();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]

        public async Task<IActionResult> GetProduct(int id)
        {
            var result = await _dataContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}