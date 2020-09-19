using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("WebApiPolicy")]
    public class ValuesController : ControllerBase
    {

        private readonly Context _context;

        public ValuesController(Context context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            string json;
            try
            {
                //Converted object to json
                json = JsonConvert.SerializeObject(_context.Variables.ToArray(), Formatting.Indented);
            }
            catch (Exception e)
            {
                return null;
            }
            return json; 
        }
        
    }
}
