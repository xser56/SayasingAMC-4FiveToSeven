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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaservices;
        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaservices)
        {
            _reverseItAlphaservices = reverseItAlphaservices;
        }

        [HttpPost]
        [Route("ReverseAlpha/{EnterSequenceHere}")]
        public string ReverseNumbers(string EnterSequenceHere)
        {
            return _reverseItAlphaservices.ReverseSequence(EnterSequenceHere);
        }
    }
}