using System;
using Microsoft.AspNetCore.Identity;

namespace Agraviador_Forms.Data

{
    public class User : IdentityUser
    {
        public string FirstName {  get; set; } 
        public string LastName { get; set; }
    }
}
