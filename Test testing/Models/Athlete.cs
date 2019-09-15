using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_testing.Models
{
    public class Athlete
    {
        [Key]
        public string ID { get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set; }
        public List<Test> Test { get; set; }
    }
}
