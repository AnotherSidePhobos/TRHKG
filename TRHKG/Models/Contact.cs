using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRHKG.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Country { get; set; }
        public string Subject { get; set; }
    }
}
