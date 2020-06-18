using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StemApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace StemApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

            private readonly DataContext _context;
            public ValuesController (DataContext context)
            {
                _context = context;
            }
            ///Summary
            
            [HttpGet]
            public  async Task<IActionResult> GetValues()
            {
                var values = await _context.Values.ToListAsync();
                return Ok(values); 
            }

            [HttpGet("{id}")]
            public IActionResult GetValue(int id){
                try{
                      var value = _context.Values.FirstOrDefault(x=> x.Id == id);
                      return Ok(value);
                }
               catch{
                   throw new Exception("Not able to find the values in Database...Please Try it later...!!!");
               }
            }
    }
}