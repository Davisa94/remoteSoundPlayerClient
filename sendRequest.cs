using System;

public class CPHInline
{
    public bool Execute()
    {
		CPH.SendWhisper("melonlore", "TestWhisper");
        foreach (var arg in args)
        {
			CPH.SendWhisper("melonlore", $"LogVars :: {arg.Key} = {arg.Value}");
            CPH.LogInfo($"LogVars :: {arg.Key} = {arg.Value}");
            CPH.LogInfo($"LogVars :: {arg.Key} = {arg.Value}");
			if (arg.Key == "rawInput")
			{
				CPH.SendMessage($"{arg.Value}");
			}
        }

        return true;
    }
}