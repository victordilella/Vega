using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{

    public class MakesController : Controller
    {
        private readonly VegaDbContext dbContext;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext dbContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await dbContext.Makes.ToListAsync();
        }

        [HttpGet("/api/make/{id}")]
        public async Task<IEnumerable<MakeResource>> GetMake(int id)
        {
            var makes = await dbContext.Makes.Where(x => x.Id == id).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}