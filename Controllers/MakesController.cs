using System.Collections.Generic;
using System.Linq;
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
            return await dbContext.Makes.ToListAsync();
        }

        [HttpGet("/api/make/{id}")]
        public async Task<IEnumerable<Make>> GetMake(int id)
        {
            return await dbContext.Makes.Where(x => x.Id == id).ToListAsync();
        }
    }
}