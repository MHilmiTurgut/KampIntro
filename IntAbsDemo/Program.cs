using IntAbsDemo.Abstract;
using IntAbsDemo.Concrete;
using IntAbsDemo.Entites;
using System;

namespace IntAbsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), 
                FirstName = "Engin", LastName = "Demiroğ", NationalityId = "123456789" });

        
        
        
        }
    }
}
