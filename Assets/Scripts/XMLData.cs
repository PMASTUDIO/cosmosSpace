/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "string")]
    public class String
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "en-US")]
    public class EnUS
    {
        [XmlElement(ElementName = "string")]
        public String String { get; set; }
    }

    [XmlRoot(ElementName = "pt-BR")]
    public class PtBR
    {
        [XmlElement(ElementName = "string")]
        public String String { get; set; }
    }

    [XmlRoot(ElementName = "langs")]
    public class Langs
    {
        [XmlElement(ElementName = "en-US")]
        public EnUS EnUS { get; set; }
        [XmlElement(ElementName = "pt-BR")]
        public PtBR PtBR { get; set; }
    }

    [XmlRoot(ElementName = "xml")]
    public class Xml
    {
        [XmlElement(ElementName = "langs")]
        public Langs Langs { get; set; }
    }

}
