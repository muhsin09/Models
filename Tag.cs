using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuhsinBlog.Models
{
    public class Tag
    {
        public int TagId { set; get; }

        [Required(ErrorMessage = " Please enter the tag !!! ")]
        [StringLength(63, ErrorMessage = "Please enter the tag in a specified length less than 63")]
        public String ContentTag { get; set; }

        public ICollection<Article> Articles { set; get; }
    }
}