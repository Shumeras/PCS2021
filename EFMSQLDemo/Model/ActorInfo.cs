using System;
using System.Collections.Generic;

#nullable disable

namespace EFMSQLDemo.Model
{
    public partial class ActorInfo
    {
        public short ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FilmInfo { get; set; }
    }
}
