using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class AccountService : IAccountService
    {
        public string Register(string username, string email, string password)
        {
            try
            {
                var result = GetAllEmails();

                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponsMessages.InvalidRegisterMessage);
                }

                return "Register succes";

            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }

            
            
            
        }
        private List<string> GetAllEmails()
        {
            return new List<string>() { "pervin12@gmail.com", "ali@code.edu.az", "agshin@gmail.com" };
        }
    }
}
