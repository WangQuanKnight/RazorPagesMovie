using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Schedule
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string PublicSchedule { get; set; }

        [DisplayName("Public Schedule Size(bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public string PublicScheduleSize { get; set; }

        public string PrivateSchedule { get; set; }

        [DisplayName("Private Schedule Size(bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public string PrivateScheduleSize { get; set; }

        [DisplayName("Uploaded(UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime UploadDT { get; set; }
    }
}
