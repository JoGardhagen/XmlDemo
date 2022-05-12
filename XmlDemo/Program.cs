﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SerilizeObjectToXmlString();
            SerializeObjectToXmlFile();
            Console.ReadKey();
        }
        private static void SerilizeObjectToXmlString()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));
            using(var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
            }
        }
        private static void SerializeObjectToXmlFile()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StreamWriter(@"D:\CsharpRepo\XmlDemo\XmlDemo\xml-files\sample01.xml"))
            {
                xmlSerializer.Serialize(writer, member);
            }
            Console.WriteLine("Process Completed");
        }
        private static void SerializeListToXmlFile()
        {
            var memberList = new List<Member>
            {
                new Member
                {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
                },
                new Member
                {
                Name = "George",
                Email = "george@gmail.com",
                Age = 44,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = true
                }, 
                new Member
                {
                Name = "Anna",
                Email = "anna@gmail.com",
                Age = 27,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
                }, 
                new Member
                {
                Name = "Albin",
                Email = "albin@gmail.com",
                Age = 34,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
                },
                new Member
                {
                Name = "Gregor",
                Email = "gregor@gmail.com",
                Age = 66,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = true
                }
            };
            var xmlSerializer = new XmlSerializer(typeof(Member));
        }
    }
}