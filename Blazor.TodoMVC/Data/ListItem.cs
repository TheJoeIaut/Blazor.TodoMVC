using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.TodoMVC.Data
{
    public class ListItemModel
    {
        public bool Completed { get; set; }
        public bool IsEdited { get; set; }
        public string   Text { get; set; }
    }
}
