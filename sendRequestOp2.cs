using System;
using System.Net;
using System.Collections.Specialized;

public class CPHInline
{
   private static readonly String targetURL = "localhost:8080";
   private static bool SendRequest(NameValueCollection postData)
   {
      //send the request off
      var client = new WebClient();
      var response = client.UploadValues(targetURL, "POST", postData);
      return true;
   }

   public bool Execute()
   {
      var postValues = new NameValueCollection();
      foreach (var arg in args)
      {
         CPH.LogInfo($"LogVars :: {arg.Key} = {arg.Value}");
         if (arg.Key == "rawInput")
         {
            // TODO: Change this to remove extra qoute once it is removed in the server
            postValues[$"{arg.Key}"] = $"\"{arg.Value}\"";
            CPH.SendMessage($"{arg.Value}");
         }
      }
      var result = SendRequest(postValues);
      return true;
   }
}