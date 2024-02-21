using System;

namespace ClassLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture interaktionsdesign = new Lecture("HCI");
            Lecture softwareudvikling = new Lecture("Software Development");
            Student lauritz = new Student("Lauritz", "Computer Science Student", "23");
            Student puk = new Student("Puk Damsgaard", "Data Science Student", "50");
            Student Jørgen = new Student("Jørgen", "Biology Student (Swamp Specialization)", "50");
            Student mette = new Student("Mette", "Cryptography Student", "44");
            Student danni = new Student("Danni", "Part-time drummer.", "N/A");
            Speaker boris = new Speaker("Boris Düdeman", "Professor", "40");
            Speaker barack = new Speaker("Barack Obama", "Renowned Speaker", "600");
            boris.Broadcast(softwareudvikling);
            boris.Speak("\"Hello my minions. Today you will learn how to code C# and hopefully you will not cry. \"", "Introduction to C#");
            lauritz.Join(softwareudvikling);
            danni.Join(softwareudvikling);
            lauritz.Listen();
            mette.Join(softwareudvikling);
            barack.Broadcast(interaktionsdesign);
            Jørgen.Join(interaktionsdesign);
            Jørgen.Join(softwareudvikling);
            puk.Join(interaktionsdesign);
            Console.WriteLine(interaktionsdesign);
            Console.WriteLine(softwareudvikling);
            barack.Speak("\"Greetings, good people! Welcome to this HCI Lecture. Today we will try to design the perfect flat tax proposal and then accidentally end up proving there exists no god.\"", "Religious Studies.");
            Jørgen.Listen();
            puk.Listen();
            Console.WriteLine(mette);
            Console.WriteLine(lauritz);
            Console.WriteLine(Jørgen);
            Console.WriteLine(boris);
            Console.WriteLine(barack);
            Console.WriteLine(danni);
            Console.WriteLine(puk);

        }
    }
}

