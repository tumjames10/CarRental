using CarRentalContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billy.Framework.Model;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRentalCtx _ctx = new CarRentalCtx();

            User _myUser = new User { Username = "Billy"};

            _ctx.User.Add(_myUser);

            _ctx.SaveChanges();
        }
    }
}
