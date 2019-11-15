using System;

namespace _3_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            

            logger.Logs = logger.Loop;

            logger.Logs += delegate
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            };

            logger.Logs += () =>
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.Write(i);
                }
            };

            void LocalLoop ()
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }

            logger.Logs += LocalLoop;

            logger.GetLogs();            
        }
    }

    class Logger
    {
        public Action Logs;

        public void GetLogs()
        {
            foreach (var d in Logs.GetInvocationList())
            {
                var invoke = (Action)d;
                invoke.Invoke();
            }
        }

        public void Loop()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i);
            }
        }
    }
}
