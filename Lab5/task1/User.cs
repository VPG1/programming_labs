using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;

namespace task1
{
    public class User
    {
        public string Name { get; private set; }
        private List<Tariff> _rings = new List<Tariff>();

        public User(string name)
        {
            Name = name;
        }

        public User(User user)
        {
            this.Name = user.Name;
            this._rings = user._rings;
        }


        public void Call(Tariff tariff)
        {
            _rings.Add(tariff);
        }

        public decimal CallsCoast()
        {
            decimal res = 0;
            foreach (var ring in _rings)
            {
                res += ring.Coast;
            }

            return res;
        }
    }
}