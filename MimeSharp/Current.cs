using System;
using System.Collections.Generic;
using System.Text;

namespace MimeSharp
{
    public static class Current
    {
        static MimeSharp _service;
        static MimeSharp Service => _service = _service ?? new MimeSharp();

        public static string Lookup(string filePath) => Service.Lookup(filePath);

        public static string DefaultType() => Service.DefaultType();

        public static List<string> Extension(string mimeType) => Service.Extension(mimeType);
    }
}
