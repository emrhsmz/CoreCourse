using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.UI.Models
{
    public class UserComment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
