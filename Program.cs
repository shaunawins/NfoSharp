using System.IO;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using NfoSharp.NfoDtos;

namespace NfoSharp
{
    public class NfoSharp
    {
        public static void Main(string[] args)
        {
            var m = new Movie();
            m.Title = "Movie Title";
            m.Ratings = new List<Rating>();
            var r = new Rating();
            r.Name = "custom";
            r.Value = "10";
            m.Ratings.Add(new Rating());
            var x = m.SerializeToXml();
            Console.WriteLine(x.ToString());
        }
    }
}
