using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuhsinBlog.Models
{
    public class Users
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the user name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The length of the user name must be in the range 2-50")]
        public String Name { set; get;}

        [Required(ErrorMessage = "Please enter e-mail address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter the e-mail address in the mail format")]
        public String Email { set; get;}

        [DataType(DataType.Url, ErrorMessage = "Please enter in the url format")]
        public String WebSite { set; get;}

        [DataType(DataType.ImageUrl, ErrorMessage = "Please enter the image path")]
        public string ImagePath { get; set; }


        [Required(ErrorMessage = "please enter the register date")]

        [DataType(DataType.DateTime, ErrorMessage = "Please enter the date of the register in date format")]
        public DateTime RegisterDate { get; set; }

        public ICollection<Article> Articles { set; get; }
        public ICollection<Comment> Comments { set; get; }

 
    }
}