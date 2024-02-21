using System;

namespace ClassLecture {
    public class ChatRoom {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public ChatRoom(string name) {
            this.name = name;

        }
    }
}