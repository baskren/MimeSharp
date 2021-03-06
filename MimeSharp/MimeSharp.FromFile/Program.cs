﻿using System;
using Newtonsoft.Json;

namespace MimeSharp
{
    class MainClass
    {
#pragma warning disable CC0057 // Unused parameters
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
#pragma warning restore CC0057 // Unused parameters
        {
            var MimeSharp = new MimeSharp();

            Console.WriteLine("MimeSharp example usage: ");
            Console.WriteLine("MIME type for {0} is {1}", "song.ogg", MimeSharp.Lookup(@"song.ogg"));
            Console.WriteLine("The default MIME type is {0}", MimeSharp.DefaultType());
            Console.WriteLine("File extensions that match the mime type {0} are :", "audio/ogg");
            Console.WriteLine(JsonConvert.SerializeObject(MimeSharp.Extension("audio/ogg")));
        }
    }
}
