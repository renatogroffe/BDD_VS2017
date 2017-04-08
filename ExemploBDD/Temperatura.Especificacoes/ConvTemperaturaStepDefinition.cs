using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temperatura.Especificacoes
{
    [Binding]
    public sealed class ConvTemperaturaStepDefinition
    {
        private double _temperaturaFahrenheit;
        private double _temperaturaCelsius;
        private double _temperaturaKelvin;

        [Given("que o valor da temperatura é de (.*) graus Fahrenheit")]
        public void PreencherTemperaturaFahrenheit(double valorFahrenheit)
        {
            _temperaturaFahrenheit = valorFahrenheit;
        }

        [When("eu solicitar a conversão desta teperatura")]
        public void ProcessarConversao()
        {
            _temperaturaCelsius =
                ConversorTemperatura.FahrenheitParaCelsius(
                    _temperaturaFahrenheit);
            _temperaturaKelvin =
                ConversorTemperatura.FahrenheitParaKelvin(
                    _temperaturaFahrenheit);
        }

        [Then("o resultado da conversão para Celsius será de (.*) graus")]
        public void ValidarResultadoCelsius(double valorCelsius)
        {
            Assert.AreEqual(valorCelsius, _temperaturaCelsius);
        }

        [Then("o resultado da conversão para Kelvin será de (.*) graus")]
        public void ValidarResultadoKelvin(double valorKelvin)
        {
            Assert.AreEqual(valorKelvin, _temperaturaKelvin);
        }
    }
}