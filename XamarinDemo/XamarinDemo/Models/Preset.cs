using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo.Models
{
    public class Preset
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<Interval> Intervals { get; set; } = new List<Interval>();

    }
}
