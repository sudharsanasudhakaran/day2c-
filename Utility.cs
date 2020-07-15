using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
	public class Utility
	{
		public static String LastWord(int position, String stringVariable, char charToParse)
		{
			String[] ans = stringVariable.Split(charToParse);
			String s = "message";
			if (ans.Length >= position)
			{
				return ans[position - 1];
			}
			return s;
		}
		public void GetPalindromes(String[] s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i].Equals(Array.Reverse(s[i])))
				{
					Console.WriteLine(s[i]);
				}
			}
		}	

	}
}
