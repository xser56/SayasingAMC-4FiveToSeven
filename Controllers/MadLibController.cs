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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }
        
        [HttpPost]
        [Route("MadLib/{YourName}/{animal}/{name2}/{place}/{adjective}/{noun}/{emotion}/{adjective2}")]
        public string MadLib(string YourName, string animal, string name2, string place, string adjective, string noun, string emotion, string adjective2)
        {
            return _madLibServices.MadLib(YourName, animal, name2, place, adjective, noun, emotion, adjective2);
        }
    }
}