﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace socialapp.Models

{
    public class ProfilePicture : BaseEntity.BaseEntity
    {
        public string Picture { get; set; } = String.Empty;

        public int UserID { get; set; }
        public User User { get; set; }
    }
}