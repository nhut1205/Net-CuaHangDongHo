using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Net
{
    public class Account
    {
        string userName;
        string password;
        string disPlayName;
        string email;
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string DisPlayName { get => disPlayName; set => disPlayName = value; }

        public Account(string userName, string passWord)
        {
            this.UserName = userName;
            this.Password = passWord;
        }

        public Account(string userName, string disPlayName , string email) { 
        this.UserName = userName;
        this.DisPlayName = disPlayName;
        this.Email = email;
        }

        }
    }
