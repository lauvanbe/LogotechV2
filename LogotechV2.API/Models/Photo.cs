using System;
using System.ComponentModel.DataAnnotations;

namespace LogotechV2.API.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreation { get; set; }

        public bool IsMain { get; set; }
    }
}