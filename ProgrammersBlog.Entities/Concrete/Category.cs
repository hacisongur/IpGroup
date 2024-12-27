﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Oda { get; set; }
        public string IpNo { get; set; }
        public string PcAdi { get; set; }
        public string Bina { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}