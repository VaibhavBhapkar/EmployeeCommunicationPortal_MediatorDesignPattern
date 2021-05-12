using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCommunicationPortal_MediatorDesignPattern
{
    public interface EmployeeGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
