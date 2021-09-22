using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool isStatus { get; set; }

        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

    }
}
