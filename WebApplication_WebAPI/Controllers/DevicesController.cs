using AutoMapper;
using HomeApi.Contracts.Models.Devices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication_WebAPI.Configuration;

namespace HomeAPI.Controllers
{
    /// <summary>
    /// Контроллер статусов устройств
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class DevicesController : ControllerBase
    {
        private IOptions<HomeOptions> _options;
        private IMapper _mapper;

        public DevicesController(IOptions<HomeOptions> options, IMapper mapper)
        {
            _options = options;
            _mapper = mapper;
        }

        /// <summary>
        /// Просмотр списка подключенных устройств
        /// </summary>
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            return StatusCode(200, "Устройства отсутствуют");
        }

        /// <summary>
        /// Добавление нового устройства
        /// </summary>
        [HttpPost]
        [Route("Add")]
        public IActionResult Add( 
            [FromBody] // Атрибут, указывающий, откуда брать значение объекта
            AddDeviceRequest request // Объект запроса
        )
        {
            return StatusCode(200, $"Устройство {request.Name} добавлено!");
        }
    }
}
