using System;

namespace Temperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(
            double temperatura)
        {
            return Math.Round(
                (temperatura - 32.0) / 1.8, 2);
        }

        public static double FahrenheitParaKelvin(
             double temperatura)
        {
            return FahrenheitParaCelsius(temperatura) + 273.15;
        }
    }
}