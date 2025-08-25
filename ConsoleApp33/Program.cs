namespace _33_KlasserOchArv
{
    internal class ModerKlass
    {
        static void Main(string[] args)
        {
            int MittTal = 42;

            // Klassen Teacher instansieras med en variabel
            Teacher t = new Teacher();

            // Anropa metoden Teach i klassen Teacher
            int TTal = t.Teach(MittTal);
            Console.WriteLine($"Värdet kommer från metoden Teach från variabeln TAnrop {TTal}");

            Student s = new Student();
            s.Learn();
            int STal = s.Teach(MittTal);
            Console.WriteLine($"Värdet kommer från metoden Teach från variabeln SAnrop {STal}");



        }
    }

    // Rgrndefinierad klass
    class Teacher
    {
        public int Teach(int Tal)
        {
            return Tal * 2;
        }

    }

    class Student : Teacher
    {
        public void Learn()
        {
            Console.WriteLine("Egenskaper från klasserna Teacher och Student");
            Console.WriteLine("eftersom klassen Student ärver allt från klassen Teacher");

        }
    }
}