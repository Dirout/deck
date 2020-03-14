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
		Console.WriteLine("Channel manager is ready.");
		var manInput = Console.ReadLine();
		var channelCommand = chunkInput(manInput)[0];
		var commandOptions = getCommandOptions(chunkInput(manInput));
		if(channelCommand.Equals("create", StringComparison.OrdinalIgnoreCase))
		{
			if(!File.Exists("./_channels/" + commandOptions + ".md"))
			{
				var defaultChannel = "---\ntitle: " + commandOptions + "\nlayout: channel\nsource: \"\"\nmute: true\nautoplay: false\n---\n{% inc player.html %}";
				using (FileStream fs = File.Create("./_channels/" + commandOptions + ".md"))
				{
						fs.Write(Encoding.UTF8.GetBytes(defaultChannel), 0, Encoding.UTF8.GetBytes(defaultChannel).Length);
				}
			}
		}
	}
	public static string getCommandOptions(string[] chunkedInput)
	{
		string commandOptions = "";
		for(int i = 1; i < chunkedInput.Length; i++)
		{
			commandOptions += chunkedInput[i];
		}
		return commandOptions;
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
