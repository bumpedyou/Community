﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Community.Models
{
    public class ReplyAds
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Level { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public virtual Post Post { get; set; }
    }
}