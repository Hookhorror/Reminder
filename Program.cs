using System;

namespace Reminder
{
    class Program
    {

        public static void remind(int interval)
        {
            DateTime endTime = new DateTime().AddSeconds(interval);
            
        }
        static void Main(string[] args)
        {
            string taskName = "task1";
            int interval = 3;
            Task task1 = new Task(taskName, interval);

            String input = Console.ReadLine();
        }
    }
}
