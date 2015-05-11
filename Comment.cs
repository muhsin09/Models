
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuhsinBlog.Models
{
    public class Comment
    {
        public int CommentID { set; get; }

        [Required(ErrorMessage = "Please give your Comment.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please give the date of your Comment.")]
        [DataType(DataType.DateTime, ErrorMessage = "Please give the date of your Comment correctly")]
        public DateTime Date { get; set; }

        //Her yorum, yalnızca bir makaleye ait olabilir. Bu yüzden, tek bir makaleye bağlıyoruz. 
        //Dikkat edileceği üzere veri türü (burada aynı zamanda sınıf) olarak Makale yazılıyor.
        public Article Article { get; set; }

        //Her yorumu, yalnızca bir kişi yazmış olabilir.
        public Users User { get; set; }


    }
}