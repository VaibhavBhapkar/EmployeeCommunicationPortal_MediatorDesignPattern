﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCommunicationPortal_MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(EmployeeGroupMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}
