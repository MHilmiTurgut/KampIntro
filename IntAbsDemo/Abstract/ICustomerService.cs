using IntAbsDemo.Entites;
using IntAbsDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntAbsDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
