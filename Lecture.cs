using System;

namespace ClassLecture
{
    public class Lecture : ChatRoom
    {
        private int numOfStudentsOnline = 0;
        public int NumOfStudentsOnline
        {
            get { return numOfStudentsOnline; }
            set { numOfStudentsOnline = value; }
        }

        private string information;
        public string Information
        {
            get { return information; }
            set { information = value; }
        }

        public Lecture(string name) : base(name)
        {
        }

        public override String ToString()
        {
            return String.Format("\nNumbers of students online in {0} lecture : {1}", Name, numOfStudentsOnline);
        }
    }
}
