using System;

namespace Interfaces
{
    class Program
    {
        // Interface'ler NEWLENEMEZ!!!
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            

            EmployeeManager employeeManager = new EmployeeManager();


            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(customerManager);

            projectManager.Add(employeeManager);

            projectManager.Delete(customerManager);
        }
    }

    abstract class IPersonManager
    {
        public abstract void Add();

        public void Delete()
        {
            Console.WriteLine("Silindi...");
        }
    }

    class CustomerManager : IPersonManager
    {
        public override void Add()
        {
            Console.WriteLine("Müşteri eklendi...");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi...");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public override void Add()
        {
            Console.WriteLine("Çalışan eklendi...");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Delete(IPersonManager personManager)
        {
            personManager.Delete();
        }
    }


}
