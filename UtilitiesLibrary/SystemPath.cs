using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UtilitiesLibrary
{
    public static class SystemPath
    {
        public static readonly string FarmPath = CheckFarmXML(Path.Combine(Application.LocalUserAppDataPath, "farm.xml"));
        [Obsolete]
        public static readonly string ConnectionPath = CheckConnectionXML(Path.Combine(Application.LocalUserAppDataPath, "connection.xml"));
        public static readonly string ProfilesPath = CheckPath(Path.GetFullPath(Application.LocalUserAppDataPath+@"\ProfileImage\"));
        public static readonly string PondPath = CheckPath(Path.GetFullPath(Application.LocalUserAppDataPath+@"\PondImage\"));
        public static readonly string SlideShowPath = CheckPath(Path.GetFullPath(Application.LocalUserAppDataPath + @"\SlideShow\"));


        private static string CheckPath(string path)
        {
            bool exist = Directory.Exists(path);

            if (!exist)
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        [Obsolete]
        private static string CheckConnectionXML(string XML_FilePath)
        {
            try
            {
                if (File.Exists(XML_FilePath))
                {
                    return XML_FilePath;
                }
                else
                {
                    string host = Dns.GetHostName();
                    using (XmlWriter xwriter = XmlWriter.Create(XML_FilePath))
                    {
                        xwriter.WriteStartElement("Table");
                        xwriter.WriteStartElement("Connection");
                        xwriter.WriteElementString("Server", Dns.GetHostByName(host).AddressList[0].ToString());
                        xwriter.WriteElementString("Database", "rd_salesinventorydb");
                        xwriter.WriteElementString("User", "root");
                        xwriter.WriteElementString("Password", "root");
                        xwriter.WriteElementString("Port", "3306");
                        xwriter.WriteElementString("Security", "true");
                        xwriter.WriteEndElement();
                        xwriter.WriteEndElement();

                        xwriter.Flush();
                    }
                    return XML_FilePath;
                }
            }
            catch {
                return "";
            }
        }
        private static string CheckFarmXML(string XML_FilePath)
        {
            try
            {
                if (File.Exists(XML_FilePath))
                {
                    return XML_FilePath;
                }
                else
                {
                    string host = Dns.GetHostName();
                    using (XmlWriter xwriter = XmlWriter.Create(XML_FilePath))
                    {
                        xwriter.WriteStartElement("Farm");
                        xwriter.WriteElementString("Name", "");
                        xwriter.WriteEndElement();
                        xwriter.Flush();
                    }
                    return XML_FilePath;
                }
            }
            catch
            {
                return "";
            }
        }

    }


}
