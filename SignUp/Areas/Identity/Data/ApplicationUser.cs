using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignUp.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    
    {
     
            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            public string FirstName { get; set; }

            [PersonalData]
            [Column(TypeName = "nvarchar(100)")]
            public string LirstName { get; set; }

        
    }
}
