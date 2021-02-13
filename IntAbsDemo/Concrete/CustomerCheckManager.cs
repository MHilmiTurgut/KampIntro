using IntAbsDemo.Abstract;
using IntAbsDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntAbsDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
