using System;
using System.Xml.Serialization;

namespace XmlDemo
{

    [XmlRoot("Users")]
    [Serializable]
    public class Users
    {
        [XmlArray("UserList")]
        [XmlArrayItem("User")]
        public User[] UserList { get; set; }
    }
    [Serializable]
    public class User
    {
        public string Name { get; set; }
    }
    
}
