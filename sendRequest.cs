using System;
using System.Net.Http;
using System.Collections.Generic;

public class CPHInline
{
	async private void SendRequest(Dictionary<string,string> postData)
	{
      //send the request off
      var content = new FormUrlEncodedContent(postValues);
      var response = await client.PostAsync(targetURL, content);
      var responseString = await response.Content.ReadAsStringAsync();
	}
   private static readonly HttpClient client = new HttpClient();
   private static readonly String targetURL = "localhost:8080";
   async public bool Execute()
   {
      var postValues = new Dictionary<string, string> {};
      CPH.SendWhisper("melonlore", "TestWhisper");
      foreach (var arg in args)
      {
         CPH.SendWhisper("melonlore", $"LogVars :: {arg.Key} = {arg.Value}");
         CPH.LogInfo($"LogVars :: {arg.Key} = {arg.Value}");
         CPH.LogInfo($"LogVars :: {arg.Key} = {arg.Value}");
         if (arg.Key == "rawInput")
         {
            postValues.Add($"{arg.Key}", $"{arg.Value}");
            CPH.SendMessage($"{arg.Value}");
         }
      }

      return true;
   }
}