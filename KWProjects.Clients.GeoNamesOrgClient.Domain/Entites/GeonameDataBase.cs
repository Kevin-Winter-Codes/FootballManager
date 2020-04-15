using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace KWProjects.Clients.GeoNamesOrgClient.Domain.Entities
{
    public class GeonameDataBase
    {
        public XmlElement xml;

        public decimal ToDecimal(string str)
        {
            if (str == "")
                return 0;

            try
            {
                return XmlConvert.ToDecimal(str);
            }
            catch
            {
                return 0;
            }
        }

        public int ToInt(string str)
        {
            if (str == "")
                return 0;

            try
            {
                return XmlConvert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
        }

        public DateTime ToDataTime(string str)
        {
            if (str == "")
                return DateTime.MinValue;

            try
            {
                return Convert.ToDateTime(str);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public string GetElement(XmlElement doc, string name)
        {
            XmlNodeList elements = doc.GetElementsByTagName(name);

            if (elements.Count == 0)
                return "";

            return elements[0].InnerXml;
        }
    }
}
