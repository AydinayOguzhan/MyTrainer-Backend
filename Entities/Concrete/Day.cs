﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Day:IEntity
    {
        public int Id { get; set; }
        public string DayName { get; set; }
    }
}