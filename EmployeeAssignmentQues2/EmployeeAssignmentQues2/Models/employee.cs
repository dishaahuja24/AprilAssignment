using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAssignmentQues2.Models
{
    public class employee
    {

        public int id { get; set; }
        public string name { get; set; }

        public employee()
        {

        }

        public List<employee> get()
        {
            List<employee> emp = new List<employee>()
            {
                new employee{id=1,name="disha"},
                new employee{id=2,name="sunita"},
                new employee{id=3,name="sam"},
                new employee{id=4,name="jagpreet"},
                new employee{id=5,name="ketan"}

            };

            return emp;

        }



    }
}
