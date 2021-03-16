using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDemo.Models
{
    public class Interval
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public TimeSpan Duration { get; set; } = new TimeSpan();

    }
}
