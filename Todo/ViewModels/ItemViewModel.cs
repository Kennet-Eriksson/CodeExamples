using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Todo.Models;

namespace Todo.ViewModels
{
    public class ItemViewModel
    {
        public List<Item> Items { get; set; }
        public Item SetItem { get; set; }
    }
}