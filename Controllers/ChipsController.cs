using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChipsController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ChipsController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Add(ChipsRequest request)
        {
            Chips chips = _mapper.Map<Chips>(request);
            return Ok();
        }
    }
}
