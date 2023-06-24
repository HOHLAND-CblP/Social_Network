﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public DateTime Creation_Date { get; set; }
        public DateTime? Last_Modified { get; }
    }
}
