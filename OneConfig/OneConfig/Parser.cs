using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OneConfig
{
	class Parser
	{
		public static List<List<string>> BO4(string pathToGame)
		{
			//get lines from the config file
			//"C:\\Program Files (x86)\\Call of Duty Black Ops 4\\players\\config.ini"
			List<string> lines = new List<string>(System.IO.File.ReadAllLines(pathToGame));

			//pare down the file into core components
			/// input:
			/// mouse_filter = "0" // 0 to 10
			/// output:
			/// mouse_filter = "0"
			for (var i = 0; i < lines.Count; i++)
			{
				//if the line contains a comment, delete the comment part from the string
				if (lines[i].IndexOf("//") >= 0)
				{
					lines[i] = lines[i].Remove(lines[i].IndexOf("//"));
				}
				//delete the \r from each line
				if (lines[i] == "\r")
				{
					lines.RemoveRange(i, 1);
					i--;
				}
			}
			for(int m = 0; m<lines.Count; m++)
			{
				if(string.IsNullOrEmpty(lines[m])){
					lines.RemoveAt(m);
					--m;
				}
			}

			List<List<string>> formattedArr = new List<List<string>>();

			//splits them into 2 value arrays
			for (var j = 0; j < lines.Count; j++)
			{
				formattedArr.Add(new List<string>(lines[j].Split(" = ")));
			}
			//removes the '""' marks from the beginning and end of the values
			for (var k = 0; k < formattedArr.Count; k++)
			{
				var tempValue = formattedArr[k][1];
				tempValue = tempValue.Replace("\"", string.Empty);
				formattedArr[k][1] = tempValue.TrimEnd(' ');
			}
			Console.WriteLine(formattedArr);
			return formattedArr;
		}
	}
}
