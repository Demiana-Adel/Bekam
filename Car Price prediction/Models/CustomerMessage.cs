﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Car_Price_prediction.Models
{
    public class CustomerMessage
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string phoneNumber { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public IdentityUser User { get; set; }

    }
}