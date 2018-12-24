using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class FileUpload
    {
        [Required]
        [DisplayName("Title")]
        [StringLength(60,MinimumLength =3)]
        public string Title { get; set; }

        [Required]
        [DisplayName("Public Schedule")]
        IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [DisplayName("Private Schedule")]
        IFormFile UploadPrivateSchedule { get; set; }
    }
}
