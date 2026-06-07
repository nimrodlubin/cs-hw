using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Item
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item(int code, string name, string description, double price)
        {
            Code = Code;
            Name = name;
            Price = price;
            Description = description;
        }
        public Item(string name, string description, double price)
        {
            Name = name;
            Price = price;
            Description = description;
        }
        public override string ToString()
        {
            return $"Code: {Code} Name: {Name}, Description: {Description}, Price: {Price}";
        }

    }
}
