﻿using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
