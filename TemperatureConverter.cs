using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
	public static class TemperatureConverter
		{
			public static double FromCelsiusToFahrenheit(int v)
			{
				double sum = (v * (9 / 5)) + 32;
				return sum;
			}

			public static double FromFahrenheitToCelsius(int v)
			{
				double sum = (v - 32) * 5 / 9;
				return sum;
			}
		}
}
