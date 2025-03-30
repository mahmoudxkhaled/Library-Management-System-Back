using Microsoft.AspNetCore.Identity;

namespace LMS.DAL.Data.Models
{

    public class Role : IdentityRole<int>
    {
        public Role() { }

        public Role(string roleName)
        {
            Name = roleName;
        }
    }
}
