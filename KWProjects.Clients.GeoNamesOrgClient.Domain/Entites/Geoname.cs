
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace KWProjects.Clients.GeoNamesOrgClient.Domain.Entities
{
    public class Geoname : GeonameDataBase, IGeoBase
    {
        public Geoname()
        {
        }

        public Geoname(string genonameXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(genonameXml);

            if (doc.DocumentElement == null)
                return;

            XmlNodeList root = doc.GetElementsByTagName("geoname");
            if (root.Count == 0)
                return;

            xml = (XmlElement)root[0];

            Init();
        }

        public Geoname(XmlElement geoname)
        {
            xml = geoname;
            Init();
        }

        public void Init()
        {
            this.Name = GetElement(xml, "name");
            this.CountryCode = GetElement(xml, "countryCode");
            this.CountryName = GetElement(xml, "countryName");
            this.Fcl = GetElement(xml, "fcl");
            this.FCode = GetElement(xml, "fcode");
            this.FclName = GetElement(xml, "fclName");
            this.FCodeName = GetElement(xml, "fcodeName");
            //this.ContinentCode = GetElement(xml, "continentCode");

            this.AdminCode1 = GetElement(xml, "adminCode1");
            this.AdminCode2 = GetElement(xml, "adminCode2");
            this.AdminName1 = GetElement(xml, "adminName1");
            this.AdminName2 = GetElement(xml, "adminName2");

            this.Latitude = ToDecimal(GetElement(xml, "lat"));
            this.Longitude = ToDecimal(GetElement(xml, "lng"));

            this.GeonameId = Convert.ToInt32(GetElement(xml, "geonameId"));

            if (GetElement(xml, "population") != string.Empty)
                this.Population = Convert.ToInt64(GetElement(xml, "population"));
        }

        // public string Username { get; set; }

        #region IGeoBase

        //public string ToponymName
        //{
        //    get;
        //    set;
        //}

        public string Name
        {
            get;
            set;
        }

        public int GeonameId
        {
            get;
            set;
        }

        public string CountryCode
        {
            get;
            set;
        }

        public string CountryName
        {
            get;
            set;
        }

        public string Fcl
        {
            get;
            set;
        }

        public string FclName
        {
            get;
            set;
        }

        public string FCode
        {
            get;
            set;
        }

        public string FCodeName
        {
            get;
            set;
        }

        public long Population
        {
            get;
            set;
        }

        public string AsciiName
        {
            get;
            set;
        }

        public string AdminCode1
        {
            get;
            set;
        }

        public string AdminCode2
        {
            get;
            set;
        }

        public string AdminName1
        {
            get;
            set;
        }

        public string AdminName2
        {
            get;
            set;
        }

        public decimal Latitude
        {
            get;
            set;
        }

        public decimal Longitude
        {
            get;
            set;
        }

        #endregion IGeoBase

        public IEnumerable<AlternateName> AlternateNames()
        {
            if (xml == null)
                yield break;

            XmlNodeList nodes = xml.SelectNodes("alternateName");
            if (nodes == null)
                yield break;

            foreach (XmlElement node in nodes)
            {
                AlternateName a = new AlternateName();

                if (node.HasAttribute("isShortName"))
                {
                    a.IsShortName = Convert.ToBoolean(node.GetAttribute("isShortName"));
                }

                if (node.HasAttribute("isPreferredName"))
                {
                    a.IsPreferredName = Convert.ToBoolean(node.GetAttribute("isPreferredName"));
                }

                if (node.HasAttribute("lang"))
                {
                    a.Language = node.GetAttribute("lang");
                    a.Name = node.InnerText;
                }

                yield return a;
            }
        }


        public string GetTranslatedName(string LanguageCode)
        {
            List<AlternateName> allAlternateNames = AlternateNames().ToList();

            var result = from c in allAlternateNames
                         where c.Language == LanguageCode
                         select c;

            if (!result.Any())
                return this.Name;

            return result.First().Name;

        }

        //public List<Geoname> Children()
        //{
        //    return GeoNamesOrgWebservice.Children(this, "ffmcoder");
        //}

        //public List<Geoname> Children(string SelectedUsername = "ffmcoder")
        //{
        //    return GeoNamesOrgWebservice.Children(this, SelectedUsername);
        //}

        public GeoTyp CheckGeoname()
        {
            // EA
            if (FCode == "AREA" && Latitude == 0 && Longitude == 0)
            {
                return GeoTyp.World;
            }

            if (FCode == "CONT")
            {
                return GeoTyp.Continent;
            }

            if (FCode == "PCLI")
            {
                return GeoTyp.Country;
            }

            if (FCode == "ADM1")
            {
                return GeoTyp.State;
            }

            if (FCode == "ADM2")
            {
                return GeoTyp.PartOfState;
            }

            if (FCode == "ADM3")
            {
                return GeoTyp.District;
            }

            if (FCode == "ADM4" || FCode == "PPL")
            {
                return GeoTyp.City;
            }

            return GeoTyp.None;
        }


        public string ContinentCode
        {
            get;
            set;
        }
    }
}

