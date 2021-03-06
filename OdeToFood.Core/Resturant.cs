using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public class Resturant
    {
        public int Id { get; set; }
        [Required, StringLength(63)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Location { get; set; }
        public CousineType Cousine { get; set; }
    }
}
