namespace HW_OOP_4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            Animal[] animals = new Animal[]
             {
                new Dog("Rex", 5),
                new Cat("Whiskers", 3)
             };

            PrintSound(animals);
        }
        public static Animal[] animals = new Animal[100];
        public static int count = 0;
        public static void PrintSound(Animal[] animals )
        {
            foreach (var Animal in animals)
            {
                Console.Write(Animal.ToString());
                if (Animal is Dog dog)
                {
                    dog.bark();
                }
                else if (Animal is Cat cat)
                {
                    cat.Purr();

                }
            }
        }
    }
}