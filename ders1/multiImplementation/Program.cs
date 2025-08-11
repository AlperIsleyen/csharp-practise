namespace multiImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Developer(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
                if (worker is ISalary salaryWorker)
                {
                    salaryWorker.GetSalary();
                }
            }

        }
    }

    interface IWorker
    {
        void Work();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager is working");
        }
        public void GetSalary()
        {
            Console.WriteLine("Manager's salary is 60000");
        }
    }

    class Developer : IWorker, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Developer is coding");
        }
        public void GetSalary()
        {
            Console.WriteLine("Developer's salary is 35000");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }
}