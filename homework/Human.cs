using System;
namespace homework
{
    public class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public Human(int age,string name=null,string surname=null)
        {
            Age = age;
            Surname = surname;
            Name = name;
        }
    }
}
