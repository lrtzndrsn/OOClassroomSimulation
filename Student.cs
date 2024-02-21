using System;

namespace ClassLecture
{
    public class Student : Person
    {
        private bool isInLecture = false;

        private Lecture lecture;

        public Student(string name, string occupation, string age) : base(name, occupation, age)
        {
        }

        public void Join(Lecture lectureToJoin)
        {
            if (this.isInLecture)
            {
                Console.WriteLine("ERROR: Cannot join more than one lecture at a time");
            }
            else
            {
                this.lecture = lectureToJoin;
                this.isInLecture = true;
                lectureToJoin.NumOfStudentsOnline++;
                Console.WriteLine(this.Name + " has joined " + lecture);
            }
        }

        public void Listen()
        {
            if (this.isInLecture)
            {
                Console.WriteLine("\nStudent " + this.Name + " is listening to this nonsense: " + this.lecture.Information);
            }
            else
            {
                Console.WriteLine("ERROR: Cannot listen to info when not in lecture");
            }
        }
    }
}