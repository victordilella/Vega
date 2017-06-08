using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{

    public class MakesController : Controller
    {
        private readonly VegaDbContext dbContext;

        public MakesController(VegaDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await dbContext.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}