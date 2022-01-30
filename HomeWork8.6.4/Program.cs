using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace HomeWork8._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            AddContact();

        }

        static void AddContact()
        {
            XElement contact = new XElement("Person"); // создаем XElement для основного дерева контакта
            
            Console.WriteLine("Ввод нового контакта");            
            
            Console.WriteLine("Пожалуйста введите полное имя контакта"); 
            contact.SetAttributeValue("name", Console.ReadLine()); // запрашиваем и добавляем атрибут имени контакта

            XElement address = new XElement("Address"); // создаем XElement для поддерева Address. Запрашиваем детали адреса и записываем в дерево
            Console.WriteLine("Пожалуйста введите название улицы");            
            address.Add(new XElement("Street", Console.ReadLine()));
            Console.WriteLine("Пожалуйста введите номер дома");
            address.Add(new XElement("HouseNumber", Console.ReadLine()));
            Console.WriteLine("Пожалуйста введите номер квартиры");
            address.Add(new XElement("FlatNumber", Console.ReadLine()));

            XElement phones = new XElement("Phones"); // создаем XElement для поддерева телефонных номеров
            Console.WriteLine("Пожалуйста введите номер мобильного телефона");
            phones.Add(new XElement("MobilePhone", Console.ReadLine()));
            Console.WriteLine("Пожалуйста введите номер домашнего телефона");
            phones.Add(new XElement("FlatPhone", Console.ReadLine()));

            contact.Add(address);
            contact.Add(phones);

            SerializeXML(contact);
        }

        static void SerializeXML(XElement newContact)
        {
            Stream fStream = new FileStream("contact.xml", FileMode.Create, FileAccess.Write);

            newContact.Save(fStream);

            fStream.Close();
        }
    }
}
