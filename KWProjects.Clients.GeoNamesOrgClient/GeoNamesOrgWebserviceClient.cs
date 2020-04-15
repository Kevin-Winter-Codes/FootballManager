using KWProjects.Clients.GeoNamesOrgClient;
using KWProjects.Clients.GeoNamesOrgClient.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Xml;

namespace KWProjects.Client.GeonameOrgClient
{
    public static class GeoNamesOrgWebservice
    {
        #region WebClient - Factory

        private static WebClient webClient;

        public static WebClient CreateWebClient()
        {
            if (webClient == null)
            {
                webClient = new WebClient { Encoding = Encoding.UTF8 };
                webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);
                webClient.OpenReadCompleted += new OpenReadCompletedEventHandler(client_OpenReadCompleted);
                webClient.OpenWriteCompleted += new OpenWriteCompletedEventHandler(client_OpenWriteCompleted);
            }

            return webClient;
        }

        #endregion WebClient - Factory

        #region WebClient Events

        private static void client_OpenWriteCompleted(object sender, OpenWriteCompletedEventArgs e)
        {
#if Debug
                Debug.WriteLine("Methode: WebClient.OpenWriteCompleted");
                Debug.WriteLine(e.ToString());
                Debug.WriteLine("#####################################");
#endif
        }

        private static void client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
#if Debug
            Debug.WriteLine("Methode: WebClient.OpenReadCompleted");
            Debug.WriteLine(e.ToString());
            Debug.WriteLine("#####################################");
#endif
        }

        private static void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
#if Debug
            Debug.WriteLine("Methode: WebClient.DownloadStringCompleted");
            Debug.WriteLine(e.ToString());
            Debug.WriteLine("#####################################");
#endif
        }

        private static void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
#if Debug
            Debug.WriteLine("Methode: WebClient.DownloadProgressChanged");
            Debug.WriteLine(e.ToString());
            Debug.WriteLine("#####################################");
#endif
        }

        private static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
#if Debug
            Debug.WriteLine("Methode: WebClient.DownloadDataCompleted");
            Debug.WriteLine(e.ToString());
            Debug.WriteLine("#####################################");
#endif
        }

        #endregion WebClient Events

        public static Geoname GetRoot(string username)
        {
            //http://api.geonames.org/get?geonameId=6295630&username=demo&style=full

            string rootGeoNameId = "6295630";

            string url = String.Format("http://api.geonames.org/get?geonameId={0}&username={1}&style=full", rootGeoNameId, username);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);
            return new Geoname(xml);
        }

        public static Geoname Get(string geonameId, string username)
        {
            string url = String.Format("http://api.geonames.org/get?geonameId={0}&username={1}&style=full", geonameId, username);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);
            return new Geoname(xml);
        }

        public static byte[] GetCountryFlag(string CoundryCode)
        {
            string url = String.Format("http://www.geonames.org/flags/x/{0}.gif", CoundryCode.ToLower());

            Uri uri = new Uri(url);

            byte[] flag = CreateWebClient().DownloadData(url);
            return flag;
        }

        public static IList<Geoname> Children(string geonameId, string username, GeoNamesDataStyle style)
        {
            string url = String.Format("http://api.geonames.org/children?geonameId={0}&username={1}&style={2}", geonameId, username, GeoNamesDataStyle.Full);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);

            return CreateGeonameList(xml);
        }


        public static List<Geoname> TextSearch(string searchText, GeoNamesDataStyle style)
        {

            //http://api.geonames.org/search?q=london&maxRows=10&username=ffmcoder
            string url = String.Format("http://api.geonames.org/search?q={0}&maxRows=10&username=ffmcoder&style=full", searchText);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);

            return CreateGeonameList(xml);
        }

        public static List<Geoname> Hirachy(int geonameId, string username, GeoNamesDataStyle style)
        {
            string url = String.Format("http://api.geonames.org/hierarchy?geonameId={0}&username={1}&style={2}", geonameId, username, GeoNamesDataStyle.Full);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);

            return CreateGeonameList(xml);
        }

        public static IList<Geoname> Children(Geoname geoname, string username)
        {
            return Children(geoname.GeonameId, username, GeoNamesDataStyle.Full);
        }

        public static IList<Geoname> Children(int geonameId, string username, GeoNamesDataStyle style)
        {
            string url = String.Format("http://api.geonames.org/children?geonameId={0}&username={1}&style={2}", geonameId, username, style);
            Debug.WriteLine("Requesting " + url);

            string xml = CreateWebClient().DownloadString(url);
            GeonameException.ThrowOnError(xml);

            return CreateGeonameList(xml);
        }

        private static List<Geoname> CreateGeonameList(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            if (doc.DocumentElement == null)
                return new List<Geoname>();

            XmlNodeList root = doc.GetElementsByTagName("geonames");
            if (root.Count == 0)
                return new List<Geoname>();

            XmlElement geonames = (XmlElement)root[0];

            List<Geoname> names = new List<Geoname>();
            foreach (XmlElement element in geonames.GetElementsByTagName("geoname"))
            {
                Geoname n = new Geoname(element);
                names.Add(n);
            }

            return names;
        }
    }
}
