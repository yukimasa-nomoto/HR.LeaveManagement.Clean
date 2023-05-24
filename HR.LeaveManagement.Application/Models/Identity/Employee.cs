﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Models.Identity
{
    public class Employee
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
    }
}
