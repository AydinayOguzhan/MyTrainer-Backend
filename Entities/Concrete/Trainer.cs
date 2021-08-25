using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Trainer:IEntity
    {
        public int BaseUserId { get; set; }
    }
}
