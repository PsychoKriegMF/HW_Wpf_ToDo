﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Wpf_ToDo.src
{
    public class ToDo
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Doing { get; set; }
        public ToDo() { Doing = false; }
        public ToDo(string title, DateTime date, string description, bool doing)
        {
            this.Title = title;
            this.Date = date;
            this.Description = description;
            this.Doing = doing;
        }
    }
}
