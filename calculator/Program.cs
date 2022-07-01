using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace taschenrechner {
	class Program {
		static void Main(string[] args) {
			Console.Clear();
			Console.WriteLine("Hey there! welcome to Aland Calculator.\n");
			Console.WriteLine("Please enter an operand (+, -, /, *) \n");
			Console.WriteLine("Enter the action to be performed: ");  
			string input = Console.ReadLine();
			string num1 = "";
			string num2 = "";
			int type = 0;
			char operand = ' ';
			float answer = 0;
			
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] >= '0' && input[i] <= '9' && type == 0) {
					num1 += input[i];
					
				} else if (input[i] == '+' || input[i] == '-' || input[i] == '/'|| input[i] == '*') {
					operand = input[i];
					type = 1;
					
				} else if (input[i] >= '0' && input[i] <= '9') {
					num2 += input[i];
					
				} else {
					Console.WriteLine(input[i] + " crach");
					
				}
			}

			int number1 = Int32.Parse(num1);
			int number2 = Int32.Parse(num2);
			
			switch (operand) {
				case '+' : answer = number1 + number2; break;
				case '-' : answer = number1 - number2; break;
				case '*' : answer = number1 * number2; break;
				case '/' : answer = number1 / number2; break;
			}
			Console.WriteLine(num1 + "" + operand + "" + num2);
			Console.WriteLine(answer); 
		}
	}
}