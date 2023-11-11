﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace infrastructure.ViewModel
{
    public class ApplicationUser :IdentityUser
    {
        public string Name {  get; set; }
        public string ImageUser {  get; set; }
        public bool ActiveUser { get; set; }
    }

}