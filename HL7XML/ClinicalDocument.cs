using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace HL7XML
{
    [XmlRoot(ElementName = "typeId", Namespace = "urn:hl7-org:v3")]
    public class TypeId
    {
        [XmlAttribute(AttributeName = "extension")]
        public string Extension { get; set; }
        [XmlAttribute(AttributeName = "root")]
        public string Root { get; set; }
    }

    [XmlRoot(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
    public class TemplateId
    {
        [XmlAttribute(AttributeName = "root")]
        public string Root { get; set; }
    }

    [XmlRoot(ElementName = "id", Namespace = "urn:hl7-org:v3")]
    public class Id
    {
        [XmlAttribute(AttributeName = "root")]
        public string Root { get; set; }
        [XmlAttribute(AttributeName = "extension")]
        public string Extension { get; set; }
        [XmlAttribute(AttributeName = "nullFlavor")]
        public string NullFlavor { get; set; }
    }

    [XmlRoot(ElementName = "code", Namespace = "urn:hl7-org:v3")]
    public class Code
    {
        [XmlAttribute(AttributeName = "code")]
        public string _code { get; set; }
        [XmlAttribute(AttributeName = "codeSystem")]
        public string CodeSystem { get; set; }
        [XmlAttribute(AttributeName = "displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute(AttributeName = "nullFlavor")]
        public string NullFlavor { get; set; }
    }

    [XmlRoot(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
    public class EffectiveTime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlElement(ElementName = "low", Namespace = "urn:hl7-org:v3")]
        public Low Low { get; set; }
        [XmlElement(ElementName = "high", Namespace = "urn:hl7-org:v3")]
        public High High { get; set; }
    }

    [XmlRoot(ElementName = "confidentialityCode", Namespace = "urn:hl7-org:v3")]
    public class ConfidentialityCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "codeSystem")]
        public string CodeSystem { get; set; }
    }

    [XmlRoot(ElementName = "languageCode", Namespace = "urn:hl7-org:v3")]
    public class LanguageCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "name", Namespace = "urn:hl7-org:v3")]
    public class Name
    {
        [XmlElement(ElementName = "given", Namespace = "urn:hl7-org:v3")]
        public string Given { get; set; }
        [XmlElement(ElementName = "family", Namespace = "urn:hl7-org:v3")]
        public string Family { get; set; }
        [XmlElement(ElementName = "prefix", Namespace = "urn:hl7-org:v3")]
        public string Prefix { get; set; }
    }

    [XmlRoot(ElementName = "administrativeGenderCode", Namespace = "urn:hl7-org:v3")]
    public class AdministrativeGenderCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "codeSystem")]
        public string CodeSystem { get; set; }
    }

    [XmlRoot(ElementName = "birthTime", Namespace = "urn:hl7-org:v3")]
    public class BirthTime
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "patient", Namespace = "urn:hl7-org:v3")]
    public class Patient
    {
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "administrativeGenderCode", Namespace = "urn:hl7-org:v3")]
        public AdministrativeGenderCode AdministrativeGenderCode { get; set; }
        [XmlElement(ElementName = "birthTime", Namespace = "urn:hl7-org:v3")]
        public BirthTime BirthTime { get; set; }
    }

    [XmlRoot(ElementName = "providerOrganization", Namespace = "urn:hl7-org:v3")]
    public class ProviderOrganization
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "patientRole", Namespace = "urn:hl7-org:v3")]
    public class PatientRole
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "patient", Namespace = "urn:hl7-org:v3")]
        public Patient Patient { get; set; }
        [XmlElement(ElementName = "providerOrganization", Namespace = "urn:hl7-org:v3")]
        public ProviderOrganization ProviderOrganization { get; set; }
    }

    [XmlRoot(ElementName = "recordTarget", Namespace = "urn:hl7-org:v3")]
    public class RecordTarget
    {
        [XmlElement(ElementName = "patientRole", Namespace = "urn:hl7-org:v3")]
        public PatientRole PatientRole { get; set; }
    }

    [XmlRoot(ElementName = "time", Namespace = "urn:hl7-org:v3")]
    public class Time
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlElement(ElementName = "low", Namespace = "urn:hl7-org:v3")]
        public Low Low { get; set; }
        [XmlElement(ElementName = "high", Namespace = "urn:hl7-org:v3")]
        public High High { get; set; }
    }

    [XmlRoot(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
    public class AssignedPerson
    {
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public Name Name { get; set; }
    }

    [XmlRoot(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
    public class RepresentedOrganization
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "assignedAuthor", Namespace = "urn:hl7-org:v3")]
    public class AssignedAuthor
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
        public AssignedPerson AssignedPerson { get; set; }
        [XmlElement(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
        public RepresentedOrganization RepresentedOrganization { get; set; }
    }

    [XmlRoot(ElementName = "author", Namespace = "urn:hl7-org:v3")]
    public class Author
    {
        [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "assignedAuthor", Namespace = "urn:hl7-org:v3")]
        public AssignedAuthor AssignedAuthor { get; set; }
    }

    [XmlRoot(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
    public class AssignedEntity
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "representedOrganization", Namespace = "urn:hl7-org:v3")]
        public RepresentedOrganization RepresentedOrganization { get; set; }
        [XmlElement(ElementName = "assignedPerson", Namespace = "urn:hl7-org:v3")]
        public AssignedPerson AssignedPerson { get; set; }
    }

    [XmlRoot(ElementName = "informant", Namespace = "urn:hl7-org:v3")]
    public class Informant
    {
        [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
        public AssignedEntity AssignedEntity { get; set; }
    }

    [XmlRoot(ElementName = "representedCustodianOrganization", Namespace = "urn:hl7-org:v3")]
    public class RepresentedCustodianOrganization
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "assignedCustodian", Namespace = "urn:hl7-org:v3")]
    public class AssignedCustodian
    {
        [XmlElement(ElementName = "representedCustodianOrganization", Namespace = "urn:hl7-org:v3")]
        public RepresentedCustodianOrganization RepresentedCustodianOrganization { get; set; }
    }

    [XmlRoot(ElementName = "custodian", Namespace = "urn:hl7-org:v3")]
    public class Custodian
    {
        [XmlElement(ElementName = "assignedCustodian", Namespace = "urn:hl7-org:v3")]
        public AssignedCustodian AssignedCustodian { get; set; }
    }

    [XmlRoot(ElementName = "signatureCode", Namespace = "urn:hl7-org:v3")]
    public class SignatureCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "legalAuthenticator", Namespace = "urn:hl7-org:v3")]
    public class LegalAuthenticator
    {
        [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "signatureCode", Namespace = "urn:hl7-org:v3")]
        public SignatureCode SignatureCode { get; set; }
        [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
        public AssignedEntity AssignedEntity { get; set; }
    }

    [XmlRoot(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
    public class Addr
    {
        [XmlElement(ElementName = "streetAddressLine", Namespace = "urn:hl7-org:v3")]
        public string StreetAddressLine { get; set; }
        [XmlElement(ElementName = "city", Namespace = "urn:hl7-org:v3")]
        public string City { get; set; }
        [XmlElement(ElementName = "state", Namespace = "urn:hl7-org:v3")]
        public string State { get; set; }
        [XmlElement(ElementName = "postalCode", Namespace = "urn:hl7-org:v3")]
        public string PostalCode { get; set; }
    }

    [XmlRoot(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
    public class Telecom
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "associatedPerson", Namespace = "urn:hl7-org:v3")]
    public class AssociatedPerson
    {
        [XmlElement(ElementName = "name", Namespace = "urn:hl7-org:v3")]
        public Name Name { get; set; }
    }

    [XmlRoot(ElementName = "associatedEntity", Namespace = "urn:hl7-org:v3")]
    public class AssociatedEntity
    {
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "addr", Namespace = "urn:hl7-org:v3")]
        public Addr Addr { get; set; }
        [XmlElement(ElementName = "telecom", Namespace = "urn:hl7-org:v3")]
        public Telecom Telecom { get; set; }
        [XmlElement(ElementName = "associatedPerson", Namespace = "urn:hl7-org:v3")]
        public AssociatedPerson AssociatedPerson { get; set; }
        [XmlAttribute(AttributeName = "classCode")]
        public string ClassCode { get; set; }
        [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public Code Code { get; set; }
    }

    [XmlRoot(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
    public class Participant
    {
        [XmlElement(ElementName = "associatedEntity", Namespace = "urn:hl7-org:v3")]
        public AssociatedEntity AssociatedEntity { get; set; }
        [XmlAttribute(AttributeName = "typeCode")]
        public string TypeCode { get; set; }
    }

    [XmlRoot(ElementName = "low", Namespace = "urn:hl7-org:v3")]
    public class Low
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "high", Namespace = "urn:hl7-org:v3")]
    public class High
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "functionCode", Namespace = "urn:hl7-org:v3")]
    public class FunctionCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "codeSystem")]
        public string CodeSystem { get; set; }
    }

    [XmlRoot(ElementName = "performer", Namespace = "urn:hl7-org:v3")]
    public class Performer
    {
        [XmlElement(ElementName = "functionCode", Namespace = "urn:hl7-org:v3")]
        public FunctionCode FunctionCode { get; set; }
        [XmlElement(ElementName = "time", Namespace = "urn:hl7-org:v3")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "assignedEntity", Namespace = "urn:hl7-org:v3")]
        public AssignedEntity AssignedEntity { get; set; }
        [XmlAttribute(AttributeName = "typeCode")]
        public string TypeCode { get; set; }
    }

    [XmlRoot(ElementName = "serviceEvent", Namespace = "urn:hl7-org:v3")]
    public class ServiceEvent
    {
        [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
        public EffectiveTime EffectiveTime { get; set; }
        [XmlElement(ElementName = "performer", Namespace = "urn:hl7-org:v3")]
        public Performer Performer { get; set; }
        [XmlAttribute(AttributeName = "classCode")]
        public string ClassCode { get; set; }
    }

    [XmlRoot(ElementName = "documentationOf", Namespace = "urn:hl7-org:v3")]
    public class DocumentationOf
    {
        [XmlElement(ElementName = "serviceEvent", Namespace = "urn:hl7-org:v3")]
        public ServiceEvent ServiceEvent { get; set; }
    }

    [XmlRoot(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
    public class Tr
    {
        [XmlElement(ElementName = "th", Namespace = "urn:hl7-org:v3")]
        public List<string> Th { get; set; }
        [XmlElement(ElementName = "td", Namespace = "urn:hl7-org:v3")]
        public List<string> Td { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "thead", Namespace = "urn:hl7-org:v3")]
    public class Thead
    {
        [XmlElement(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
        public Tr Tr { get; set; }
    }

    [XmlRoot(ElementName = "tbody", Namespace = "urn:hl7-org:v3")]
    public class Tbody
    {
        [XmlElement(ElementName = "tr", Namespace = "urn:hl7-org:v3")]
        public List<Tr> Tr { get; set; }
    }

    [XmlRoot(ElementName = "table", Namespace = "urn:hl7-org:v3")]
    public class Table
    {
        [XmlElement(ElementName = "thead", Namespace = "urn:hl7-org:v3")]
        public Thead Thead { get; set; }
        [XmlElement(ElementName = "tbody", Namespace = "urn:hl7-org:v3")]
        public Tbody Tbody { get; set; }
        [XmlAttribute(AttributeName = "border")]
        public string Border { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
    }

    [XmlRoot(ElementName = "text", Namespace = "urn:hl7-org:v3")]
    public class Text
    {
        [XmlElement(ElementName = "table", Namespace = "urn:hl7-org:v3")]
        public Table Table { get; set; }
    }

    [XmlRoot(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
    public class StatusCode
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "value", Namespace = "urn:hl7-org:v3")]
    public class Value
    {
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "codeSystem")]
        public string CodeSystem { get; set; }
        [XmlAttribute(AttributeName = "displayName")]
        public string DisplayName { get; set; }
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "observation", Namespace = "urn:hl7-org:v3")]
    public class Observation
    {
        [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
        public TemplateId TemplateId { get; set; }
        [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "statusCode", Namespace = "urn:hl7-org:v3")]
        public StatusCode StatusCode { get; set; }
        [XmlElement(ElementName = "value", Namespace = "urn:hl7-org:v3")]
        public Value Value { get; set; }
        [XmlAttribute(AttributeName = "classCode")]
        public string ClassCode { get; set; }
        [XmlAttribute(AttributeName = "moodCode")]
        public string MoodCode { get; set; }
    }

    [XmlRoot(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
    public class EntryRelationship
    {
        [XmlElement(ElementName = "observation", Namespace = "urn:hl7-org:v3")]
        public Observation Observation { get; set; }
        [XmlAttribute(AttributeName = "typeCode")]
        public string TypeCode { get; set; }
    }

    [XmlRoot(ElementName = "act", Namespace = "urn:hl7-org:v3")]
    public class Act
    {
        [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
        public TemplateId TemplateId { get; set; }
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "entryRelationship", Namespace = "urn:hl7-org:v3")]
        public EntryRelationship EntryRelationship { get; set; }
        [XmlAttribute(AttributeName = "classCode")]
        public string ClassCode { get; set; }
        [XmlAttribute(AttributeName = "moodCode")]
        public string MoodCode { get; set; }
    }

    [XmlRoot(ElementName = "entry", Namespace = "urn:hl7-org:v3")]
    public class Entry
    {
        [XmlElement(ElementName = "act", Namespace = "urn:hl7-org:v3")]
        public Act Act { get; set; }
        [XmlAttribute(AttributeName = "typeCode")]
        public string TypeCode { get; set; }
    }

    [XmlRoot(ElementName = "section", Namespace = "urn:hl7-org:v3")]
    public class Section
    {
        [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
        public TemplateId TemplateId { get; set; }
        [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "title", Namespace = "urn:hl7-org:v3")]
        public string Title { get; set; }
        [XmlElement(ElementName = "text", Namespace = "urn:hl7-org:v3")]
        public Text Text { get; set; }
        [XmlElement(ElementName = "entry", Namespace = "urn:hl7-org:v3")]
        public Entry Entry { get; set; }
    }

    [XmlRoot(ElementName = "component", Namespace = "urn:hl7-org:v3")]
    public class Component
    {
        [XmlElement(ElementName = "section", Namespace = "urn:hl7-org:v3")]
        public Section Section { get; set; }
    }

    [XmlRoot(ElementName = "structuredBody", Namespace = "urn:hl7-org:v3")]
    public class StructuredBody
    {
        [XmlElement(ElementName = "component", Namespace = "urn:hl7-org:v3")]
        public Component Component { get; set; }
    }

    [XmlRoot(ElementName = "ClinicalDocument", Namespace = "urn:hl7-org:v3")]
    public class ClinicalDocument
    {
        [XmlElement(ElementName = "typeId", Namespace = "urn:hl7-org:v3")]
        public TypeId TypeId { get; set; }
        [XmlElement(ElementName = "templateId", Namespace = "urn:hl7-org:v3")]
        public TemplateId TemplateId { get; set; }
        [XmlElement(ElementName = "id", Namespace = "urn:hl7-org:v3")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "code", Namespace = "urn:hl7-org:v3")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "title", Namespace = "urn:hl7-org:v3")]
        public string Title { get; set; }
        [XmlElement(ElementName = "effectiveTime", Namespace = "urn:hl7-org:v3")]
        public EffectiveTime EffectiveTime { get; set; }
        [XmlElement(ElementName = "confidentialityCode", Namespace = "urn:hl7-org:v3")]
        public ConfidentialityCode ConfidentialityCode { get; set; }
        [XmlElement(ElementName = "languageCode", Namespace = "urn:hl7-org:v3")]
        public LanguageCode LanguageCode { get; set; }
        [XmlElement(ElementName = "recordTarget", Namespace = "urn:hl7-org:v3")]
        public RecordTarget RecordTarget { get; set; }
        [XmlElement(ElementName = "author", Namespace = "urn:hl7-org:v3")]
        public Author Author { get; set; }
        [XmlElement(ElementName = "informant", Namespace = "urn:hl7-org:v3")]
        public Informant Informant { get; set; }
        [XmlElement(ElementName = "custodian", Namespace = "urn:hl7-org:v3")]
        public Custodian Custodian { get; set; }
        [XmlElement(ElementName = "legalAuthenticator", Namespace = "urn:hl7-org:v3")]
        public LegalAuthenticator LegalAuthenticator { get; set; }
        [XmlElement(ElementName = "participant", Namespace = "urn:hl7-org:v3")]
        public List<Participant> Participant { get; set; }
        [XmlElement(ElementName = "documentationOf", Namespace = "urn:hl7-org:v3")]
        public DocumentationOf DocumentationOf { get; set; }
        [XmlElement(ElementName = "component", Namespace = "urn:hl7-org:v3")]
        public Component Component { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "voc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Voc { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }

}
