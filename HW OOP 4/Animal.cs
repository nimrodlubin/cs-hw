using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HW_OOP_4
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return ($"name: {Name} \nage:{Age}");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public void bark()
        {
            Console.WriteLine($"{Name} says: Bark Bark!"); ;
        }
    }
    sealed class Cat : Animal
    {
        public Cat(string Name, int Age) : base(Name, Age) {}
        public void Purr()
        {
            Console.WriteLine($"{Name} says: Purrrr...");
        }
    }
}
