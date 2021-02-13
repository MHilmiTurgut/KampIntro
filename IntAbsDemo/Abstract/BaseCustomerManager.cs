using IntAbsDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntAbsDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db:" + customer.FirstName);
        }
    }
}
