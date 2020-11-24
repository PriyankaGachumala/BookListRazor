using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Models
{
    public class Book
    {
        //to create properties write prop and double click tab button
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
    }
    //After creating Book we need add them to database and for that we need to add few packages of entity frame work.
}
