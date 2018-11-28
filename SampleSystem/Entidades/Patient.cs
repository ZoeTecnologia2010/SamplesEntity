using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Cellphone { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public DateTime Born { get; set; }
        public string Sex { get; set; }
    }
}
