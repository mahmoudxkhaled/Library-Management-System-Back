using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Dtos.User
{
    public class ChangePasswordDto
    {
        public string currentPassword { get; set; } = null!;
        public string newPassword { get; set; } = null!;
    }
}
