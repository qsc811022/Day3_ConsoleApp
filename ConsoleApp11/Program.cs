using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	//Day3_
	class Program
	{
		static void Main(string[] args)
		{
			//string originalValue = "  abc def  ";
			//string trimLeft = originalValue.TrimStart();  //"abc def  "
			//string trimRight = originalValue.TrimEnd(); // "  abc def"
			//string trimResult = originalValue.Trim(); // "abc def"

			//Console.WriteLine(trimLeft);
			//Console.WriteLine(trimRight);
			//Console.WriteLine(trimResult);

			//string row = "**********"; // 太多星星,會昏頭
			//Console.WriteLine(row);

			//string row2 = new string('*', 10); // 指定數量, 一看就明白
			//Console.WriteLine(row2);

			//Console.WriteLine(new string('*', 1));
			//Console.WriteLine(new string('*', 2));
			//Console.WriteLine(new string('*', 3));
			//Console.WriteLine(new string('*', 4));
			//Console.WriteLine(new string('*', 5));
			string valueA = "AllEn";
			string valueB = "aLLeN";
			int result = string.Compare(valueA, valueB, StringComparison.CurrentCultureIgnoreCase);
			Console.WriteLine(result);



		}
	}


}
