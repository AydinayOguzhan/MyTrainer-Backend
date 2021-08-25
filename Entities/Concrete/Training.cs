using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Training:IEntity
    {
        public int Id { get; set; }
        public string MoveName { get; set; }
        public string MoveDescription { get; set; }
        public int Weight { get; set; }
        public string WeightDescription { get; set; }
        public int NumberOfSets { get; set; }
        public string SetDescription { get; set; }
        public int NumberOfRepeats { get; set; }
        public string RepeatDescription { get; set; }
        public string GeneralDescription { get; set; }
    }
}