//EARTH
//<geoname>
//<toponymName>Earth</toponymName>
//<name>Earth</name>
//<lat>0</lat>
//<lng>0</lng>
//<geonameId>6295630</geonameId>
//<countryCode/>
//<countryName/>
//<fcl>L</fcl>
//<fcode>AREA</fcode>
//<fclName>parks,area, ...</fclName>
//<fcodeName>area</fcodeName>
//<population>6814400000</population>
//<asciiName>Earth</asciiName>
//<alternateNames>
//Aarde,Earth,Er shary,Erde,Foeld,Föld,Ge,Globe,Globo,Jorden,Lurra,Maa,Monde,Mondo,Mundo,Mundua,Orbs,Pamant,Pamânt,Pianeta Terra,Planeta Tierra,Tero,Terra,Terre,Tierra,Welt,World,Ydrogeios,Yeryuezue,Yeryüzü,Zeme,Zemlja,Ziemia,el mon,el món,el planeta,nuestro planeta,prthvi,Γη,Υδρόγειος,Ер шары,Земля,Җir shary,Җир шары,पृथ्वी
//</alternateNames>
//<elevation/>
//<srtm3>-32768</srtm3>
//<adminCode1/>
//<adminName1/>
//<adminCode2/>
//<adminName2/>

//´Kontinente
//<toponymName>Africa</toponymName>
//<name>Africa</name>
//<lat>7.1881</lat>
//<lng>21.09375</lng>
//<geonameId>6255146</geonameId>
//<countryCode/>
//<countryName/>
//<fcl>L</fcl>
//<fcode>CONT</fcode>
//<fclName>parks,area, ...</fclName>
//<fcodeName>continent</fcodeName>
//<population>1031833000</population>
//<asciiName>Africa</asciiName>
//<alternateNames>
//Affrica,Africa,Afrihkka,Afrihkká,Afrika,Afrikka,Afriko,Afrique,Afryka,Afríka,Aphrike,Chau Phi,Châu Phi,afrika,afryqa,afryqya,afurika,an Afraic,apeulika,el Continente Negro,fei zhou,Àfrica,África,Āfrika,Αφρική,Африка,אפריקה,أفريقيا,افریقا,अफ़्रीका,แอฟริกา,アフリカ,非洲,아프리카
//</alternateNames>
//<elevation/>
//<continentCode>AF</continentCode>
//<adminCode1/>
//<adminName1/>
//<adminCode2/>
//<adminName2/>

