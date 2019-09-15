using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_testing.Models
{
    public class Test
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string TestName { get; set; }
        public string AthleteID { get; set; }
        public Athlete Athlete { get; set; }
    }
}
