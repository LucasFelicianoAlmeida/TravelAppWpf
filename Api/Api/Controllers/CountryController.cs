using Api.Context;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly IUnityOfWork _uow;
        public CountryController(IUnityOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var list = _uow.CountryRepository.Get();
                return Ok(list);
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}
