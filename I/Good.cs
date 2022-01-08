using System;

namespace I
{
    public class Good
    {
        // Interfaces
        internal interface ILead
        {
            void CreateSubTask();
            void AssginTask();
        }

        internal interface IProgrammer
        {
            void WorkOnTask();
        }

        // Clients
        internal class Manager : ILead
        {
            public void CreateSubTask()
            {
                Console.WriteLine("Task created.");
            }

            public void AssginTask()
            {
                Console.WriteLine("Task assigned.");
            }
        }

        internal class TeamLead : ILead, IProgrammer
        {
            public void CreateSubTask()
            {
                Console.WriteLine("Task created.");
            }

            public void AssginTask()
            {
                Console.WriteLine("Task assigned.");
            }

            public void WorkOnTask()
            {
                Console.WriteLine("Started working on the task.");
            }
        }

        internal class Programmer : IProgrammer
        {
            public void WorkOnTask()
            {
                Console.WriteLine("Started working on the task.");
            }
        }
    }
}