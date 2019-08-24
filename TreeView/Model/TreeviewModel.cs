using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeView.Model
{
    public class TreeviewModel
    {
        public int Id { get; set; }
        public int pid { get; set; }
        public string name { get; set; }
        public bool hasChild { get; set; }
        public bool expanded { get; set; }
    }
}
