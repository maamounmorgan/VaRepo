using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agency.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("  الإسمبالكامل ")]
        public string Name { get; set; }
        
        [DisplayName(" رقم الهاتف")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("عنوان التواصل")]
        public string Subject { get; set; }
        [Required]
        [DisplayName("ايميل التواصل")]
        public string Email { get; set; }
        [Required]
        [DisplayName("رسالة التواصل")]
        public string Message { get; set; }
    }
}
