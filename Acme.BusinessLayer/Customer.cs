using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; } // 2- propg tab tab shortkey.
        public string EmailAddress  { get; set; } // 1- Insert Prop Snippet ctrl+k, ctrl x
        public string FirstName {get; set;} // Auto Implemented Property.
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }          
    }
}
