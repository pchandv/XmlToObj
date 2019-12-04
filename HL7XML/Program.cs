using MARC.Everest.Formatters.XML.Datatypes.R1;
using MARC.Everest.Formatters.XML.ITS1;
using MARC.Everest.Xml;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace HL7XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentPath = Path.GetDirectoryName(typeof(Program).GetTypeInfo().Assembly.Location) +"\\";

            //Add file to bin/debug/netcoreapp2.0/ 
            //provide file name here
            string fileName = "ccd1";
            string filePath = parentPath + fileName+ ".xml";
            var doc=ReadXML(filePath);
            Console.ReadLine();
        }


        /// <summary>
        /// Below logic  generic method to read xml document and returns object type
        /// </summary>
        /// <param name="path"></param>
        public static ClinicalDocument ReadXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClinicalDocument));
            StreamReader reader = new StreamReader(path);
            //If you are using new ccd.xml document then you need to generate class 
            //and that can be done by following Notes.txt
            ClinicalDocument doc = null;
            using (reader)
            {
                doc = (ClinicalDocument)serializer.Deserialize(reader);
                reader.Close();
            }
            return doc;
        }
    }
}
