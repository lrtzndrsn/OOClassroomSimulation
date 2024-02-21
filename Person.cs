using System;

namespace ClassLecture
{
    public class Person
    {
        private string name;
        private string occupation;
        private string age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, string occupation, string age)
        {
            this.name = name;
            this.occupation = occupation;
            this.age = age;
        }

        public override String ToString()
        {
            return "\nOBJECT PROPERTIES\nage: " + this.age + "\n" + "name: " + this.name + "\n" + "occupation: " + this.occupation;
        }
    }
}