using ServiceLayer.Service;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer__Reflection_Practices.Controllers
{
    public class AccountControllers
    {
        private readonly IAccountService _service;

        public AccountControllers()
        {
            _service = new AccountService();
        }
        public void Register()
        {
            Console.WriteLine("add your username");
            string usrename = Console.ReadLine();

            Console.WriteLine("add your email");
            string email = Console.ReadLine();

            Console.WriteLine("add your password");
            string password = Console.ReadLine();


            var result = _service.Register(usrename, email, password);

            Console.WriteLine(result);
        }
    }
}
