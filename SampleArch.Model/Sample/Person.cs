﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using SampleArch.Model.Common;

namespace SampleArch.Model
{
    [Table("Person")]
    public class Person : AuditableEntity<long>
    {   
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Display(Name="Country")]
        public long CountryId { get; set;  }

        //!!!!!!!!
        //This becomes required for valid data-binding
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        
    }
}
