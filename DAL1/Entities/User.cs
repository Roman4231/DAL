using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public int user_ID { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String email { get; set; }
    }
}
