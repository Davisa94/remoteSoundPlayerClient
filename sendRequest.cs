using System;
using System.Net.Http;
using System.Collections.Generic;

public class CPHInline
{
    private static readonly HttpClient client = new HttpClient();
    public bool Execute()
    {
        var postValues = new Dictionary<string, string>{};
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