using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayasingAMC_4FiveToSeven.Services;

namespace SayasingAMC_4FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenServices = oddOrEvenService;
        }
        
        [HttpPost]
        [Route("OddOrEven/{EnterNumber}")]
        public string OddOrEven(int EnterNumber)
        {
            return _oddOrEvenServices.OddOrEven(EnterNumber);
        }
    }
}