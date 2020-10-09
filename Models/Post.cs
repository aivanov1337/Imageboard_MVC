using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Website1.Models
{
    public class Post
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string author { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime date { get; set; }

        [Column(TypeName ="nvarchar(1500)")]
        public string message { get; set; }

        [Column(TypeName ="nvarchar(max)")]
        public string image { get; set; }

        [NotMapped]
        [DisplayName("Upload Image(Optional)")]
        //public HttpPostedFileBase ImageFile { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
