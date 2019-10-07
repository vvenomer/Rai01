using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rai01.Models
{
    public class User
    {
        public string login { get; set; }
        public DateTime createdTime { get; set; }
        public List<Friend> friends { get; set; }
    }
}
