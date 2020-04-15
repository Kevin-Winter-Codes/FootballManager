﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace KWProjects.Clients.GeoNamesOrgClient
{
    internal class GeonameException : Exception
    {
        public GeonameException(XmlDocument doc)
            : base(doc.OuterXml)
        {
        }

        public static GeonameException CreateOnError(string geonameResult)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(geonameResult);

            XmlNode element = doc.SelectSingleNode("geonames/status");

            if (element == null)
                return null;

            return new GeonameException(doc);
        }

        public static void ThrowOnError(string geonameResult)
        {
            GeonameException e = CreateOnError(geonameResult);
            if (e != null)
                throw e;
        }
    }
}
