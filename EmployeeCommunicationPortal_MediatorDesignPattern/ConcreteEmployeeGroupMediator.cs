using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCommunicationPortal_MediatorDesignPattern
{
    public class ConcreteEmployeeGroupMediator:EmployeeGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }
        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
