using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Assesment.Models
{
    public class TaskList
    {
        public int? id { get; set; }
        public string title { get; set; }
        public DateTime? due_date { get; set; }
        public decimal? estimated_hours { get; set; }
    }
}