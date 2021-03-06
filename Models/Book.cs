﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZalhanPaula_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }

        public string Author { get; set; }

        [Display(Name = "Book Title and Author Name")]
        public string TitleAndAuthor
        {
            get { return Title + " by " + Author; }
        }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navigation property
        public ICollection<BookCategory> BookCategories { get; set; }
    } 
}

