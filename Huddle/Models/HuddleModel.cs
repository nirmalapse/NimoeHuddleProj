using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huddle.Models
{
    public class HuddleModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Subject> Info { get; set; }


    }
}

public class Subject
{
    public int ID { get; set; }
    public string Name { get; set; }
}