//Land
//<geoname>
//<toponymName>Federal Republic of Germany</toponymName>
//<name>Germany</name>
//<lat>51.5</lat>
//<lng>10.5</lng>
//<geonameId>2921044</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>PCLI</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>independent political entity</fcodeName>
//<population>81802257</population>
//<asciiName>Federal Republic of Germany</asciiName>
//<alternateNames>
//A' Ghearmailt,Alamagn,Alemagne,Alemaina,Alemana,Alemanha,Alemani,Alemania,Alemanu,Alemanya,Alemaña,Alimaniya,Alimanya,Alimaɲi,Allemagne,Allemangne,Almaan,Almaañ,Almanija,Almaniya,Almanya,Almayn,Alémani,An Ghearmain,An Ghearmáin,Budaaki,Bundesrepublik Deutschland,Daeitschland,Deitschland,Deitschlånd,Deutaen,Deutschland,Deutän,Discuessiun sura la fundazziun,Discüssiun sura la fundazziun,Dueuetschland,Duiska,Duiskka,Duitschland,Duitsland,Dutslan,Duutsjlandj,Duutsland,Däitschland,Dútslân,Düütschland,Federal Republic of Germany,GJuc,German,Germani,Germania,Germania nutome,Germanija,Germanio,Germanja,Germanujo,Germany,Germània,Girimane,Girmania,Gjermani,Gjermania,Gjermanie,Gyaaman,Heremani,IJalimani,Jamani,Jamus,Jarmal,Jarmalka,Jerman,Jermaniya,Jámánì,Jėrman,Miemiecko,Miemieckô,Nemachka,Nemacka,Nemačka,Nemcija,Nemecko,Nemetorszag,Nemska,Nemčija,Niemcy,Nimeccina,Njamechchyna,Njemacka,Njemačka,Njeremani,Németország,Německo,Němska,Olmon,Olmonija,Olmoniya,Orileede Gemani,Orílẹ́ède Gemani,Saksa,Saksamaa,Siaman,Siamane,THeodiscland,THyskaland,Teutotitlan,Teutōtitlan,Tiamana,Toitshi,Tyskland,Tysklandi,Tôitšhi,Týskland,Ubudage,Udachi,Ujerumani,Vacija,Vokietija,Vācija,West Germany,Yn Ghermaan,Yr Almaen,Zamani,Zermania,Zâmani,alman,almanya,de guo,dog-il,doitsu,doitsu lian bang gong he guo,dotygu'e,germania,grmn,grmnyh,i-Germany,jamina,jarmani,jerman,jermani,jrmny,jrmny/alman,narmani,prathes yexrmni,shphanth satharnrath yexrmni,yexrman,yexrmni,Þýskaland,Þēodiscland,Đức,Ġermanja,Γερμανία,Алмания,Герман,Германи,Германия,Германија,Германія,Немачка,Нямеччына,Німеччина,Олмон,Олмония,Ӂермания,Գերմանիա,גרמניה,דייטשלאנד,آلمان,ألمانيا,ئەڵمانیا,المان,المانيا,جرمني/آلمان,جرمنی,گېرمانىيە,ܓܪܡܢ,जमिन,जर्मनी,জার্মানি,জাৰ্মানি,જર્મની,ଜର୍ମାନୀ,ஜெர்மனி,ஜெர்மன்,ఙర్మని,ಜರ್ಮನಿ,ജര്‍മനി,ജര്‍മ്മനി,ජර්මනිය,ประเทศเยอรมนี,สหพันธ์สาธารณรัฐเยอรมนี,เยอรมนี,เยอรมัน,ເຢຍລະມັນ,ཇཱར་མ་ནི,འཇར་མན་,ဂျာမဏီ,გერმანია,ጀርመን,អាល្លឺម៉ង់,ドイツ,ドイツ連邦共和国,德国,ꄓꇩ,독일
//</alternateNames>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1>00</adminCode1>
//<adminName1/>
//<adminCode2/>
//<adminName2/>

// Bundesland
//<geoname>
//<toponymName>Baden-Württemberg Region</toponymName>
//<name>Baden-Württemberg</name>
//<lat>48.5</lat>
//<lng>9</lng>
//<geonameId>2953481</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>ADM1</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>first-order administrative division</fcodeName>
//<population>10744921</population>
//<asciiName>Baden-Wuerttemberg Region</asciiName>
//<alternateNames>
//Badaen-Vuertaen,Bade-Wirddebaersch,Bade-Wirddebärsch,Bade-Woeoetebersch,Bade-Wurtemberg,Bade-Wöötebersch,Badehn-Vjurtehmberg,Baden-Virtemberg,Baden-Virtembergo,Baden-Vjurtemberg,Baden-Vuertemberq,Baden-Vyrtemberg,Baden-Vürtemberq,Baden-Wuerrtenberg,Baden-Wuertembaerj,Baden-Wuertembergska,Baden-Wuertembierich,Baden-Wuerttemberg,Baden-Wuerttemberg Region,Baden-Wurtemberch,Baden-Wurtemberg,Baden-Wúrtemberch,Baden-Würrtenberg,Baden-Würtembergska,Baden-Würtembierich,Baden-Würtembärj,Baden-Württemberg,Baden-Württemberg Region,Badenas-Viurtembergas,Badene-Virtemberga,Badenia-Virtembergia,Badenia-Wirtembergia,Badenia-Wurtemberg,Badensko-Wuerttembergska,Badensko-Wuerttembersko,Badensko-Württembergska,Badn-Wuerttmberg,Badän-Vürtän,Bádensko-Württembersko,Bådn-Württmberg,Bādene-Virtemberga,Pays de Bade,Vadi-Vyrtemvergi,ba deng-fu teng bao,baden=vu~yurutenberuku zhou,badena-vyurtembarga,badenbwileutembeleukeu ju,badenvirtemberg,badn fwrtmbyrgh,badn-wwrtmbrg,badnwrtmbrg,Βάδη-Βυρτεμβέργη,Баден-Виртемберг,Баден-Вюртемберг,Бадэн-Вюртэмберг,באדין-בורטינבירג,באדן-וירטמברג,بادن فورتمبيرغ,بادن-وورتمبرگ,بادنورتمبرگ,بادێن-ڤوورتمبێرگ,باډن ورټم بېرګ,बाडेन-व्युर्टेंबर्ग,รัฐบาเดิน-เวือร์ทเทมแบร์ก,ბადენ-ვიურტემბერგი,バーデン＝ヴュルテンベルク州,巴登-符腾堡,바덴뷔르템베르크 주
//</alternateNames>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1 ISO3166-2="BW">01</adminCode1>
//<adminName1>Baden-Württemberg</adminName1>
//<adminCode2/>
//<adminName2/>

