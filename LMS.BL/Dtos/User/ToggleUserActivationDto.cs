using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL.Dtos.User
{
    public class ToggleUserActivationDto
    {
        public string UserId { get; set; }
        public bool IsActive { get; set; }
    }
}
