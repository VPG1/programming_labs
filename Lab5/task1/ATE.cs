using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Threading;

namespace task1
{
    public class Ate
    {
        public enum State
        {
            Successfully,
            NotSuccessfully
        }


        private List<Tariff> _tariffs;
        private List<User> _users;
        private User _curUser;


        public Ate(List<Tariff> tariffs)
        {
            _tariffs = tariffs;
            _users = new List<User>();
            _curUser = null;
        }

        public List<Tariff> GetTariffs()
        {
            return _tariffs;
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public void LogIn(string name)
        {
            foreach (var user in _users)
            {
                if (user.Name == name)
                {
                    _curUser = user;
                    return;
                }
            }

            _curUser = new User(name);
            _users.Add(_curUser);
        }

        public void LogOut()
        {
            _curUser = null;
        }

        public State Call(string tariffType)
        {
            foreach (var temp in _tariffs)
            {
                if (temp.TariffType == tariffType)
                {
                    _curUser.Call(temp);
                    return State.Successfully;
                }
            }

            return State.NotSuccessfully;
        }

        public decimal Find(string name)
        {
            foreach (var user in _users)
            {
                if (user.Name == name)
                {
                    return user.CallsCoast();
                }
            }

            return -1;
        }

        public decimal CallsCoast()
        {
            decimal res = 0;
            
            foreach (var user in _users)
            {
                res += user.CallsCoast();
            }

            return res;
        }

        public State AddTariff(string tariffType, decimal coast)
        {
            foreach (var tariff in _tariffs)
            {
                if (tariff.TariffType == tariffType)
                {
                    return State.NotSuccessfully;
                }
            }

            _tariffs.Add(new Tariff(tariffType, coast));
            return State.Successfully;
        }
    }
}