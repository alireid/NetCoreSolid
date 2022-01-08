using System;

namespace L
{
    public class Bad
    {
        internal interface IBird
        {
            void MakeSound();

            void Fly();

            void Run();
        }

        public class Duck : IBird
        {
            public void MakeSound()
            {
                Console.WriteLine("Making sound.");
            }

            public void Fly()
            {
                Console.WriteLine("Flying...");
            }

            public void Run()
            {
                Console.WriteLine("Running...");
            }
        }

        public class Ostrich : IBird
        {
            public void MakeSound()
            {
                Console.WriteLine("Making sound.");
            }

            // Cannot fly.
            public void Fly()
            {
                throw new NotImplementedException();
            }

            public void Run()
            {
                Console.WriteLine("Running...");
            }
        }
    }
}