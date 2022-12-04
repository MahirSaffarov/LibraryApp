﻿using DomainLayer.Common;
using DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public Library? library { get; set; }
    }
}
