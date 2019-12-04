using MARC.Everest.Formatters.XML.Datatypes.R1;
using MARC.Everest.Formatters.XML.ITS1;
using MARC.Everest.Xml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HL7XML
{
    class UsingThirdParty
    {
        /// <summary>
        /// Tired this method but it failed to return object.
        /// //still need to explore on this.
        /// </summary>
        /// <param name="path"></param>
        public static void Read(string path)
        {
            using (XmlStateReader xr = new XmlStateReader(XmlReader.Create(path)))
            {
                var fmtr = new XmlIts1Formatter();
                fmtr.ValidateConformance = false;
                fmtr.GraphAides.Add(new ClinicalDocumentDatatypeFormatter());
                var parseResult = fmtr.Parse(xr, typeof(ClinicalDocument));
                             var cda = parseResult.Structure as ClinicalDocument;
            }
        }
    }
}
