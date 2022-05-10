using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class ConsumerController : Controller
    {

        private readonly RegistryContext _context;

        public ConsumerController(RegistryContext context)
        {
            _context = context;
        }

        // GET: api/Registry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registry>>> GetRegistry()
        {




            return await _context.Registries.ToListAsync();
        }
    }
}
