using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Web.Helpers;
using System.Xml;
using System.Xml.Serialization;

namespace HL7XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentPath = Path.GetDirectoryName(typeof(Program).GetTypeInfo().Assembly.Location) + "\\";
            string fileName = "ccd1";
            string filePath = parentPath + fileName + ".xml";
            string Outputfile= parentPath + "output" + ".json";
            var doc = ReadXML<POCD_MT000040ClinicalDocument>(filePath);
            var _json = JsonConvert.SerializeObject(doc);
            System.IO.File.WriteAllText(Outputfile, _json);
            Console.WriteLine(_json);
            Console.ReadLine();
        }

        public static T ReadXML<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader reader = new StreamReader(path);
            //If you are using new ccd.xml document then you need to generate class 
            //and that can be done by following Notes.txt
            T doc;
            using (reader)
            {
                doc = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            return doc;
        }
    }
}
