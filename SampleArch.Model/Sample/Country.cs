using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using SampleArch.Model.Common;

namespace SampleArch.Model
{
    public class Country : Entity<long>
    {      
        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        [Display(Name="Country Name")]
        public string Name { get; set; }
        
        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
