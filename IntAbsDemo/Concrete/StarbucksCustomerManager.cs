using IntAbsDemo.Abstract;
using IntAbsDemo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntAbsDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager,ICustomerCheckService
    {
        ICustomerCheckService CheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            CheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (CheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
