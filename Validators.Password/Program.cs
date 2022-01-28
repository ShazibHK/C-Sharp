using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validators.Password
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            PasswordValidator p=new PasswordValidator();
        }
    }
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            Regex passwordPolicyExpression = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})");
            return passwordPolicyExpression.IsMatch(password);
        }
    }
}
