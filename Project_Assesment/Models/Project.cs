using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Assesment.Models
{
    public class Project
    {
        public int? pk { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public bool is_billable { get; set; }
        public bool is_active { get; set; }
        public DateTime? Created { get; set; }
        public List<TaskList> ask_set { get; set; }
    }
}