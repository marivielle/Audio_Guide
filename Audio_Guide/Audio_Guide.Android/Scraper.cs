using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HtmlAgilityPack;

namespace Audio_Guide.Droid
{
    class Scraper
    {
        public Scraper()
        {

        }

        public HtmlNodeCollection getNodes(String website, String xpathQuery) { 
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(website);

            var nodecollection = htmlDoc.DocumentNode.SelectNodes(xpathQuery);

            return nodecollection;
        }
    }
}