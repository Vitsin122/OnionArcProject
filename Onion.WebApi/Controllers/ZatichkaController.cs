using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionArcProject.Domain.Models;
using OnionArcProject.Domain.ModelsDTO;
using OnionArcProject.Interfaces.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZatichkaController : ControllerBase
    {
        private IServiceZatichka1 _serviceZatichka;
        private IMapper _mapper;
        private ILogger<ZatichkaController> _logger;
        public ZatichkaController(IMapper mapper, IServiceZatichka1 serviceZatichka1, ILogger<ZatichkaController> _logger)
        {
            _mapper = mapper;
            _serviceZatichka = serviceZatichka1;
            this._logger = _logger;
        }

        [HttpPost]
        [Route("CreateVender")]
        public IActionResult Create(VenderModelDTO venderDTO)
        {
            if (ModelState.IsValid)
            {
                var vender = _mapper.Map<Vender>(venderDTO);

                _serviceZatichka.CreateVender(vender);
                

                return Ok(vender);
            }
            return BadRequest("Not Correct Data");
        }
        [HttpGet]
        [Route("GetVender/{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }
    }
}
