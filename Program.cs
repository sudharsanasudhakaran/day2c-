using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution;

namespace Program
{
	class Solution
	{
		static void Main(string[] args)
		{
			Utility u = new Utility();
			var result = Utility.LastWord(2, "Prathap", ' ');

			Console.WriteLine("Enter the position, string variable and character to parse");
			int position = Convert.ToInt32(Console.ReadLine());
			String stringVariable = Console.ReadLine();
			char charToParse = Console.ReadLine()[0];
			result = Utility.LastWord(position, stringVariable, charToParse);
			string[] stringArray = new string[10];
			for (int i = 0; i < stringArray.Length; i++)
			{
				stringArray[i] = Console.ReadLine();
			}
			Console.WriteLine(result);
			u.GetPalindromes(stringArray);
			Console.WriteLine("enter the temperature in celsius to convert");
			int c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(TemperatureConverter.FromCelsiusToFahrenheit(c) + "F");
			Console.WriteLine("enter the temperature in fahrenheit to convert");
			int f = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(TemperatureConverter.FromFahrenheitToCelsius(f) + "C");
		}
		
		public String stringReverse(String str)
		{
			char[] chars = str.ToCharArray();
			for (int i = 0, j = str.Length - 1; i < j; i++, j--)
			{
				chars[i] = str[j];
				chars[j] = str[i];
			}
			return new String(chars);
		}
	}


}

