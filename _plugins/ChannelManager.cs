using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;

public class ChannelManager
{
	public void Main(string[] args)
	{
		if(args[0].Equals("build", StringComparison.OrdinalIgnoreCase) || args[0].Equals("b", StringComparison.OrdinalIgnoreCase))
		{
			Console.WriteLine("Channel manager is ready.");
			var manInput = Console.ReadLine();
			if(chunkInput(manInput)[0].Equals("create", StringComparison.OrdinalIgnoreCase))
			{
				var defaultChannel = "---\ntitle: " + chunkInput(manInput)[1] + "\nlayout: channel\nsource: \"\"\nmute: true\nautoplay: false\n---\n{% include player.html %}";
				using (FileStream fs = File.Create("./_channels/" + chunkInput(manInput)[1] + ".md"))
        {
            fs.Write(Encoding.UTF8.GetBytes(defaultChannel), 0, Encoding.UTF8.GetBytes(defaultChannel).Length);
        }
			}
		}
	}
	public static string[] chunkInput(string input)
	{
		input = input.Trim();
		List<string> chunkedInput = new List<string>();
		string currentChunk = "";
		int lastSpace = 0;

		for(int i = 0; i < input.Length - 1; i++)
		{
			if(input[i].Equals(' '))
			{
				chunkedInput.Add(currentChunk);
				currentChunk = "";
				lastSpace = i;
			}
			else
			{
				currentChunk += input[i];
			}
		}
		currentChunk = "";

		for(int i = lastSpace + 1; i < input.Length; i++)
		{
			currentChunk += input[i];
		}
		chunkedInput.Add(currentChunk);

		return chunkedInput.ToArray();
	}
}
