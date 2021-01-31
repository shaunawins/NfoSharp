using System.IO;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using NfoSharp.NfoDtos;

namespace NfoSharp
{
    public static class NfoSharp
    {
        public static bool GeneratedNfos { get; set; } = true;
        public static string UniqueidType { get; set; } = "generated";
    }
    
    // Todo: Put code in here to parse an XML and return a properly typed NFO
    public class Nfo {
        public void Parse(XDocument NfoFile){
            // Try serializing and return proper type of NFO 
        }
        public void Parse(FileInfo NfoFile) => 
            XDocument.Parse(File.ReadAllText(NfoFile.FullName));
    }

}
