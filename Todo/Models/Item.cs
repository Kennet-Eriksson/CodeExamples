using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class Item
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public bool Status { get; set; }

    }
}
