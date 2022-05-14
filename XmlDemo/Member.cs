using System;
using System.Xml.Serialization;

namespace XmlDemo
{
    
    [Serializable]
    //[XmlRoot("MemberDetails")]
    public class Member
    {
        //[XmlElement("MemberName")]
        public string Name { get; set; }
        //[XmlElement("MemberEmailAddress")]
        public string Email { get; set; }
        public int Age { get; set; }
        //[XmlIgnore]
        public DateTime JoiningDate { get; set; }
        //[XmlAttribute("PlatinumMember")]
        public bool IsPlatinumMember { get; set; }
    }
   
}
