using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCommunicationPortal_MediatorDesignPattern
{
    public abstract class User
    {
        protected EmployeeGroupMediator mediator;
        protected string name;
        public User(EmployeeGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
