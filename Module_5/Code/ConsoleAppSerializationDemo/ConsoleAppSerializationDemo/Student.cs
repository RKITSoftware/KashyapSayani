using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSerializationDemo
{
    [Serializable]
    class Student
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";

        public Student(int id , string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
