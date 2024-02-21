using System;

namespace ClassLecture
{
    public class Speaker : Person
    {
        private bool isInLecture = false;

        private Lecture lecture;

        public Speaker(string name, string occupation, string age) : base(name, occupation, age)
        {
        }

        public void Broadcast(Lecture lectureToBroadcast)
        {
            if (this.isInLecture)
            {
                //cannot begin lecture 
            }
            else
            {
                this.isInLecture = true;
                this.lecture = lectureToBroadcast;
                System.Console.WriteLine(this.Name + " is currently broadcasting");
            }
        }

        public void Speak(string info, string newName)
        {
            if (this.isInLecture)
            {
                this.lecture.Information = info;
                this.lecture.Name = newName;
                System.Console.WriteLine("The name of the lecture has been changed to " + newName);
            }
        }

        public override String ToString()
        {
            return base.ToString() + "\nlecture.information: " + this.lecture.Information;
        }
    }
}