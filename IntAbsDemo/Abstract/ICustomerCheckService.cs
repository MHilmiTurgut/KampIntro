using IntAbsDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntAbsDemo.Abstract
{
    public interface ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
