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
	[XmlElement(ElementName="movie")]
	public Movie Movie { get; set; }
	[XmlElement(ElementName="tvshow")]
	public Tvshow Tvshow { get; set; }
	[XmlElement(ElementName="episodedetails")]
	public Episodedetails Episodedetails { get; set; }
	[XmlElement(ElementName="musicvideo")]
	public Musicvideo Musicvideo { get; set; }
    }

}