//<geoname>
//<toponymName>Regierungsbezirk Darmstadt</toponymName>
//<name>Regierungsbezirk Darmstadt</name>
//<lat>50</lat>
//<lng>8.75</lng>
//<geonameId>2938912</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>ADM2</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>second-order administrative division</fcodeName>
//<population>3791381</population>
//<asciiName>Regierungsbezirk Darmstadt</asciiName>
//<alternateNames>
//Darmstadt,District de Darmstadt,Regierungsbezirk Darmstadt
//</alternateNames>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1 ISO3166-2="HE">05</adminCode1>
//<adminName1>Hesse</adminName1>
//<adminCode2>064</adminCode2>
//<adminName2>Regierungsbezirk Darmstadt</adminName2>
//<alternateName lang="fr">District de Darmstadt</alternateName>
//<alternateName lang="link">
//http://en.wikipedia.org/wiki/Darmstadt_%28region%29
//</alternateName>
//<timezone dstOffset="2.0" gmtOffset="1.0">Europe/Berlin</timezone>
//<numberOfChildren>14</numberOfChildren>
//</geoname>

//Landkreis
//<geoname>
//<toponymName>Landkreis Darmstadt-Dieburg</toponymName>
//<name>Landkreis Darmstadt-Dieburg</name>
//<lat>49.85639</lat>
//<lng>8.75667</lng>
//<geonameId>3220966</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>ADM3</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>third-order administrative division</fcodeName>
//<population>284413</population>
//<asciiName>Landkreis Darmstadt-Dieburg</asciiName>
//<alternateNames>Darmstadt-Dieburg,Landkreis Darmstadt-Dieburg</alternateNames>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1 ISO3166-2="HE">05</adminCode1>
//<adminName1>Hesse</adminName1>
//<adminCode2>064</adminCode2>
//<adminName2>Regierungsbezirk Darmstadt</adminName2>
//<adminCode3>06432</adminCode3>
//<adminName3>Landkreis Darmstadt-Dieburg</adminName3>
//<alternateName lang="link">http://en.wikipedia.org/wiki/Darmstadt-Dieburg</alternateName>
//<timezone dstOffset="2.0" gmtOffset="1.0">Europe/Berlin</timezone>
//<numberOfChildren>23</numberOfChildren>
//</geoname>

//<geoname>
//<toponymName>Landkreis Barnim</toponymName>
//<name>Landkreis Barnim</name>
//<lat>52.84306</lat>
//<lng>13.70917</lng>
//<geonameId>3249079</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>ADM3</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>third-order administrative division</fcodeName>
//<population>173193</population>
//<asciiName>Landkreis Barnim</asciiName>
//<alternateNames>Barnim,Landkreis Barnim</alternateNames>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1 ISO3166-2="BB">11</adminCode1>
//<adminName1>Brandenburg</adminName1>
//<adminCode2>00</adminCode2>
//<adminName2/>
//<adminCode3>12060</adminCode3>
//<adminName3>Landkreis Barnim</adminName3>
//<alternateName lang="link">http://en.wikipedia.org/wiki/Barnim</alternateName>
//<timezone dstOffset="2.0" gmtOffset="1.0">Europe/Berlin</timezone>
//<numberOfChildren>25</numberOfChildren>
//</geoname>

//Komune
//<geoname>
//<toponymName>Schaafheim</toponymName>
//<name>Schaafheim</name>
//<lat>49.9242</lat>
//<lng>9.00944</lng>
//<geonameId>6553170</geonameId>
//<countryCode>DE</countryCode>
//<countryName>Germany</countryName>
//<fcl>A</fcl>
//<fcode>ADM4</fcode>
//<fclName>country, state, region,...</fclName>
//<fcodeName>fourth-order administrative division</fcodeName>
//<population>9126</population>
//<asciiName>Schaafheim</asciiName>
//<alternateNames/>
//<elevation/>
//<continentCode>EU</continentCode>
//<adminCode1 ISO3166-2="HE">05</adminCode1>
//<adminName1>Hesse</adminName1>
//<adminCode2>064</adminCode2>
//<adminName2>Regierungsbezirk Darmstadt</adminName2>
//<adminCode3>06432</adminCode3>
//<adminName3>Landkreis Darmstadt-Dieburg</adminName3>
//<adminCode4>06432021</adminCode4>
//<adminName4>Schaafheim</adminName4>
//<timezone dstOffset="2.0" gmtOffset="1.0">Europe/Berlin</timezone>
//</geoname>

