using System;
using System.Diagnostics;
namespace Wzsckj.com.Common
{
    public class RSS
    {
        public struct Channel
        {
            public string title;
            public string link;
            public string description;
            public string copyright;
            public string language;
            public string pubDate;
            public string lastBuildDate;
            public string generator;
        }
        public struct Item
        {
            public string title;
            public string link;
            public string description;
            public string category;
            public string author;
            public string pubDate;
        }
        [DebuggerNonUserCode]
        public RSS()
        {
        }
    }
}
