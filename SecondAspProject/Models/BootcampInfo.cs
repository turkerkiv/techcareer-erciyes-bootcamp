using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondAspProject.Models
{
    public class BootcampInfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }

    }
}