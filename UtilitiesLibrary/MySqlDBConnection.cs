using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UtilitiesLibrary
{
    public class MySqlDBConnection
    {
        public static string stringCon = "";

        public static string XMLConnection(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Connection");
            string Server = "", Database = "", User = "", Password = "", SecurityInfo = "", Port = "";

            foreach (XmlNode node in nodeList)
            {
                Server = node.SelectSingleNode("Server").InnerText;
                Database = node.SelectSingleNode("Database").InnerText;
                User = node.SelectSingleNode("User").InnerText;
                Password = node.SelectSingleNode("Password").InnerText;
                SecurityInfo = node.SelectSingleNode("Security").InnerText;
                Port = node.SelectSingleNode("Port").InnerText;
            }
            return ($"Server = {Server}; Database = {Database}; User Id = {User}; Password = {Password}; Persistsecurityinfo = {SecurityInfo}; Port = {Port};");
        }
    }
}
