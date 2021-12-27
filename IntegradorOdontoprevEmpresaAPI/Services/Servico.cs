using IntegradorOdontoprevEmpresaAPI.Services.Interfaces;

namespace IntegradorOdontoprevEmpresaAPI.Services
{
    public class Servico : IServico
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static IEnumerable<WeatherForecast>? _lista;
        public IEnumerable<WeatherForecast> ObterTodos()
        {
            if (_lista == null)
                _lista = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }).ToArray();

            return _lista;
        }
    }
}
