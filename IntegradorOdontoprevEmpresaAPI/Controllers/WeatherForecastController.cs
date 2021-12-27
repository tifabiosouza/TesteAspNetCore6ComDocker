using IntegradorOdontoprevEmpresaAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IntegradorOdontoprevEmpresaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IServico _servico;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IServico servico)
        {
            _servico = servico;
            _logger = logger;
        }

        [HttpGet(Name = "GetsWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(string nome)
        {
            var dados = _servico.ObterTodos();

            return dados.Where(w => w.Summary == nome);
        }

        [HttpGet("GetAll" , Name = "All")]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _servico.ObterTodos();
        }
    }
}