using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete
{
    public class Writter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isStatus { get; set; }
    }
}
