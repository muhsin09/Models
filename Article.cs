using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuhsinBlog.Models
{
    public class Article
    {
        public int ArticleId { get; set;}


        [Required(ErrorMessage = "Article Please enter !!! ")]
        [StringLength(63,MinimumLength = 2, ErrorMessage = "Please enter the title in a specified length")]
        public String Title{get; set;}


        [Required(ErrorMessage = "Article Please enter The body of the article ")]
        [DataType(DataType.Html, ErrorMessage="Please enter the format of the Content as a html")]
        public String Content{get;set;}


        [Required(ErrorMessage = " Please give the date of the article ")]
        [DataType(DataType.DateTime, ErrorMessage="Please give the format of the Date Time correctly")]
        public DateTime Date{get; set;}

        [Required(ErrorMessage = "Author Please enter !!! ")]
        [StringLength(63,MinimumLength = 2, ErrorMessage = "Please enter the Author in a specified length")]
        public String Author{get; set;}


        public ICollection<Comment> Comments { set; get; }
        public ICollection<Tag> Tags { set; get; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password. ")]
        public String Password { set; get; }
    }

}