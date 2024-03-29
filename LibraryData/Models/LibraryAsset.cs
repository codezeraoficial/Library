﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryData.Models
{
    public abstract class LibraryAsset
    {      
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }  
        
        [Required]
        public int Year { get; set; }  

        [Required]
        public Status Status { get; set; }   

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Cost { get; set; }  
        public string ImageUrl { get; set; }   
        public int NumberOfCopies { get; set; }  
        public virtual LibraryBranch Location { get; set; }

    }
}
