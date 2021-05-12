using System;

namespace EmployeeCommunicationPortal_MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeGroupMediator employeeGroupMediator = new ConcreteEmployeeGroupMediator();
            User Vaibhav = new ConcreteUser(employeeGroupMediator, "Vaibhav");
            User Bhapkar = new ConcreteUser(employeeGroupMediator, "Bhapkar");
            User Test = new ConcreteUser(employeeGroupMediator, "Test");

            employeeGroupMediator.RegisterUser(Vaibhav);
            employeeGroupMediator.RegisterUser(Bhapkar);
            employeeGroupMediator.RegisterUser(Test);

            Vaibhav.Send("Test Message");
            Console.WriteLine();
            Test.Send("Test Again");
        }
    }
}
