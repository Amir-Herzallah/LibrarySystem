﻿using System;
using System.Collections.Generic;

namespace LibrarySystem.Core.Data
{
    public partial class Contactu
    {
        public decimal Contactus_Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
