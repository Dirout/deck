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
		if(channelCommand.Equals("create", StringComparison.OrdinalIgnoreCase))
		{
			var commandOptions = getCommandOptions(chunkInput(manInput), 2);
			if(!File.Exists("./_channels/" + chunkInput(manInput)[1] + ".md"))
			{
				var defaultChannel = "---\ntitle: " + commandOptions + "\nlayout: channel\nsource: \"\"\nmute: true\nautoplay: false\n---\n{% inc player.html %}";
				using (FileStream fs = File.Create("./_channels/" + chunkInput(manInput)[1] + ".md"))
				{
						fs.Write(Encoding.UTF8.GetBytes(defaultChannel), 0, Encoding.UTF8.GetBytes(defaultChannel).Length);
				}
			}
		}
		else if(channelCommand.Equals("delete", StringComparison.OrdinalIgnoreCase))
		{
			if(File.Exists("./_channels/" + chunkInput(manInput)[1] + ".md"))
			{
				File.Delete("./_channels/" + chunkInput(manInput)[1] + ".md");
			}
		}
		else if(channelCommand.Equals("modify", StringComparison.OrdinalIgnoreCase))
		{
			var commandOptions = getCommandOptions(chunkInput(manInput), 2);
			string channelContents = "";
			for(int i = 6; i < File.ReadAllLines("./_channels/" + chunkInput(manInput)[1] + ".md").Length; i++)
			{
				channelContents += File.ReadAllLines("./_channels/" + chunkInput(manInput)[1] + ".md")[i];
			}
			channelContents = commandOptions + channelContents;
			using (FileStream fs = File.Create("./_channels/" + chunkInput(manInput)[1] + ".md"))
			{
					fs.Write(Encoding.UTF8.GetBytes(channelContents), 0, Encoding.UTF8.GetBytes(channelContents).Length);
			}
		}
	}
	public static string getCommandOptions(string[] chunkedInput, int initial)
	{
		string commandOptions = "";
		for(int i = initial; i < chunkedInput.Length; i++)
		{
			commandOptions += " " + chunkedInput[i];
		}
		return commandOptions.Trim();
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
