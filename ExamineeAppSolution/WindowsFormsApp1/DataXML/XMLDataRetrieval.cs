using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1.DataXML
{
    internal class XMLDataRetrieval
    {
        private XmlDocument xmlDoc;
        private string xmlFilePath;

        public XMLDataRetrieval(string xmlFilePath)
        {
            // Load XML data
            this.xmlFilePath = xmlFilePath;
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
        }
        public void AddExaminee(string id, string name, string sex, string address, string phone, string email)
        {
            // Check if the ID already exists
            XmlNodeList svNodes = xmlDoc.SelectNodes("/QLTTSV/SV[@id='" + id + "']");
            if (svNodes.Count > 0)
            {
                return;
            }

            // Create a new SV element
            XmlNode root = xmlDoc.DocumentElement;
            XmlElement svElement = xmlDoc.CreateElement("SV");

            // Set the id attribute
            XmlAttribute idAttribute = xmlDoc.CreateAttribute("id");
            idAttribute.Value = id;
            svElement.Attributes.Append(idAttribute);

            // Create child elements and set their values
            XmlElement nameElement = xmlDoc.CreateElement("Name");
            nameElement.InnerText = name;
            svElement.AppendChild(nameElement);

            XmlElement sexElement = xmlDoc.CreateElement("Sex");
            sexElement.InnerText = sex;
            svElement.AppendChild(sexElement);

            XmlElement addressElement = xmlDoc.CreateElement("Address");
            addressElement.InnerText = address;
            svElement.AppendChild(addressElement);

            XmlElement phoneElement = xmlDoc.CreateElement("Phone");
            phoneElement.InnerText = phone;
            svElement.AppendChild(phoneElement);

            XmlElement emailElement = xmlDoc.CreateElement("Email");
            emailElement.InnerText = email;
            svElement.AppendChild(emailElement);

            // Append the new SV element to the root element
            root.AppendChild(svElement);

            // Save changes to XML file
            xmlDoc.Save(xmlFilePath);
        }

        public (string, string, string, string, string) RetrieveDataById(string id)
        {
            XmlNodeList svNodes = xmlDoc.SelectNodes("/QLTTSV/SV[@id='" + id + "']");
            if (svNodes.Count > 0)
            {
                XmlNode svNode = svNodes[0];
                string name = svNode.SelectSingleNode("Name").InnerText;
                string sex = svNode.SelectSingleNode("Sex").InnerText;
                string address = svNode.SelectSingleNode("Address").InnerText;
                string phone = svNode.SelectSingleNode("Phone").InnerText;
                string email = svNode.SelectSingleNode("Email").InnerText;
                return (name, sex, address, phone, email);
            }
            else
            {
                throw new Exception("ID not found");
            }
        }

        public void UpdateData(string id, string name, string sex, string address, string phone, string email)
        {
            XmlNodeList svNodes = xmlDoc.SelectNodes("/QLTTSV/SV[@id='" + id + "']");
            if (svNodes.Count > 0)
            {
                XmlNode svNode = svNodes[0];
                svNode.SelectSingleNode("Name").InnerText = name;
                svNode.SelectSingleNode("Sex").InnerText = sex;
                svNode.SelectSingleNode("Address").InnerText = address;
                svNode.SelectSingleNode("Phone").InnerText = phone;
                svNode.SelectSingleNode("Email").InnerText = email;

                // Save changes to XML file
                xmlDoc.Save(xmlFilePath);
            }
            else
            {
                throw new Exception("ID not found");
            }
        }
    }
}

