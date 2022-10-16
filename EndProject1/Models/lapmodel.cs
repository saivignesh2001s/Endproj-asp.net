using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace EndProject1.Models
{
    public class lapmodel
    {
        [Required()]
        public int lapid
        {
            get;
            set;
        }
        [MaxLength(20,ErrorMessage ="Maximum 20 characters")]
       public string lapname
        {
            get;
            set;
        }
    }
}