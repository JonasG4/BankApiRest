using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Users
{
    public class AuthenticationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
